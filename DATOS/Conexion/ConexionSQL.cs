using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS.Conexion
{
    public abstract class ConexionSQL
    {

        private readonly string 
            connectionsstring;

        public ConexionSQL() {
            connectionsstring = @"Data Source=DESKTOP-MTL1D8I;Initial Catalog=ENJOYMANNAGER;Integrated Security=True;";
        }


        protected SqlConnection GETConexionSQL()
        {
            return new SqlConnection(connectionsstring);

        }



    }


}
