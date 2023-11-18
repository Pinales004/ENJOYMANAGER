using DATOS.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.Models
{
    public class ProyectoMiembro
    {

        // Propiedades de la clase ProyectoMiembro
        public int IdProyectoMiembro { get; set; }
        public int IdProyecto { get; set; }
        public int IdUsuario { get; set; }

        ProyectoMiembrosAccess miembros = new ProyectoMiembrosAccess();

        public ProyectoMiembro()
        {
        }
        public ProyectoMiembro(int idProyecto, int idUsuario)
        {
            IdProyecto = idProyecto;
            IdUsuario = idUsuario;
        }
        public System.Data.DataTable GetUsuarioMiembrosProgramador()
        {
            return miembros.CargarUsuarioProgramador();
        }

        public System.Data.DataTable GetProyectoMiembro(int ProyectoID)
        {
            return miembros.CargarMiembros(ProyectoID);
        }

        public void InsertarMiembros(int proyectoid , int UsuarioID) {

            miembros.InsertarMiembro(proyectoid, UsuarioID);

        }
        public void BorrarMiembroProyecto(int Miembro)
        {
            miembros.EliminarMiembro(Miembro);

        }


    }
}
