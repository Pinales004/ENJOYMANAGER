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


        public void AgregarProyecto(string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, DateTime fechaInicioProgramada, DateTime fechaFinProgramada, int estadoProyectoid, int idUsuario)
        {

            project.InsertarProyecto(nombreProyecto, descripcion, fechaInicio, fechaFin, fechaInicioProgramada, fechaFinProgramada, estadoProyectoid, idUsuario);


        }

        public void UpdateProyecto(int IdProyecto,string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, DateTime fechaInicioProgramada, DateTime fechaFinProgramada, int estadoProyectoid, int idUsuario)
        {

            project.EditarProyecto(IdProyecto, nombreProyecto, descripcion, fechaInicio, fechaFin, fechaInicioProgramada, fechaFinProgramada, estadoProyectoid, idUsuario);


        }

        public void EliminarProyecto(int IdProyecto)
        {

            project.EliminarProyecto(IdProyecto);


        }


        public System.Data.DataTable GetProyectos()
        {
            return project.CargarProyectos();
        }

        public System.Data.DataTable GetProyectosEstado()
        {
            return project.ProyectoEstado();
        }

        public System.Data.DataTable BuscarPorNombreProyecto(String NombreUsuario)
        {
            return project.BuscarProyectoPorNombre(NombreUsuario);
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
