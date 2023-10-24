using Comun.Cache;
using DATOS.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION.Proyecto
{
    public partial class Frm_NuevoProyecto : Form
    {
        public Frm_NuevoProyecto()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Validar los campos antes de agregar el proyecto
            if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se agrega el proyecto si falta el nombre
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProyecto.Text))
            {
                MessageBox.Show("Debe ingresar una descripción de proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se agrega el proyecto si falta la descripción
            }

            if (dateTimePickerInicio.Value > dateTimePickerEntrega.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se agrega el proyecto si la fecha de inicio es posterior a la fecha de fin
            }

            if (cmbEstadoProyecto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado para el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No se agrega el proyecto si no se selecciona un estado
            }

            // Si todas las validaciones pasan, puedes agregar el proyecto
            AgregarNuevoProyecto();
        }

        private void AgregarNuevoProyecto()
        {

            ProyectoAcceso proyecto = new ProyectoAcceso();
            proyecto.InsertarProyecto(
                this.txtNombreProyecto.Text
                ,this.txtDescripcionProyecto.Text,
                dateTimePickerInicio.Value,
                dateTimePickerEntrega.Value,
                Convert.ToInt32(this.cmbEstadoProyecto.SelectedValue), 
                UserLoginCache.IdUsuario);


            MessageBox.Show("Proyecto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombreProyecto.Text = "";
            txtDescripcionProyecto.Text = "";
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerEntrega.Value = DateTime.Now;
            cmbEstadoProyecto.SelectedIndex = -1;
        }
    }
}
