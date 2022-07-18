using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Relatorio;
using DEV_Car.Veiculo.Repository;


namespace DEV_Car.Veiculo.Relatorio
{
    internal class Relatorio
    {
        public static void MenuRelatorio()
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Relatório");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Motos/Triciclos");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Carros");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Camionetes");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Todos");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("5 - Menu Principal");
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite uma opção de relatório: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 1)
            {
                RelatorioMoto relatorio = new RelatorioMoto();
                relatorio.MenuMoto();
            }
            else if (opcao == 2)
            {
                RelatorioCarro relatorio = new RelatorioCarro();
                relatorio.MenuCarro();
            }
            else if (opcao == 3)
            {
                RelatorioCamionete relatorio = new RelatorioCamionete();
                relatorio.MenuCamionete();

            }
            else if (opcao == 4)
            {
                RelatorioTodos relatorio = new RelatorioTodos();
                relatorio.MenuTodos();
            }
            else
            {
                MenuPrincipal.Mostrar();
            }




        }
    }
}
