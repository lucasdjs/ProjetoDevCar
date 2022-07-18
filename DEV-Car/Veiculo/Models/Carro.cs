using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Models
{
    internal class Carro : Veiculos
    {
     
        public int TotalPortas { get; set; }
        public string Combustivel { get; set; }
        public int Potencia { get; set; }


        public Carro(Guid id,string nome, DateTime date, string cor, decimal valor, int potencia, string placa, int portas, string combustivel) : base()
        {
            id = Id;
            Nome = nome;
            DataFabricacao = date;
            Cor = cor;
            Valor = valor;
            Potencia = potencia;
            Placa = placa;
            TotalPortas = portas;
            Combustivel = combustivel;
            Chassi = new Random().Next(1000000000, 2000000000);
            CPFComprador = "0";
        }
        public Carro(string nome, DateTime date, string cor, decimal valor, int potencia, string placa, int portas, string combustivel) : base()
        {
           
            Nome = nome;
            DataFabricacao = date;
            Cor = cor;
            Valor = valor;
            Potencia = potencia;
            Placa = placa;
            TotalPortas = portas;
            Combustivel = combustivel;
            Chassi = new Random().Next(1000000000, 2000000000);
            CPFComprador = "0";

        }



    }


}
