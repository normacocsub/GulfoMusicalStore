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
    public class EstadisticasService
    {
        private ConectionManager Conection;
        private IList<EstadisticasVentas> Estadisticas;
        private EstadisticasRepository EstadisticasRepositorio;

        public EstadisticasService(string conection)
        {
            Conection = new ConectionManager(conection);
            EstadisticasRepositorio = new EstadisticasRepository(Conection);
        }

        public IList<EstadisticasVentas> FiltroEstadisticasDia(int dia,int mes,int año)
        {
            try
            {
                Conection.Open();
                Estadisticas = EstadisticasRepositorio.FiltroDiaEstadisticas(dia, mes, año);
                Conection.Close();
                return Estadisticas;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public IList<EstadisticasVentas> FiltroFechaEstadisticas(DateTime desde, DateTime hasta)
        {
            try
            {
                Conection.Open();
                Estadisticas = EstadisticasRepositorio.FiltroFechaEstadisticas(desde,hasta);
                Conection.Close();
                return Estadisticas;
            }
            catch (OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }
    }
}
