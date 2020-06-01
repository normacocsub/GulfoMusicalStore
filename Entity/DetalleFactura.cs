using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public Cliente Cliente { get; set; }
        public decimal PrecioProducto { get; set; }
        public int Unidades { get; set; }
        public DetalleFactura(Producto producto)
        {
            Producto = producto;  
        }
    }
}
