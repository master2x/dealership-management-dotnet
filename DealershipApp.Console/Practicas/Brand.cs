using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;  // ¡IMPORTANTE para LINQ!

namespace DealershipApp.Console.Practicas
{
    public class Brand
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }

    class Yonose
    {
        static void Main(string[] args)  // ✅ Punto de entrada
        {
            var marcas = new List<Brand>()
            {
                new Brand(){Nombre = "Toyota", Pais = "Japon"},
                new Brand(){Nombre = "Subaru", Pais = "Japon"},
                new Brand(){Nombre = "Volkwagen", Pais = "Alemania"},
                new Brand(){Nombre = "Fiat", Pais = "Italia"}
            };


        }
    }
}