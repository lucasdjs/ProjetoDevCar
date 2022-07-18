using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Models;
using System.Globalization;
using DEV_Car.Veiculo.Repository;

namespace DEV_Car.Veiculo.Cadastro.Cadastro
{
    internal class CadastroCamionete
    {
        
        public static void CadastrarCamionete()
        {
           
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Cadastro de camionete:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.Write("Nome da camionete: ");
            string nomeCamionete = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Combustivel: Gasolina(1) / Diesel(2): ");
            string combustivel = Console.ReadLine();
            if (combustivel == "1")
            {
                combustivel = "Gasolina";
            }
            else if (combustivel == "2")
            {
                combustivel = "Diesel";
            }
            else
            {
                combustivel = "Valor inválido";
            }
            Console.SetCursorPosition(2, 7);
            Console.Write("Total de portas: ");
            int portasCamionete = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 8);
            Console.Write("Data de Fabricação: ");
            DateTime dateCamionete = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 9);
            Console.Write("Capacidade de carregamento na caçamba (em litros): ", CultureInfo.InvariantCulture);
            double capacidade = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 10);
            Console.Write("Valor: R$ ");
            decimal valorCamionete = decimal.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 11);
            Console.Write("Potência em CV: ");
            int potenciaCamionete = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, 12);
            Console.Write("Placa: ");
            string placaCamionete = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            Camionete camionete = new Camionete(nomeCamionete, portasCamionete, potenciaCamionete, capacidade, combustivel, dateCamionete, valorCamionete, placaCamionete);
            
            camionete.ListarInformacoes(portasCamionete, capacidade, potenciaCamionete, combustivel);
            VeiculoRepositorio.ListVeiculos.Add(camionete);
            VeiculoRepositorio.ListCamionetes.Add(camionete);
            MenuPrincipal.Mostrar();


        }
    }
}
