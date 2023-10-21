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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRESENTACION
{
    public partial class FormProyectos : Form
    {
        private Proyecto proyecto;

        public FormProyectos()
        {
            InitializeComponent();
            proyecto = new Proyecto();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
            ListarEstadosProyecto();
            LimpiarDatos();
        }

        private void CargarProyectos()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = proyecto.GetProyectos(mostrarBorrados: true);
        }

        private void ListarEstadosProyecto()
        {
            // Puedes llenar un ComboBox con los estados de proyecto aquí
        }

        private void LimpiarDatos()
        {
            txtNombreProyecto.Text = string.Empty;
            txtDescripcionProyecto.Text = string.Empty;
            cmbEstadoProyecto.SelectedIndex = -1;
            dateTimePickerInicio.Value = DateTimePicker.MinimumDateTime;
            dateTimePickerEntrega.Value = DateTimePicker.MinimumDateTime;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text))
            {
                MessageBox.Show("Debe indicar un nombre de proyecto.");
            }
            else if (string.IsNullOrWhiteSpace(txtDescripcionProyecto.Text))
            {
                MessageBox.Show("Debe indicar una descripción.");
            }
            else if (cmbEstadoProyecto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado de proyecto.");
            }
            else
            {
                // Obtén el idUsuario desde UserLoginCache
                int idUsuario = UserLoginCache.IdUsuario;

                proyecto.InsertarProyecto(
                    txtNombreProyecto.Text,
                    txtDescripcionProyecto.Text,
                    dateTimePickerInicio.Value,
                    dateTimePickerEntrega.Value,
                    Convert.ToInt32(cmbEstadoProyecto.SelectedValue),
                idUsuario, // Asegúrate de tener el ID del usuario adecuado
                    false // Puedes establecer el valor de borrado según tus necesidades
                );
                CargarProyectos();
                LimpiarDatos();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Código para editar un proyecto seleccionado
                // Similar al método btn_agregar_Click
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                proyecto.EliminarProyecto(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdProyecto"].Value.ToString()));
                CargarProyectos();
                MessageBox.Show("Proyecto eliminado correctamente.");
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar un proyecto.");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CenterGroupBoxHorizontally();
        }
        private void CenterGroupBoxHorizontally()
        {
            //Para mantener el contenido centrado dentro del panel superior del formulario Usuarios
            int panelWidth = panel1.Width;
            int groupBoxWidth = groupBox1.Width;

            int centerX = (panelWidth - groupBoxWidth) / 2;
            if (centerX < 0)
            {
                centerX = 0;
            }
            groupBox1.Location = new Point(centerX, groupBox1.Location.Y);
        }
    }
}
