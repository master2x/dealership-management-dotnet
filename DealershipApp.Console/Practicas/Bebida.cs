using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Console.Practicas
{
    public class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //Metodo
        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }

        //Constructor
        public Bebida(int Cantidad, string Nombre)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
    }
}
