using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Venda_Veiculo
{
    internal class VenderMotocicleta
    {
        public static void Venda()
        {
            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {

                Veiculos veiculos = new Veiculos();
                veiculos.ListarInformacoesVendaMoto("Motocicletas");
                Console.Write("Digite o nome da moto/triciclo que deseja vender:");
                string opcao = Console.ReadLine();
                Console.SetCursorPosition(2, 12);
                Console.Write("Digite o CPF do cliente que deseja comprar: ");
                string CPF = Console.ReadLine();

                Console.Clear();


                Veiculos moto = VeiculoRepositorio.ListMotos.Find(x => x.Nome == opcao);



                if (moto != null)
                {
                    moto.CPFComprador = CPF;
                    VeiculoRepositorio.ListMotosVendidos.Add(moto);
                    VeiculoRepositorio.ListVeiculosVendidos.Add(moto);
                    VeiculoRepositorio.ListMotos.Remove(moto);
                    VeiculoRepositorio.ListVeiculos.Remove(moto);

                    Console.WriteLine("Item Vendido com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                }
                else
                {
                    Console.WriteLine("Moto esta vindo null");
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
