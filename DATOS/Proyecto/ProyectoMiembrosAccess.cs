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
    public class ProyectoMiembrosAccess: ConexionSQL
    {

        // Método para insertar un nuevo miembro en un proyecto
        public void InsertarMiembro(int idProyecto, int idUsuario)
        {
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

        // Método para eliminar un miembro de un proyecto
        public void EliminarMiembro(int idProyectoMiembro)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM ProyectoMiembros WHERE IdProyectoMiembro = @IdProyectoMiembro";
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
                    command.CommandText = "SELECT * FROM ProyectoMiembros WHERE IdProyecto = @IdProyecto";
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
