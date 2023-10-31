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


        private void EditarFormulario<MiForm>(MiForm form) where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = form; // Utiliza la instancia del formulario que pasaste como argumento
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }


        public void CargarEstadoProyecto(Frm_NuevoProyecto form)
        {
            Proyectos cargar = new Proyectos();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoProyecto.DataSource = cargar.GetProyectosEstado();
            form.cmbEstadoProyecto.DisplayMember = "Estado";
            form.cmbEstadoProyecto.ValueMember = "EstadoProyectoid";
        }



        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var form = new Frm_NuevoProyecto(); // Crear una instancia del formulario FrmNuevoProyecto

                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];

                int idProyecto = (int)selectedRow["IdProyecto"];
                MessageBox.Show($"ID del proyecto seleccionado: {idProyecto}");

                // Configura los campos en el formulario
                form.IdProyecto.Text = idProyecto.ToString();
                form.txtNombreProyecto.Text = selectedRow["NombreProyecto"].ToString();
                form.txtDescripcionProyecto.Text = selectedRow["Descripcion"].ToString();
                form.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["FechaInicio"].ToString());
                form.dateTimePickerEntrega.Value = DateTime.Parse(selectedRow["FechaFin"].ToString());

                // Llamar al método CargarEstadoProyecto pasando el formulario como argumento
                CargarEstadoProyecto(form);

                // Llamar al método AbrirFormulario con el formulario FrmNuevoProyecto
                EditarFormulario<Frm_NuevoProyecto>(form);

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }

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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_NuevoProyecto>();
        }
    }
}

