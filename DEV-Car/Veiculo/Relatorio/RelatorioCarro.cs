using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;
using DEV_Car.Veiculo.Cadastro;

namespace DEV_Car.Veiculo.Relatorio
{
    internal class RelatorioCarro
    {
        public void MenuCarro()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Relatório de Carros:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Carros Disponíveis");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Carros Vendidos");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Carros Vendido com o maior preço");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Carros Vendido com o menor preço");
            Console.WriteLine();
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite uma opção: ");

            int opcaoRelatorio = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcaoRelatorio)
            {
                case 1:
                    CarrosDisponiveis();

                    MenuPrincipal menu = new MenuPrincipal();

                    Console.SetCursorPosition(2, 3);
                    Console.Write("Digite 'Enter' para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 2:
                    CarrosVendidos();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
            }

        }
        private void CarrosDisponiveis()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {
                foreach (var item in VeiculoRepositorio.ListCarros)
                {

                    veiculos.ListarInformacoes(item.Id, item.Nome, item.Placa, item.Valor, item.Cor, item.DataFabricacao, item.Chassi);
                }
            }
            else
            {
                MenuPrincipal.DrawCanvas();
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("Não há veículos para listar!");

            }

        }



        private void CarrosVendidos()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {
                veiculos.ListarInformacoesVendido("Carros");
            }
            else
            {
                MenuPrincipal.DrawCanvas();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Não há veículos para listar!");
                Console.SetCursorPosition(2, 5);
                Console.Write("Digite 'Enter' para continuar: ");
                Console.ReadLine();
            }
        }
    }
}