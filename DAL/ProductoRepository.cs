using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace DAL
{
    public class ProductoRepository
    {
        private IList<Producto> Productos;
        private IList<Producto> ProductosFiltrados;
        private OracleConnection Conexion;
        private OracleDataReader reader;
        public ProductoRepository(OracleConnection conexion)
        {
            Conexion = conexion;
            Productos = new List<Producto>();
        }


        public void GuardarProductos(Producto producto)
        {
            OracleCommand command = new OracleCommand("GuardarProducto", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = producto.Nombre;
            command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(producto.Precio.ToString());
            command.Parameters.Add("marca", OracleDbType.Varchar2).Value = producto.Marca.NumeroMarca;
            command.ExecuteNonQuery();
        }


        public Producto ConsultarCodigoProducto(string nombre)
        {
            Producto producto = null;
            OracleCommand command = new OracleCommand("ConsultarnombreCodigo", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                producto = Map(reader);
            }
            return producto;
        }

        public Producto BuscarProducto(string codigo)
        {
            Producto producto = null;
            OracleCommand command = new OracleCommand("BuscarProducto", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("codigo", OracleDbType.Varchar2).Value = codigo;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                producto = Map(reader);
            }
            return producto;
        }
       
        
        public IList<Producto> Consultar()
        {
            Productos.Clear();
            OracleCommand command = new OracleCommand("ConsultarProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Producto producto;
                producto = Map(reader);
                Productos.Add(producto);
            }
            return Productos;
        }

       
        public Producto Map(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.Codigo = ((object)reader["id_producto"]).ToString();
            producto.Nombre = (string)reader["nombre"];
            producto.Precio = decimal.Parse(((double)reader["precio"]).ToString());
            Marca marca = new Marca();
            marca.NumeroMarca = ((object)reader["sk_marca"]).ToString();
            marca.Nombre = (string)reader["nombremarca"];
            producto.AgregarMarca(marca);
            return producto;
        }

        

        public void ModificarPrecioProductos(Producto producto)
        {
            OracleCommand command = new OracleCommand("ModificarPrecioProductos", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("precionew", OracleDbType.Double).Value = double.Parse(producto.Precio.ToString());
            command.Parameters.Add("codigo", OracleDbType.Varchar2).Value = producto.Codigo;
            command.ExecuteNonQuery();
        }

        public void EliminarProducto(Producto producto)
        {
            OracleCommand command = new OracleCommand("EliminarProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
            command.ExecuteNonQuery();
        }

        

        public IList<Producto> FiltrarProductos(string productonombre)
        {
            ProductosFiltrados = new List<Producto>();
            OracleCommand command = new OracleCommand("filtrarproductos", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("nombreproduct", OracleDbType.Varchar2).Value = productonombre;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Producto producto;
                producto = Map(reader);
                ProductosFiltrados.Add(producto);
            }


            return ProductosFiltrados;
        }
    }
}
