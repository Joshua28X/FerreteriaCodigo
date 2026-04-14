using System;
using System.Collections.Generic;
using System.Text;

namespace FerreteriaCodigo
{
    internal class Producto : Categoria
    {
        //Cambio estatico que comparte el estado entre todas las instancias para generar IDs unicos.
        private static int _contadorid = 1;
        //Campos privados. 
        private int _id;
        private string _nombre;
        private double _precio;
        private int _stock;
        private int _minimo;

        //Constructor: Se ejecuta al crear un nuevo objeto "Producto".
        public Producto(string _nombre, string nombreCategoria, double _precio, int _stock, int _minimo) : base(nombreCategoria) 
        {
            this._id = _contadorid++; //Asigna el ID actual e incrementa el contador para el siguiente.
            this._nombre = _nombre;
            this._precio = _precio;
            this._stock = _stock;
            this._minimo = _minimo;
        }

        //Propiedades publicas (Getters y Setters).
        public int Id => _id;// Solo lectura, el ID no debe cambiar manualmente.
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int Minimo { get => _minimo; set => _minimo = value; }
            }
    }
