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
        private readonly ConectionManager Connetion;

        public MarcaService(string connection)
        {
            Connetion = new ConectionManager(connection);
            MarcaRepositorio = new MarcaRepository(Connetion);
        }

        public string GuardarMarca(Marca marca)
        {
            try
            {
                Connetion.Open();
                MarcaRepositorio.GuardarMarca(marca);
                Connetion.Close();
                return $"Se ha guardado la marca. {marca.Nombre}";
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return $"Error en la Base de datos. {ex.Message.ToString()}";
            }
        }

        public IList<Marca> ConsultarMarcas()
        {
            try
            {
                Connetion.Open();
                Marcas = MarcaRepositorio.ConsultarMarcas();
                Connetion.Close();
                return Marcas;
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return null;
            }
        }

        public Marca FiltrarMarca(string nombre)
        {
            try
            {
                Marca marca;
                Connetion.Open();
                marca = MarcaRepositorio.FiltrarMarca(nombre);
                Connetion.Close();
                return marca;
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return null;
            }
        }
        public Marca BuscarCodigoMarca(string nombre)
        {
            Marca marca; 
            try
            {
                Connetion.Open();
                marca = MarcaRepositorio.BuscarCodigoMarca(nombre);
                Connetion.Close();
                return marca;
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return null;
            }
        }

        public Marca BuscarMarca(string marca)
        {
            Marca marcas=null;
            try
            {
                Connetion.Open();
                marcas = MarcaRepositorio.BuscarMarca(marca);
                Connetion.Close();
                return marcas;
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return null;
            }
        }

        public string ModificarMarca(Marca marca)
        {
            try
            {
                Connetion.Open();
                MarcaRepositorio.ModificarMarca(marca);
                Connetion.Close();
                return $"Se ha modificado. ";
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return $"Error. {ex.Message.ToString()}";
            }
        }

        public string EliminarMarca(Marca marca)
        {
            try
            {
                Connetion.Open();
                MarcaRepositorio.EliminarMarca(marca);
                Connetion.Close();
                return $"Eliminar Marca";
            }
            catch(OracleException ex)
            {
                Connetion.Close();
                return $"Error. {ex.Message.ToString()}";
            }
        }
    }
}
