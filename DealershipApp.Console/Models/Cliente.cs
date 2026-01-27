using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Console.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CorreoCliente { get; set; }
        public uint TelefonoCliente { get; set; }
    }
}
