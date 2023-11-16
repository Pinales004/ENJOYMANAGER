using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO.Models;
using PRESENTACION;

namespace PRESENTACION.Administracion_Usuarios
{

    public partial class Frm_NuevoUsuario : Form
    {
        public Frm_NuevoUsuario()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_volver);
            btn_icon_hover.AplicarFormaRedonda(btn_guardar);
            btn_icon_hover.AplicarFormaRedonda(btn_limpiar);
        }
        public Frm_Usuarios Frm_Usuarios { get; set; }

        Frm_Usuarios form = new Frm_Usuarios();
        public string TipoOperacion = "Insertar";
        public string IdUsuario;

        private void Frm_NuevoUsuario_Load(object sender, EventArgs e)
        {
            if (TipoOperacion == "Insertar")
            {
                ListarRoles();
                LLnearCombroboxGnero();
                ListarEstados();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_NuevoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region botones
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuario cargar = new Usuario();

            if (TipoOperacion == "Insertar")
            {
                if (string.IsNullOrWhiteSpace(this.txtNombreUsuario.Text))
                {
                    MessageBox.Show("Debe indicar un UsuarioNombre.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    MessageBox.Show("Debe indicar los nombres del usuario.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    MessageBox.Show("Debe indicar el apellido del usuario.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtContraseña.Text))
                {
                    MessageBox.Show("Debe ingresar una contraseña.");
                }
                else if (this.txtContraseña.Text != this.txtContraseña2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
                else if (cmbGenero.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar el sexo del usuario.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
                {
                    MessageBox.Show("Debe indicar un correo electrónico.");
                }
                else if (cmbRol.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un rol de usuario.");
                }
                else if (CboEstadoUsuario.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un Estado de usuario.");
                }
                else
                {
                    // Calcular el hash SHA-256 de la contraseña antes de almacenarla
                    string contraseñaIngresada = this.txtContraseña.Text;
                    string contraseñaHash = HashHelper.CalculateSHA256Hash(contraseñaIngresada);

                    // Llamar al método para insertar el usuario si todas las validaciones pasan
                    cargar.InsertarUsuarios(
                        this.txtNombreUsuario.Text,
                        this.txtNombre.Text,
                        txtApellido.Text,
                        Convert.ToBoolean(cmbGenero.SelectedValue),
                        txtEmail.Text,
                        contraseñaHash,  // Almacenar el hash en la base de datos
                        Convert.ToInt32(cmbRol.SelectedValue),
                        Convert.ToInt32(CboEstadoUsuario.SelectedValue)
                    );
                    form.CargarUsuarios();
                    // Llama al método CargarUsuarios del formulario FormUsuarios para actualizar el DataGridView
                    if (Frm_Usuarios != null)
                    {
                        Frm_Usuarios.CargarUsuarios();
                    }
                    LimpiarCampos();
                    this.Hide();
                }
            }
            else if (TipoOperacion == "Editar")
            {
                // Calcular el hash SHA-256 de la nueva contraseña antes de almacenarla
                string nuevaContraseña = this.txtContraseña.Text;
                string nuevaContraseñaHash = HashHelper.CalculateSHA256Hash(nuevaContraseña);

                cargar.ActualizarUsuarios(Convert.ToInt32(IdUsuario),
                    this.txtNombreUsuario.Text,
                    this.txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToBoolean(cmbGenero.SelectedValue),
                    txtEmail.Text,
                    nuevaContraseñaHash,  // Almacenar el nuevo hash en la base de datos
                    Convert.ToInt32(cmbRol.SelectedValue),
                    Convert.ToInt32(CboEstadoUsuario.SelectedValue)
                );
                form.CargarUsuarios();
                // Llama al método CargarUsuarios del formulario FormUsuarios para actualizar el DataGridView
                if (Frm_Usuarios != null)
                {
                    Frm_Usuarios.CargarUsuarios();
                }
                LimpiarCampos();
                this.Hide();
            }
        }
        #endregion

        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtContraseña2.Text = "";
            this.CheckActivo.Checked = false;
        }
        private void ListarRoles()
        {
            Usuario cargar = new Usuario();

            cmbRol.DataSource = cargar.GetRoles();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "IdUsuarioRol";
        }

        private void ListarEstados()
        {
            Usuario cargar = new Usuario();

            CboEstadoUsuario.DataSource = cargar.GetEstados();
            CboEstadoUsuario.DisplayMember = "Estado";
            CboEstadoUsuario.ValueMember = "IdUsuarioEstado";
        }
        private void LLnearCombroboxGnero()
        {
            // Crear un diccionario de valores booleanos y sus representaciones de texto
            Dictionary<bool, string> valoresBooleanos = new Dictionary<bool, string>{
            { true, "Hombre" },
            { false, "Mujer" }
            };

            // Enlazar el diccionario al ComboBox
            cmbGenero.DataSource = new BindingSource(valoresBooleanos, null);
            cmbGenero.DisplayMember = "Value"; // Mostrar el valor de texto en el ComboBox
            cmbGenero.ValueMember = "Key"; // Obtener el valor booleano seleccionado
        }
        #region btn_hover
        private void btn_limpiar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_limpiar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_guardar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_guardar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_volver_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_volver_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }
        #endregion
    }
}
