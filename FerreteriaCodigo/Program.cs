using System;
namespace FerreteriaCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario(); //Instancia unica del inventario 
            bool salir=false;
            do
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine(" Bienvenido al sistema de Ferreteria");
                Console.WriteLine("=====================================");
                Console.WriteLine("1) Añadir producto");
                Console.WriteLine("2) Eliminar producto");
                Console.WriteLine("3) Listar productos");
                Console.WriteLine("4) Buscar producto");
                Console.WriteLine("5) Salir");
                int opcion = Validacion.LeerOpcion(1, 5); //Uso de la clase de validacion para capturar la opcion del menu.
                switch (opcion)
                {
                    case 1: // Alta del producto.
                        Console.Clear();
                        Console.WriteLine("Nombre:");
                        string n = Console.ReadLine() ?? "";
                        Console.WriteLine("Categoria:");
                        string c = Console.ReadLine() ?? "";
                        Console.WriteLine("Precio:");
                        double p = Validacion.LeerPrecio(0);
                        Console.WriteLine("Stock:");
                        int s = Validacion.LeerOpcion(0, 100);
                        Console.WriteLine("Stock minimo:");
                        int m = Validacion.LeerOpcion(0, 100); //Rango ampliado para stock.
                        Producto nuevo = new Producto(n, c, p, s, m);
                        inventario.AgregarProducto(nuevo);
                        Console.ReadKey();
                        break;

                    case 2: //Baja de producto.
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID a eliminar:");
                        int id = Validacion.LeerOpcion(1, 100);
                        inventario.EliminarProducto(id);
                        Console.ReadKey();
                        break;

                    case 4: //Busqueda 
                        Console.Clear();
                        Console.WriteLine("Nombre a buscar:");
                        string b = Console.ReadLine() ?? "";
                        inventario.BuscarProducto(b);
                        Console.ReadKey();
                        break;

                    case 3: //Reporte
                        Console.Clear();
                        inventario.ListarProductos();
                        Console.ReadKey();
                        break;

                    case 5: //Salida
                        salir = true;
                        break;
                }
            }
            while (!salir);
        }
        static void PresionarContinuar()//Metodo auxiliar para pausar la pantalla y que el usuario vea los mensajes.
        {
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
        }
    }
}