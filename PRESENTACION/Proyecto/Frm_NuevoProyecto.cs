using Comun.Cache;
using DATOS.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO.Models;
using Comun.Cache;
namespace PRESENTACION.Proyecto
{
    public partial class Frm_NuevoProyecto : Form
    {
        String OperacionTipo = "Insertar";

        public Frm_NuevoProyecto()
        {
            InitializeComponent();
        }
        private void Frm_NuevoProyecto_Load(object sender, EventArgs e)
        {
            CargarEstadoProyecto();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_NuevoProyecto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void CargarEstadoProyecto()
        {

            Proyectos cargar = new Proyectos();

            this.cmbEstadoProyecto.DataSource = cargar.GetProyectosEstado();
            this.cmbEstadoProyecto.DisplayMember = "Estado";
            this.cmbEstadoProyecto.ValueMember = "EstadoProyectoid";

        }


        private void AgregarNuevoProyecto()
        {
            Proyectos cargar = new Proyectos();
            cargar.AgregarProyecto(this.txtNombreProyecto.Text,
                                    this.txtDescripcionProyecto.Text,
                                    this.dateTimePickerInicio.Value.Date,
                                    this.dateTimePickerEntrega.Value.Date,
                                    Convert.ToInt32(cmbEstadoProyecto.SelectedValue),
                                    UserLoginCache.IdUsuario);

            CargarProyectos();
            MessageBox.Show("Proyecto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

        }

        private void UpdateNuevoProyecto()
        {
            Proyectos cargar = new Proyectos();
            cargar.UpdateProyecto(Convert.ToInt32(this.IdProyecto.Text),
                                    this.txtNombreProyecto.Text,
                                    this.txtDescripcionProyecto.Text,
                                    this.dateTimePickerInicio.Value.Date,
                                    this.dateTimePickerEntrega.Value.Date,
                                    Convert.ToInt32(cmbEstadoProyecto.SelectedValue),
                                    UserLoginCache.IdUsuario);

            CargarProyectos();
            MessageBox.Show("Proyecto actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();

        }




        private void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            FormProyectos form = new FormProyectos();
            form.dataGridView1.AutoGenerateColumns = true;
            form.dataGridView1.DataSource = cargar.GetProyectos();
        }


        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombreProyecto.Text = "";
            labelDescripcionProyecto.Text = "";
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerEntrega.Value = DateTime.Now;
            cmbEstadoProyecto.SelectedIndex = -1;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEquipoProyecto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEquipoProgramadores>();
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

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {

            if (OperacionTipo == "Insertar")
            {
                // Validar los campos antes de agregar el proyecto
                if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text))
                {
                    MostrarError("Debe ingresar un nombre de proyecto.");
                }
                else if (string.IsNullOrWhiteSpace(txtDescripcionProyecto.Text))
                {
                    MostrarError("Debe ingresar una descripción de proyecto.");
                }
                else if (dateTimePickerInicio.Value > dateTimePickerEntrega.Value)
                {
                    MostrarError("La fecha de inicio no puede ser posterior a la fecha de fin.");
                }
                else if (cmbEstadoProyecto.SelectedIndex == -1)
                {
                    MostrarError("Debe seleccionar un estado para el proyecto.");
                }
                else
                {
                    // Si todas las validaciones pasan, puedes agregar el proyecto
                    AgregarNuevoProyecto();
                }
            }
            else if (OperacionTipo == "Editar")
            {
                // Lógica para editar un proyecto
                // (Puedes completar esta parte según tus necesidades)
            }




        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





    }
}
