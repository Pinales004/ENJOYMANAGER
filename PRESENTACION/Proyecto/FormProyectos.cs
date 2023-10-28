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
        Frm_NuevoProyecto form = new Frm_NuevoProyecto();
        public string? idproyect;

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

        public void CargarEstadoProyecto()
        {
            
            Proyectos cargar = new Proyectos();

            form.cmbEstadoProyecto.DataSource = cargar.GetProyectosEstado();
            form.cmbEstadoProyecto.DisplayMember = "Estado";
            form.cmbEstadoProyecto.ValueMember = "EstadoProyectoid";

        }


        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                form.Show();
                CargarEstadoProyecto();

                // Accede al DataTable subyacente
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Obtén la fila seleccionada
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];

                // Accede al valor del ID del proyecto
                int idProyecto = (int)selectedRow["IdProyecto"];

                // Muestra el ID del proyecto (puedes hacer lo que desees con él)
                MessageBox.Show($"ID del proyecto seleccionado: {idProyecto}");

                form.IdProyecto.Text = idProyecto.ToString();
                form.txtNombreProyecto.Text = selectedRow["NombreProyecto"].ToString();
                form.txtDescripcionProyecto.Text = selectedRow["Descripcion"].ToString();
                form.dateTimePickerInicio.Text = selectedRow["FechaInicio"].ToString();
                form.dateTimePickerEntrega.Text = selectedRow["FechaFin"].ToString();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }



        }
    }

}

