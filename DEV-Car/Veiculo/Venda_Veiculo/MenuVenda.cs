using DEV_Car.Veiculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculo.Venda_Veiculo
{
    internal class MenuVenda
    {


        public static void MenuVendas()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("Qual tipo de veículo gostaria de vender?");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("1 - Carro");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("2 - Moto/Triciclo");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("3 - Camionete");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("4 - Voltar ao menu principal");
            Console.WriteLine();
            Console.SetCursorPosition(4, 11);
            Console.Write("Digite uma opção: ");
            int opcao = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.Clear();

            switch (opcao)
            {
                case 1: VenderCarro.Venda(); break;
                case 2: VenderMotocicleta.Venda(); break;
                case 3: VenderCamionete venda = new VenderCamionete();
                    venda.Venda();
                    
                    break;
                case 4: MenuPrincipal.Mostrar(); break;
                default: MenuPrincipal.Mostrar(); break;

            }

        }
    }
}
