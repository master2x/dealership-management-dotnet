using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class ClienteService
    {
        private List<Cliente> clientes = new List<Cliente>();
        public Cliente CrearCliente(int id, string nombre, string apellido, string direccion, string correo, int telefono)
        {
            if (id < 0)
            {
                return null;
            }
            else if (nombre == "" || apellido == "" || direccion == "" || correo == "" || telefono == 0)
            {
                return null;
            }
            else
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = id,
                    NombreCliente = nombre,
                    ApellidoCliente = apellido,
                    DireccionCliente = direccion,
                    CorreoCliente = correo,
                    TelefonoCliente = telefono
                };
                clientes.Add(cliente);
                return cliente;
            }
        }
        public void MostrarCliente(Cliente cliente)
        {
            System.Console.WriteLine("Cliente registrado");
            System.Console.WriteLine($"Datos del cliente: ID: {cliente.IdCliente} | Nombre: {cliente.NombreCliente} | Apellido: {cliente.ApellidoCliente} | Direccion: {cliente.DireccionCliente}");
            System.Console.WriteLine($"Contacto del cliente: Correo: {cliente.CorreoCliente} | Telefono: {cliente.TelefonoCliente}");
        }

        public void EliminarCliente (int id)
        {
            Cliente clienteEncontrado = null;
            foreach (var c in clientes)
            {
                if (c.IdCliente == id)
                {
                    clienteEncontrado = c;
                    System.Console.WriteLine("Cliente encontrado");
                    break;
                }
            }
            if (clienteEncontrado != null)
            {
                clientes.Remove(clienteEncontrado);
                System.Console.WriteLine("Cliente eliminado");
            }
        }
    }
}
