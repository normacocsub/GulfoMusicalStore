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

        public IList<Factura> ConsultarFacturas()
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.ConsultarFacturas();
                Conection.Close();
                return Facturas;
            }
            catch(OracleException e)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltrarFacturaFecha(DateTime fechainicial, DateTime fechafinal)
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltrarFacturaFecha(fechainicial, fechafinal);
                Conection.Close();
                return Facturas;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltroFacturaEstado(string estado)
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltroFacturaEstado(estado);
                Conection.Close();
                return Facturas;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltrarFacturasCedula(string cedula)
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltrarFacturasCedula(cedula);
                Conection.Close();
                return Facturas;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }
    }
}
