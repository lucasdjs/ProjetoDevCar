using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;


namespace DEV_Car.Veiculo.Cadastro.Cadastro
{
    internal class CadastroCarro
    {
        public static void CadastrarCarro()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Cadastro de carro:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.Write("Nome do carro: ");
            string nomeCarro = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Flex? Sim / Não: ");
            string combustivel = Console.ReadLine();

            if (combustivel == "sim" || combustivel == "Sim")
            {
                combustivel = "Flex";
            }
            else if (combustivel == "Não" || combustivel == "não" || combustivel == "nao")
            {
                combustivel = "Gasolina";
            }
            else { combustivel = "Valor inválido"; }
            Console.SetCursorPosition(2, 7);
            Console.Write("Total de portas: ");
            int portasCarro = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 8);
            Console.Write("Data de Fabricação: ");
            DateTime dateCarro = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 9);
            Console.Write("Cor: ");
            string corCarro = Console.ReadLine();
            Console.SetCursorPosition(2, 10);
            Console.Write("Valor:R$ ");
            decimal valorCarro = decimal.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 11);
            Console.Write("Potência em CV: ");
            int potenciaCarro = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 12);
            Console.Write("Placa: ");
            string placaCarro = Console.ReadLine();
            Console.SetCursorPosition(2, 13);
            Console.Clear();

            Carro carro = new Carro(nomeCarro, dateCarro, corCarro, valorCarro, potenciaCarro, placaCarro, portasCarro, combustivel);
            carro.ListarInformacoes(portasCarro, combustivel, potenciaCarro);
            VeiculoRepositorio.ListVeiculos.Add(carro);
            VeiculoRepositorio.ListCarros.Add(carro);
            Console.Clear();

            MenuPrincipal.Mostrar();
        }
    }
}
