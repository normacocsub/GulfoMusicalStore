using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DAL;
using Entity;

namespace BLL
{
    public class FacturaService
    {
        private IList<Factura> Facturas;
        private ConectionManager Conection;
        private FacturaRepository FacturaRepositorio;

        public FacturaService(string conection)
        {
            Conection = new ConectionManager(conection);
            FacturaRepositorio = new FacturaRepository(Conection);
        }

        public string GuardarFactura(Factura factura)
        {
            try
            {
                Conection.Open();
                FacturaRepositorio.GuardarFactura(factura);
                factura.Numero = FacturaRepositorio.ObtenerCodigo().ToString();
                FacturaRepositorio.EliminarCodigoTemp();
                FacturaRepositorio.GuardarDetalles(factura);
                FacturaRepositorio.GuardarDetalleCursos(factura);
                Conection.Close();
                return $"Se ha guardado la factura. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
    }
}
