﻿using DATOS.Conexion;
using DATOS.Tareas;
using System.Data;
using System.Data.SqlClient;

namespace DOMINIO.Models
{
    public class Tareas : ConexionSQL
    {

        public DataTable CargarTareas(int idUsuario)
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
                        // Utilizamos un parámetro para evitar posibles problemas de seguridad y para pasar el IdUsuario.
                        command.CommandText =
                            "SELECT task.TareaId, " +
                            "pro.Idproyecto, " +
                            "task.NombreTarea AS \"Nombre de la tarea\", " +
                            "pro.NombreProyecto AS \"Nombre del proyecto\", " +
                            "task.DescripcionTarea AS Descripción, " +
                            "est.Estado, " +
                            "task.FechaInicio AS \"Fecha de inicio\", " +
                            "task.FechaFin AS \"Fecha final\", " +
                            "usu.Nombres AS Responsable " +
                            "FROM TareasProyecto task " +
                            "INNER JOIN Proyectos pro ON task.IdProyecto = pro.IdProyecto " +
                            "INNER JOIN TareaEstado est ON task.EstadoTareaid = est.EstadoTareaid " +
                            "LEFT JOIN ProyectoMiembros miem ON task.IdProyectoMiembro = miem.IdProyectoMiembro " +
                            "INNER JOIN Usuario usu ON miem.IdUsuario = usu.IdUsuario " +
                            "WHERE task.Borrado = 0 " +
                            "  AND pro.Borrado = 0 " +
                            "  AND pro.IdProyecto IN (SELECT IdProyecto FROM ProyectoMiembros WHERE IdUsuario = @IdUsuario)";

                        command.CommandType = CommandType.Text;

