using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.Conexion;
using DATOS.Proyecto;

namespace DOMINIO.Models
{

    //clase modelo
    public class Proyectos
    {
        ProyectoAcceso project = new ProyectoAcceso();

        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int EstadoProyectoid { get; set; }
        public int IdUsuario { get; set; }
        public bool Borrado { get; set; }


        public Proyectos() { }
        public Proyectos(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int estadoProyectoid, int idUsuario, bool borrado)
        {
            IdProyecto = idProyecto;
            NombreProyecto = nombreProyecto;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoProyectoid = estadoProyectoid;
            IdUsuario = idUsuario;
            Borrado = borrado;
        }


        public void AgregarProyecto(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int estadoProyectoid, int idUsuario)
        {

            ProyectoAcceso proyecto = new ProyectoAcceso();
            proyecto.InsertarProyecto(this.NombreProyecto, this.Descripcion, this.FechaInicio, this.FechaFin, this.EstadoProyectoid, this.IdUsuario);


        }
        public System.Data.DataTable GetProyectos()
        {
            return project.CargarProyectos();
        }
    }
    

    public class ProyectoEstado
    {

        public int EstadoProyectoid { get; set; }
        public string Estado { get; set; }

        public ProyectoEstado(int estadoProyectoid, string estado)
        {
            EstadoProyectoid = estadoProyectoid;
            Estado = estado;
        }
    }

}
