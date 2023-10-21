using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Conexion
{
    public class ProjectAcceso : ConexionSQL
    {

        public void InsertarProyecto(string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idEstado, int idUsuario, bool borrado)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Proyectos (NombreProyecto, Descripcion, FechaInicio, FechaFin, IdEstado, IdUsuario, Borrado) " +
                                        "VALUES (@NombreProyecto, @Descripcion, @FechaInicio, @FechaFin, @IdEstado, @IdUsuario, @Borrado)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                    command.Parameters.Add(new SqlParameter("@IdEstado", idEstado));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));
                    command.Parameters.Add(new SqlParameter("@Borrado", borrado));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarProyectos(bool mostrarBorrados)
        {
            DataTable table = new DataTable();
            try
            {
                using (var connection = GETConexionSQL())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        if (mostrarBorrados)
                        {
                            // Consulta para cargar todos los proyectos, incluidos los marcados como borrados
                            command.CommandText = "SELECT P.NombreProyecto, U.UsuarioNombre AS 'Administrador', E.Nombre AS 'Estado', P.FechaInicio, P.FechaFin " +
                                                "FROM Proyectos P " +
                                                "INNER JOIN Usuario U ON P.IdUsuario = U.IdUsuario " +
                                                "INNER JOIN Estado E ON P.IdEstado = E.IdEstado";
                        }
                        else
                        {
                            // Consulta para cargar solo proyectos no marcados como borrados
                            command.CommandText = "SELECT P.NombreProyecto, U.UsuarioNombre AS 'Administrador', E.Nombre AS 'Estado', P.FechaInicio, P.FechaFin " +
                                                "FROM Proyectos P " +
                                                "INNER JOIN Usuario U ON P.IdUsuario = U.IdUsuario " +
                                                "INNER JOIN Estado E ON P.IdEstado = E.IdEstado " +
                                                "WHERE P.Borrado = 0";
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar proyectos: " + ex.Message);
            }
            return table;
        }

        public void EditarProyecto(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idEstado, int idUsuario, bool borrado)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Proyectos " +
                                        "SET NombreProyecto = @NombreProyecto, " +
                                        "Descripcion = @Descripcion, " +
                                        "FechaInicio = @FechaInicio, " +
                                        "FechaFin = @FechaFin, " +
                                        "IdEstado = @IdEstado, " +
                                        "IdUsuario = @IdUsuario, " +
                                        "Borrado = @Borrado " +
                                        "WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                    command.Parameters.Add(new SqlParameter("@IdEstado", idEstado));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));
                    command.Parameters.Add(new SqlParameter("@Borrado", borrado));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProyecto(int idProyecto)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Proyectos WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para el IdProyecto
                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
