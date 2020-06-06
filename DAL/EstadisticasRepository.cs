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
    public class EstadisticasRepository
    {
        private ConectionManager Conection;
        private IList<EstadisticasVentas> Estadisticas;
        private OracleDataReader Reader;

        public EstadisticasRepository(ConectionManager conection)
        {
            Conection = conection;
            Estadisticas = new List<EstadisticasVentas>();
        }

        public IList<EstadisticasVentas> ConsultarEstadisticas()
        {
            Estadisticas.Clear();
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_ESTADISTICAS.FILTRARESTADISTICAS";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("estadisticas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    EstadisticasVentas estadisticas;
                    estadisticas = Map(Reader);
                    Estadisticas.Add(estadisticas);
                }
            }
            return Estadisticas;
        }

        private EstadisticasVentas Map(OracleDataReader Reader)
        {
            EstadisticasVentas estadisticas = new EstadisticasVentas();
            estadisticas.Fecha = DateTime.Parse(((object)Reader["fecha"]).ToString());
            estadisticas.NumeroEstadistica = ((object)Reader["sk_estadistica"]).ToString();
            estadisticas.Total = decimal.Parse(((object)Reader["Total"]).ToString());
            estadisticas.Cantidad = int.Parse(((object)Reader["Unidades"]).ToString());
            return estadisticas;
        }

        public IList<EstadisticasVentas> FiltroDiaEstadisticas(int dia,int mes,int año)
        {
            ConsultarEstadisticas();
            return Estadisticas.Where(E => E.Fecha.Day.Equals(dia) && E.Fecha.Month.Equals(mes) && E.Fecha.Year.Equals(año)).ToList();
        }

        public IList<EstadisticasVentas> FiltroFechaEstadisticas(DateTime desde,DateTime hasta)
        {
            ConsultarEstadisticas();
            return Estadisticas.Where(E => E.Fecha >= desde && E.Fecha <= hasta).ToList();
        }
    }
}
