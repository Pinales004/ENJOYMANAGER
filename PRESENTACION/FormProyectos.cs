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

        public FormProyectos()
        {
            InitializeComponent();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
            LimpiarDatos();
        }

        private void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetProyectos();
        }

        private void LimpiarDatos()
        {
            txtNombreProyecto.Text = string.Empty;
            txtDescripcionProyecto.Text = string.Empty;
            cmbEstadoProyecto.SelectedIndex = -1;
            dateTimePickerInicio.Value = DateTimePicker.MinimumDateTime;
            dateTimePickerEntrega.Value = DateTimePicker.MinimumDateTime;
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
