using System;
using System.Collections.Generic;
using System.Text;

namespace FerreteriaCodigo
{
    internal class Categoria
    {
        private string _nombreCategoria;

        public Categoria(string nombreCategoria)
        {
            this._nombreCategoria = nombreCategoria;
        }

        // Propiedad para que las clases accedan al nombre
        public string NombreCategoria
        {
            get => _nombreCategoria;
            set => _nombreCategoria = value;
        }
    }
}
