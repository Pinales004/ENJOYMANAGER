namespace Comun.Cache
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static String UsuarioNombre { get; set; }
        public static String Nombres { get; set; }
        public static String Apellidos { get; set; }
        public static bool Sexo { get; set; }
        public static String EmailUsuario { get; set; }
        public static String ContrasenaUsuario { get; set; }
        public static bool ResetPasword { get; set; }
        public static int RolUsuario { get; set; }
        public static int EstadoUsuario { get; set; }
        public static int IntentosFallidos { get; set; }
        public static bool Borrado { get; set; }


    }
}
