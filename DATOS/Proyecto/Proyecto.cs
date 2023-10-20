using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;
using DATOS.Conexion;

namespace DATOS.Proyecto
{

    //manejo de logica
    public class Proyecto  : ConexionSQL
    {

        public DataTable CargarProyectos()
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
                        command.CommandText = "SELECT P.IdProyecto, P.NombreProyecto, P.Descripcion, P.FechaInicio, P.FechaFin, " +
                                            "E.Estado AS EstadoProyecto, U.IdUsuario " +
                                            "FROM Proyectos P " +
                                            "INNER JOIN ProyectoEstado E ON P.EstadoProyectoid = E.EstadoProyectoid " +
                                            "INNER JOIN Usuarios U ON P.IdUsuario = U.IdUsuario";
                        command.CommandType = CommandType.Text;

                        using (var reader = command.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción aquí, por ejemplo, mostrar un mensaje de error o registrar el error.
                Console.WriteLine("Error al cargar proyectos: " + ex.Message);
            }

            return table;
        }


        public void InsertarProyecto(string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int estadoProyectoid, int idUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Proyectos (NombreProyecto, Descripcion, FechaInicio, FechaFin, EstadoProyectoid, IdUsuario) " +
                                        "VALUES (@NombreProyecto, @Descripcion, @FechaInicio, @FechaFin, @EstadoProyectoid, @IdUsuario)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                    command.Parameters.Add(new SqlParameter("@EstadoProyectoid", estadoProyectoid));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                    // Ejecuta la consulta para insertar el nuevo proyecto
                    command.ExecuteNonQuery();
                }
            }
        }


        public void EditarProyecto(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int estadoProyectoid, int idUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Proyectos " +
                                        "SET NombreProyecto = @NombreProyecto, Descripcion = @Descripcion, " +
                                        "FechaInicio = @FechaInicio, FechaFin = @FechaFin, EstadoProyectoid = @EstadoProyectoid, " +
                                        "IdUsuario = @IdUsuario " +
                                        "WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                    command.Parameters.Add(new SqlParameter("@EstadoProyectoid", estadoProyectoid));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                    // Ejecuta la consulta para actualizar el proyecto existente
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

                    // Ejecuta la consulta para eliminar el proyecto
                    command.ExecuteNonQuery();
                }
            }
        }


































    }
}
