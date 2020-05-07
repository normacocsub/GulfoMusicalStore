using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public Factura Factura { get; set; }

        public Curso()
        {

        }

        public void RegistrarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
    }
}
