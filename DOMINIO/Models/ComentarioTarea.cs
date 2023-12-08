using DATOS.Conexion;
using DATOS.Tareas;
using System.Data;
using System.Data.SqlClient;

namespace DOMINIO.Models
{
    public class ComentarioTarea : ConexionSQL
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
                    command.CommandText = "SELECT * FROM ComentariosTASK_vw_ENJOY WHERE TareaId = @TareaId";
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
                                FechaCreacion = (DateTime)reader["Fecha de creación"],
                                UsuarioCrea = reader["Nombre de Usuario"].ToString(),
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
                    command.CommandText = "INSERT INTO ComentarioTarea (Comentario,FechaCreacion,TareaId,IdUsuario) " +
                                        "VALUES (@Comentario,@FechaCreacion,@TareaId,@IdUsuario)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@Comentario", comentarioTarea.Comentario));
                    command.Parameters.Add(new SqlParameter("@FechaCreacion", comentarioTarea.FechaCreacion));
                    command.Parameters.Add(new SqlParameter("@TareaId", comentarioTarea.TareaId));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", comentarioTarea.IdUsuario));

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
                                        "SET Comentario = @Comentario " + // Espacio agregado aquí
                                        "WHERE ComentarioTareaId = @ComentarioTareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@ComentarioTareaId", comentarioTarea.ComentarioTareaId));
                    command.Parameters.Add(new SqlParameter("@Comentario", comentarioTarea.Comentario));

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
