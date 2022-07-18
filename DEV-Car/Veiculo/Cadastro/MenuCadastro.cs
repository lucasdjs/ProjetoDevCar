using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo;
using DEV_Car.Veiculo.Cadastro.Cadastro;
using DEV_Car.Veiculo.Models;

namespace DEV_Car.Veiculo.Cadastro
{
    internal class MenuCadastro
    {
        public static void MenuVeiculo()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Qual tipo de veículo gostaria de cadastrar? ");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Moto/Triciclo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Carro");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Camionete");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Menu principal");
            Console.WriteLine();
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite a opção: ");
            int tipoVeiculo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            switch (tipoVeiculo)
            {
                case 1:
                    CadastroMoto.CadastrarMoto();
                    break;

                case 2:
                    CadastroCarro.CadastrarCarro();
                    break;

                case 3:
                    CadastroCamionete.CadastrarCamionete();
                    break;

                case 4:
                    MenuPrincipal.Mostrar();
                    break;

            }


        }
    }
}
