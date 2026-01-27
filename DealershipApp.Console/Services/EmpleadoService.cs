using System;
using System.Collections.Generic;
using System.Text;
using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class EmpleadoService
    {

        //Esto es un metodo lo de los parentesis son los parametros 
        public Empleado CrearEmpleado(int id, string nombre, string apellido, int telefono, string correo, string cargo, decimal salario)
        {
            //En el return se comparan los datos de la clase con los parametros de la funcion, esto para crear un nuevo objeto
            return new Empleado
            {
                IdEmpleado = id,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Correo = correo,
                Cargo = cargo,
                Salario = salario
            };
        }

        public void MostrarEmpleado(Empleado empleado)
        {
            System.Console.WriteLine("Has creado un nuevo empleado");
            System.Console.WriteLine($"Con el ID {empleado.IdEmpleado}");//El parametro empleado "toma" los datos de la clase 
            System.Console.WriteLine($"Nombre completo: ${empleado.Nombre} {empleado.Apellido}");
            System.Console.WriteLine($"Contacto: {empleado.Correo} | {empleado.Telefono}");
            System.Console.WriteLine($"Cargo: {empleado.Cargo}");
            System.Console.WriteLine($"Salario: {empleado.Salario}");
        }       

    }
}
