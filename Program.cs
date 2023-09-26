using DesafioPOO.Models;

Smartphone cell1 = new Nokia("+55 21 91234-5678", "Moto E4 Plus", "000000-11-222222-3", 16);
Console.WriteLine($"Smartphone: Nokia, número: {cell1.Numero}");
cell1.Ligar();
cell1.ReceberLigacao();
cell1.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Smartphone cell2 = new Iphone("+55 11 99876-5432", "IPhone X", "444444-55-666666-7", 128);
Console.WriteLine($"Smartphone: iPhone, número: {cell2.Numero}");
cell2.Ligar();
cell2.ReceberLigacao();
cell2.InstalarAplicativo("Telegram");


Console.WriteLine("\nTeste concluído com sucesso!");