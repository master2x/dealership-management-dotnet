using DealershipApp.Console.Models;
using DealershipApp.Console.Services;

EmpleadoService empleadoService = new EmpleadoService(); // Toca traer la clase EmpleadoService para instanciarlo

//Se crea el empleado con el servicio
Empleado empleado = empleadoService.CrearEmpleado(1, "Jair", "Duarte", 312465341, "djduarterojas2212@gmail.com", "Backend", 2500);
empleadoService.MostrarEmpleado(empleado);// empleado de crearempleado
Console.WriteLine("-------------------------------------------------------------------");
VehiculoService vehiculoService = new VehiculoService();
Vehiculos vehiculo = vehiculoService.CrearVehiculo(1, "Yaris", 2009, 50, true, "Rojo", "Toyota");
vehiculoService.MostrarVehiculos(vehiculo);
Console.WriteLine("-------------------------------------------------------------------");
ClienteService clienteService = new ClienteService();
Cliente cliente = clienteService.CrearCliente(1, "Nataly", "Zuñiga", "Calle 123", "nataly@gmail.com", 3259784456);
clienteService.MostrarCliente(cliente);


