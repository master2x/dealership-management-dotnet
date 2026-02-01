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
            if (id <= 0)
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
            var clienteEncontrado = clientes.FirstOrDefault(c => c.IdCliente == id);

            if (clienteEncontrado != null)
            {
                clientes.Remove(clienteEncontrado);
                System.Console.WriteLine("Cliente eliminado");
            }
        }

        public void MostrarListaClientes()
        {
            foreach (var cli in clientes)
            {
                System.Console.WriteLine(cli);
            }

        }
        public void ActualizarNombreCliente(int id, string nombre)
        {
            var cliente = clientes.Find(c => c.IdCliente == id);

            if(cliente == null)
            {
                System.Console.WriteLine("Cliente no encontrado");
                return;
            }
            cliente.NombreCliente = nombre;
            System.Console.WriteLine("Nombre actualizado");
        }
        public void ActualizarApellidoCliente(int id, string apellido)
        {
            var cliente = clientes.Find(c => c.IdCliente == id);

            if (cliente == null)
            {
                System.Console.WriteLine("Cliente no encontrado");
                return;
            }
            cliente.ApellidoCliente = apellido;
            System.Console.WriteLine("Nombre actualizado");

        }
        public void ActualizarDireccionCliente(int id, string direccion)
        {
            var cliente = clientes.Find(c => c.IdCliente == id);

            if (cliente == null)
            {
                System.Console.WriteLine("Cliente no encontrado");
                return;
            }
            cliente.DireccionCliente = direccion;
            System.Console.WriteLine("Nombre actualizado");

        }
        public void ActualizarTelefonoCliente(int id, int telefono)
        {
            var cliente = clientes.Find(c => c.IdCliente == id);

            if (cliente == null)
            {
                System.Console.WriteLine("Cliente no encontrado");
                return;
            }
            cliente.TelefonoCliente = telefono;
            System.Console.WriteLine("Nombre actualizado");

        }
    }
}
