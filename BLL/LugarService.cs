using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace BLL
{
    public class LugarService
    {
        private IList<Lugar> lugares;
        private ConectionManager Conection;
        private LugarRepository LugarRepositorio;

        public LugarService(string connection)
        {
            Conection = new ConectionManager(connection);
            LugarRepositorio = new LugarRepository(Conection);
        }

        public string GuardarLugar(Lugar lugar)
        {
            try
            {
                Conection.Open();
                LugarRepositorio.GuardarLugar(lugar);
                Conection.Close();
                return $"Se ha guardado el lugar. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error. {ex.Message.ToString()}";
            }
        }

        public IList<Lugar> ConsultarLugares()
        {
            try
            {
                Conection.Open();
                lugares = LugarRepositorio.ConsultarLugares();
                Conection.Close();
                return lugares;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }
    }
}
