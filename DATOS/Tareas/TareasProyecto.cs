using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Tareas
{
    public  class TareasProyecto
    {
        public int TareaId { get; set; }
        public int IdProyecto { get; set; }
        public int EstadoTareaid { get; set; }
        public int IdProyectoMiembro { get; set; }
        public string NombreTarea { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public TareasProyecto(int idProyecto, int estadoTareaid, int idProyectoMiembro, string nombreTarea, DateTime fechaInicio, DateTime fechaFin)
        {
            IdProyecto = idProyecto;
            EstadoTareaid = estadoTareaid;
            IdProyectoMiembro = idProyectoMiembro;
            NombreTarea = nombreTarea;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

    }
}
