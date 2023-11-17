using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using DATOS.Conexion;
using DOMINIO.Models;
using PRESENTACION.Proyecto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRESENTACION
{
    public partial class FormProyectos : Form
    {
        public FormProyectos()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
        }
        private void FormProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }
        public void CargarProyectos()
        {
            Proyectos cargar = new Proyectos();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.GetProyectos();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
        }

        private void AbrirFormulario<MiForm>(MiForm form) where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = form; // Utiliza la instancia del formulario como argumento
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.ShowDialog(); // Mostrar el formulario de manera modal
            }
            else
            {
                formulario.BringToFront();
            }
        }
        public void CargarEstadoProyecto(Frm_NuevoProyecto form)
        {
            Proyectos cargar = new Proyectos();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoProyecto.DataSource = cargar.GetProyectosEstado();
            form.cmbEstadoProyecto.DisplayMember = "Estado";
            form.cmbEstadoProyecto.ValueMember = "EstadoProyectoid";
        }

        #region botones
        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                var form = new Frm_NuevoProyecto(); // Crear una instancia del formulario FrmNuevoProyecto
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                // Llamar al método CargarEstadoProyecto pasando el formulario como argumento
                CargarEstadoProyecto(form);
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];
                form.OperacionTipo = "Editar";
                form.LblEquipoProyecto.Visible = true;
                form.btnEquipoProyecto.Visible = true;
                int idProyecto = (int)selectedRow["IdProyecto"];

                // Configura los campos en el formulario
                form.IdProyecto.Text = idProyecto.ToString();
                form.txtNombreProyecto.Text = selectedRow["NombreProyecto"].ToString();
                form.txtDescripcionProyecto.Text = selectedRow["Descripcion"].ToString();
                form.cmbEstadoProyecto.Text = selectedRow["EstadoProyecto"].ToString();
                form.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["FechaInicio"].ToString());
                form.dateTimePickerEntrega.Value = DateTime.Parse(selectedRow["FechaFin"].ToString());


                // Establece la propiedad FormProyectos
                form.FormProyectos = this;
                // Llamar al método AbrirFormulario con el formulario FrmNuevoProyecto
                AbrirFormulario<Frm_NuevoProyecto>(form);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var form = new Frm_NuevoProyecto();
            form.OperacionTipo = "Insertar";
            CargarEstadoProyecto(form);
            form.FormProyectos = this; // Establece la propiedad FormProyectos

            AbrirFormulario<Frm_NuevoProyecto>(form);
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Preguntar al usuario si está seguro de eliminar el proyecto
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este Proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Continuar con la eliminación si el proyecto confirma
                    Proyectos cargar = new Proyectos();
                    cargar.EliminarProyecto(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdProyecto"].Value.ToString()));
                    MessageBox.Show("Proyecto Eliminado Correctamente");
                    CargarProyectos();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder Eliminar un Proyecto");
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Proyectos cargar = new Proyectos();
            try
            {
                string nombreBusqueda = this.txtbox_buscar.Text;

                // Llama a un método que realiza la búsqueda y obtiene los resultados
                DataTable resultados = cargar.BuscarPorNombreProyecto(nombreBusqueda);

                // Muestra los resultados en una cuadrícula o en otro control
                this.dataGridView1.DataSource = resultados; // Ejemplo con DataGridView

            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante la búsqueda
                MessageBox.Show("Error al buscar Proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarTareas(int idproyecto)
        {
            Tareas cargar = new Tareas();
            this.dataGridViewTareas.AutoGenerateColumns = true;
            this.dataGridViewTareas.DataSource = cargar.BuscarTareaPorIdPoryecto(Convert.ToInt32(idproyecto));
            this.dataGridViewTareas.Columns[0].Visible = false;
            this.dataGridViewTareas.Columns[1].Visible = false;
            this.dataGridViewTareas.Columns[3].Visible = false;
            this.dataGridViewTareas.Columns[4].Visible = false;
            this.dataGridViewTareas.Columns[6].Visible = false;
            this.dataGridViewTareas.Columns[7].Visible = false;
           


        }

        private void CargarMiembros(int idproyecto)
        {
            if (idproyecto != null)
            {
                ProyectoMiembro miembro = new ProyectoMiembro();
                dataGridViewEquipoProgramadores.AutoGenerateColumns = true;
                dataGridViewEquipoProgramadores.DataSource = miembro.GetProyectoMiembro(Convert.ToInt32(idproyecto));
                this.dataGridViewEquipoProgramadores.Columns[0].Visible = false;
                

            }
        }

        


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Obtén el Id del proyecto seleccionado
                int idProyecto = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["IdProyecto"].Value);

                CargarTareas(idProyecto);
                CargarMiembros(idProyecto);
            }
        }




    }
}

