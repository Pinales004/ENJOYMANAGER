using Comun.Biblioteca.Enums;
using Comun.Cache;
using DOMINIO.Models;
using System.Runtime.InteropServices;

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
            txtContraseñaComprobar.Text = "";
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

                UserLoginCache.ResetPasword = false;

                int IdUsuario = UserLoginCache.IdUsuario;

                string nuevaContraseña = this.txtContraseña.Text;

                // Llamar a ActualizarContraseña sin proporcionar el valor de resetPassword
                cargar.ActualizarContraseña(
                    Convert.ToInt32(IdUsuario),
                    nuevaContraseña,
                    Convert.ToInt32(EnumEstadoUsuario.Estado.Activo)
                );
                this.Hide();
            }
            else
            {
                MessageBox.Show("Compruebe que ambas contraseñas son iguales.");
            }
        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseñaComprobar.UseSystemPasswordChar = true;
        }
    }
}
