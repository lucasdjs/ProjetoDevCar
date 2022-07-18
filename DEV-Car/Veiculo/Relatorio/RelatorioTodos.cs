﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Car.Veiculo.Models;
using DEV_Car.Veiculo.Repository;
using DEV_Car.Veiculo.Cadastro;



namespace DEV_Car.Veiculo.Relatorio
{
    internal class RelatorioTodos
    {
        public void MenuTodos()

        {
            MenuPrincipal.DrawCanvas();
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Relatório de veiculos: ");
            Console.WriteLine();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Todos Veiculos Disponíveis");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Todos Veiculos Vendidos");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("3 - Todos Veiculos Vendidos com o maior preço");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("4 - Todos Veiculos Vendidos com o menor preço");
            Console.WriteLine();
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite uma opção: ");


            int opcaoRelatorio = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcaoRelatorio)
            {
                case 1:
                    VeiculosDisponiveis();
                    MenuPrincipal.DrawCanvas();
                    Console.SetCursorPosition(2, 3);
                    Console.Write("Digite 'Enter' para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;
                    case 2:VeiculosVendidos();
                    MenuPrincipal.DrawCanvas();
                    Console.SetCursorPosition(2, 3);
                    Console.Write("Digite 'Enter' para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal.Mostrar();
                    break;

            }

        }
        private void VeiculosDisponiveis()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculos.Count != 0)
            {

                foreach (var item in VeiculoRepositorio.ListVeiculos)
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
        private void VeiculosVendidos()
        {
            Veiculos veiculos = new Veiculos();

            if (VeiculoRepositorio.ListVeiculosVendidos.Count != 0)
            {

                foreach (var item in VeiculoRepositorio.ListVeiculosVendidos)
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


    }
}
