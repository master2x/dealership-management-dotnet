using System;
using System.Collections.Generic;
using System.Text;
using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class VehiculoService
    {
        public Vehiculos CrearVehiculo(int id, string nombre, int modelo, int cantidad, bool disponible, string color, string marca)
        {
            return new Vehiculos
            {
                IdVehiculo = id,
                NombreVehiculo = nombre,
                Modelo = modelo,
                Cantidad = cantidad,
                Disponible = disponible,
                Color = color,
                Marca = marca
            };
        }

        public void MostrarVehiculos(Vehiculos vehiculo)
        {
            System.Console.WriteLine("Has creado un vehiculo");
            System.Console.WriteLine($"Con ID {vehiculo.IdVehiculo}");
            System.Console.WriteLine($"Informacion del vehiculo | Nombre: {vehiculo.NombreVehiculo} | Marca: {vehiculo.Marca} | Modelo: {vehiculo.Modelo} | Color: {vehiculo.Color} ");
            System.Console.WriteLine($"Quedan disponibles? {vehiculo.Disponible}");
            System.Console.WriteLine($"Quedan en total: {vehiculo.Cantidad}");
        }
    }
}
