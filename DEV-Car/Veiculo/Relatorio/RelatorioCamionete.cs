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
    internal class RelatorioCamionete
    {
        public void MenuCamionete()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Relatório Camionetes: ");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Camionete Disponíveis");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Camionete Vendidos");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Camionete Vendido com o maior preço");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Camionete Vendido com o menor preço");
            Console.WriteLine();
            Console.SetCursorPosition(2, 10);
            Console.Write("Digite uma opção: ");

            int opcaoRelatorio = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcaoRelatorio)
            {
                case 1:
                    CamionetesDisponiveis();
                    MenuPrincipal.DrawCanvas();
                    Console.SetCursorPosition(2, 3);
                    Console.Write("Digite 'Enter' para continuar: ");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 2:
                    CamionetesVendidos();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                case 3:
                    MenuPrincipal.DrawCanvas();
                    CamionetesVendidosValorMaior();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;

            }

        }
        private void CamionetesDisponiveis()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {
                foreach (var item in VeiculoRepositorio.ListCamionetes)
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

        private void CamionetesVendidosValorMaior()
        {
            foreach (var item in VeiculoRepositorio.ListCamioneteVendidos)
            {
                Console.WriteLine(item.Valor) ;

            }

        }



    }
}
