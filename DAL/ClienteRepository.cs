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
    public class ClienteRepository
    {
        private IList<Cliente> Clientes;
        private OracleDataReader Reader;
        private ConectionManager Conection;
        public ClienteRepository(ConectionManager conection)
        {
            Clientes = new List<Cliente>();
            Conection = conection;
        }

        public void GuardarCliente(Cliente cliente)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_CLIIENTE.GuardarCLientes";
                MapearComando(command, cliente);
                command.ExecuteNonQuery();
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_CLIIENTE.ModificarClientes";
                MapearComando(command, cliente);
                command.ExecuteNonQuery();
            }
        }

        public void MapearComando(OracleCommand command,Cliente cliente)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
            command.Parameters.Add("primername", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
            command.Parameters.Add("segundoname", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
            command.Parameters.Add("primerape", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
            command.Parameters.Add("segundoape", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
            command.Parameters.Add("email", OracleDbType.Varchar2).Value = cliente.Correo;
            command.Parameters.Add("phone", OracleDbType.Varchar2).Value = cliente.Telefono;
            command.Parameters.Add("city", OracleDbType.Varchar2).Value = cliente.Lugar.Codigo;
            command.Parameters.Add("barriocliente", OracleDbType.Varchar2).Value = cliente.Barrio.Codigo;
            command.Parameters.Add("direction", OracleDbType.Varchar2).Value = cliente.Direccion;
        }
        public IList<Cliente> ConsultarClientes()
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Clientes.Clear();
                command.CommandText = "PAQUETE_CLIIENTE.ConsultarClientes";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Cliente cliente;
                    cliente = MapCLiente(Reader);
                    Clientes.Add(cliente);
                }
                return Clientes;
            }
        }

        public Cliente BuscarCliente(string cedula)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Cliente cliente = null;
                command.CommandText = "PAQUETE_CLIIENTE.BuscarCliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cedula;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    cliente = MapCLiente(Reader);
                }
                return cliente;
            }
        }

        public Cliente MapCLiente(OracleDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = (string)reader["id_clientte"];
            cliente.PrimerNombre = (string)reader["primernombre"];
            cliente.SegundoNombre = (string)reader["segundonombre"];
            cliente.PrimerApellido = (string)reader["primerapellido"];
            cliente.SegundoApellido = (string)reader["segundoapellido"];
            cliente.Correo = (string)reader["correo"];
            cliente.Telefono = (string)reader["telefono"];
            Lugar lugar = new Lugar();
            lugar.Codigo = int.Parse(((object)reader["sk_lugar"]).ToString());
            lugar.Ciudad = (string)reader["ciudad"];
            Barrio barrio = new Barrio();
            barrio.Codigo = int.Parse(((object)reader["sk_barrio"]).ToString());
            barrio.Nombre = (string)reader["nombre"];
            cliente.Direccion = (string)reader["direccion"];
            cliente.AgregarLugar(lugar);
            cliente.AgregarBarrio(barrio);
            return cliente;
        }
    }
}
