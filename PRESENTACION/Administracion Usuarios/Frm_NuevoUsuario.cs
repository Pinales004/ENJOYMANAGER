﻿using DOMINIO.Models;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
            txtNombre.MaxLength = 50;
            txtApellido.MaxLength = 50;
            txtNombreUsuario.MaxLength = 100;
            txtEmail.MaxLength = 100;
            txtContraseña.MaxLength = 255;
            txtContraseña2.MaxLength = 255;

            if (TipoOperacion == "Insertar")
            {
                ListarRoles();
                LLnearCombroboxGnero();
                ListarEstados();
                ResetPassword.Visible = false;
                materialLabel9.Visible = false;
                CboEstadoUsuario.Visible = false;
            }

            // Suscribirse al evento TemaCambiado del formulario principal
            FormPrincipal.TemaCambiado += FormPrincipal_TemaCambiado;

            // Obtener y aplicar el tema actual
            string temaActual = FormPrincipal.TemaSeleccionado;
            panel1.BackColor = TemaColores.BarraTitulo;
        }
        private void FormPrincipal_TemaCambiado(object sender, EventArgs e)
        {
            // El tema en el formulario principal cambió, actualizar el tema en este formulario
            string temaActual = FormPrincipal.TemaSeleccionado;
            AplicarTema(temaActual);
        }
        private void AplicarTema(string tema)
        {
            panel1.BackColor = TemaColores.BarraTitulo;
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
            try
            {

                if (string.IsNullOrWhiteSpace(this.txtNombreUsuario.Text))
                {
                    MessageBox.Show("Debe indicar un UsuarioNombre.");
                }
                else if (this.txtNombreUsuario.Text.Length > 100)
                {
                    MessageBox.Show("El NombreUsuario debe ser menor a 100 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    MessageBox.Show("Debe indicar el Nombres del usuario.");
                }
                else if (this.txtNombre.Text.Length > 50)
                {
                    MessageBox.Show("El Nombre de usuario debe ser menor a 50 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    MessageBox.Show("Debe indicar el apellido del usuario.");
                }
                else if (this.txtApellido.Text.Length > 50)
                {
                    MessageBox.Show("El Apellido de usuario debe ser menor a 50 acaracteres.");
                }
                else if (this.txtContraseña.Text.Length > 255)
                {
                    MessageBox.Show("La Contraseña debe ser menor a 255 caracteres.");
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
                else if (!EsCorreoElectronicoValido(this.txtEmail.Text))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.");
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
                    if (TipoOperacion == "Insertar")
                    {
                        ResetPassword.Visible = false;

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
                            Convert.ToInt32(CboEstadoUsuario.SelectedValue),
                            Convert.ToBoolean(ResetPassword.Checked)
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

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        #endregion

        private bool EsCorreoElectronicoValido(string email)
        {
            // Patrón de expresión regular para validar el formato del correo electrónico
            string patron = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Verifica si el correo electrónico coincide con el patrón
            return Regex.IsMatch(email, patron);
        }
        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtContraseña2.Text = "";
            this.ResetPassword.Checked = false;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validadores.Validador_Alfabetico(e.KeyChar);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validadores.Validador_Alfabetico(e.KeyChar);
        }

    }
}
