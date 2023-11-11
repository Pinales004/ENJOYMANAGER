using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DATOS.Conexion;
using DATOS.Tareas;
namespace DOMINIO.Models
{
    public  class AnexoTarea : ConexionSQL
    {
        public int iD { get; set; }
        public void InsertAnexo(Anexos anexo)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Anexo (Nombre, Documento, Extension, TareaId) " +
                                        "VALUES (@Nombre, @Documento, @Extension, @TareaId)";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@Nombre", anexo.Nombre));
                    command.Parameters.Add(new SqlParameter("@Documento", anexo.Documento));
                    command.Parameters.Add(new SqlParameter("@Extension", anexo.Extension));
                    command.Parameters.Add(new SqlParameter("@TareaId", anexo.TareaId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }


        public void UpdateAnexo(Anexos anexo)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Anexo " +
                                        "SET Nombre = @Nombre, Documento = @Documento, Extension = @Extension, TareaId = @TareaId, Borrado = @Borrado " +
                                        "WHERE AnexoId = @AnexoId";
                    command.CommandType = CommandType.Text;

                    // Agrega los parámetros y sus valores
                    command.Parameters.Add(new SqlParameter("@AnexoId", anexo.AnexoId));
                    command.Parameters.Add(new SqlParameter("@Nombre", anexo.Nombre));
                    command.Parameters.Add(new SqlParameter("@Documento", anexo.Documento));
                    command.Parameters.Add(new SqlParameter("@Extension", anexo.Extension));
                    command.Parameters.Add(new SqlParameter("@TareaId", anexo.TareaId));
                    command.Parameters.Add(new SqlParameter("@Borrado", anexo.Borrado));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }
        public void SoftDeleteAnexo(int anexoId)
        {
            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Anexo SET Borrado = 1 WHERE AnexoId = @AnexoId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro y su valor
                    command.Parameters.Add(new SqlParameter("@AnexoId", anexoId));

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAnexosPorTarea(int tareaId)
        {
            DataTable anexosDataTable = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Anexo WHERE TareaId = @TareaId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro y su valor
                    command.Parameters.Add(new SqlParameter("@TareaId", tareaId));

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(anexosDataTable);
                    }
                }
            }

            return anexosDataTable;
        }

        public DataTable GetAnexosPorIdAnexo(Anexos anexos)
        {
            DataTable anexosDataTable = new DataTable();

            using (var connection = GETConexionSQL())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT AnexoId, Nombre, Documento, Extension FROM Anexo WHERE AnexoId = @AnexoId";
                    command.CommandType = CommandType.Text;

                    // Agrega el parámetro y su valor
                    command.Parameters.AddWithValue("@AnexoId", anexos.AnexoId);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(anexosDataTable);
                    }
                }
            }

            return anexosDataTable;
        }

        public List<Anexos> FiltroDocumentos(Anexos IdANEXO)
        {
            var tabla = GetAnexosPorIdAnexo(IdANEXO);
            var InfoDocumento = new List<Anexos>();
            foreach (DataRow item in tabla.Rows)
            {
                InfoDocumento.Add(new Anexos
                {
                    AnexoId = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Documento = (byte[])item[2],
                    Extension = item[3].ToString()


                });
            }
            return InfoDocumento;


        }









































    }
}
