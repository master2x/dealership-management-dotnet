using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Console.Models
{
    public class Vehiculos
    {
        public int IdVehiculo { get; set; }
        public string NombreVehiculo { get; set; }
        public int Modelo { get; set; }
        public int Cantidad { get; set; }
        public bool Disponible { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
    }
}
