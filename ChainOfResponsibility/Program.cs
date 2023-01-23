using System;
//using ChainOfResponsibility;
using ChainOfResponsibility.Exercise;

// Authenticator -> Logger -> Encryptor -> Compressor

//var compressor = new Compressor(null);
//var logger = new Logger(compressor);
//var encryptor = new Encryptor(logger);
//var authenticator = new Authenticator(encryptor);

//var webServer = new WebServer(authenticator);
//webServer.Handle(new HttpRequest("admin", "1234"));

var quickBookReader = new QuickBookReader(null);
var numbersSheetReader = new NumbersSheetReader(quickBookReader);
var excelReader = new ExcelReader(numbersSheetReader);
var readService = new DataReadService(excelReader);

readService.Read("abc.qbw");

Console.Read();