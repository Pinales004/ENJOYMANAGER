using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.Conexion;
using System.Data.SqlClient;
using System.Data;
using DATOS.Tareas;

namespace DOMINIO.Models
{
    public  class ComentarioTarea : ConexionSQL
    {

        public List<ComentariosTarea> GetComentariosPorIdTarea(int tareaId)
        {
            List<ComentariosTarea> comentarios = new List<ComentariosTarea>();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ComentarioTareaId, Comentario FROM ComentarioTarea WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro y su valor
                    command.Parameters.Add(new SqlParameter("@TareaId", tareaId));

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComentariosTarea comentario = new ComentariosTarea
                            {
                                ComentarioTareaId = (int)reader["ComentarioTareaId"],
                                Comentario = reader["Comentario"].ToString(),
                                TareaId = (int)reader["TareaId"]
                            };

                            comentarios.Add(comentario);
                        }
                    }
                }
            }

            return comentarios;
        }










        public void InsertComentarioTarea(ComentariosTarea comentarioTarea)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ComentarioTarea (Comentario, TareaId) " +
                                        "VALUES (@Comentario, @TareaId)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@Comentario", comentarioTarea.Comentario));
                    command.Parameters.Add(new SqlParameter("@TareaId", comentarioTarea.TareaId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateComentarioTarea(ComentariosTarea comentarioTarea)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE ComentarioTarea " +
                                        "SET Comentario = @Comentario, TareaId = @TareaId, Borrado = @Borrado " +
                                        "WHERE ComentarioTareaId = @ComentarioTareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@ComentarioTareaId", comentarioTarea.ComentarioTareaId));
                    command.Parameters.Add(new SqlParameter("@Comentario", comentarioTarea.Comentario));
                    command.Parameters.Add(new SqlParameter("@TareaId", comentarioTarea.TareaId));
                    command.Parameters.Add(new SqlParameter("@Borrado", comentarioTarea.Borrado));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SoftDeleteComentarioTarea(int comentarioTareaId)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE ComentarioTarea SET Borrado = 1 WHERE ComentarioTareaId = @ComentarioTareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro y su valor
                    command.Parameters.Add(new SqlParameter("@ComentarioTareaId", comentarioTareaId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }








































    }
}
