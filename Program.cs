using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "3323633", modelo: "Nokia 2T", imei: "32587c", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "40028922", modelo: "Pera phone", imei: "48752987b223s58e", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");