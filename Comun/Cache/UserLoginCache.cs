using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static String UsuarioNombre { get; set; }
        public static String Nombres { get; set; }
        public static String Apellido { get; set; }
        public static bool Sexo { get; set; }
        public static String EmailUsuario { get; set; }
        public static String ContrasenaUsuario { get; set; }
        public static int RolUsuario { get; set; }
        public static bool Activo { get; set; }


    }
}
