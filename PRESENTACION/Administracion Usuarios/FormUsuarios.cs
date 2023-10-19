using DOMINIO.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class Frm_Usuarios : MaterialForm
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            Usuario cargar = new Usuario();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetUsuarios();


        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            Administracion_Usuarios.Frm_AgregarEdit formAgreagar = new Administracion_Usuarios.Frm_AgregarEdit();
            formAgreagar.Show();
        }
    }
}
