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
        private ConectionManager Conection;
        private ProductoRepository ProductoRepositorio;
        public ProductoService(string connection)
        {
            Conection = new ConectionManager(connection);
            ProductoRepositorio = new ProductoRepository(Conection);
        }

       
        public string GuardarProducto(Producto producto)
        {
            try
            {
                Conection.Open();
                ProductoRepositorio.GuardarProductos(producto);
                Conection.Close();
                return $"Se ha guardado el producto. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Producto> ConsultarProductos()
        {
            try
            {
                Conection.Open();
                Productos = new List<Producto>();
                Productos = ProductoRepositorio.Consultar();
                Conection.Close();
                return Productos;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
            
        }

        public IList<Producto> ConsultarNombreProductos()
        {
            try
            {
                Conection.Open();
                Productos = new List<Producto>();
                Productos = ProductoRepositorio.Consultar();
                Conection.Close();
                return Productos;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

       
        public Producto FiltrarCodigo(string productonombre)
        {
            try
            {
                Conection.Open();
                Producto producto;
                producto= ProductoRepositorio.ConsultarCodigoProducto(productonombre);
                Conection.Close();
                return producto;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public Producto BuscarProducto(string codigo)
        {
            try
            {
                Conection.Open();
                Producto producto;
                producto = ProductoRepositorio.BuscarProducto(codigo);
                Conection.Close();
                return producto;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }
        

       

        public string ModificarPrecioProductos(Producto producto)
        {
            try
            {
                Conection.Open();
                ProductoRepositorio.ModificarPrecioProductos(producto);
                Conection.Close();
                return $"Se ha modificado los productos. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }

        public string EliminarProducto(Producto producto)
        {
            try
            {
                Conection.Open();
                ProductoRepositorio.EliminarProducto(producto);
                Conection.Close();
                return $"Se ha eliminado. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }

       



    }
}
