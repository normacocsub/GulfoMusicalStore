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
    public class LugarRepository
    {
        private IList<Lugar> Lugares;
        private ConectionManager Connection;
        private OracleDataReader Reader;

        public LugarRepository(ConectionManager connection)
        {
            Connection = connection;
            Lugares = new List<Lugar>();
        }

        public void GuardarLugar(Lugar lugar)
        {
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_LUGAR.GuardarLugar";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ciudadnew", OracleDbType.Varchar2).Value = lugar.Ciudad;
                command.ExecuteNonQuery();
            }
        }

        public IList<Lugar> ConsultarLugares()
        {
            Lugares.Clear();
            using(var command = Connection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_LUGAR.ConsultarLugares";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Lugar lugar;
                    lugar = Map(Reader);
                    Lugares.Add(lugar);
                    
                }
            }
            return Lugares;
        }

        private Lugar Map(OracleDataReader reader)
        {
            Lugar lugar = new Lugar();
            lugar.Codigo = int.Parse(((object)reader["sk_lugar"]).ToString());
            lugar.Ciudad = (string)reader["ciudad"];
            return lugar;
        }
    }
}
