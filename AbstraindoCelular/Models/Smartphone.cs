using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string IMEI;
        private string Modelo;
        private int Memoria;

        public Smartphone(string numero, string imei, string modelo, int memoria) { 
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando aparelho...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ImprimirEspecificacoes()
        {
            Console.WriteLine("\nEspecificações Técnicas do Aparelho:");
            Console.WriteLine($"\tIMEI: {IMEI}\n\tModelo: {Modelo}\n\tMemória: {Memoria}");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}
