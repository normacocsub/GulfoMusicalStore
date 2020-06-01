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
    public class CursoService
    {
        private CursoRepository CursoRepositorio;
        private IList<Curso> Cursos;
        private ConectionManager Conection;
        public CursoService(string connection)
        {
            Conection = new ConectionManager(connection);
            CursoRepositorio = new CursoRepository(Conection);
            Cursos = new List<Curso>();
        }

        public string GuardarCurso(Curso curso)
        {
            try
            {
                Conection.Open();
                CursoRepositorio.GuardarCurso(curso);
                Conection.Close();
                return $"Se ha guardado el curso ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Curso> ConsultarCursos()
        {
            try
            {
                Cursos.Clear();
                Conection.Open();
                Cursos = CursoRepositorio.ConsultarCursos();
                Conection.Close();
                return Cursos;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public Curso BuscarCurso(string nombre)
        {
            try
            {
                Curso curso;
                Conection.Open();
                curso = CursoRepositorio.BuscarCurso(nombre);
                Conection.Close();
                return curso;
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return null;
            }
        }

        public string ModificarCurso(Curso curso)
        {
            try
            {
                Conection.Open();
                CursoRepositorio.ModificarCurso(curso);
                Conection.Close();
                return $"Se ha modificado. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error al modificar. {ex.Message.ToString()}";
            }
        }

        public string EliminarCurso(Curso curso)
        {
            try
            {
                Conection.Open();
                CursoRepositorio.EliminarCurso(curso);
                Conection.Close();
                return $"Se ha eliminado. ";
            }
            catch(OracleException ex)
            {
                Conection.Close();
                return $"Error. {ex.Message.ToString()}";
            }
        }
    }
}
