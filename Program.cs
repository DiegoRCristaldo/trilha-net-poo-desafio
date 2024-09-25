using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("(19)98990-9456", "G20Plus", "156489462008", 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Iphone iphone = new Iphone("(67)98990-9456", "GiBaito", "03684160687", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Onlyfans");