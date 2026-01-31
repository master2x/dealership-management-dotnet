using System;
using System.Collections.Generic;
using System.Text;
using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class VehiculoService
    {
        private List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Vehiculos CrearVehiculo(int id, string nombre, int modelo, int cantidad, bool disponible, string color, string marca)
        {
            if (id <= 0)
            {
                return null;
            }else if (nombre == "" || marca == "")
            {
                return null;
            }else if (modelo == 0 || cantidad < 0)
            {
                return null;
            }
            else
            {
                Vehiculos vehiculo = new Vehiculos
                {
                    IdVehiculo = id,
                    NombreVehiculo = nombre,
                    Modelo = modelo,
                    Cantidad = cantidad,
                    Disponible = disponible,
                    Color = color,
                    Marca = marca
                };
                vehiculos.Add(vehiculo);
                return vehiculo;
            }
        }

        public void MostrarVehiculos(Vehiculos vehiculo)
        {
            System.Console.WriteLine("Has creado un vehiculo");
            System.Console.WriteLine($"Con ID {vehiculo.IdVehiculo}");
            System.Console.WriteLine($"Informacion del vehiculo | Nombre: {vehiculo.NombreVehiculo} | Marca: {vehiculo.Marca} | Modelo: {vehiculo.Modelo} | Color: {vehiculo.Color} ");
            System.Console.WriteLine($"Quedan disponibles? {vehiculo.Disponible}");
            System.Console.WriteLine($"Quedan en total: {vehiculo.Cantidad}");
        }
        public void MostrarListaVehiculos()
        {
            foreach (var veh in vehiculos)
            {
                System.Console.WriteLine(veh);
            }

        }
        public void EliminarVehiculo(int id)
        {
            Vehiculos vehiculoEncontrado = null;// Se inicia en null

            foreach (var v in vehiculos)
            {
                if (v.IdVehiculo == id)
                {
                    vehiculoEncontrado = v; // Si lo encuentra se asigna v 
                    break;
                }
            }
            if (vehiculoEncontrado == null)
            {
                System.Console.WriteLine("Vehículo no encontrado");
            }
            else
            {
                vehiculos.Remove(vehiculoEncontrado);// Elimina el vehiculo
                System.Console.WriteLine("Vehículo eliminado correctamente");
            }

        }

        public void ActualizarModelo(int id, int modelo)
        {
            var vehiculo = vehiculos.Find(v => v.IdVehiculo == id);

            if (vehiculo == null)
            {
                System.Console.WriteLine("Vehículo no encontrado");
                return;
            }

            vehiculo.Modelo = modelo;
            System.Console.WriteLine("Modelo actualizado");
        }

        public void ActualizarCantidad(int id, int cantidad)
        {
            var vehiculo = vehiculos.Find(v => v.IdVehiculo == id);

            if (vehiculo == null)
            {
                System.Console.WriteLine("Vehículo no encontrado");
                return;
            }

            vehiculo.Cantidad = cantidad;
            System.Console.WriteLine("Modelo actualizado");
        }

        public void ActualizarNombre(int id, string nombre)
        {
            var vehiculo = vehiculos.Find(v => v.IdVehiculo == id);

            if (vehiculo == null)
            {
                System.Console.WriteLine("Vehículo no encontrado");
                return;
            }

            vehiculo.NombreVehiculo = nombre;
            System.Console.WriteLine("Nombre actualizado");
        }


    }
}
