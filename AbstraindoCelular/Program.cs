// See https://aka.ms/new-console-template for more information
using AbstraindoCelular.Models;

Console.WriteLine("---------- Verificando aparellho da Nokia: ----------");

Nokia nokia = new Nokia("11 92222-3333", "10101010011", "N1", 6);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Visual Studio App");
nokia.ImprimirEspecificacoes();

Console.WriteLine("\n---------- Verificado com suceso!!! ----------\n\n");
Console.WriteLine("---------- Verificando aparellho da Apple: ----------");

Iphone iphone = new Iphone("22 93333-4444", "20202020202", "Iphone 15", 10);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Visual Studio IOS");
iphone.ImprimirEspecificacoes();

Console.WriteLine("\n---------- Verificado com suceso!!! ----------");