namespace DATOS.Tareas
{
    public class ComentariosTarea
    {
        public int ComentarioTareaId { get; set; }
        public string Comentario { get; set; }
        public int TareaId { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Borrado { get; set; }

        //virtual
        public string UsuarioCrea { get; set; }

        public ComentariosTarea()
        {
            // Constructor vacío
        }

        public ComentariosTarea(int comentarioTareaId, string comentario)
        {
            ComentarioTareaId = comentarioTareaId;
            Comentario = comentario;
        }

        public ComentariosTarea(string comentario, int tareaId, int idUsuario, DateTime fechaCreacion)
        {
            Comentario = comentario;
            TareaId = tareaId;
            IdUsuario = idUsuario;
            FechaCreacion = fechaCreacion;
        }

        public ComentariosTarea(string comentario, int tareaId, int idUsuario, DateTime fechaCreacion, string usuarioCrea)
        {
            Comentario = comentario;
            TareaId = tareaId;
            IdUsuario = idUsuario;
            FechaCreacion = fechaCreacion;
            UsuarioCrea = usuarioCrea;
        }

    }
}
