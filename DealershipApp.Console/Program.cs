using DealershipApp.Console.Models;
using DealershipApp.Console.Services;

/*Console.WriteLine("Bienvenido, ingresa un nuevo empleado");

EmpleadoService empleadoService = new EmpleadoService(); // Nueva instancia del servicio

Console.Write("ID: ");
int id = int.Parse(Console.ReadLine());

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Apellido: ");
string apellido = Console.ReadLine();

Console.Write("Teléfono: ");
int telefono = int.Parse(Console.ReadLine());

Console.Write("Correo: ");
string correo = Console.ReadLine();

Console.Write("Cargo: ");
string cargo = Console.ReadLine();

Console.Write("Salario: ");
decimal salario = decimal.Parse(Console.ReadLine());

Empleado empleadoCreado = empleadoService.CrearEmpleado(
    id, nombre, apellido, telefono, correo, cargo, salario // Datos de la funcion CrearEmpleado
);

empleadoService.MostrarEmpleado(empleadoCreado); // Muestra el empleado creado
empleadoService.MostrarLista();*/

Console.WriteLine("Ingresa un nuevo Vehiculo");

VehiculoService vehiculoService = new VehiculoService(); // Nueva instancia del servicio

Console.Write("ID: ");
int id = int.Parse(Console.ReadLine());

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Modelo: ");
int modelo = int.Parse(Console.ReadLine());

Console.Write("Cantidad actual: ");
int cantidad = int.Parse(Console.ReadLine());

Console.Write("Disponible?: ");
bool disponible = bool.Parse(Console.ReadLine());

Console.Write("Color: ");
string color = Console.ReadLine();

Console.Write("Marca: ");
string marca = Console.ReadLine();

Vehiculos vehiculoCreado = vehiculoService.CrearVehiculo(
    id, nombre, modelo, cantidad, disponible, color, marca // Datos de la funcion CrearEmpleado
);

vehiculoService.MostrarVehiculos(vehiculoCreado); // Muestra el empleado creado*/
vehiculoService.MostrarListaVehiculos();




