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
        private ConectionManager Conection;
        private OracleDataReader Reader;
        public CursoRepository(ConectionManager conection)
        {
            Cursos = new List<Curso>();
            Conection = conection;
        }

        public void GuardarCurso(Curso curso)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_CURSO.GUARDARCURSOS";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = curso.Nombre;
                command.Parameters.Add("estado", OracleDbType.Varchar2).Value = curso.Estado;
                command.Parameters.Add("fecha", OracleDbType.Varchar2).Value = curso.FechaCreacion.ToShortDateString();
                command.Parameters.Add("precio", OracleDbType.Decimal).Value = curso.Total;
                command.ExecuteNonQuery();
            }
        }
        public IList<Curso> ConsultarCursos()
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Cursos.Clear();
                command.CommandText = "PAQUETE_CURSO.ConsultarCursos";
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
        }

        public Curso MapCurso(OracleDataReader reader)
        {
            Curso curso = new Curso();
            curso.Codigo = ((object)reader["sk_Curso"]).ToString();
            curso.Nombre = (string)reader["nombre"];
            curso.Total = decimal.Parse(((double)reader["precio"]).ToString());
            curso.Estado = (string)reader["estado"];
            curso.FechaCreacion = DateTime.Parse((string)reader["fecha"]);
            return curso;
        }

        public Curso BuscarCurso(string nombre)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                Curso curso = null;
                command.CommandText = "PAQUETE_CURSO.BuscarCurso";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("codigo", OracleDbType.Int32).Value = int.Parse(nombre);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    curso = MapCurso(Reader);
                }
                return curso;
            }
        }

        public void ModificarCurso(Curso curso)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_CURSO.MODIFICARCURSO";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("curso", OracleDbType.Int32).Value = int.Parse(curso.Codigo);
                command.Parameters.Add("precionew", OracleDbType.Decimal).Value = curso.Total;
                command.ExecuteNonQuery();
            }
        }

        public void EliminarCurso(Curso curso)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_CURSO.ELIMINARCURSO";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("curso", OracleDbType.Int32).Value = int.Parse(curso.Codigo);
                command.ExecuteNonQuery();
            }
        }
    }
}
