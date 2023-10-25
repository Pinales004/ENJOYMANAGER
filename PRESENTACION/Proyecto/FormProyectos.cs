using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using DATOS.Conexion;
using DOMINIO.Models;
using PRESENTACION.Proyecto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRESENTACION
{
    public partial class FormProyectos : Form
    {

        public FormProyectos()
        {
            InitializeComponent();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();

        }

        private void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetProyectos();
        }

        //private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    // Itera a través de todas las columnas y establece AutoSizeMode en AllCells
        //    foreach (DataGridViewColumn column in dataGridView1.Columns)
        //    {
        //        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    }
        //}

        private void BntNewProyect_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_NuevoProyecto>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }
    }

}

