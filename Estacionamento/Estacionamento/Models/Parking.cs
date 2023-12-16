using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    internal class Parking
    {
        private double initialValue { get; set; }
        private double costPerHour { get; set; }

        private List<string> vehicles = [];
        private Dictionary<string, double> payments = new Dictionary<string, double>();

        public void welcomeToParking()
        {
            Console.WriteLine("Digite o preço inicial: ");
            initialValue = double.Parse(Console.ReadLine() ?? "Valor nulo não aceito");

            Console.WriteLine("Agora digite o preço por hora:");
            costPerHour = double.Parse(Console.ReadLine()!);

            Console.Clear();
        }

        public void showMenu()
        {
            int selectedOption;
            
            do
            {
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine(
                "1 - Cadastrar veículo\n" +
                "2 - Remover veículo\n" +
                "3 - Listar veículos\n" +
                "4 - Listar pagamentos\n" +
                "5 - Encerrar"
                );

                selectedOption = int.Parse(Console.ReadLine()!);
                switch (selectedOption)
                {
                    case 1:
                        saveVehicle();
                        clearConsole();
                        break;
                    case 2:
                        removeVehicle();
                        clearConsole();
                        break;
                    case 3:
                        listAllVehicles();
                        clearConsole();
                        break;
                    case 4:
                        listAllPayments();
                        clearConsole();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada");
                        break;
                }
            }while (selectedOption != 5);
        }

        private void saveVehicle()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                var vehicle = Console.ReadLine();
                vehicles.Add(vehicle!);
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao inserir veículo..");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void removeVehicle()
        {
            try {
                Console.WriteLine("Digite a placa do veículo para remover:");
                var vehicle = Console.ReadLine();

                
                var vehicleFound = vehicles.Find(v => v.Equals(vehicle!));
                if(vehicleFound != null) { 
                    vehicles.Remove(vehicleFound); 
                } else {
                    throw new Exception("Veículo não encontrado!");
                }

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var hours = int.Parse(Console.ReadLine()!);

                var total = (hours * costPerHour) + initialValue;
                Console.WriteLine($"O veículo {vehicle} foi removido e o preço total foi de: R$ {total}");
            
                payments.Add(vehicle!, total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover veículo..");
                Console.WriteLine(ex.Message);
            }
        }

        private void listAllVehicles()
        {
            Console.WriteLine("Os veículos estacionados são:");
            vehicles.ForEach(vehicle => Console.WriteLine(vehicle) );
        }

        private void listAllPayments()
        {
            Console.WriteLine($"Pagamentos do dia {DateTime.Now.Day}:");
            var totalCost = 0.0;
            foreach(var payment in payments)
            {
                totalCost += payment.Value;
                Console.WriteLine($"O veículo da placa: {payment.Key}, custou: R$ {payment.Value}");
            }
            Console.WriteLine($"Total pagamentos do dia: R$ {totalCost}");
        }

        private void clearConsole()
        {
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
