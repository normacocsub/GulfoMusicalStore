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
    public class MarcaService
    {
        private MarcaRepository MarcaRepositorio;
        private IList<Marca> Marcas;
        private OracleConnection Conexion;

        public MarcaService()
        {
            Conexion = new OracleConnection(@"Data Source=localhost:1521/xe;User Id=Gulfo;Password=Shoops0119");
            MarcaRepositorio = new MarcaRepository(Conexion);
        }

        public string GuardarMarca(Marca marca)
        {
            try
            {
                Conexion.Open();
                MarcaRepositorio.GuardarMarca(marca);
                Conexion.Close();
                return $"Se ha guardado la marca. {marca.Nombre}";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la Base de datos. {ex.Message.ToString()}";
            }
        }

        public IList<Marca> ConsultarMarcas()
        {
            try
            {
                Conexion.Open();
                Marcas = MarcaRepositorio.ConsultarMarcas();
                Conexion.Close();
                return Marcas;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }

        public Marca FiltrarMarca(string nombre)
        {
            try
            {
                Marca marca;
                Conexion.Open();
                marca = MarcaRepositorio.FiltrarMarca(nombre);
                Conexion.Close();
                return marca;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }
    }
}
