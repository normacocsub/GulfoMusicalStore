using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Marca Marca { get; set; }

        public Producto()
        {
                
        }
        public Producto(string codigo,string nombre,decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public void AgregarMarca(Marca marca)
        {
            Marca = marca;
        }
    }
}
