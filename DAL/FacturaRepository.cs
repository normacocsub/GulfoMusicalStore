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
        private OracleConnection Conexion;
        private OracleDataReader Reader;

        public FacturaRepository(OracleConnection conexion)
        {
            Conexion = conexion;
            Facturas = new List<Factura>();
        }

        public void GuardarFactura(Factura factura)
        {
            OracleCommand command = new OracleCommand("GuardarFacturas", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("fecha", OracleDbType.Date).Value = factura.Fecha.ToShortDateString();
            command.Parameters.Add("estadofac", OracleDbType.Varchar2).Value = factura.Estado;
            command.Parameters.Add("subtotalfac", OracleDbType.Double).Value = double.Parse(factura.SubTotal.ToString());
            command.Parameters.Add("ivafac", OracleDbType.Double).Value = double.Parse(factura.Iva.ToString());
            command.Parameters.Add("totalfac", OracleDbType.Double).Value = double.Parse(factura.Total.ToString());
            command.Parameters.Add("cantidadfac", OracleDbType.Int32).Value = double.Parse(factura.Cantidad.ToString());
            command.ExecuteNonQuery();
        }

        public int ContarFacturas()
        {
            OracleCommand command = new OracleCommand("ContarFacturas", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            return int.Parse(command.ExecuteScalar().ToString());
        }
        public void GuardarDetalles(Factura factura)
        {
            foreach (var item in factura.VerListaProductos())
            {
                OracleCommand command = new OracleCommand("GuardarDetalleFactura", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(item.Producto.Precio.ToString());
                command.Parameters.Add("fechadate", OracleDbType.Date).Value = factura.Fecha.ToShortDateString();
                command.Parameters.Add("factura", OracleDbType.Varchar2).Value= factura.Numero;
                command.Parameters.Add("producto", OracleDbType.Varchar2).Value = item.Producto.Codigo;
                command.Parameters.Add("cliente", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                command.ExecuteNonQuery();
            }
        }

        public string ObtenerMaxIdFactura()
        {
            string codigo = null;
            OracleCommand command = new OracleCommand("MaxIDFactura", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                codigo = ((object)Reader["max(id_factura)"]).ToString();
            }
            return codigo;
        }
    }
}
