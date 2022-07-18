using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Venda_Veiculo
{
    internal class VenderCamionete
    {

        public void Venda()
        {

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {

                Veiculos veiculos = new Veiculos();
                veiculos.ListarInformacoesCamionete("Camionete");
                Console.Write("Digite o nome da camionete que deseja vender:");
                string opcao = Console.ReadLine();
                Console.SetCursorPosition(2,12);
                Console.Write("Digite o CPF do cliente que deseja comprar: ");
                string CPF = Console.ReadLine();
               
                Console.Clear();


                Veiculos camionete = VeiculoRepositorio.ListCamionetes.Find(x => x.Nome == opcao);



                if (camionete != null)
                {
                    camionete.CPFComprador = CPF;
                    VeiculoRepositorio.ListCamioneteVendidos.Add(camionete);
                    VeiculoRepositorio.ListVeiculosVendidos.Add(camionete);
                    VeiculoRepositorio.ListCamionetes.Remove(camionete);
                    VeiculoRepositorio.ListVeiculos.Remove(camionete);

                    Console.WriteLine("Item Vendido com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                }
                else
                {
                    Console.WriteLine("Camionete esta vindo null");
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
