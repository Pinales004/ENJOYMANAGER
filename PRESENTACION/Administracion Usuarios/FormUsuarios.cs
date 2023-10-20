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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }


        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            ListarRoles();
            LLnearCombroboxGnero();

        }
        String OperacionTipo = "Insertar";
        string idUsuari;
        private void CargarUsuarios()
        {
            Usuario cargar = new Usuario();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetUsuarios();


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
            if (OperacionTipo=="Insertar")
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
                }
            }
            else if(OperacionTipo == "Editar")
            {

                Usuario cargar = new Usuario();
                cargar.ActualizarUsuarios(Convert.ToInt32(idUsuari),
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

            }

           
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ListarRoles();
                LLnearCombroboxGnero();
                OperacionTipo = "Editar";

                idUsuari = dataGridView1.SelectedRows[0].Cells["IdUsuario"].Value.ToString();

            txtUsuarioNombre.Text = dataGridView1.CurrentRow.Cells["UsuarioNombre"].Value.ToString();
            TxtNombres.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
            TxtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            TxtEmail.Text = dataGridView1.CurrentRow.Cells["EmailUsuario"].Value.ToString();
            TxtContrasena.Text = dataGridView1.CurrentRow.Cells["ContrasenaUsuario"].Value.ToString();
            CmbSexo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CmbRol.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          //  CheckActivo.Checked = (bool)dataGridView1.CurrentRow.Cells[7].Value;
              

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Usuario cargar = new Usuario();
                cargar.EliminarUusario(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdUsuario"].Value.ToString()));
                CargarUsuarios();
                MessageBox.Show("Usuario Eliminado Correctamente");
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder Eliminar un usuario");
            }

            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
    }

    

