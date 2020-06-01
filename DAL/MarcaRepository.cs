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
    public class MarcaRepository
    {
        private IList<Marca> Marcas;
        private readonly ConectionManager Connection;
        private OracleDataReader Reader;

        public MarcaRepository(ConectionManager connection)
        {
            Connection = connection;
            Marcas = new List<Marca>();
        }

        public void GuardarMarca(Marca marca)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText= "PAQUETE_MARCA.GuardarMarcas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = marca.Nombre;
                command.ExecuteNonQuery();
            }
        }


        public IList<Marca> ConsultarMarcas()
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                Marcas.Clear();
                command.CommandText = "PAQUETE_MARCA.ConsultarMarcas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Marca marca;
                    marca = MapMarca(Reader);
                    Marcas.Add(marca);
                }
                return Marcas;
            }
        }

        public Marca FiltrarMarca(string nombre)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                Marca marca = null;
                command.CommandText = "PAQUETE_MARCA.FiltrarMarcas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    marca = MapMarca(Reader);
                }
                return marca;
            }
        }

        public Marca MapMarca(OracleDataReader reader)
        {
            Marca marca = new Marca();
            marca.NumeroMarca = ((object)reader["sk_marca"]).ToString();
            marca.Nombre = (string)reader["nombremarca"];
            return marca;
        }

        public Marca BuscarCodigoMarca(string nombre)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                Marca marca = null;
                command.CommandText = "PAQUETE_MARCA.CodigoNombreMarca";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {

                    marca = MapMarca(Reader);

                }
                return marca;
            }
        }

        public void ModificarMarca(Marca marca)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_MARCA.ModificarMarca";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("marca", OracleDbType.Int32).Value = int.Parse(marca.NumeroMarca);
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = marca.Nombre;
                command.ExecuteNonQuery();
            }
        }

        public Marca BuscarMarca(string marca)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                Marca marcas = null;
                command.CommandText = "PAQUETE_MARCA.BuscarMarca";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("marca", OracleDbType.Varchar2).Value = marca;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    marcas = MapMarca(Reader);
                }
                return marcas;
            }
        }

        public void EliminarMarca(Marca marca)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_MARCA.EliminarMarca";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("marca", OracleDbType.Int32).Value = int.Parse(marca.NumeroMarca);
                command.ExecuteNonQuery();
            }
        }
        
    }
}
