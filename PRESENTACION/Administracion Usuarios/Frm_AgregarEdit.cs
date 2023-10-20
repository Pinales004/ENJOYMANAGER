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
    public partial class Frm_AgregarEdit : Form
    {
        public Frm_AgregarEdit()
        {
            InitializeComponent();
        }

        private void Frm_AgregarEdit_Load(object sender, EventArgs e)
        {
            ListarRoles();
            LLnearCombroboxGnero();
        }

        private void CargarUsuarios()
        {
            Usuario cargar = new Usuario();
            Frm_Usuarios formUsuario = new Frm_Usuarios();
            DataGridView dataGridView = formUsuario.dataGridView1;
            dataGridView.AutoGenerateColumns = true; 
            dataGridView.DataSource = cargar.GetUsuarios();


        }

        private void ListarRoles()
        {
            Usuario cargar = new Usuario();
            
            this.CmbRol.DataSource = cargar.GetRoles();
            this.CmbRol.DisplayMember = "Rol";
            this.CmbRol.ValueMember = "IdUsuarioRol";
        }

        private void LLnearCombroboxGnero()
        {
            // Crear un diccionario de valores booleanos y sus representaciones de texto
            Dictionary<bool, string> valoresBooleanos = new Dictionary<bool, string>
               {
        { true, "Hombre" },
        { false, "Mujer" }
           };

            // Enlazar el diccionario al ComboBox
            CmbSexo.DataSource = new BindingSource(valoresBooleanos, null);
            CmbSexo.DisplayMember = "Value"; // Mostrar el valor de texto en el ComboBox
            CmbSexo.ValueMember = "Key"; // Obtener el valor booleano seleccionado
        }




        private void materialButton1_Click(object sender, EventArgs e)
        {

            Usuario cargar = new Usuario();
            if (string.IsNullOrWhiteSpace(this.txtUsuarioNombre.Text))
            {
                MessageBox.Show("Debe indicar un UsuarioNombre.");
            }
            else if (string.IsNullOrWhiteSpace(this.TxtNombres.Text))
            {
                MessageBox.Show("Debe indicar los nombres del usuario.");
            }
            else if (string.IsNullOrWhiteSpace(this.TxtApellido.Text))
            {
                MessageBox.Show("Debe indicar el apellido del usuario.");
            }
            else if (string.IsNullOrWhiteSpace(this.TxtContrasena.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.");
            }
            else if (this.TxtContrasena.Text != this.TxtContrasena2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
            else if (CmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el sexo del usuario.");
            }
            else if (string.IsNullOrWhiteSpace(this.TxtEmail.Text))
            {
                MessageBox.Show("Debe indicar un correo electrónico.");
            }
            else if (CmbRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol de usuario.");
            }
            else
            {
                // Llamar al método para insertar el usuario si todas las validaciones pasan
                cargar.InsertarUsuarios(
                    this.txtUsuarioNombre.Text,
                    this.TxtNombres.Text,
                    TxtApellido.Text,
                    Convert.ToBoolean(CmbSexo.SelectedValue),
                    TxtEmail.Text,
                    TxtContrasena.Text,
                    Convert.ToInt32(CmbRol.SelectedValue),
                    Convert.ToBoolean(CheckActivo.Checked)
                );
                CargarUsuarios();
                LimpiarDatos();
                this.Hide();
            }


        }

        private void LimpiarDatos()
        {
            this.txtUsuarioNombre.Text = string.Empty;
            this.TxtNombres.Text = string.Empty;
            this.TxtApellido.Text = string.Empty;
            this.TxtContrasena.Text = string.Empty;
            this.TxtContrasena2.Text = string.Empty;
            this.CmbSexo.SelectedItem = null;
            this.TxtEmail.Text = string.Empty;
            this.CmbRol.SelectedItem = null;
        }

    }
}
       






