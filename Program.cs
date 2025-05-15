using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia;");
Nokia nk1 = new Nokia("61-999991234", "Modelo NK01", "987654321", 8);
nk1.Ligar();
nk1.ReceberLigacao();
nk1.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone;");
Iphone iph1 = new Iphone("61-888881234", "Modelo IPH01", "876543210", 4);
iph1.ReceberLigacao();
iph1.Ligar();
iph1.InstalarAplicativo("Google Chrome");
