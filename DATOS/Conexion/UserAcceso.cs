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
            using (var connection = GETConexionSQL()) {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where UsuarioNombre =@user and ContrasenaUsuario=@pass";
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
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Sexo = reader.GetBoolean(4);
                            UserLoginCache.EmailUsuario = reader.GetString(5);
                            UserLoginCache.ContrasenaUsuario = reader.GetString(6);
                            UserLoginCache.RolUsuario = reader.GetInt32(7);
                            UserLoginCache.Activo = reader.GetBoolean(8);

                        }


                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }

        }

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

        public void InsertUsuario(string UsuarioNombre, string nombres, string apellido, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, bool Activo)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Usuario (UsuarioNombre, Nombres, Apellido, Sexo, EmailUsuario, ContrasenaUsuario, RolUsuario, Activo) " +
                                        "VALUES (@UsuarioNombre, @Nombres, @Apellido, @Sexo, @EmailUsuario, @ContrasenaUsuario, @RolUsuario, @Activo)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@UsuarioNombre", UsuarioNombre));
                    command.Parameters.Add(new SqlParameter("@Nombres", nombres));
                    command.Parameters.Add(new SqlParameter("@Apellido", apellido));
                    command.Parameters.Add(new SqlParameter("@Sexo", sexo));
                    command.Parameters.Add(new SqlParameter("@EmailUsuario", EmailUsuario));
                    command.Parameters.Add(new SqlParameter("@ContrasenaUsuario", ContrasenaUsuario));
                    command.Parameters.Add(new SqlParameter("@RolUsuario", RolUsuario));
                    command.Parameters.Add(new SqlParameter("@Activo", Activo));

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
                        command.CommandText = "SELECT IdUsuario, usu.UsuarioNombre, usu.Nombres, usu.Apellido, usu.EmailUsuario, " +
                            "CASE WHEN Sexo = 1 THEN 'Hombre' ELSE 'Mujer' END AS Genero, rol.Rol, usu.ContrasenaUsuario, " +
                            "CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Bloqueado' END AS Estado " +
                            "FROM Usuario usu " +
                            "INNER JOIN UsuarioRol rol ON usu.RolUsuario = rol.IdUsuarioRol";
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


        public void EditarUsuario(int IdUsuario, string UsuarioNombre, string nombres, string apellido, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, bool Activo)
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
                                        "Apellido = @Apellido, " +
                                        "Sexo = @Sexo, " +
                                        "EmailUsuario = @EmailUsuario, " +
                                        "ContrasenaUsuario = @ContrasenaUsuario, " +
                                        "RolUsuario = @RolUsuario, " +
                                        "Activo = @Activo " +
                                        "WHERE IdUsuario = @IdUsuario"; // Identifica el registro por IdUsuario
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@IdUsuario", IdUsuario));
                    command.Parameters.Add(new SqlParameter("@UsuarioNombre", UsuarioNombre));
                    command.Parameters.Add(new SqlParameter("@Nombres", nombres));
                    command.Parameters.Add(new SqlParameter("@Apellido", apellido));
                    command.Parameters.Add(new SqlParameter("@Sexo", sexo));
                    command.Parameters.Add(new SqlParameter("@EmailUsuario", EmailUsuario));
                    command.Parameters.Add(new SqlParameter("@ContrasenaUsuario", ContrasenaUsuario));
                    command.Parameters.Add(new SqlParameter("@RolUsuario", RolUsuario));
                    command.Parameters.Add(new SqlParameter("@Activo", Activo));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }






    }
            }
