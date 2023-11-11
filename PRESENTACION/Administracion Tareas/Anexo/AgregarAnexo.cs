using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS.Tareas;
using DOMINIO.Models;

namespace PRESENTACION.Administracion_Tareas.Anexo
{
    public partial class AgregarAnexo : Form
    {

        AnexoTarea anexo = new AnexoTarea();
        private string IdTarea;
        public AgregarAnexo(string idTarea)
        {
            InitializeComponent();
            IdTarea = idTarea;
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtRuta.Text =openFileDialog1.FileName;

            }

        }

        private void BntAnexoGuardar_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo = obj.ToArray();
            if (TxtNombreArchivo.Text=="")
            {
                MostrarError("Dbe indicar un nombre para el documento");

            }      
            //Agregar
            Anexos agregar = new Anexos(
                TxtNombreArchivo.Text,
                archivo,
                openFileDialog1.SafeFileName,
                Convert.ToInt32(IdTarea)              
                
                );
            anexo.InsertAnexo(agregar);
            MessageBox.Show("Documento guardado");
            this.Hide();

        }


        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
