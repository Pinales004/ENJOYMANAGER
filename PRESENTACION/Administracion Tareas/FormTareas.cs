using DOMINIO.Models;
using PRESENTACION.Administracion_Tareas;
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
    public partial class FormTareas : Form
    {
        public FormTareas()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_NuevaTarea>();
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

        public void CargarTareas()
        {
            Tareas cargar = new Tareas();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = cargar.CargarTareas();
        }

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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }
    }
}
