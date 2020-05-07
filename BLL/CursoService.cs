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
        private OracleConnection Conexion;
        public CursoService()
        {
            Conexion = new OracleConnection(@"Data Source=localhost:1521/xe;User Id=Gulfo;Password=Shoops0119");
            CursoRepositorio = new CursoRepository(Conexion);
            Cursos = new List<Curso>();
        }

        public string GuardarCurso(Curso curso)
        {
            try
            {
                Conexion.Open();
                CursoRepositorio.GuardarCurso(curso);
                Conexion.Close();
                return $"Se ha guardado el curso ";
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return $"Error en la base de datos. {ex.Message.ToString()}";
            }
        }
        public IList<Curso> ConsultarCursos()
        {
            try
            {
                Cursos.Clear();
                Conexion.Open();
                Cursos = CursoRepositorio.ConsultarCursos();
                Conexion.Close();
                return Cursos;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }

        public Curso BuscarCurso(string nombre)
        {
            try
            {
                Curso curso;
                Conexion.Open();
                curso = CursoRepositorio.BuscarCurso(nombre);
                Conexion.Close();
                return curso;
            }
            catch(OracleException ex)
            {
                Conexion.Close();
                return null;
            }
        }
    }
}
