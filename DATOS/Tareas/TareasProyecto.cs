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
        private int v1;
        private int v2;

        public TareasProyecto(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public TareasProyecto(int idProyecto, int estadoTareaid, int idProyectoMiembro, string nombreTarea, string descripcionTarea, DateTime fechaInicio, DateTime fechaFin)
        {
            IdProyecto = idProyecto;
            EstadoTareaid = estadoTareaid;
            IdProyectoMiembro = idProyectoMiembro;
            NombreTarea = nombreTarea;
            DescripcionTarea = descripcionTarea;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public TareasProyecto(int tareaId, int idProyecto, int estadoTareaid, int idProyectoMiembro, string nombreTarea, string descripcionTarea, DateTime fechaInicio, DateTime fechaFin)
        {
            TareaId = tareaId;
            IdProyecto = idProyecto;
            EstadoTareaid = estadoTareaid;
            IdProyectoMiembro = idProyectoMiembro;
            NombreTarea = nombreTarea;
            DescripcionTarea = descripcionTarea;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public int TareaId { get; set; }
        public int IdProyecto { get; set; }
        public int EstadoTareaid { get; set; }
        public int IdProyectoMiembro { get; set; }
        public string NombreTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
