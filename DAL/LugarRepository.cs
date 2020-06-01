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
                    int opcion = 5;
                    Lugar lugar;
                    lugar = Map(Reader);
                    if (Lugares.Count == 0)
                    {
                        Lugares.Add(lugar);
                    }
                    foreach (var item in Lugares)
                    {
                        if (lugar.Codigo.Equals(item.Codigo))
                        {
                            opcion = 1;
                        }
                        else
                        {
                            opcion = 2;
                        }
                    }
                    if (opcion == 1)
                    {
                        lugar.AgregarBarrios(lugar.Barrio);
                    }
                    if (opcion == 2)
                    {
                        Lugares.Add(lugar);
                    }
                    
                }
            }
            return Lugares;
        }

        private Lugar Map(OracleDataReader reader)
        {
            Lugar lugar = new Lugar();
            lugar.Codigo = int.Parse(((object)reader["sk_lugar"]).ToString());
            lugar.Ciudad = (string)reader["ciudad"];
            Barrio barrio = new Barrio();
            barrio.Codigo = int.Parse(((object)reader["sk_barrio"]).ToString());
            barrio.Nombre = (string)reader["nombre"];
            lugar.AgregarBarrios(barrio);
            return lugar;
        }
    }
}
