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
        private readonly ConectionManager Conection;
        private OracleDataReader reader;
        public ProductoRepository(ConectionManager conection)
        {
            Conection = conection;
            Productos = new List<Producto>();
        }


        public void GuardarProductos(Producto producto)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_PRODUCTO.GuardarProducto";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = producto.Nombre;
                command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(producto.Precio.ToString());
                command.Parameters.Add("marca", OracleDbType.Varchar2).Value = producto.Marca.NumeroMarca;
                command.ExecuteNonQuery();
            }
        }


        public Producto ConsultarCodigoProducto(string nombre)
        {
            Producto producto = null;
            using (var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "ConsultarnombreCodigo";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    producto = MapCodigo(reader);
                }
                return producto;
            }
        }

        public Producto BuscarProducto(string codigo)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Producto producto = null;
                command.CommandText = "PAQUETE_PRODUCTO.BuscarProducto";
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
        }
       
        
        public IList<Producto> Consultar()
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Productos.Clear();
                command.CommandText = "PAQUETE_PRODUCTO.ConsultarProductos";
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

        public Producto MapCodigo(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.Codigo = ((object)reader["id_producto"]).ToString();
            producto.Nombre = (string)reader["nombre"];
            producto.Precio = decimal.Parse(((double)reader["precio"]).ToString());
            return producto;
        }



        public void ModificarPrecioProductos(Producto producto)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_PRODUCTO.ModificarPrecioProductos";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("precionew", OracleDbType.Double).Value = double.Parse(producto.Precio.ToString());
                command.Parameters.Add("codigo", OracleDbType.Varchar2).Value = producto.Codigo;
                command.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(Producto producto)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_PRODUCTO.EliminarProductos";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("producto", OracleDbType.Varchar2).Value = producto.Codigo;
                command.ExecuteNonQuery();
            }
        }
          
        

        
    }
}
