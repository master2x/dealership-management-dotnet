using DealershipApp.Console.Models;
using System.Globalization;

namespace DealershipApp.Console.Services
{
    public class EmpleadoService
    {
        private List<Empleado> empleados = new List<Empleado>();


        //Esto es un metodo lo de los parentesis son los parametros 
        public Empleado CrearEmpleado(int id, string nombre, string apellido, int telefono, string correo, string cargo, decimal salario)
        {
            System.Console.WriteLine("Creando un nuevo empleado...");

            if (salario <= 0)
            {
                return null;

            }
            else if (nombre == "" || apellido == "" || correo == "" || telefono <= 0)
            {
                System.Console.WriteLine("Faltan datos del empleado");
                return null;
            }
            else if (id <= 0)
            {
                return null;
            }else if (empleados.Any(e => e.IdEmpleado == id))
            {
                System.Console.WriteLine("El ID del empleado ya existe");
                return null;
            }
            else if (!correo.Contains("@"))
            {
                System.Console.WriteLine("Correo inválido");
                return null;
            }
            else
            {

                Empleado empleado = new Empleado
                {
                    IdEmpleado = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Correo = correo,
                    Cargo = cargo,
                    Salario = salario
                };
                empleados.Add(empleado);//Toca instanciar  la clase para agregarlo ala lista
                return empleado;
            }

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
        public void MostrarLista()
        {
            foreach (var emp in empleados)
            {
                System.Console.WriteLine(emp);
            }

        }
        public void EmpleadoPorCargo()
        {
            var datos = empleados
                .GroupBy(e => e.Cargo)
                .Select(grupo => new
                {
                    Cargo = grupo.Key,
                    Empleados = grupo.ToList()
                });
            foreach ( var grupo in datos)
            {
                System.Console.WriteLine($"Cargo: {grupo.Cargo}");

                foreach (var empleado in grupo.Empleados)
                { 
                    System.Console.WriteLine($"Nombre: {empleado.Nombre} | Apellido: {empleado.Apellido} | Cargo: {empleado.Cargo}");
                }
            }
            
        }

        public void SalariosAltos()
        {
            var datos = empleados
                .GroupBy(e => e.Salario >= 300000)
                .Select(grupo => new
                {
                    Salario = grupo.Key,
                    Empleados = grupo.ToList()
                });
            foreach (var grupo in datos)
            {
                System.Console.WriteLine("Salario mayor a 300000: " + grupo.Salario);
                foreach (var empleado in grupo.Empleados)
                {
                    System.Console.WriteLine($"Nombre: {empleado.Nombre} | Apellido: {empleado.Apellido} | Salario: {empleado.Salario}");
                } 
            }
        }

        public Empleado BuscarEmpleadoPorCorreo(string correo)
        {
            return empleados.FirstOrDefault(c => c.Correo == correo);
        }

        public void EliminarEmpleado(int id)
        {
            var empleadoEncontrado = empleados.FirstOrDefault(e => e.IdEmpleado == id);

            if (empleadoEncontrado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
            }
            else
            {
                empleados.Remove(empleadoEncontrado);
                System.Console.WriteLine("Empleado eliminado exitosamente");
            }

        }

        public void ActualizarNombreEmpleado(int id, string nombre)
        {
            var empleado = empleados.Find(e => e.IdEmpleado == id);

            if (empleado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
                return;
            }
            empleado.Nombre = nombre;
            System.Console.WriteLine("Empleado actualizado");

        }

        public void ActualizarApellidoEmpleado(int id, string apellido)
        {
            var empleado = empleados.Find(e => e.IdEmpleado == id);

            if (empleado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
                return;
            }
            empleado.Apellido = apellido;
            System.Console.WriteLine("Empleado actualizado");

        }

        public void ActualizarTelefonoEmpleado(int id, int telefono)
        {
            var empleado = empleados.Find(e => e.IdEmpleado == id);

            if (empleado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
                return;
            }
            empleado.Telefono = telefono;
            System.Console.WriteLine("Empleado actualizado");

        }

        public void ActualizarCargoEmpleado(int id, string cargo)
        {
            var empleado = empleados.Find(e => e.IdEmpleado == id);

            if (empleado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
                return;
            }
            empleado.Cargo = cargo;
            System.Console.WriteLine("Empleado actualizado");

        }

        public void ActualizarSalarioEmpleado(int id, decimal salario)
        {
            var empleado = empleados.Find(e => e.IdEmpleado == id);

            if (empleado == null)
            {
                System.Console.WriteLine("Empleado no encontrado");
                return;
            }
            empleado.Salario = salario;
            System.Console.WriteLine("Empleado actualizado");

        }

    }
}
