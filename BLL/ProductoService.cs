using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;
using DAL;
namespace BLL
{
    public class ProductoService
    {
        private IList<Producto> Productos;
        private IList<Producto> ProductosFiltrados;

        private OracleConnection Conexion;
        private ProductoRepository ProductoRepositorio;
        public ProductoService()
        {
            Conexion = new OracleConnection(@"Data Source=localhost:1521/xe;User Id=Gulfo;Password=Shoops0119");
            ProductoRepositorio = new ProductoRepository(Conexion);
        }

       
        public string GuardarProducto(Producto producto)
        {
            try
            {
                Conexion.Open();
                ProductoRepositorio.GuardarProductos(producto);
                Conexion.Close();
                return $"Se ha guardado el producto. ";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Producto> ConsultarProductos()
        {
            try
            {
                Conexion.Open();
                Productos = new List<Producto>();
                Productos = ProductoRepositorio.Consultar();
                Conexion.Close();
                return Productos;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
            
        }

        public IList<Producto> ConsultarNombreProductos()
        {
            try
            {
                Conexion.Open();
                Productos = new List<Producto>();
                Productos = ProductoRepositorio.Consultar();
                Conexion.Close();
                return Productos;
            }
            catch (OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }

       
        public Producto FiltrarCodigo(string productonombre)
        {
            try
            {
                Conexion.Open();
                Producto producto;
                producto= ProductoRepositorio.ConsultarCodigoProducto(productonombre);
                Conexion.Close();
                return producto;
            }
            catch (OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }

        public Producto BuscarProducto(string codigo)
        {
            try
            {
                Conexion.Open();
                Producto producto;
                producto = ProductoRepositorio.BuscarProducto(codigo);
                Conexion.Close();
                return producto;
            }
            catch (OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }
        public IList<Producto> FiltrarProductos(string productonombre)
        {
            try
            {
                Conexion.Open();
                ProductosFiltrados = new List<Producto>();
                ProductosFiltrados = ProductoRepositorio.FiltrarProductos(productonombre);
                Conexion.Close();
                return ProductosFiltrados;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }

       

        public string ModificarPrecioProductos(Producto producto)
        {
            try
            {
                Conexion.Open();
                ProductoRepositorio.ModificarPrecioProductos(producto);
                Conexion.Close();
                return $"Se ha modificado los productos. ";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }

        public string EliminarProducto(Producto producto)
        {
            try
            {
                Conexion.Open();
                ProductoRepositorio.EliminarProducto(producto);
                Conexion.Close();
                return $"Se ha eliminado. ";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }

       



    }
}
