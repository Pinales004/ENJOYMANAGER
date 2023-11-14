using DOMINIO.Models;
using MaterialSkin.Controls;
using PRESENTACION.Administracion_Usuarios;
using PRESENTACION.Proyecto;
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

        public string OperacionTiPoM = "Insertar";
        public string UsuarioId;
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        public void CargarUsuarios()
        {
            Usuario cargar = new Usuario();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetUsuarios();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
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

        #region botones
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            var form = new Frm_NuevoUsuario();
            form.TipoOperacion = "Insertar";

            form.Frm_Usuarios = this; // Establece la propiedad Frm_Usuarios

            AbrirFormulario<Frm_NuevoUsuario>(form);
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                var frm = new Frm_NuevoUsuario();
                frm.TipoOperacion = "Editar";

                // Obtén los valores de la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                frm.IdUsuario = selectedRow.Cells["IdUsuario"].Value.ToString();
                frm.txtNombreUsuario.Text = selectedRow.Cells["UsuarioNombre"].Value.ToString();
                frm.txtNombre.Text = selectedRow.Cells["Nombres"].Value.ToString();
                frm.txtApellido.Text = selectedRow.Cells["Apellidos"].Value.ToString();
                frm.txtEmail.Text = selectedRow.Cells["EmailUsuario"].Value.ToString();
                frm.cmbGenero.Text = selectedRow.Cells["Genero"].Value.ToString(); // Establecer el valor en el ComboBox
                frm.cmbRol.SelectedValue = Convert.ToInt32(selectedRow.Cells["IdUsuarioRol"].Value.ToString());
                frm.CboEstadoUsuario.SelectedValue = Convert.ToInt32(selectedRow.Cells["IdUsuarioEstado"].Value);
                //CheckActivo.Checked = (bool)dataGridView1.CurrentRow.Cells[7].Value;

                // Establece la propiedad FormUsuarios
                frm.Frm_Usuarios = this;
                // Llamar al método AbrirFormulario con el formulario Frm_NuevoUsuario
                AbrirFormulario<Frm_NuevoUsuario>(frm);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Usuario cargar = new Usuario();
                cargar.EliminarUusario(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdUsuario"].Value.ToString()));
                CargarUsuarios();
                MessageBox.Show("Usuario Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder Eliminar un usuario");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Usuario cargar = new Usuario();
            try
            {
                string nombreBusqueda = this.txtbox_buscar.Text;

                // Llama a un método que realiza la búsqueda y obtiene los resultados
                DataTable resultados = cargar.BuscarUsuariosPorNombre(nombreBusqueda);

                // Muestra los resultados en una cuadrícula o en otro control
                this.dataGridView1.DataSource = resultados; // Ejemplo con DataGridView

            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante la búsqueda
                MessageBox.Show("Error al buscar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region btn_hover
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
        #endregion
    }
}