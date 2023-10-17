using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11 976922222", modelo: "Tijolão", imei:"522900047623000", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "11 976933333", modelo: "Pro Max 15", imei:"111900047623000", memoria: 62);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
