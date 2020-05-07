using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace DAL
{
    public class CursoRepository
    {
        private IList<Curso> Cursos;
        private OracleConnection Conexion;
        private OracleDataReader Reader;
        public CursoRepository(OracleConnection conexion)
        {
            Cursos = new List<Curso>();
            Conexion = conexion;
        }

        public void GuardarCurso(Curso curso)
        {
            OracleCommand command = new OracleCommand("GuardarCurso", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = curso.Nombre;
            command.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(curso.Total.ToString());
            command.Parameters.Add("fechac", OracleDbType.Date).Value = curso.FechaCreacion.ToShortDateString();
            command.Parameters.Add("estadoc", OracleDbType.Varchar2).Value = curso.Estado;
            command.ExecuteNonQuery();
        }
        public IList<Curso> ConsultarCursos()
        {
            Cursos.Clear();
            OracleCommand command = new OracleCommand("ConsultarCursos",Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                Curso curso;
                curso = MapCurso(Reader);
                Cursos.Add(curso);
            }
            return Cursos;
        }

        public Curso MapCurso(OracleDataReader reader)
        {
            Curso curso = new Curso();
            curso.Codigo = ((object)reader["id_Curso"]).ToString();
            curso.Nombre = (string)reader["nombrecurso"];
            curso.Total = decimal.Parse(((double)reader["preciocurso"]).ToString());
            curso.Estado = (string)reader["estado"];
            curso.FechaCreacion = (DateTime)reader["fecha"];
            return curso;
        }

        public Curso BuscarCurso(string nombre)
        {
            Curso curso=null;
            OracleCommand command = new OracleCommand("BuscarCurso", Conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                curso = MapCurso(Reader);
            }
            return curso;
        }
    }
}
