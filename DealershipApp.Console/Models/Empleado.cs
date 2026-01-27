using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Console.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
    }
}
