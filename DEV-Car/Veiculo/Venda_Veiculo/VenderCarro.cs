using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Venda_Veiculo
{
    internal class VenderCarro
    {
        public static void Venda()
        {
            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {

                Veiculos veiculos = new Veiculos();
                veiculos.ListarInformacoesVendaCarro("Carro");
                Console.Write("Digite o nome do carro que deseja vender:");
                string opcao = Console.ReadLine();
                Console.SetCursorPosition(2, 12);
                Console.Write("Digite o CPF do cliente que deseja comprar: ");
                string CPF = Console.ReadLine();

                Console.Clear();


                Veiculos carro = VeiculoRepositorio.ListCarros.Find(x => x.Nome == opcao);



                if (carro != null)
                {
                    carro.CPFComprador = CPF;
                    VeiculoRepositorio.ListCarrosVendidos.Add(carro);
                    VeiculoRepositorio.ListVeiculosVendidos.Add(carro);
                    VeiculoRepositorio.ListCarros.Remove(carro);
                    VeiculoRepositorio.ListVeiculos.Remove(carro);

                    Console.WriteLine("Item Vendido com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                }
                else
                {
                    Console.WriteLine("carro esta vindo null");
                    Console.ReadLine();
                    MenuPrincipal.Mostrar();
                }

            }
            else
            {
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("Não há veículos para listar!");
                Console.SetCursorPosition(2, 7);
                Console.Write("Digite 'Enter' para continuar:");
                Console.ReadLine();
                Console.Clear();
                MenuPrincipal.Mostrar();

            }
        }
    }
}
