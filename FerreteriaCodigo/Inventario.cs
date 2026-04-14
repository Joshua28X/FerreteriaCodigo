using System;
using System.Collections.Generic;
using System.Text;

namespace FerreteriaCodigo
{
    internal class Inventario
    {
        private Producto?[] productos; // Arreglo de objetos Producto (acepta nulos).
        private int _contador; //Rastrea cuantos productos reales hay en el arreglo.
        public Inventario() 
        {
            productos = new Producto[50]; // Tamaño fijo de 50 elementos.
            _contador = 0;
        }

        //Agrega un producto al primer espacio disponible.
        public void AgregarProducto(Producto nuevo)
        {
            if (_contador < productos.Length)
            {
                productos[_contador] = nuevo;
                _contador++;
                Console.WriteLine("Producto agregador con exito");
            }
            else
            {
                Console.WriteLine("Error: Inventario lleno");
            }
        }
        //Elimina un producto por ID y desplaza los elementos para no dejar "huecos".
        public void EliminarProducto(int _idEliminar)
        {
            int IndiceEncontrado = -1; //Busca el indice del producto con el ID solicitado.
            for (int i = 0; i < _contador; i++) 
            {
                if (productos[i]?.Id == _idEliminar) 
                {
                    IndiceEncontrado = i; 
                    break;
                }
            }
            if (IndiceEncontrado != -1)
            {
                for (int i = IndiceEncontrado; i < _contador - 1; i++)// Desplazamiento a la izquierda de los elementos posteriores.
                {
                    productos?[i] = productos[i + 1];
                }
                productos?[_contador - 1] = null;//Limpia la ultima posicion duplicada.
                _contador--;
                Console.WriteLine("Producto eliminado");
            }
            else 
            {
                Console.WriteLine("Error: No se encotro ningun producto con ese ID");
            }
        }
        public void ListarProductos()//Muestra todos los productos registrados en formato de tabla.
        {
            Console.WriteLine("     Productos     ");
            Console.WriteLine("===================");
            if (_contador == 0) 
            {
                Console.WriteLine("El inventario esta vacio, registre productos");
                return;
            }
            Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10}", "ID", "NOMBRE", "CATEGORÍA",
                "PRECIO", "STOCK");
            Console.WriteLine("======================================================================");
            for (int i = 0; i < _contador; i++) 
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-15} {3,-10:C} {4,-10}",
                    productos[i]?.Id,
                    productos[i]?.Nombre,
                    productos[i]?.NombreCategoria,
                    productos[i]?.Precio,// Aplica formato de moneda local.
                    productos[i]?.Stock);
            }
        }
        public void BuscarProducto(string nombreBuscar) //Busca productos cuyo nombre contenga la cadena buscada.
        {
            bool encontrado = false;
            Console.WriteLine("Resultados de: "+ nombreBuscar);
            for (int i= 0; i< _contador; i++) 
            {
                if (productos[i]?.Nombre.ToLower().Contains(nombreBuscar.ToLower()) == true)
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("ID: " + productos[i]?.Id + "Nombre: " + productos[i]?.Nombre);
                    Console.WriteLine("Categoria: " + productos[i]?.NombreCategoria + "Precio: " + productos[i]?.Precio);
                    Console.WriteLine("Stock actual: " + productos[i]?.Stock + "Minimo: " + productos[i]?.Minimo);
                    encontrado = true;
                }
            }
            if (!encontrado) 
            {
                Console.WriteLine("No se encontro ningun producto");
            }
        }            
    }
}
