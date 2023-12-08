using DATOS.Conexion;
using System.Data;
using System.Data.SqlClient;
namespace DATOS.Proyecto
{
    public class ProyectoMiembrosAccess : ConexionSQL
    {

        public void InsertarMiembro(int idProyecto, int idUsuario)
        {
            if (ProyectoMiembroExiste(idProyecto, idUsuario))
            {
                // El miembro ya existe en el proyecto
                // Verificar el estado de Borrado
                bool borrado = ObtenerEstadoBorrado(idProyecto, idUsuario);

                if (borrado)
                {
                    // Si Borrado es 1, cambiarlo a 0
                    ActualizarEstadoBorrado(idProyecto, idUsuario, false);
                }
                else
                {
                    // Si Borrado es 0, lanzar una excepción
                    throw new InvalidOperationException("El miembro ya existe en el proyecto.");
                }
            }
            else
            {
                // El miembro no existe, insertarlo en la tabla
                using (var connection = GETConexionSQL())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO ProyectoMiembros (IdProyecto, IdUsuario) VALUES (@IdProyecto, @IdUsuario)";
                        command.CommandType = CommandType.Text;

                        command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                        command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        private bool ObtenerEstadoBorrado(int idProyecto, int idUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Borrado FROM ProyectoMiembros WHERE IdProyecto = @IdProyecto AND IdUsuario = @IdUsuario";
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                    var resultado = command.ExecuteScalar();
                    return resultado != null && (bool)resultado;
                }
            }
        }

        private void ActualizarEstadoBorrado(int idProyecto, int idUsuario, bool nuevoEstado)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE ProyectoMiembros SET Borrado = @NuevoEstado WHERE IdProyecto = @IdProyecto AND IdUsuario = @IdUsuario";
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));
                    command.Parameters.Add(new SqlParameter("@NuevoEstado", nuevoEstado));

                    command.ExecuteNonQuery();
                }
            }
        }

        private bool ProyectoMiembroExiste(int idProyecto, int idUsuario)
        {
            // Lógica para verificar si el miembro ya existe en el proyecto
            // Puedes ajustar esto según cómo almacenes la relación entre proyectos y miembros
            // Podrías hacer una consulta a la base de datos, buscar en una lista, etc.
            // Aquí, asumiré que existe un método en ProyectoMiembro para verificar esto

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM ProyectoMiembros WHERE IdProyecto = @IdProyecto AND IdUsuario = @IdUsuario";
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter("@IdProyecto", idProyecto));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", idUsuario));

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }




        // Método para eliminar un miembro de un proyecto
        public void EliminarMiembro(int idProyectoMiembro)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE  ProyectoMiembros SET Borrado =1 WHERE IdProyectoMiembro = @IdProyectoMiembro";
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new SqlParameter("@IdProyectoMiembro", idProyectoMiembro));

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para cargar los miembros de un proyecto
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

        public DataTable CargarUsuarioProgramador()
        {
            DataTable table = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuario where RolUsuario = 3";
                    command.CommandType = CommandType.Text;

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
