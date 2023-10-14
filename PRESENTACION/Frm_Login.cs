using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using DOMINIO.Moldes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DOMINIO.Models;

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


        //no esta funcionando esto no se porque se supone que debe de moverse la ventana
        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
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
                if (TxtContrasena.Text != "CONTRASEÑA") {

                    Usuario user = new Usuario();
                    var ValidLogin = user.LoginUser(txtUsuario.Text, TxtContrasena.Text);
                    if (ValidLogin==true)
                    {
                        Form1 menu = new Form1();
                        menu.FormClosed += Logout;
                        menu.Show();
                        this.Hide();

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
        private void MsgError(string msg) {
            blErrorMensaje.Text = "     " + msg;
            blErrorMensaje.Visible = true;
        
        
        }



        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtContrasena.Clear();
            txtUsuario.Clear();
            blErrorMensaje.Visible = false;
            this.Show();
            txtUsuario.Focus();

        }
    }






}
