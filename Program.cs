using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia: ");
Nokia n1 = new Nokia("123456", "G11 Plus", "111222333", 64);
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("123-456-7890", "12", "123456789012345", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
