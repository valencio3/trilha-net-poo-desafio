using DesafioPOO.Models;

var nokia = new Nokia("123456","2120","123456789", 2);
Console.WriteLine("-------- testando celular nokia --------");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"O número do celular é {nokia.Numero}");
nokia.Numero = "654321";
Console.WriteLine($"O novo número do celular é {nokia.Numero}");

var iphone = new Iphone("123456","2120","123456789", 2);
Console.WriteLine("-------- testando celular iphone --------");
Console.WriteLine($"O número do celular é {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Numero = "654321";
Console.WriteLine($"O novo número do celular é {iphone.Numero}");