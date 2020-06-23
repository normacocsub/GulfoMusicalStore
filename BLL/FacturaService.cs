using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DAL;
using Entity;
using InfraEstructura;

namespace BLL
{
    public class FacturaService
    {
        private IList<Factura> Facturas;
        private ConectionManager Conection;
        private FacturaRepository FacturaRepositorio;
        private PDF pdf;
        private Email Email;
        public FacturaService(string conection)
        {
            Conection = new ConectionManager(conection);
            FacturaRepositorio = new FacturaRepository(Conection);
        }

        public string GuardarFactura(Factura factura,string ruta,string ciudad)
        {
            
            try
            {
                pdf = new PDF(ruta);
                Email = new Email();
                Conection.Open();
                int codigo=FacturaRepositorio.CodigoFactura(int.Parse(ciudad));
                factura.Numero = codigo +"-"+ ciudad;
                FacturaRepositorio.GuardarFactura(factura);
                foreach (var item in factura.VerListaProductos())
                {
                    FacturaRepositorio.GuardarDetalles(item,factura.Fecha,factura.Cliente.Cedula);
                }
                foreach (var item in factura.VerListaCursos())
                {
                    FacturaRepositorio.GuardarDetalleCursos(item,factura.Fecha, factura.Cliente.Cedula);
                }
                
                pdf.CrearPDF(factura);
                Email.EnviarEmail(factura);
                Conection.Close();
                return $"Se ha guardado la factura. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
            catch(Exception ex)
            {
                return $"error. {ex.Message.ToString()}";
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
                return Facturas=new List<Factura>();
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

        public Factura BuscarFactura(int numero)
        {
            Factura factura = null;
            try
            {
                Conection.Open();
                factura = FacturaRepositorio.BuscarFactura(numero);
                Conection.Close();
                return factura;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltroNumeroFactura(int numero)
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltroNumeroFactura(numero);
                Conection.Close();
                return Facturas;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public string ModificarFactura(Factura factura)
        {
            try
            {
                Conection.Open();
                FacturaRepositorio.ModificarFactura(factura);
                Conection.Close();
                return $"Se ha modificado el estado de la factura. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error. {ex.Message.ToString()}";
            }
        }


        public Factura ConsultarDetallesFactura(Factura factura)
        {
            try
            {
                Conection.Open();
                return FacturaRepositorio.ConsultarDetallesFactura(factura);
            }
            catch(OracleException ex)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }

        public Factura ConsultarDetallesCurso(Factura factura)
        {
            try
            {
                Conection.Open();
                return FacturaRepositorio.ConsultarDetallesCurso(factura);
            }
            catch (OracleException ex)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }

        public IList<Factura> FiltroCiudadFactura(int numero)
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltroCiudadFactura(numero);
                Conection.Close();
                return Facturas;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltroTotalAsc()
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltroTotalASC();
                Conection.Close();
                return Facturas;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<Factura> FiltroTotalDEs()
        {
            try
            {
                Conection.Open();
                Facturas = FacturaRepositorio.FiltroTotalDesc();
                Conection.Close();
                return Facturas;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public string PruebaConexion()
        {
            try
            {
                Conection.Open();
                return $"conectado";
            }
            catch(OracleException ex)
            {
                return $"Error.";
            }
            finally
            {
                Conection.Close();
            }
        }
    }
}
