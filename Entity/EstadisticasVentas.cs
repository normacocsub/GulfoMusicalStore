using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EstadisticasVentas
    {
        public DateTime Fecha { get; set; }
        public Factura Factura { get; set; }
        public string NumeroEstadistica { get; set; }

        public EstadisticasVentas()
        {

        }

        public void AgregarFactura(Factura factura)
        {
            Factura = factura;
        }
    }
}
