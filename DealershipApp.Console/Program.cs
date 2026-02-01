using DealershipApp.Console.Models;
using DealershipApp.Console.Services;
using System.Runtime.CompilerServices;

bool continuar = true;

VehiculoService vehiculoService = new VehiculoService();
ClienteService clienteService = new ClienteService();
EmpleadoService empleadoService = new EmpleadoService();

do
{

    Console.WriteLine("Bienvenido al sistema de gestion de concesionarias, porfavor elige una opcion");
    Console.WriteLine("1. Gestionar Vehiculos");
    Console.WriteLine("2. Gestionar Clientes");
    Console.WriteLine("3. Gestionar Empleados");
    Console.WriteLine("0. Salir");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("=== Gestión de Vehículos ===");
            Console.WriteLine("1. Crear Vehículo");
            Console.WriteLine("2. Listar Vehículos");
            Console.WriteLine("3. Actualizar Vehículo");
            Console.WriteLine("4. Eliminar Vehículo");

            int opcionVehiculos = int.Parse(Console.ReadLine());                                         

            switch (opcionVehiculos)
            {

                case 1:

                    Console.WriteLine("Crear Vehiculo");

                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Modelo: ");
                    int modelo = int.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Disponiblilidad: ");
                    bool disponible = bool.Parse(Console.ReadLine());

                    Console.Write("Color: ");
                    string color = Console.ReadLine();

                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();

                    Vehiculos vehiculoCreado = vehiculoService.CrearVehiculo(
                        id, nombre, modelo, cantidad, disponible, color, marca
                    );
                    vehiculoService.MostrarVehiculos(vehiculoCreado);
                    vehiculoService.MostrarListaVehiculos();
                    break;

                case 2:
                    Console.WriteLine("Lista de Vehiculos:");
                    vehiculoService.MostrarListaVehiculos();
                    break;


                case 3:
                    Console.WriteLine("Actualizar Vehículo");

                    Console.Write("ID del vehículo a actualizar: ");
                    int idActualizar = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Qué deseas actualizar?");
                    Console.WriteLine("1. Modelo");
                    Console.WriteLine("2. Cantidad");
                    Console.WriteLine("3. Nombre");
                    int opcionActualizar = int.Parse(Console.ReadLine());

                    switch (opcionActualizar)
                    {
                        case 1:
                            Console.Write("Nuevo modelo: ");
                            int nuevoModelo = int.Parse(Console.ReadLine());
                            vehiculoService.ActualizarModelo(idActualizar, nuevoModelo);
                            break;

                        case 2:
                            Console.Write("Nueva cantidad: ");
                            int nuevaCantidad = int.Parse(Console.ReadLine());
                            vehiculoService.ActualizarCantidad(idActualizar, nuevaCantidad);
                            break;

                        case 3:
                            Console.Write("Nuevo nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            vehiculoService.ActualizarNombre(idActualizar, nuevoNombre);
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("ID del vehiculo a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    vehiculoService.EliminarVehiculo(idEliminar);
                    break;

            }
            break;



        case 2:
            Console.WriteLine("=== Gestión de Clientes ===");
            Console.WriteLine("1. Crear Ciente");
            Console.WriteLine("2. Listar Clientes");
            Console.WriteLine("3. Actualizar Cliente");
            Console.WriteLine("4. Eliminar Cliente");

            int opcionClientes = int.Parse(Console.ReadLine());

            switch (opcionClientes)
            {

                case 1:

                    Console.WriteLine("Crear Cliente");

                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Direccion: ");
                    string direccion = Console.ReadLine();

                    Console.Write("Correo: ");
                    string correo = Console.ReadLine();

                    Console.Write("Telefono: ");
                    int telefono = int.Parse(Console.ReadLine());



                    Cliente clienteCreado = clienteService.CrearCliente(
                        id, nombre, apellido, direccion, correo, telefono
                    );
                    clienteService.MostrarCliente(clienteCreado);
                    break;

                case 2:
                    Console.WriteLine("Lista de Vehiculos:");
                    clienteService.MostrarListaClientes();
                    break;


                case 3:
                    Console.WriteLine("Actualizar Cliente");

                    Console.Write("ID del cliente a actualizar: ");
                    int idActualizar = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Qué deseas actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Direccion");
                    Console.WriteLine("4. Telefono");

                    int opcionActualizar = int.Parse(Console.ReadLine());

                    switch (opcionActualizar)
                    {
                        case 1:
                            Console.Write("Nuevo Nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            clienteService.ActualizarNombreCliente(idActualizar, nuevoNombre);
                            break;

                        case 2:
                            Console.Write("Nuevo Apellido: ");
                            string nuevoApellido = Console.ReadLine();
                            clienteService.ActualizarApellidoCliente(idActualizar, nuevoApellido);
                            break;

                        case 3:
                            Console.Write("Nueva direccion: ");
                            string nuevaDireccion = Console.ReadLine();
                            clienteService.ActualizarDireccionCliente(idActualizar, nuevaDireccion);
                            break;

                        case 4:
                            Console.Write("Nuevo telefono: ");
                            int nuevoTelefono = int.Parse(Console.ReadLine());
                            clienteService.ActualizarTelefonoCliente(idActualizar, nuevoTelefono);
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("ID del cliente a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    clienteService.EliminarCliente(idEliminar);
                    break;

            }
            break;

        case 3:
            Console.WriteLine("=== Gestión de Empleados ===");
            Console.WriteLine("1. Crear Empleado");
            Console.WriteLine("2. Listar Empleados");
            Console.WriteLine("3. Actualizar Empleado");
            Console.WriteLine("4. Eliminar Empleado");

            int opcionEmpleados = int.Parse(Console.ReadLine());

            switch (opcionEmpleados)
            {

                case 1:

                    Console.WriteLine("Crear Empleado");

                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Telefono: ");
                    int telefono = int.Parse(Console.ReadLine());

                    Console.Write("Correo: ");
                    string correo = Console.ReadLine();

                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();

                    Console.Write("Salario: ");
                    decimal salario = decimal.Parse(Console.ReadLine());

                    Empleado empleadoCreado = empleadoService.CrearEmpleado(
                        id, nombre, apellido, telefono, correo, cargo, salario
                    );
                    empleadoService.MostrarEmpleado(empleadoCreado);
                    break;

                case 2:
                    Console.WriteLine("Lista de Vehiculos:");
                    empleadoService.MostrarLista();
                    break;

                case 3:
                    Console.WriteLine("Actualizar Empleado");

                    Console.Write("ID del empleado a actualizar: ");
                    int idActualizar = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Qué deseas actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Telefono");
                    Console.WriteLine("4. Cargo");
                    Console.WriteLine("5. Salario");

                    int opcionActualizar = int.Parse(Console.ReadLine());

                    switch (opcionActualizar)
                    {
                        case 1:
                            Console.Write("Nuevo Nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            empleadoService.ActualizarNombreEmpleado(idActualizar, nuevoNombre);
                            break;

                        case 2:
                            Console.Write("Nuevo Apellido: ");
                            string nuevoApellido = Console.ReadLine();
                            empleadoService.ActualizarApellidoEmpleado(idActualizar, nuevoApellido);
                            break;

                        case 3:
                            Console.Write("Nuevo telefono: ");
                            int nuevoTelefono = int.Parse(Console.ReadLine());
                            empleadoService.ActualizarTelefonoEmpleado(idActualizar, nuevoTelefono);
                            break;

                        case 4:
                            Console.Write("Nuevo cargo: ");
                            string nuevoCargo = Console.ReadLine();
                            empleadoService.ActualizarCargoEmpleado(idActualizar, nuevoCargo);
                            break;

                        case 5:
                            Console.Write("Nuevo salario: ");
                            int nuevoSalario = int.Parse(Console.ReadLine());
                            empleadoService.ActualizarSalarioEmpleado(idActualizar, nuevoSalario);
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("ID del empleado a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    empleadoService.EliminarEmpleado(idEliminar);
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }


            Console.WriteLine("Preciona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            break;
    }
} while (continuar);



