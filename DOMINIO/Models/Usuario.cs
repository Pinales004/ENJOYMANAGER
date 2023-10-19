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

        public System.Data.DataTable GetRoles()
        {
            return users.CargarRoles();
        }



        public void InsertarUsuarios(string UsuarioNombre, string nombres, string apellido, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, bool Activo) {

            users.InsertUsuario(UsuarioNombre, nombres, apellido, sexo, EmailUsuario, ContrasenaUsuario, RolUsuario, Activo);
        
        }

        public System.Data.DataTable GetUsuarios()
        {
            return users.CargarUsuarios();
        }
    }
}
