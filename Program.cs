using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "71999999999", modelo: "Empiria", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Spaceship for Newbies");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "11900000000", modelo: "17 pro max turbo", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Fortnite");