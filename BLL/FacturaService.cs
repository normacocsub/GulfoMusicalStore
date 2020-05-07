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
        private OracleConnection Conexion;
        private FacturaRepository FacturaRepositorio;

        public FacturaService()
        {
            Conexion = new OracleConnection(@"Data Source=localhost:1521/xe;User Id=Gulfo;Password=Shoops0119");
            FacturaRepositorio = new FacturaRepository(Conexion);
        }

        public string GuardarFactura(Factura factura)
        {
            try
            {
                Conexion.Open();
                FacturaRepositorio.GuardarFactura(factura);
                factura.Numero = FacturaRepositorio.ObtenerMaxIdFactura();
                FacturaRepositorio.GuardarDetalles(factura);
                Conexion.Close();
                return $"Se ha guardado la factura. ";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
    }
}
