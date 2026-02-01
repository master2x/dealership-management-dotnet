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


            // Method Syntax
            var mine2 = colas.Where(b => b.Precio >= 3000)
            .Select(b => new { b.Nombre, b.Precio });


            // ORDER BY
            var mine3 = from c in colas
                        where c.Nombre == "Manzana" || c.Precio >= 3000
                        orderby c.Nombre descending // de forma descendente
                        select new { c.Marca, c.Nombre };
            // Group by
            var mine4 = from c in colas
                        group c by c.Marca into Marquiñas
                        select new
                        {
                            Marca = Marquiñas.Key,
                            Count = Marquiñas.Count()// Nueva variable donde contara los elementos del grupo
                        };

            foreach (var c in mine4)
            {
                System.Console.WriteLine(c.Marca + "" + c.Count);
            }

            foreach (var name in mine3)
            {
                System.Console.WriteLine(name.Nombre);
            }
        }
    }
}   