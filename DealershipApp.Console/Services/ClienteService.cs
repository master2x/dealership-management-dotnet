using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class ClienteService
    {
        public Cliente CrearCliente(int id, string nombre, string apellido, string direccion, string correo, uint telefono)
        {
            return new Cliente
            {
                IdCliente = id,
                NombreCliente = nombre,
                ApellidoCliente = apellido,
                DireccionCliente = direccion,
                CorreoCliente = correo,
                TelefonoCliente = telefono

            };
        }
        public void MostrarCliente(Cliente cliente)
        {
            System.Console.WriteLine("Cliente registrado");
            System.Console.WriteLine($"Datos del cliente: ID: {cliente.IdCliente} | Nombre: {cliente.NombreCliente} | Apellido: {cliente.ApellidoCliente} | Direccion: {cliente.DireccionCliente}");
            System.Console.WriteLine($"Contacto del cliente: Correo: {cliente.CorreoCliente} | Telefono: {cliente.TelefonoCliente}");
        }
    }
}
