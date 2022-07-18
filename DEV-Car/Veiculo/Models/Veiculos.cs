using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Venda_Veiculo;
using System.Globalization;
using DEV_Car.Veiculo.Repository;

namespace DEV_Car.Veiculo.Models
{
    public class Veiculos
    {
        public Guid Id { get; set; }
        public int Chassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public string CPFComprador { get; set; }
        public string Cor { get; set; }

        int linha = 5;
        int linhasVenda = 1;


        public Veiculos()
        {
            Id = Guid.NewGuid();
        }

        public void VenderVeiculos()
        {
            MenuVenda.MenuVendas();
        }


        public void ListarInformacoesCamionete(string nome)
        {
            MenuPrincipal aumentarLinhas = new MenuPrincipal();
            aumentarLinhas.DrawCanvas(linhasVenda);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"{nome} disponiveis para venda: ");

            foreach (var item in VeiculoRepositorio.ListCamionetes)
            {
                Console.SetCursorPosition(2, linha);
                Console.WriteLine($"Nome: {item.Nome} | Cor : {item.Cor} | Valor:{item.Valor.ToString("C")} | Ano de fabricação: {item.DataFabricacao.Year} ");


                linha++;
                linhasVenda++;
            }

            Console.SetCursorPosition(2, linha + 4);
        }
        public void ListarInformacoesVendaMoto(string nome)
        {
            MenuPrincipal aumentarLinhas = new MenuPrincipal();
            aumentarLinhas.DrawCanvas(linhasVenda);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"{nome} disponiveis para venda: ");

            foreach (var item in VeiculoRepositorio.ListMotos)
            {
                Console.SetCursorPosition(2, linha);
                Console.WriteLine($"Nome: {item.Nome} | Cor : {item.Cor} | Valor:{item.Valor.ToString("C")} | Ano de fabricação: {item.DataFabricacao.Year} ");


                linha++;
                linhasVenda++;
            }

            Console.SetCursorPosition(2, linha + 4);
        }
        public void ListarInformacoesVendaCarro(string nome)
        {
            MenuPrincipal aumentarLinhas = new MenuPrincipal();
            aumentarLinhas.DrawCanvas(linhasVenda);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"{nome} disponiveis para venda: ");

            foreach (var item in VeiculoRepositorio.ListCarros)
            {
                Console.SetCursorPosition(2, linha);
                Console.WriteLine($"Nome: {item.Nome} | Cor : {item.Cor} | Valor:{item.Valor.ToString("C")} | Ano de fabricação: {item.DataFabricacao.Year} ");


                linha++;
                linhasVenda++;
            }

            Console.SetCursorPosition(2, linha + 4);
        }

        public void ListarInformacoesVendido(string nome)
        {
            MenuPrincipal aumentarLinhas = new MenuPrincipal();
            aumentarLinhas.DrawCanvas(linhasVenda);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"{nome} Vendidas: ");

            foreach (var item in VeiculoRepositorio.ListCamioneteVendidos)
            {
                Console.SetCursorPosition(2, linha);
                Console.WriteLine("Nome: " + item.Nome + " | Cor: " + item.Cor + " | Valor: " + item.Valor.ToString("C"));
                Console.SetCursorPosition(2, linha+1);
                Console.WriteLine("Ano de Fabricação: " + item.DataFabricacao.Year + " | CPF Comprador: " + item.CPFComprador);

                linha = linha +2;
                Console.SetCursorPosition(2, linha);
                linhasVenda++;
                linha++;
            }

            Console.SetCursorPosition(2, linha + 4);
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
        }




        public void ListarInformacoes(Guid id, string nome, string placa, decimal valor, string cor, DateTime data, int chassi)
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Dados do Veículo:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Id:" + id);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Nome: " + nome);
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Placa: " + placa);
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Valor: " + valor.ToString("C"));
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("Cor: " + cor);
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("Data de fabricação: " + data.Day + "/" + data.Month + "/" + data.Year);
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("Chassi: " + chassi);
            Console.SetCursorPosition(2, 13);
            Console.WriteLine("Veiculo Cadastrado com sucesso!");
            Console.SetCursorPosition(2, 16);
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
            Console.Clear();

        }


        public void ListarInformacoes(int rodas, int potencia)
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Dados da Moto/Triciclo:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Nome: " + Nome);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Placa: " + Placa);
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Valor: " + Valor.ToString("C"));
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Cor: " + Cor);
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("Data de fabricação: " + DataFabricacao.Day + "/" + DataFabricacao.Month + "/" + DataFabricacao.Year);
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("Chassi: " + Chassi);
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("Quantidade de rodas: " + rodas);
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("Potência: " + potencia + "CV");
            Console.SetCursorPosition(2, 14);
            Console.WriteLine("Veiculo Cadastrado com sucesso!");
            Console.SetCursorPosition(2, 17);
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
            Console.Clear();


        }
        public void ListarInformacoes(int portas, string combustivel, int potencia)
        {

            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Dados do carro:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Nome: " + Nome);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Placa: " + Placa);
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Valor: " + Valor.ToString("C"));
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Cor: " + Cor);
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("Data de fabricação: " + DataFabricacao.Day + "/" + DataFabricacao.Month + "/" + DataFabricacao.Year);
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("Chassi: " + Chassi);
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("Quantidade de portas: " + portas);
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("Combustivel: " + combustivel);
            Console.SetCursorPosition(2, 13);
            Console.WriteLine("Potência: " + potencia + "CV");
            Console.SetCursorPosition(2, 15);
            Console.WriteLine("Veiculo Cadastrado com sucesso!");
            Console.SetCursorPosition(2, 18);
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
            Console.Clear();

        }
        public void ListarInformacoes(int portas, double capacidade, int potencia, string combustivel)
        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Dados da camionete:");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Nome: " + Nome);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Placa: " + Placa);
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Valor: " + Valor.ToString("C"));
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Cor: " + Cor);
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("Data de fabricação: " + DataFabricacao.Day + "/" + DataFabricacao.Month + "/" + DataFabricacao.Year);
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("Chassi: " + Chassi);
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("Quantidade de portas: " + portas);
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("Capacidade de carregamento em litros: " + capacidade.ToString("F2") + "LT");
            Console.SetCursorPosition(2, 13);
            Console.WriteLine("Potência: " + potencia + "CV");
            Console.SetCursorPosition(2, 14);
            Console.WriteLine("Combustivel: " + combustivel);
            Console.SetCursorPosition(2, 16);
            Console.WriteLine("Veiculo Cadastrado com sucesso!");
            Console.SetCursorPosition(2, 19);
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
            Console.Clear();



        }



    }
}
