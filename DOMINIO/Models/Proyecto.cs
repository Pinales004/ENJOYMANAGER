using System;
using System.Data;
using DATOS.Conexion; // Asegúrate de tener acceso a la clase ProjectAcceso

namespace DOMINIO.Models
{
    public class Proyecto
    {
        private ProjectAcceso projectAcceso; // Instancia de ProjectAcceso

        public Proyecto()
        {
            projectAcceso = new ProjectAcceso();
        }

        public void InsertarProyecto(string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idEstado, int idUsuario, bool borrado)
        {
            projectAcceso.InsertarProyecto(nombreProyecto, descripcion, fechaInicio, fechaFin, idEstado, idUsuario, borrado);
        }

        public DataTable GetProyectos(bool mostrarBorrados)
        {
            return projectAcceso.CargarProyectos(mostrarBorrados);
        }

        public void ActualizarProyecto(int idProyecto, string nombreProyecto, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idEstado, int idUsuario, bool borrado)
        {
            projectAcceso.EditarProyecto(idProyecto, nombreProyecto, descripcion, fechaInicio, fechaFin, idEstado, idUsuario, borrado);
        }

        public void EliminarProyecto(int idProyecto)
        {
            projectAcceso.EliminarProyecto(idProyecto);
        }
    }
}
