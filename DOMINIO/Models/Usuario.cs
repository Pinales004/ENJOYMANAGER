﻿using DATOS.Conexion;
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
        public System.Data.DataTable GetEstados()
        {
            return users.CargarEstado();
        }
        public void InsertarUsuarios(string UsuarioNombre, string nombres, string apellido, bool sexo, string EmailUsuario, string ContrasenaUsuario, int RolUsuario, int EstadoUsuario)
        {
            users.InsertUsuario(UsuarioNombre, nombres, apellido, sexo, EmailUsuario, ContrasenaUsuario, RolUsuario, EstadoUsuario);
        }

        public System.Data.DataTable GetUsuarios()
        {
            return users.CargarUsuarios();
        }
        public void ActualizarUsuarios(int IdUsuario, string UsuarioNombre, string nombres, string apellido, bool sexo, string EmailUsuario, string NuevaContrasenaUsuario, int RolUsuario, int EstadoUsuario)
        {
            // Calcular el hash SHA-256 de la nueva contraseña antes de almacenarla
            string nuevaContraseñaHash = NuevaContrasenaUsuario;

            users.EditarUsuario(IdUsuario, UsuarioNombre, nombres, apellido, sexo, EmailUsuario, nuevaContraseñaHash, RolUsuario, EstadoUsuario);
        }
        public void ActualizarContraseña(int IdUsuario, string NuevaContrasenaUsuario, int EstadoUsuario)
        {
            // Calcular el hash SHA-256 de la nueva contraseña antes de almacenarla
            string nuevaContraseñaHash = NuevaContrasenaUsuario;

            users.ContraseñaUpdate(IdUsuario, nuevaContraseñaHash, EstadoUsuario);
        }
        public void EliminarUusario(int IdUsuario) {

            users.EliminarUsuario(IdUsuario);
        }

        public System.Data.DataTable BuscarUsuariosPorNombre(String NombreUsuario)
        {

            return users.BuscarUsuariosPorNombre(NombreUsuario);
        }
    }
}
