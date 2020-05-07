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
        private OracleConnection Conexion;
        public ClienteRepository(OracleConnection conexion)
        {
            Clientes = new List<Cliente>();
            Conexion = conexion;
        }

        public void GuardarCliente(Cliente cliente)
        {
            OracleCommand command = new OracleCommand("GuardarCLientes",Conexion);
            MapearComando(command, cliente);
            command.ExecuteNonQuery();
        }

        public void ModificarCliente(Cliente cliente)
        {
            OracleCommand command = new OracleCommand("ModificarClientes", Conexion);
            MapearComando(command, cliente);
            command.ExecuteNonQuery();
        }

        public void MapearComando(OracleCommand command,Cliente cliente)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
            command.Parameters.Add("primername", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
            command.Parameters.Add("segundoname", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
            command.Parameters.Add("primerape", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
            command.Parameters.Add("segundoape", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
            command.Parameters.Add("sexo", OracleDbType.Varchar2).Value = cliente.Genero;
            command.Parameters.Add("email", OracleDbType.Varchar2).Value = cliente.Correo;
            command.Parameters.Add("phone", OracleDbType.Varchar2).Value = cliente.Telefono;
            command.Parameters.Add("city", OracleDbType.Varchar2).Value = cliente.Ciudad;
            command.Parameters.Add("barriocliente", OracleDbType.Varchar2).Value = cliente.Barrio;
            command.Parameters.Add("direction", OracleDbType.Varchar2).Value = cliente.Direccion;
        }
        public IList<Cliente> ConsultarClientes()
        {
            Clientes.Clear();
            OracleCommand command = new OracleCommand("ConsultarClientes", Conexion);
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

        public Cliente BuscarCliente(string cedula)
        {
            Cliente cliente = null;
            OracleCommand command = new OracleCommand("BuscarCliente", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cedula;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                cliente = MapCLiente(Reader);
            }
            return cliente;
        }

        public Cliente MapCLiente(OracleDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = (string)reader["id_cliente"];
            cliente.PrimerNombre = (string)reader["primernombre"];
            cliente.SegundoNombre = (string)reader["segundonombre"];
            cliente.PrimerApellido = (string)reader["primerapellido"];
            cliente.SegundoApellido = (string)reader["segundoapellido"];
            cliente.Correo = (string)reader["correo"];
            cliente.Genero = (string)reader["genero"];
            cliente.Telefono = (string)reader["telefono"];
            cliente.Ciudad = (string)reader["ciudad"];
            cliente.Barrio = (string)reader["barrio"];
            cliente.Direccion = (string)reader["direccion"];
            return cliente;
        }
    }
}
