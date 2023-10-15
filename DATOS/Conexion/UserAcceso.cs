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
    public class UserAcceso: ConexionSQL
    {
        public bool Login(string user , string pass)
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



    }
}
