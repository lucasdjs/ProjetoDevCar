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
    internal class RelatorioMoto
    {
        public void MenuMoto()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Relatório Motos/Triciclos:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Motos/Triciclos Disponíveis");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Motos/Triciclos Vendidos");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Motos/Triciclos Vendido com o maior preço");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Motos/Triciclos Vendido com o menor preço");
            Console.WriteLine();
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite uma opção: ");


            int opcaoRelatorio = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcaoRelatorio)
            {
                case 1:
                    MotosDisponiveis();
                    MenuPrincipal.DrawCanvas();
                    Console.SetCursorPosition(2, 3);
                    Console.Write("Digite 'Enter' para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 2:
                    MotosVendidos();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 3:
                    MenuPrincipal.DrawCanvas();
                    MotosVendidosValorMaior();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 4:
                    MenuPrincipal.DrawCanvas();
                    MotosVendidosValorMenor();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;


            }

        }
        private void MotosDisponiveis()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {
                foreach (var item in VeiculoRepositorio.ListMotos)
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

        private void MotosVendidos()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculosVendidos.Count != 0)
            {
                veiculos.ListarInformacoesVendidoMoto("Motos");
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

        private void CamionetesVendidos()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculosVendidos.Count != 0)
            {
                veiculos.ListarInformacoesVendido("Camionete");
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

        private void MotosVendidosValorMaior()
        {
            for (int i = 0; i < VeiculoRepositorio.ListVeiculosVendidos.Count; i++)
            {
                var item = VeiculoRepositorio.ListMotosVendidos;
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("Veiculo vendido de maior valor:");
                Console.SetCursorPosition(2, 3);
                Console.Write("Nome: ");
                Console.SetCursorPosition(2, 4);
                Console.Write(item.Max().Nome);
            }
            Console.ReadLine();

        }
        private void MotosVendidosValorMenor()
        {
            for (int i = 0; i < VeiculoRepositorio.ListVeiculosVendidos.Count; i++)
            {
                var item = VeiculoRepositorio.ListMotosVendidos;
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("Veiculo vendido de menor valor:");
                Console.SetCursorPosition(2, 2);
                Console.Write("Nome: ");
                Console.SetCursorPosition(2, 3);
                Console.Write(item.Min().Nome);
            }
            Console.ReadLine();

        }


    }
}
