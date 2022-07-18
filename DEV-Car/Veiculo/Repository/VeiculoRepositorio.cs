using DEV_Car.Veiculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DEV_Car.Veiculo.Repository
{
    public static class VeiculoRepositorio
    {
        public static List<Veiculos> ListVeiculos { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListMotos { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListCarros { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListCamionetes { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListCamioneteVendidos { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListVeiculosVendidos { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListCarrosVendidos { get; set; } = new List<Veiculos>();
        public static List<Veiculos> ListMotosVendidos { get; set; } = new List<Veiculos>();


    }

}
