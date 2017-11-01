var net = require('net');

var lireJSON = require("read-json");
var MongoClient = require('mongodb').MongoClient;

var url = "mongodb://192.168.56.10:27017/BORNE";

var port_tcp = 3000;

var clients=[];
var donneesBouees=[];

lireJSON("bouees.json", function (error, donnees) {
	donneesBouees=donnees;
});

function lireMongo()
{
	for(var i=0;i<donneesBouees.length;i++){
		donneesBouees[i].latitude=Math.random() * (180) -90;
		donneesBouees[i].longitude=Math.random() * (360) -180;
		donneesBouees[i].temperatureEau=Math.random() * (42) -2;
		donneesBouees[i].temperatureAir=Math.random() * (30);
		donneesBouees[i].salinite=Math.random() * (1000);
		donneesBouees[i].vitesseVent=Math.random() * (90) +90;
		donneesBouees[i].dimension=Math.random() * (3) +2;
		donneesBouees[i].pressionAtmospherique=Math.random() * (9000) +1000;
	}
}

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

lireMongo();
setInterval(lireMongo, 5000);