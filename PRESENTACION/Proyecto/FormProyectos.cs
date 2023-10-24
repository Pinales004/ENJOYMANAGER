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
   
        }

        private void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetProyectos();
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

        private void BntNewProyect_Click(object sender, EventArgs e)
        {
            Proyecto.Frm_NuevoProyecto frm_ = new Proyecto.Frm_NuevoProyecto();
            frm_.Show();
        }


    }
    }

