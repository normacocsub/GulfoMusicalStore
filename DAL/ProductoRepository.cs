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
                
                producto = MapProducto(reader);
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
                
                producto = MapProducto(reader);
            }
            return producto;
        }
        public IList<Producto> ConsultarNombreProductos()
        {
            Productos.Clear();
            OracleCommand command = new OracleCommand("ConsultarnombreProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Producto producto;
                producto = MapProducto(reader);
                Productos.Add(producto);
            }
            return Productos;
        }
        public void GuardarProductosInventario(Producto producto)
        {
            OracleCommand command = new OracleCommand("GuardarInventario", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
 
            command.ExecuteNonQuery();
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

        public Producto MapProducto(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.Codigo = ((object)reader["id_producto"]).ToString();
            producto.Nombre = (string)reader["nombreproducto"];
            producto.Precio = decimal.Parse(((double)reader["precio"]).ToString());
            Marca marca = new Marca();
            marca.NumeroMarca = ((object)reader["id_marca"]).ToString();
            marca.Nombre = (string)reader["nombremarca"];
            marca.Fecha = (DateTime)reader["fechacreacion"];
            producto.AgregarMarca(marca);
            return producto;
        }
        public Producto Map(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.Codigo = ((object)reader["id_inventario"]).ToString();
            producto.Nombre = (string)reader["nombreproducto"];
            producto.Precio = decimal.Parse(((double)reader["precio"]).ToString());
            Marca marca = new Marca();
            marca.NumeroMarca = ((object)reader["id_marca"]).ToString();
            marca.Nombre = (string)reader["nombremarca"];
            marca.Fecha = (DateTime)reader["fechacreacion"];
            producto.AgregarMarca(marca);
            return producto;
        }

        public int NumeroProductos(string producto)
        {
                OracleCommand command = new OracleCommand("contarproductos", Conexion);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction=ParameterDirection.Output;
                command.Parameters.Add("nombreproduct", OracleDbType.Varchar2).Value = producto;
                return int.Parse(command.ExecuteScalar().ToString());
        }

        public void ModificarPrecioProductos(Producto producto)
        {
            OracleCommand command = new OracleCommand("ModificarPrecioProductos", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("precionew", OracleDbType.Double).Value = double.Parse(producto.Precio.ToString());
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = producto.Nombre;
            command.ExecuteNonQuery();
        }

        public void EliminarProducto(Producto producto)
        {
            OracleCommand command = new OracleCommand("EliminarProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
            command.ExecuteNonQuery();
        }

        

        public int TotalProductosDisponibles()
        {
            OracleCommand command = new OracleCommand("TotalProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            return int.Parse(command.ExecuteScalar().ToString());
        }

        public int ContarFiltradoNombre(string nombre)
        {
            OracleCommand command = new OracleCommand("ContarFiltradoProductos", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
            return int.Parse(command.ExecuteScalar().ToString());
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
