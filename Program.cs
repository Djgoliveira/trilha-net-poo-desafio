using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("12463","N53","264859745123",64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Iphone i1 = new Iphone("565994326","Iphone 16 Pro","264859745123",256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");