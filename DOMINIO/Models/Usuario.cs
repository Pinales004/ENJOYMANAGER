using DATOS.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOMINIO.Models
{
    public class Usuario
    {
        UserAcceso users = new UserAcceso();
        public bool LoginUser(String User , string pass)
        {
            return users.Login(User , pass);
        }

    }
}
