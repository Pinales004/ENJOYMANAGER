using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
//using DOMINIO.Moldes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DOMINIO.Models;
using Comun.Cache;
using PRESENTACION.Login;

namespace PRESENTACION
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        //esto funciona para arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Eventos para vizualizacion solo decoracion
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;

            }
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "CONTRASEÑA")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.LightGray;
                TxtContrasena.UseSystemPasswordChar = true;

            }

        }
        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "CONTRASEÑA";
                TxtContrasena.ForeColor = Color.DimGray;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormulario<MiForm>(MiForm form) where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = form; // Utiliza la instancia del formulario que pasaste como argumento
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ValidacionDatos();
        }

        //Validacion datos vacios
        public void ValidacionDatos()
        {

            if (txtUsuario.Text != "USUARIO")
            {
                if (TxtContrasena.Text != "CONTRASEÑA")
                {

                    Usuario user = new Usuario();
                    // Calcular el hash SHA-256 de la contraseña antes de enviarla a la base de datos
                    string contraseñaHash = HashHelper.CalculateSHA256Hash(TxtContrasena.Text);
                    var ValidLogin = user.LoginUser(txtUsuario.Text, contraseñaHash);
                    var Estado = user.AccountStatus(txtUsuario.Text);
                    // UserLoginCache.EstadoUsuario


                    if (UserLoginCache.EstadoUsuario == 1)
                    {
                        this.TxtContrasena.Clear();
                        this.txtUsuario.Focus();
                        FormCambiarContraseña form = new FormCambiarContraseña();
                        AbrirFormulario<FormCambiarContraseña>(form);
                        return;
                    }
                    else if (UserLoginCache.ResetPasword == true)
                    {
                        this.TxtContrasena.Clear();
                        this.txtUsuario.Focus();
                        FormCambiarContraseña form = new FormCambiarContraseña();
                        AbrirFormulario<FormCambiarContraseña>(form);
                        return;
                    }
                    else if (Estado == 2)
                    {

                        if (ValidLogin)
                        {

                            if (UserLoginCache.EstadoUsuario == 2)
                            {

                                if (UserLoginCache.Borrado)
                                {
                                    MsgError("Tu cuenta ha sido marcada como borrada. Por favor, contacta al administrador.");
                                    this.TxtContrasena.Clear();
                                    this.txtUsuario.Focus();
                                    return;
                                }
                                else
                                {
                                    FormPrincipal menu = new FormPrincipal();
                                    menu.FormClosed += Logout;
                                    menu.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MsgError("Usuario o contraseña incorrectos");
                            this.TxtContrasena.Clear();
                            this.txtUsuario.Focus();
                        }

                    }
                    else if (Estado == 3)
                    {

                        MsgError(" Su usuario podria estar inactivo en este momento    \n  contacta el administrador del sistema.");
                        this.TxtContrasena.Clear();
                        this.txtUsuario.Focus();


                    }
                    else if (Estado == 4)
                    {

                        MsgError(" Este usuario esta Bloqueado    \n  contacta el administrador del sistema.");
                        this.TxtContrasena.Clear();
                        this.txtUsuario.Focus();


                    }
                    else
                    {
                        MsgError("Usuario o contraseña incorrectos");
                        this.TxtContrasena.Clear();
                        this.txtUsuario.Focus();
                    }



                }
                else
                {
                    MsgError("Por favor digita tu Contraseña");
                }
            }
            else
            {
                MsgError("Por favor digita tu nombre de usuario");
            }

        }
        //mensaje advertencia reutilizable
        private void MsgError(string msg)
        {
            blErrorMensaje.Text = "     " + msg;
            blErrorMensaje.Visible = true;
        }


        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtContrasena.Text = "CONTRASEÑA";
            TxtContrasena.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            blErrorMensaje.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void Frm_Login_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
