public class maineable
{
    static void Main(String[] args)
    {
        Negocio negocio = new Negocio();
        int salir = 1;
        do {
            Console.WriteLine("Ingrese su nombre de usuario");
            String NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            String Contraseña = Console.ReadLine();
            if (negocio.IngresarUsuario(NombreUsuario, Contraseña))
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Bienvenido \"{0}\" al menu del Sistema de Gestion", NombreUsuario);
                    Console.WriteLine("1: Ver Productos");
                    Console.WriteLine("2: Ver Usuarios");
                    Console.WriteLine("3: Ver ProductosVendidos");
                    Console.WriteLine("4: Ver Ventas");
                    Console.WriteLine("0: Salir");
                    int menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            negocio.mostrarProductos();
                            break;

                        case 2:
                            negocio.mostrarUsuarios();
                            break;

                        case 3:
                            negocio.mostrarProductosVendidos();
                            break;

                        case 4:
                            negocio.mostrarVentas();
                            break;

                        case 0:
                            salir = 0;
                            break;
                    }
                } while (salir == 1);
            }
            else
            {
                Console.WriteLine("Error al ingresar, Escriba '1', para intentar nuevamente o '0' para salir");
                salir = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        }while(salir == 1);

    Console.WriteLine("Bye bye...");

    }
}