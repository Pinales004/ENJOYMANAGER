using Comun.Biblioteca.Enums;
using Comun.Cache;
using DOMINIO.Models;
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

namespace PRESENTACION.Login
{
    public partial class FormCambiarContraseña : Form
    {
        public FormCambiarContraseña()
        {
            InitializeComponent();
        }
        public string IdUsuario;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_NuevoProyecto_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LimpiarCampos()
        {
            txtContraseña.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseñaComprobar.Text)
            {
                Usuario cargar = new Usuario();

                int IdUsuario = UserLoginCache.IdUsuario;

                string nuevaContraseña = this.txtContraseña.Text;
                string nuevaContraseñaHash = HashHelper.CalculateSHA256Hash(nuevaContraseña);
                cargar.ActualizarContraseña(Convert.ToInt32(IdUsuario),
                    nuevaContraseñaHash, // Almacenar el nuevo hash en la base de datos
                    Convert.ToInt32(EnumEstadoUsuario.Estado.Activo)
                );
                this.Hide();
            }
            else
            {
                MessageBox.Show("Compruebe que ambas contraseñas son iguales.");
            }

        }
    }
}
