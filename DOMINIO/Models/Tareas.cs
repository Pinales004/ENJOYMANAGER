using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.Tareas;
using DATOS.Conexion;
using System.Data.SqlClient;
using System.Data;

namespace DOMINIO.Models
{
    public class Tareas : ConexionSQL
    {

        public DataTable CargarTareas()
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
                        command.CommandText = "select * from Tareas_vw_ENJOY";
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


        public void InsertTarea(TareasProyecto tarea)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO TareasProyecto (IdProyecto, EstadoTareaid, IdProyectoMiembro, NombreTarea, FechaInicio, FechaFin) " +
                                        "VALUES (@IdProyecto, @EstadoTareaid, @IdProyectoMiembro, @NombreTarea, @FechaInicio, @FechaFin)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", tarea.IdProyecto));
                    command.Parameters.Add(new SqlParameter("@EstadoTareaid", tarea.EstadoTareaid));
                    command.Parameters.Add(new SqlParameter("@IdProyectoMiembro", tarea.IdProyectoMiembro));
                    command.Parameters.Add(new SqlParameter("@NombreTarea", tarea.NombreTarea));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", tarea.FechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", tarea.FechaFin));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTarea(TareasProyecto tarea)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE TareasProyecto " +
                                        "SET IdProyecto = @IdProyecto, EstadoTareaid = @EstadoTareaid, " +
                                        "IdProyectoMiembro = @IdProyectoMiembro, NombreTarea = @NombreTarea, " +
                                        "FechaInicio = @FechaInicio, FechaFin = @FechaFin " +
                                        "WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", tarea.IdProyecto));
                    command.Parameters.Add(new SqlParameter("@EstadoTareaid", tarea.EstadoTareaid));
                    command.Parameters.Add(new SqlParameter("@IdProyectoMiembro", tarea.IdProyectoMiembro));
                    command.Parameters.Add(new SqlParameter("@NombreTarea", tarea.NombreTarea));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", tarea.FechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", tarea.FechaFin));
                    command.Parameters.Add(new SqlParameter("@TareaId", tarea.TareaId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTarea(int tareaId)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE TareasProyecto SET Borrado = 1 WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para el TareaId
                    command.Parameters.Add(new SqlParameter("@TareaId", tareaId));

                    // Ejecuta la consulta para marcar la tarea como inactiva (borrado lógico)
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable TareaEstado()
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
                        command.CommandText = "select * from TareaEstado";
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

        public DataTable CargarListadoProyectos()
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
                        command.CommandText = "select * from Proyecto_vw_ENJOY";
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

        public DataTable CargarListadoMiembrosTarea()
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
                        command.CommandText = "select * from Proyecto_vw_ENJOY";
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

        public DataTable CargarMiembros(int idProyecto)
        {
            DataTable table = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT m.IdProyectoMiembro as ID, u.Nombres FROM ProyectoMiembros m INNER JOIN Usuario u ON m.IdUsuario = u.IdUsuario WHERE m.IdProyecto = @IdProyecto";


                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));

                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            return table;
        }

    }
}
