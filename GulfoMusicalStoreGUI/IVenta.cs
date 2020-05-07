using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace GulfoMusicalStoreGUI
{
    public interface IVenta
    {
        void TotalVenta(Factura factura);
    }
}
