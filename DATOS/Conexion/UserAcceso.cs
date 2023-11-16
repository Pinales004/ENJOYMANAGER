using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;


namespace DATOS.Conexion
{
    public class UserAcceso : ConexionSQL
    {

        public bool Login(string user, string pass)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where UsuarioNombre = @user and ContrasenaUsuario = @pass and Borrado = 0";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUsuario = reader.GetInt32(0);
                            UserLoginCache.UsuarioNombre = reader.GetString(1);
                            UserLoginCache.Nombres = reader.GetString(2);
                            UserLoginCache.Apellidos = reader.GetString(3);
                            UserLoginCache.Sexo = reader.GetBoolean(4);
                            UserLoginCache.EmailUsuario = reader.GetString(7);
                            UserLoginCache.ContrasenaUsuario = reader.GetString(8);
                            UserLoginCache.ResetPasword = reader.GetBoolean(9);
                            UserLoginCache.RolUsuario = reader.GetInt32(10);
                            UserLoginCache.EstadoUsuario = reader.GetInt32(11);
                            UserLoginCache.IntentosFallidos = reader.GetInt32(12);
                            UserLoginCache.Borrado = reader.GetBoolean(13);
                        }

                        int intento = GetFailedLoginAttempts(user);
                        if (intento < 3)
                        {

                            // Restablece los intentos fallidos a cero ya que el inicio de sesión fue exitoso.
                            ResetFailedLoginAttempts(user);
                            return true;

                        }
                        else
                        {

                            return false;

                        }

                    }
                    else
                    {
                        // Incrementa el contador de intentos fallidos y verifica si se ha excedido el límite.
                        int failedAttempts = IncrementFailedLoginAttempts(user);

                        if (failedAttempts >= 3)
                        {
                            // Si se han excedido los 3 intentos fallidos, desactiva la cuenta.
                            DeactivateAccount(user);
                        }
                        return false;
                    }
                }
            }
        }

        public int IncrementFailedLoginAttempts(string user)
        {
            // Incrementa el contador de intentos fallidos en la base de datos.
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuario SET IntentosFallidos = IntentosFallidos + 1 WHERE UsuarioNombre = @user";
                    command.Parameters.AddWithValue("@user", user);
                    command.ExecuteNonQuery();
                }
            }

            // Obtiene el nuevo valor del contador de intentos fallidos.
            int failedAttempts = GetFailedLoginAttempts(user);
            return failedAttempts;
        }

        private void ResetFailedLoginAttempts(string user)
        {
            // Restablece el contador de intentos fallidos a cero en la base de datos.
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuario SET IntentosFallidos = 0 WHERE UsuarioNombre = @user";
                    command.Parameters.AddWithValue("@user", user);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeactivateAccount(string user)
        {
            // Desactiva la cuenta estableciendo el valor de "Activo" en 0 en la base de datos.
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuario SET UsuarioEstado = 4 WHERE UsuarioNombre = @user";
                    command.Parameters.AddWithValue("@user", user);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetFailedLoginAttempts(string user)
        {
            // Obtiene el valor actual del contador de intentos fallidos desde la base de datos.
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IntentosFallidos FROM Usuario WHERE UsuarioNombre = @user";
                    command.Parameters.AddWithValue("@user", user);
                    var result = command.ExecuteScalar();
                    return result is int ? (int)result : 0;
                }
            }
        }



        public bool GetAccountStatus(string user)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT EstadoUsuario FROM Usuario WHERE UsuarioNombre = @user";
                    command.Parameters.AddWithValue("@user", user);
                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        return (Convert.ToInt32(result) == 1); // Comprueba si el valor es igual a 1
                    }
                }
            }

            return false; // Valor predeterminado si no se encuentra un resultado válido.
        }
        // En esta versión modificada de la función, se utiliza un valor booleano true o false para indicar si la cuenta está activa o no.La función devuelve true si el valor de Activo es igual a 1 y false en cualquier otro caso.Si no se encuentra un resultado válido, la función devuelve false como valor predeterminado.Asegúrate de que esta lógica coincida con la forma en que tu base de datos representa el estado activo de las cuentas.
        public DataTable CargarRoles()
        {
            DataTable table = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM UsuarioRol";
                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            return table;
        }

        public DataTable CargarEstado()
        {
            DataTable table = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM UsuarioEstado";
                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            return table;
        }
        public void InsertUsuario(string UsuarioNombre, string nombres, string apellidos, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, int EstadoUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Usuario (UsuarioNombre, Nombres, Apellidos, Sexo, EmailUsuario, ContrasenaUsuario, RolUsuario,EstadoUsuario) " +
                                        "VALUES (@UsuarioNombre, @Nombres, @Apellidos, @Sexo, @EmailUsuario, @ContrasenaUsuario, @RolUsuario, @EstadoUsuario)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@UsuarioNombre", UsuarioNombre));
                    command.Parameters.Add(new SqlParameter("@Nombres", nombres));
                    command.Parameters.Add(new SqlParameter("@Apellidos", apellidos));
                    command.Parameters.Add(new SqlParameter("@Sexo", sexo));
                    command.Parameters.Add(new SqlParameter("@EmailUsuario", EmailUsuario));
                    command.Parameters.Add(new SqlParameter("@ContrasenaUsuario", ContrasenaUsuario));
                    command.Parameters.Add(new SqlParameter("@RolUsuario", RolUsuario));
                    command.Parameters.Add(new SqlParameter("@EstadoUsuario", EstadoUsuario));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable CargarUsuarios()
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
                        command.CommandText = "SELECT * FROM Usuarios_vw_ENJOY";
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
                Console.WriteLine("Error al cargar usuarios: " + ex.Message);
            }
            return table;
        }
        public void EditarUsuario(int IdUsuario, string UsuarioNombre, string nombres, string apellidos, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, int EstadoUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuario " +
                                        "SET UsuarioNombre = @UsuarioNombre, " +
                                        "Nombres = @Nombres, " +
                                        "Apellidos = @Apellidos, " +
                                        "Sexo = @Sexo, " +
                                        "EmailUsuario = @EmailUsuario, " +
                                        "ContrasenaUsuario = @ContrasenaUsuario, " +
                                        "RolUsuario = @RolUsuario, " +
                                        "EstadoUsuario = @EstadoUsuario " +
                                        "WHERE IdUsuario = @IdUsuario"; // Identifica el registro por IdUsuario
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdUsuario", IdUsuario));
                    command.Parameters.Add(new SqlParameter("@UsuarioNombre", UsuarioNombre));
                    command.Parameters.Add(new SqlParameter("@Nombres", nombres));
                    command.Parameters.Add(new SqlParameter("@Apellidos", apellidos));
                    command.Parameters.Add(new SqlParameter("@Sexo", sexo));
                    command.Parameters.Add(new SqlParameter("@EmailUsuario", EmailUsuario));
                    command.Parameters.Add(new SqlParameter("@ContrasenaUsuario", ContrasenaUsuario));
                    command.Parameters.Add(new SqlParameter("@RolUsuario", RolUsuario));
                    command.Parameters.Add(new SqlParameter("@EstadoUsuario", EstadoUsuario));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarUsuario(int IdUsuario)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuario SET Borrado = 1 WHERE IdUsuario = @IdUsuario";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro para el IdUsuario
                    command.Parameters.Add(new SqlParameter("@IdUsuario", IdUsuario));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarUsuariosPorNombre(string nombre)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Usuarios_vw_ENJOY WHERE Nombres LIKE @Nombre";
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
