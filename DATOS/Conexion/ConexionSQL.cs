using System.Data.SqlClient;

namespace DATOS.Conexion
{
    public abstract class ConexionSQL
    {

        private readonly string
            connectionsstring;

        public ConexionSQL()
        {
            connectionsstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ENJOYMANNAGER;Integrated Security=True;";
           // connectionsstring = @"Data Source=tcp:DESKTOP-JEREMY;Initial Catalog=ENJOYMANNAGER; User Id=AppAccess ; Password=admin123";

        }



        protected SqlConnection GETConexionSQL()
        {
            return new SqlConnection(connectionsstring);
        }
    }
}
