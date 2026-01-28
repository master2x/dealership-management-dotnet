using DealershipApp.Console.Models;

namespace DealershipApp.Console.Services
{
    public class EmpleadoService
    {
        private List<Empleado> trabajador = new List<Empleado>();


        //Esto es un metodo lo de los parentesis son los parametros 
        public Empleado CrearEmpleado(int id, string nombre, string apellido, int telefono, string correo, string cargo, decimal salario)
        {
            System.Console.WriteLine("Creando un nuevo empleado...");

            if (salario <= 0)
            {
                return null ;

            }else if (nombre == "" || apellido == "")
            {
                return null;
            }else if (correo == "" || telefono <= 0)
            {
                return null;
            }else if (id <= 0)
            {
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
                trabajador.Add(empleado);//Toca instanciar  la clase para agregarlo ala lista
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
            foreach (var emp in trabajador)
            {
                System.Console.WriteLine(emp);
            }

        }
        public void EliminarEmpleado(int id)
        {
            Empleado empleadoEncontrado = null;
            foreach (var e in trabajador)
            {
                if (e.IdEmpleado == id)
                {
                    empleadoEncontrado = e;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Empleado no encontrado");
                    break;
                }
            }
            if (empleadoEncontrado != null)
            {
                trabajador.Remove(empleadoEncontrado);
                System.Console.WriteLine("Empleado eliminado exitosamente");
            }
            else
            {
                System.Console.WriteLine("Error");
            }

        }
    }
}
