﻿using DOMINIO.Models;
using MaterialSkin.Controls;
using PRESENTACION.Administracion_Usuarios;
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
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            ListarRoles();
            LLnearCombroboxGnero();
            LimpiarDatos();
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
            Dictionary<bool, string> valoresBooleanos = new Dictionary<bool, string>{
            { true, "Hombre" },
            { false, "Mujer" }
            };

            // Enlazar el diccionario al ComboBox
            CmbSexo.DataSource = new BindingSource(valoresBooleanos, null);
            CmbSexo.DisplayMember = "Value"; // Mostrar el valor de texto en el ComboBox
            CmbSexo.ValueMember = "Key"; // Obtener el valor booleano seleccionado
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (OperacionTipo == "Insertar")
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
            else if (OperacionTipo == "Editar")
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

        private void btn_editar_Click(object sender, EventArgs e)
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
                //CheckActivo.Checked = (bool)dataGridView1.CurrentRow.Cells[7].Value;
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
            this.CmbSexo.SelectedIndex = -1; // Opción para deseleccionar todos los elementos
            this.TxtEmail.Text = string.Empty;
            this.CmbRol.SelectedIndex = -1;
            this.CheckActivo.Checked = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CenterGroupBoxHorizontally();
        }
        private void CenterGroupBoxHorizontally()
        {
            //Para mantener el contenido centrado dentro del panel superior del formulario Usuarios
            int panelWidth = panel1.Width;
            int groupBoxWidth = groupBox1.Width;

            int centerX = (panelWidth - groupBoxWidth) / 2;
            if (centerX < 0)
            {
                centerX = 0;
            }
            groupBox1.Location = new Point(centerX, groupBox1.Location.Y);
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_NuevoUsuario>();
        }

        private void btn_agregar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }
    }
}



