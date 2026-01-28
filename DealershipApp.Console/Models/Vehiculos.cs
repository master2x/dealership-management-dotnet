using DealershipApp.Console.Practicas;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public override string ToString()// Mi propia version del metodo ToString
        {
            //Mi string personalizado para mostrar la informacion del empleado
            return $"[{IdVehiculo}] {NombreVehiculo} {Modelo} - {Cantidad} - {Disponible} - {Color}- {Marca}";
        }
    }
}
