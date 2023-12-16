using Estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

        Parking parking = new Parking();
        parking.welcomeToParking();
        parking.showMenu();
    }
}