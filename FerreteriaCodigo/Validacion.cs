using System;
using System.Collections.Generic;
using System.Text;

namespace FerreteriaCodigo
{
    internal static class Validacion //Valida que la entrada sea un entero dentro de un rango especifico.
    {
        public static int LeerOpcion(int min, int max) 
        {
            int opcion = 0;
            bool valido= false;
            while (!valido) 
            {
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < min || opcion > max)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        valido = true;
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Error: Ingrese un numero");
                }
                catch (ArgumentOutOfRangeException) 
                {
                    Console.WriteLine("Error: Ingrese una opcion valida");
                }
            }
            return opcion;
        }
        public static double LeerPrecio(double Precio) //Valida que el precio sea un numero positivo.
        {
            double precio = 0;
            bool vali2 = false;
            while (!vali2)
            {
                try
                {
                    precio = double.Parse(Console.ReadLine());
                    if (precio <= 0 )
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        vali2 = true;
                    }
                }
                catch (FormatException) { Console.WriteLine("Escriba un numero"); }
                catch (ArgumentOutOfRangeException) { Console.WriteLine("Escriba un numero positivo"); }
            }
            return precio;
        }
    }
}
