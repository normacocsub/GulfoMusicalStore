using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using System.Data;

namespace DAL
{
    public class FacturaRepository
    {
        private IList<Factura> Facturas;
        private ConectionManager Connection;
        private OracleDataReader Reader;

        public FacturaRepository(ConectionManager conection)
        {
            Connection = conection;
            Facturas = new List<Factura>();
        }

        public void GuardarFactura(Factura factura)
        {
           using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.GuardarFacturas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("fecha", OracleDbType.Varchar2).Value = factura.Fecha;
                command.Parameters.Add("estadofac", OracleDbType.Varchar2).Value = factura.Estado;
                command.Parameters.Add("subtotalfac", OracleDbType.Double).Value = double.Parse(factura.SubTotal.ToString());
                command.Parameters.Add("ivafac", OracleDbType.Double).Value = double.Parse(factura.Iva.ToString());
                command.Parameters.Add("totalfac", OracleDbType.Double).Value = double.Parse(factura.Total.ToString());
                command.Parameters.Add("cantidadfac", OracleDbType.Int32).Value = double.Parse(factura.Cantidad.ToString());
                command.Parameters.Add("x_id_cliente", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                command.ExecuteNonQuery();

            }
        }

        public int ObtenerCodigo()
        {
            int codigo = 0;
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.OBTENERCODIGOFACTURA";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Factura", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    codigo = int.Parse(((object)Reader["sk_codigo"]).ToString());
                }
                return codigo;
            }
        }

        public void EliminarCodigoTemp()
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.EliminarTablaTemporal";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
        }
        public void GuardarDetalles(Factura factura)
        {
            using (var command = Connection.Connection.CreateCommand())
            {
                foreach (var item in factura.VerListaProductos())
                {
                    command.CommandText = "PAQUETE_Detalles.GuardarDetalleFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(item.Producto.Precio.ToString());
                    command.Parameters.Add("fechadate", OracleDbType.Varchar2).Value = factura.Fecha;
                    command.Parameters.Add("factura", OracleDbType.Int32).Value = int.Parse(factura.Numero);
                    command.Parameters.Add("cantidad", OracleDbType.Int32).Value = item.Unidades;
                    command.Parameters.Add("producto", OracleDbType.Varchar2).Value = item.Producto.Codigo;
                    command.Parameters.Add("cliente", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                    command.ExecuteNonQuery();
                }
               
            }
        }

        public void GuardarDetalleCursos(Factura factura)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                foreach (var item in factura.VerListaCursos())
                {
                    command.CommandText = "PAQUETE_Detalles.GuardarDetalleCurso";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(item.Curso.Total.ToString());
                    command.Parameters.Add("fechadate", OracleDbType.Varchar2).Value = factura.Fecha;
                    command.Parameters.Add("factura", OracleDbType.Int32).Value = int.Parse(factura.Numero);
                    command.Parameters.Add("cantidad", OracleDbType.Int32).Value = item.Unidades;
                    command.Parameters.Add("curso", OracleDbType.Int32).Value = int.Parse(item.Curso.Codigo);
                    command.Parameters.Add("cliente", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                    command.ExecuteNonQuery();
                }
            }
        }


        public IList<Factura> ConsultarFacturas()
        {
            Facturas.Clear();
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.ConsultarFacturas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("facturas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Factura factura;
                    factura = MapFactura(Reader);
                    Facturas.Add(factura);
                }
            }
            return Facturas;
        }

        private Factura MapFactura(OracleDataReader reader)
        {
            Factura factura = new Factura();
            factura.Numero = ((object)reader["sk_factura"]).ToString();
            factura.Fecha = DateTime.Parse(((object)reader["fecha"]).ToString());
            factura.Estado = (string)reader["estado"];
            factura.SubTotal = decimal.Parse(((object)reader["subtotal"]).ToString());
            factura.Iva = decimal.Parse(((object)reader["iva"]).ToString());
            factura.Total = decimal.Parse(((object)reader["total"]).ToString());
            factura.Cantidad = int.Parse(((object)reader["cantidad"]).ToString());
            Cliente cliente = new Cliente();
            cliente.Cedula = (string)reader["id_clientte"];
            cliente.PrimerNombre = (string)reader["primernombre"];
            cliente.Telefono = (string)reader["telefono"];
            factura.AgregarCliente(cliente);
            return factura;
        }

        public IList<Factura> FiltrarFacturaFecha(DateTime fechainicial,DateTime fechafinal)
        {
            ConsultarFacturas();
            return Facturas.Where(F => F.Fecha > fechainicial && F.Fecha < fechafinal).ToList();
        }

        public IList<Factura> FiltroFacturaEstado(string estado)
        {
            Facturas.Clear();
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.FILTRARFACTURASESTADO";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("facturas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("f_estado", OracleDbType.Varchar2).Value = estado;

                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Factura factura;
                    factura = MapFactura(Reader);
                    Facturas.Add(factura);
                }
            }
            return Facturas;
        }

        public IList<Factura> FiltrarFacturasCedula(string cedula)
        {
            Facturas.Clear();
            using (var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_FACTURA.FILTRARFACTURACEDULA";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("facturas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("f_cedula", OracleDbType.Varchar2).Value = cedula;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Factura factura;
                    factura = MapFactura(Reader);
                    Facturas.Add(factura);
                }
            }
            return Facturas;
        }

        

        
    }
}
