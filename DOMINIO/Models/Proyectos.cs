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


        public void AgregarProyecto(
             string nombreProyecto,
             string descripcion,
             DateTime FechaCreacion,
             DateTime? fechaFin,
             DateTime? fechaInicioProgramada,
             DateTime? fechaFinProgramada,
             int estadoProyectoid,
             int idUsuario)
        {
            // Lógica para convertir DateTime? a DBNull.Value si es nulo
            object fechaInicioProgramadaParam = (object)fechaInicioProgramada ?? DBNull.Value;
            object fechaFinProgramadaParam = (object)fechaFinProgramada ?? DBNull.Value;

            project.InsertarProyecto(
                nombreProyecto,
                descripcion,
                FechaCreacion,
                fechaFin,
                fechaInicioProgramadaParam,
                fechaFinProgramadaParam,
                estadoProyectoid,
                idUsuario
            );
        }


        public void UpdateProyecto(
            int idProyecto,
            string nombreProyecto,
            string descripcion,
             DateTime? fechaFin,
             DateTime? fechaInicioProgramada,
             DateTime? fechaFinProgramada,
             int estadoProyectoid,
             int idUsuario)
        {
            // Lógica para convertir DateTime? a DBNull.Value si es nulo
            object fechaFinParam = (object)fechaFin ?? DBNull.Value;
            object fechaInicioProgramadaParam = (object)fechaInicioProgramada ?? DBNull.Value;
            object fechaFinProgramadaParam = (object)fechaFinProgramada ?? DBNull.Value;

            try
            {
                // Llamada al método en la capa de dominio
                project.UpdateProyecto(
                    idProyecto,
                    nombreProyecto,
                    descripcion,
                    fechaFinParam, // Convierte a DateTime, ya que el método EditarProyecto espera un DateTime
                    fechaInicioProgramadaParam, // Convierte a DateTime, ya que el método EditarProyecto espera un DateTime
                    fechaFinProgramadaParam, // Convierte a DateTime, ya que el método EditarProyecto espera un DateTime
                    estadoProyectoid,
                    idUsuario
                );
            }
            catch (Exception ex)
            {
                // En caso de otros errores, puedes manejar la excepción aquí, mostrar un mensaje de error o registrar el error.
                throw new InvalidOperationException("Error inesperado al actualizar el proyecto: " + ex.Message);
            }
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
