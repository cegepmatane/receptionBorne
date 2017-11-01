var net = require('net');

var HOST = '10.1.51.57';
var PORT = 3000;

var client = new net.Socket();
client.connect(PORT, HOST, function() {

    console.log('CONNECTED TO: ' + HOST + ':' + PORT);
    // Write a message to the socket as soon as the client is connected, the server will receive it as message from the client

});

// Add a 'data' event handler for the client socket
// data is what the server sent to this socket
client.on('data', function(data) {
    
    console.log(data.toString());
    
});

// Add a 'close' event handler for the client socket
client.on('close', function() {
});