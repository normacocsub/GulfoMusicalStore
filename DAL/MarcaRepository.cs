using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class MarcaRepository
    {
        private IList<Marca> Marcas;
        private OracleConnection Conexion;
        private OracleDataReader Reader;

        public MarcaRepository(OracleConnection conexion)
        {
            Conexion = conexion;
            Marcas = new List<Marca>();
        }

        public void GuardarMarca(Marca marca)
        {
            OracleCommand command = new OracleCommand("GuardarMarcas", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = marca.Nombre;
            command.ExecuteNonQuery();
        }


        public IList<Marca> ConsultarMarcas()
        {
            Marcas.Clear();
            OracleCommand command = new OracleCommand("ConsultarMarcas", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
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

        public Marca FiltrarMarca(string nombre)
        {
            Marca marca = null;
            OracleCommand command = new OracleCommand("FiltrarMarcas", Conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                marca = MapMarca(Reader);
            }
            return marca;
        }

        public Marca MapMarca(OracleDataReader reader)
        {
            Marca marca = new Marca();
            marca.NumeroMarca = ((object)reader["sk_marca"]).ToString();
            marca.Nombre = (string)reader["nombremarca"];
            return marca;
        }
        
    }
}
