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
                command.Parameters.Add("fecha", OracleDbType.Date).Value = factura.Fecha.ToShortDateString();
                command.Parameters.Add("estadofac", OracleDbType.Varchar2).Value = factura.Estado;
                command.Parameters.Add("subtotalfac", OracleDbType.Double).Value = double.Parse(factura.SubTotal.ToString());
                command.Parameters.Add("ivafac", OracleDbType.Double).Value = double.Parse(factura.Iva.ToString());
                command.Parameters.Add("totalfac", OracleDbType.Double).Value = double.Parse(factura.Total.ToString());
                command.Parameters.Add("cantidadfac", OracleDbType.Int32).Value = double.Parse(factura.Cantidad.ToString());
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
                    command.Parameters.Add("fechadate", OracleDbType.Date).Value = factura.Fecha.ToShortDateString();
                    command.Parameters.Add("factura", OracleDbType.Int32).Value = int.Parse(factura.Numero);
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
                    command.Parameters.Add("fechadate", OracleDbType.Date).Value = factura.Fecha.ToShortDateString();
                    command.Parameters.Add("factura", OracleDbType.Int32).Value = int.Parse(factura.Numero);
                    command.Parameters.Add("curso", OracleDbType.Int32).Value = int.Parse(item.Curso.Codigo);
                    command.Parameters.Add("cliente", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                    command.ExecuteNonQuery();
                }
            }
        }

        

        
    }
}
