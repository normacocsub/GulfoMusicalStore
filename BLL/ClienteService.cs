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
        private ConectionManager Conection;
        private ClienteRepository ClienteRepositorio;
        private IList<Cliente> Clientes;

        public ClienteService(string connection)
        {
            Conection = new ConectionManager(connection);
            ClienteRepositorio = new ClienteRepository(Conection);
            Clientes = new List<Cliente>();
        }

        public string GuardarCLiente(Cliente cliente)
        {
            try
            {
                Conection.Open();
                ClienteRepositorio.GuardarCliente(cliente);
                Conection.Close();
                return $"Se ha guardado el cliente. {cliente.PrimerNombre}";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
            
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                Conection.Open();
                ClienteRepositorio.ModificarCliente(cliente);
                Conection.Close();
                return $"Se ha modificado el cliente. {cliente.PrimerNombre}";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Cliente> ConsultarClientes()
        {
            try
            {
                Conection.Open();
                Clientes = ClienteRepositorio.ConsultarClientes();
                Conection.Close();
                return Clientes;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                
                return null;
            }
        }


        public Cliente BuscarCliente(string cedula)
        {
            Cliente cliente;
            try
            {
                Conection.Open();
                cliente = ClienteRepositorio.BuscarCliente(cedula);
                Conection.Close();
                return cliente;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                
                return null;
            }
        }
    }
}
