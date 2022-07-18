using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Models
{
    internal class Camionete : Veiculos
    {
     
        public int Portas { get; set; }
        public int Potencia { get; set; }
        public double CarregamentoCacamba { get; set; }
        public string CombustivelCamionete { get; set; }

        
        public Camionete(Guid id, string nome, int portas, int potencia, double carregamento, string combustivel, DateTime date, decimal valor, string placa)
        {
            id = Id;
            Nome = nome;
            Portas = portas;
            Placa = placa;
            Potencia = potencia;
            CarregamentoCacamba = carregamento;
            CombustivelCamionete = combustivel;
            DataFabricacao = date;
            Valor = valor;
            Chassi = new Random().Next(1000000000, 2000000000);
            Cor = "Roxo";
            CPFComprador = "0";

            
        }
        public Camionete(string nome, int portas, int potencia, double carregamento, string combustivel, DateTime date, decimal valor, string placa)
        {
           
            Nome = nome;
            Portas = portas;
            Placa = placa;
            Potencia = potencia;
            CarregamentoCacamba = carregamento;
            CombustivelCamionete = combustivel;
            DataFabricacao = date;
            Valor = valor;
            Chassi = new Random().Next(1000000000, 2000000000);
            Cor = "Roxo";
            CPFComprador = "0";
        }
        public Camionete() { }
    }
}
