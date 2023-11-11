using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Tareas
{
    public class ComentariosTarea
    {
        public int ComentarioTareaId { get; set; }
        public string Comentario { get; set; }
        public int TareaId { get; set; }
        public bool Borrado { get; set; }

        public ComentariosTarea()
        {
            // Constructor vacío
        }

        public ComentariosTarea(int comentarioTareaId, string comentario, int tareaId)
        {
            ComentarioTareaId = comentarioTareaId;
            Comentario = comentario;
            TareaId = tareaId;
        }
    }
}
