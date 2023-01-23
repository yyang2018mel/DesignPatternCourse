
using System;

// Authenticator -> Logger -> Encryptor -> Compressor

using ChainOfResponsibility;

var compressor = new Compressor(null);
var logger = new Logger(compressor);
var encryptor = new Encryptor(logger);
var authenticator = new Authenticator(encryptor);

var webServer = new WebServer(authenticator);


webServer.Handle(new HttpRequest("admin", "1234"));

Console.Read();

