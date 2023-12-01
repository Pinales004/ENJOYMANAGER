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
    public class ProyectoAcceso  : ConexionSQL
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



        public void InsertarProyecto(string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, DateTime fechaInicioProgramada, DateTime fechaFinProgramada, int estadoProyectoid, int idUsuario)
        {
            try
            {
                // Verificar si el nombre del proyecto ya existe
                if (ProyectoExistente(nombreProyecto))
                {
                    // Lanzar una excepción personalizada para manejarla desde la capa de presentación
                    throw new InvalidOperationException("El nombre del proyecto ya existe. No se puede guardar.");
                }

                using (var connection = GETConexionSQL())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Proyectos (NombreProyecto, Descripcion, FechaInicio, FechaFin, FechaInicioProgramada, FechaFinReal, EstadoProyectoid, IdUsuario) " +
                                            "VALUES (@NombreProyecto, @Descripcion, @FechaInicio, @FechaFin, @FechaInicioProgramada, @FechaFinReal, @EstadoProyectoid, @IdUsuario)";
                        command.CommandType = CommandType.Text;

                        // Agrega los parámetros y sus valores
                        command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                        command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                        command.Parameters.Add(new SqlParameter("@FechaInicio", fechaInicio));
                        command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                        command.Parameters.Add(new SqlParameter("@FechaInicioProgramada", fechaInicioProgramada));
                        command.Parameters.Add(new SqlParameter("@FechaFinReal", fechaFinProgramada));
                        command.Parameters.Add(new SqlParameter("@EstadoProyectoid", estadoProyectoid));
                        command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                        // Ejecuta la consulta para insertar el nuevo proyecto
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de otros errores, puedes manejar la excepción aquí, mostrar un mensaje de error o registrar el error.
                throw new InvalidOperationException("Error inesperado al insertar el proyecto: " + ex.Message);
               
            }
        }


        // Método para verificar si el nombre del proyecto ya existe
        private bool ProyectoExistente(string nombreProyecto)
        {
            try
            {
                using (var connection = GETConexionSQL())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT COUNT(*) FROM Proyectos WHERE NombreProyecto = @NombreProyecto";
                        command.CommandType = CommandType.Text;

                        // Agrega el parámetro y su valor
                        command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));

                        // Obtiene el resultado de la consulta
                        int count = (int)command.ExecuteScalar();

                        // Si count es mayor que 0, el nombre del proyecto ya existe
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Lanza la excepción personalizada para ser manejada desde la capa de presentación
                throw new InvalidOperationException("Error al verificar la existencia del proyecto: " + ex.Message);
            }
        }






        public void EditarProyecto(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaFin, DateTime fechaInicioProgramada, DateTime FechaFinReal, int estadoProyectoid, int idUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Proyectos " +
                                        "SET NombreProyecto = @NombreProyecto, Descripcion = @Descripcion, " +
                                        "FechaFin = @FechaFin,FechaInicioProgramada = @FechaInicioProgramada, FechaFinReal = @FechaFinReal, EstadoProyectoid = @EstadoProyectoid, " +
                                        "IdUsuario = @IdUsuario " +
                                        "WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@NombreProyecto", nombreProyecto));
                    command.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                    command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                    command.Parameters.Add(new SqlParameter("@FechaInicioProgramada", fechaInicioProgramada));
                    command.Parameters.Add(new SqlParameter("@FechaFinReal", FechaFinReal));
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
                    command.CommandText = "UPDATE Proyectos SET Borrado = 1 WHERE IdProyecto = @IdProyecto";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para el IdProyecto
                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));

                    // Ejecuta la consulta para eliminar el proyecto
                    command.ExecuteNonQuery();
                }
            }
        }



        public DataTable ProyectoEstado()
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
                        command.CommandText = "select * from ProyectoEstado";
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


        public DataTable BuscarProyectoPorNombre(string nombre)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Proyecto_vw_ENJOY WHERE Nombre LIKE @Nombre";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para la búsqueda dinámica
                    command.Parameters.Add(new SqlParameter("@Nombre", "%" + nombre + "%"));

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
