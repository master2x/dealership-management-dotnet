using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Console.Models
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public decimal ValorVenta { get; set; }

    }
}
