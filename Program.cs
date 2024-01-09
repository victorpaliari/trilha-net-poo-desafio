using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("1234", "AASD", "159", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("7898", "TYUI", "489", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");