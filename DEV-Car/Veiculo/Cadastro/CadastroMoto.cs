using DEV_Car.Veiculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Repository;

namespace DEV_Car.Veiculo.Cadastro.Cadastro
{
    internal class CadastroMoto
    {
        public static void CadastrarMoto()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Cadastro de Moto/Triciclo:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.Write("Nome da Moto/Triciclo: ");
            string nomeMoto = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Data de Fabricação: ");
            DateTime dateMoto = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 7);
            Console.Write("Quantidade de rodas: ");
            int rodasMoto = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 8);
            Console.Write("Cor: ");
            string corMoto = Console.ReadLine();
            Console.SetCursorPosition(2, 9);
            Console.Write("Valor:R$ ");
            decimal valorMoto = decimal.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 10);
            Console.Write("Potência em CV: ");
            int potenciaMoto = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 11);
            Console.Write("Placa: ");
            string placaMoto = Console.ReadLine();
            Console.Clear();

            Moto moto = new Moto(nomeMoto, dateMoto, rodasMoto, corMoto, valorMoto, potenciaMoto, placaMoto);
            moto.ListarInformacoes(rodasMoto, potenciaMoto);
            VeiculoRepositorio.ListVeiculos.Add(moto);
            VeiculoRepositorio.ListMotos.Add(moto);

            Console.Clear();

            MenuPrincipal.Mostrar();
        }
    }
}
