using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Models
{

    internal class Moto : Veiculos
    {
        
        Veiculos veiculo = new Veiculos();
        public int Rodas { get; set; }
        public int Potencia { get; set; }


        public Moto(Guid id, string nome, DateTime date, int qtdRodas, string cor, decimal valor, int potencia, string placa) : base()
        {
            id = Id;
            Nome = nome;
            DataFabricacao = date;
            Rodas = qtdRodas;
            Cor = cor;
            Valor = valor;
            Potencia = potencia;
            Placa = placa;
            Chassi = new Random().Next(1000000000, 2000000000);
            CPFComprador = "0";

        }
        public Moto( string nome, DateTime date, int qtdRodas, string cor, decimal valor, int potencia, string placa) : base()
        {
            
            Nome = nome;
            DataFabricacao = date;
            Rodas = qtdRodas;
            Cor = cor;
            Valor = valor;
            Potencia = potencia;
            Placa = placa;
            Chassi = new Random().Next(1000000000, 2000000000);
            CPFComprador = "0";

        }




    }

}




