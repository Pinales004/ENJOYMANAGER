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

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Administracion_Usuarios.Frm_AgregarEdit formAgreagar = new Administracion_Usuarios.Frm_AgregarEdit();
            formAgreagar.Show();
        }
    }
}
