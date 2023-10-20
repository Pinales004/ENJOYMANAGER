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
        public ProyectoMiembro(int idProyectoMiembro, int idProyecto, int idUsuario)
        {
            IdProyectoMiembro = idProyectoMiembro;
            IdProyecto = idProyecto;
            IdUsuario = idUsuario;
        }

        // Propiedades de la clase ProyectoMiembro
        public int IdProyectoMiembro { get; set; }
        public int IdProyecto { get; set; }
        public int IdUsuario { get; set; }

        public void InsertarMiembros() {

            ProyectoMiembrosAccess miembros = new ProyectoMiembrosAccess();

            miembros.InsertarMiembro(this.IdProyecto,this.IdUsuario);

        }


    }
}
