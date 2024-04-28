using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

Console.WriteLine("Smartphone Iphone:");
Smartphone iph = new Iphone("218-947", "g77", "1111111", 128);
iph.Ligar();
iph.ReceberLigacao();
iph.InstalarAplicativo("whatssap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nok = new Nokia("178-023", "indestrutivel", "222222", 4);
nok.Ligar();
nok.ReceberLigacao();
nok.InstalarAplicativo("radio");