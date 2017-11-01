var net = require('net');
var MongoClient = require('mongodb').MongoClient;

var url = "mongodb://192.168.56.10:27017/BORNE";
var port_tcp = 3000;

var clients=[];
var donneesBouees=[];

function lireMongo()
{
	MongoClient.connect(url, function(err, db) {
		if (err) throw err;
		db.collection("BORNE").find({}).toArray(function(err, result) {
			if (err) throw err;
			donneesBouees=result;
			db.close();
			
			for(var socket of clients){
				socket.write(JSON.stringify(donneesBouees));
			}
			
		});
	});
}
lireMongo();
setInterval(lireMongo, 5000);

net.createServer( function(socket){
	
	clients.push(socket);
	
	console.log('CONNECTED: ' + socket.remoteAddress +':'+ socket.remotePort);
	

	socket.write(JSON.stringify(donneesBouees));
	
	socket.on('close', function(data) {
        console.log('CLOSED: ' + socket.remoteAddress +' '+ socket.remotePort);
    });
	
	socket.on('error', function(err) {
        console.log("ERROR: " + err);
    });

}).listen(port_tcp);

console.log('Serveur écoute sur le port ' + port_tcp);