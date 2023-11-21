using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Tareas
{
    public class Anexos
    {

        public int AnexoId { get; set; }
        public string Nombre { get; set; }
        public byte[] Documento { get; set; }
        public string Extension { get; set; }
        public int TareaId { get; set; }
        public int UsuarioId { get; set; }
        public bool Borrado { get; set; }

        public Anexos()
        {
            // Constructor vacío
        }

        public Anexos(int anexoId, string nombre, byte[] documento, string extension, int tareaId, bool borrado)
        {
            AnexoId = anexoId;
            Nombre = nombre;
            Documento = documento;
            Extension = extension;
            TareaId = tareaId;
            Borrado = borrado;
        }

        public Anexos(string nombre, byte[] documento, string extension, int tareaId, int usuarioId)
        {
            Nombre = nombre;
            Documento = documento;
            Extension = extension;
            TareaId = tareaId;
            UsuarioId = usuarioId;
        }

        public Anexos(int anexoId)
        {
            AnexoId = anexoId;
        }
    }
}
