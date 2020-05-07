using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Oracle.ManagedDataAccess.Client;

namespace BLL
{
    public class ClienteService
    {
        private OracleConnection Conexion;
        private ClienteRepository ClienteRepositorio;
        private IList<Cliente> Clientes;

        public ClienteService()
        {
            Conexion = new OracleConnection(@"Data Source=localhost:1521/xe;User Id=Gulfo;Password=Shoops0119");
            ClienteRepositorio = new ClienteRepository(Conexion);
            Clientes = new List<Cliente>();
        }

        public string GuardarCLiente(Cliente cliente)
        {
            try
            {
                Conexion.Open();
                ClienteRepositorio.GuardarCliente(cliente);
                Conexion.Close();
                return $"Se ha guardado el cliente. {cliente.PrimerNombre}";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
            
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                Conexion.Open();
                ClienteRepositorio.ModificarCliente(cliente);
                Conexion.Close();
                return $"Se ha modificado el cliente. {cliente.PrimerNombre}";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Cliente> ConsultarClientes()
        {
            try
            {
                Conexion.Open();
                Clientes = ClienteRepositorio.ConsultarClientes();
                Conexion.Close();
                return Clientes;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                
                return null;
            }
        }


        public Cliente BuscarCliente(string cedula)
        {
            Cliente cliente;
            try
            {
                Conexion.Open();
                cliente = ClienteRepositorio.BuscarCliente(cedula);
                Conexion.Close();
                return cliente;
            }
            catch (OracleException ex)
            {
                Conexion.Close();
                
                return null;
            }
        }
    }
}
