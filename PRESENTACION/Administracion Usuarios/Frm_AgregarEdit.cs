using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO.Models;
using MaterialSkin.Controls;
namespace PRESENTACION.Administracion_Usuarios
{
    public partial class Frm_AgregarEdit : MaterialForm
    {
        public Frm_AgregarEdit()
        {
            InitializeComponent();
        }

        private void Frm_AgregarEdit_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void ListarRoles()
        {
            Usuario cargar = new Usuario();
            this.CmbRol.DataSource = cargar.GetRoles();
            this.CmbRol.DisplayMember = "Rol";
            this.CmbRol.ValueMember = "IdUsuarioRol";
        }



        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