                        // Agregamos el parámetro IdUsuario
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);

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
                Console.WriteLine("Error al cargar tareas: " + ex.Message);
            }

            return table;
        }

        public DataTable CargarTareasFiltrOpROGRAMADOR(int idUsuario, string nombreTarea, string nombreProyecto, DateTime? fechaInicio, DateTime? fechaFin, int? estadoTareaId)
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

                        // Utilizamos parámetros con nombres descriptivos
                        command.CommandText =
                            "SELECT task.TareaId, " +
                            "pro.Idproyecto, " +
                            "task.NombreTarea AS \"Nombre de la tarea\", " +
                            "pro.NombreProyecto AS \"Nombre del proyecto\", " +
                            "task.DescripcionTarea AS Descripción, " +
                            "est.Estado, " +
                            "task.FechaInicio AS \"Fecha de inicio\", " +
                            "task.FechaFin  AS \"Fecha final\", " +
                            "usu.Nombres AS Responsable " +
                            "FROM TareasProyecto task " +
                            "INNER JOIN Proyectos pro ON task.IdProyecto = pro.IdProyecto " +
                            "INNER JOIN TareaEstado est ON task.EstadoTareaid = est.EstadoTareaid " +
                            "LEFT JOIN ProyectoMiembros miem ON task.IdProyectoMiembro = miem.IdProyectoMiembro " +
                            "INNER JOIN Usuario usu ON miem.IdUsuario = usu.IdUsuario " +
                            "WHERE task.Borrado = 0 " +
                            "  AND pro.Borrado = 0 " +
                            "  AND pro.IdProyecto IN (SELECT IdProyecto FROM ProyectoMiembros WHERE IdUsuario = @IdUsuario) " +
                            "  AND (@NombreTarea IS NULL OR task.NombreTarea LIKE '%' + @NombreTarea + '%') " +
                            "  AND (@NombreProyecto IS NULL OR pro.NombreProyecto LIKE '%' + @NombreProyecto + '%') " +
                            "  AND (@FechaInicio IS NULL OR task.FechaInicio >= @FechaInicio) " +
                            "  AND (@FechaFin IS NULL OR task.FechaFin <= @FechaFin) " +
                            "  AND (@EstadoTareaId IS NULL OR est.EstadoTareaId = @EstadoTareaId)";

                        command.CommandType = CommandType.Text;

                        // Agregamos los parámetros
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        command.Parameters.AddWithValue("@NombreTarea", nombreTarea);
                        command.Parameters.AddWithValue("@NombreProyecto", nombreProyecto);
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio != null ? fechaInicio : (object)DBNull.Value);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin != null ? fechaFin : (object)DBNull.Value);
                        command.Parameters.AddWithValue("@EstadoTareaId", estadoTareaId != null ? estadoTareaId : (object)DBNull.Value);

                        using (var reader = command.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, puedes personalizar esto según tus necesidades
                Console.WriteLine("Error al cargar tareas: " + ex.Message);
            }

            return table;
        }


        public DataTable CargarTareasGeneral()
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
                    command.CommandText = "INSERT INTO TareasProyecto (IdProyecto, EstadoTareaid, IdProyectoMiembro, NombreTarea, DescripcionTarea, FechaInicio, FechaFin) " +
                                        "VALUES (@IdProyecto, @EstadoTareaid, @IdProyectoMiembro, @NombreTarea, @DescripcionTarea, @FechaInicio, @FechaFin)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", tarea.IdProyecto));
                    command.Parameters.Add(new SqlParameter("@EstadoTareaid", tarea.EstadoTareaid));
                    command.Parameters.Add(new SqlParameter("@IdProyectoMiembro", tarea.IdProyectoMiembro));
                    command.Parameters.Add(new SqlParameter("@NombreTarea", tarea.NombreTarea));
                    command.Parameters.Add(new SqlParameter("@DescripcionTarea", tarea.DescripcionTarea));
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
                                        "IdProyectoMiembro = @IdProyectoMiembro, NombreTarea = @NombreTarea, DescripcionTarea = @DescripcionTarea, " +
                                        "FechaInicio = @FechaInicio, FechaFin = @FechaFin " +
                                        "WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", tarea.IdProyecto));
                    command.Parameters.Add(new SqlParameter("@EstadoTareaid", tarea.EstadoTareaid));
                    command.Parameters.Add(new SqlParameter("@IdProyectoMiembro", tarea.IdProyectoMiembro));
                    command.Parameters.Add(new SqlParameter("@NombreTarea", tarea.NombreTarea));
                    command.Parameters.Add(new SqlParameter("@DescripcionTarea", tarea.DescripcionTarea));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", tarea.FechaInicio));
                    command.Parameters.Add(new SqlParameter("@FechaFin", tarea.FechaFin));
                    command.Parameters.Add(new SqlParameter("@TareaId", tarea.TareaId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEstadoTarea(int tareaId, int nuevoEstadoTareaId)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE TareasProyecto " +
                                          "SET EstadoTareaid = @EstadoTareaid " +
                                          "WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@EstadoTareaid", nuevoEstadoTareaId));
                    command.Parameters.Add(new SqlParameter("@TareaId", tareaId));

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
                    command.CommandText = "SELECT m.IdProyectoMiembro as ID, u.Nombres " +
                                          "FROM ProyectoMiembros m " +
                                          "INNER JOIN Usuario u ON m.IdUsuario = u.IdUsuario " +
                                          "WHERE m.IdProyecto = @IdProyecto AND m.Borrado = 0";

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

        public DataTable BuscarTareaPorFiltros(string nombreProyecto, string responsable, DateTime? fechaInicio, DateTime? fechaFin, int? estadoTareaId)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Tareas_vw_ENJOY WHERE " +
                                          "(@NombreProyecto IS NULL OR [Nombre del proyecto] LIKE '%' + @NombreProyecto + '%') AND " +
                                          "(@Responsable IS NULL OR Responsable LIKE '%' + @Responsable + '%') AND " +
                                          "(@FechaInicio IS NULL OR [Fecha de inicio] >= @FechaInicio) AND " +
                                          "(@FechaFin IS NULL OR [Fecha final] <= @FechaFin) AND " +
                                          "(@EstadoTareaId IS NULL OR EstadoTareaid = @EstadoTareaId)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros para la búsqueda dinámica
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Responsable", responsable));
                    command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio != null ? fechaInicio : (object)DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin != null ? fechaFin : (object)DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@EstadoTareaId", estadoTareaId != null ? estadoTareaId : (object)DBNull.Value));

                    var results = new DataTable();

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(results);
                    }

                    return results;
                }
            }
        }


        public DataTable BuscarTareaPorIdPoryecto(int IdProyecto)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Tareas_vw_ENJOY WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para la búsqueda dinámica
                    command.Parameters.Add(new SqlParameter("@IdProyecto", IdProyecto));

                    var results = new DataTable();

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(results);
                    }

                    return results;
                }
            }
        }




    }
}
