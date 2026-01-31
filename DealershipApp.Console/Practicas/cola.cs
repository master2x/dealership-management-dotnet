using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;  // ¡IMPORTANTE para LINQ!

namespace DealershipApp.Console.Practicas
{
    public class Cola
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
    }

    class Program
    {
        static void Main(string[] args)  // ✅ Punto de entrada
        {
            
            var colas = new List<Cola>()
            {
                new Cola(){Nombre = "Mandarina", Marca = "Postobon", Precio= 2500},
                new Cola(){Nombre = "Manzana", Marca = "Big Cola", Precio= 3500},
                new Cola(){Nombre = "Piña", Marca = "Big Cola", Precio= 2000},
                new Cola(){Nombre = "Uva", Marca = "Postobon", Precio= 3000}
            };

           
            var names = from c in colas
                        select new { c.Nombre, c.Marca }// Consulta multiple
            ;

            var mine = from c in colas
                       where c.Nombre == "Manzana"
                       select new { c.Marca, c.Nombre };

            foreach (var name in mine)
            {
                System.Console.WriteLine(name.Nombre);
            }
        }
    }
}