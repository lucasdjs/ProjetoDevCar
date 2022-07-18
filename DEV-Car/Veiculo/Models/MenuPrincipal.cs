using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Cadastro;
using DEV_Car.Veiculo.Relatorio;
using DEV_Car.Veiculo.Models;



namespace DEV_Car.Veiculo.Models
{
    internal class MenuPrincipal
    {

        public static void Mostrar()
        {
            Menu();
        }

        public static void Menu()
        {
            DrawCanvas();
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("DEVCar");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("1 - Cadastrar veículo");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("2 - Relatório");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("3 - Vender Veiculo");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.SetCursorPosition(4, 11);
            Console.Write("Digite uma opção: ");
            int opcao = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.Clear();

            switch (opcao)
            {
                case 1: MenuCadastro.MenuVeiculo(); break;
                case 2: Relatorio.Relatorio.MenuRelatorio(); ; break;
                case 3:
                    Veiculos veiculo = new Veiculos();
                    veiculo.VenderVeiculos();
                    break;
                case 4:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Mostrar(); break;

            }

        }
        public static void PrintHorizontalLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 60; i++)
                System.Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }
        public static void PrintHorizontalLineVenda()
        {
            Console.Write("+");
            for (int i = 0; i <= 90; i++)
                System.Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }
        public static void DrawCanvas()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            PrintHorizontalLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 60; line++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            PrintHorizontalLine();
        }
        int aumentar = 0;
        public void DrawCanvas(int aumentarLinha)
        {
            aumentar = aumentarLinha;
            Console.BackgroundColor = ConsoleColor.Black;

            PrintHorizontalLineVenda();
            for (int i = 0; i < 20 + aumentar; i++)
            {
                Console.Write("|");
                for (int line = 0; line <= 90; line++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            aumentar++;

            PrintHorizontalLineVenda();
        }


    }
}
