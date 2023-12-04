using Comun.Biblioteca.Enums;
using Comun.Cache;
using DOMINIO.Models;
using PRESENTACION.Administracion_Tareas;
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
    public partial class FormTareas : Form
    {

        public string TareaId;
        public FormTareas()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
            btn_icon_hover.AplicarFormaRedonda(btn_realizar);
            dateFechaInicio.ShowCheckBox = true;
            dateFechaInicio.Checked = false; // Inicialmente no hay fecha seleccionada

            // Configura el DateTimePicker de fin
            DateFechFin.ShowCheckBox = true;
            DateFechFin.Checked = false; // Inic
        }

        private void rolUsuario()
        {
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Gerente)
            {
                btn_agregar.Visible = true;
                btn_editar.Visible = true;
                btn_eliminar.Visible = true;
                btn_realizar.Visible = true;
                CargarTareasGerentes();
                CargarEstadoTareaFiltro();
            }
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Programador)
            {
                btn_agregar.Visible = false;
                btn_editar.Visible = false;
                btn_eliminar.Visible = false;
                btn_realizar.Visible = true;
                CargarTareasProgrmadores();
                CargarEstadoTareaFiltro();
            }
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {

            rolUsuario();
        }
        public void CargarEstadoTarea(Frm_NuevaTarea form)
        {
            Tareas cargar = new Tareas();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoTarea.DataSource = cargar.TareaEstado();
            form.cmbEstadoTarea.DisplayMember = "Estado";
            form.cmbEstadoTarea.ValueMember = "EstadoTareaid";
        }

        private void ListadoProyectos(Frm_NuevaTarea form)
        {
            Tareas cargar = new Tareas();
            form.CmbNombreProyecto.DataSource = cargar.CargarListadoProyectos();
            form.CmbNombreProyecto.DisplayMember = "Nombre";
            form.CmbNombreProyecto.ValueMember = "IdProyecto";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var form = new Frm_NuevaTarea();
            form.TipoOperacion = "Insertar";
            CargarEstadoTarea(form);
            // ListadoProyectos(form);
            form.FormTareas = this; // Establece la propiedad FormTareas

            AbrirFormulario<Frm_NuevaTarea>(form);
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

        public void CargarTareasProgrmadores()
        {
            Tareas cargar = new Tareas();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.CargarTareas(UserLoginCache.IdUsuario);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
        }

        public void CargarTareasGerentes()
        {
            Tareas cargar = new Tareas();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = cargar.CargarTareasGeneral();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
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

        private void btn_realizar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_realizar_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }

        #endregion



        public void CargarEstadoTareaProgra(Frm_RealizarTarea form)
        {
            Tareas cargar = new Tareas();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoTarea.DataSource = cargar.TareaEstado();
            form.cmbEstadoTarea.DisplayMember = "Estado";
            form.cmbEstadoTarea.ValueMember = "EstadoTareaid";
        }

        public void CargarEstadoTareaFiltro()
        {
            Tareas cargar = new Tareas();

            // Configura el ComboBox en el formulario pasado como argumento
            cbmFiltroEstado.DataSource = cargar.TareaEstado();
            cbmFiltroEstado.DisplayMember = "Estado";
            cbmFiltroEstado.ValueMember = "EstadoTareaid";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var frm = new Frm_NuevaTarea();
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                CargarEstadoTarea(frm);
                ListadoProyectos(frm);
                frm.TipoOperacion = "Editar";
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];

                frm.TareaId = dataGridView1.SelectedRows[0].Cells["TareaId"].Value.ToString();

                frm.txtNombreTarea.Text = selectedRow["Nombre de la tarea"].ToString();
                frm.CmbNombreProyecto.Text = selectedRow[3].ToString();
                frm.cmbEstadoTarea.Text = selectedRow["Estado"].ToString();
                frm.cmbResponsableTarea.Text = selectedRow["Responsable"].ToString();
                frm.txtDescripcionTarea.Text = selectedRow["Descripción"].ToString();
                frm.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["Fecha de inicio"].ToString());
                frm.dateTimePickerFin.Value = DateTime.Parse(selectedRow["Fecha final"].ToString());

                // Establece la propiedad FormTareas
                frm.FormTareas = this;
                // Llamar al método AbrirFormulario con el formulario Frm_NuevaTarea
                AbrirFormulario<Frm_NuevaTarea>(frm);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var frm = new Frm_RealizarTarea();
                CargarEstadoTareaProgra(frm);

                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                frm.TipoOperacion = "Editar";
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];

                TareaId = dataGridView1.SelectedRows[0].Cells["TareaId"].Value.ToString();

                frm.TareaId = TareaId;

                frm.txtNombreTarea.Text = selectedRow["Nombre de la tarea"].ToString();
                frm.cmbEstadoTarea.Text = selectedRow["Estado"].ToString();
                frm.txtDescripcionTarea.Text = selectedRow["Descripción"].ToString();
                frm.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["Fecha de inicio"].ToString());
                frm.dateTimePickerFin.Value = DateTime.Parse(selectedRow["Fecha final"].ToString());

                // Establece la propiedad FormTareas
                frm.FormTareas = this;
                // Llamar al método AbrirFormulario con el formulario Frm_NuevaTarea
                AbrirFormulario<Frm_RealizarTarea>(frm);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el proyecto
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este Tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Continuar con la eliminación si el proyecto confirma
                    Tareas cargar = new Tareas();
                    cargar.EliminarTarea(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TareaId"].Value.ToString()));
                    MessageBox.Show("Tarea Eliminada Correctamente");
                    CargarTareasGerentes();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder Eliminar un Tarea");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Tareas cargar = new Tareas();
            try
            {
                // Obtén los valores de los filtros desde tus controles de interfaz de usuario
                string nombreProyecto = this.txtbox_buscar.Text;
                string responsable = this.TxtResponsable.Text;
                DateTime? fechaInicio = dateFechaInicio.Checked ? dateFechaInicio.Value : (DateTime?)null;
                DateTime? fechaFin = DateFechFin.Checked ? DateFechFin.Value : (DateTime?)null;
                int? estadoTareaId = Convert.ToInt32(cbmFiltroEstado.SelectedValue);
                 // Llama al nuevo método que realiza la búsqueda con filtros
                 DataTable resultados = cargar.BuscarTareaPorFiltros(nombreProyecto, responsable, fechaInicio, fechaFin, estadoTareaId);

                // Muestra los resultados en una cuadrícula o en otro control
                this.dataGridView1.DataSource = resultados; // Ejemplo con DataGridView
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir durante la búsqueda
                MessageBox.Show("Error al buscar Tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime? ObtenerFechaDesdeControl(DateTimePicker datePicker)
        {
            if (datePicker.Checked)
            {
                return datePicker.Value;
            }
            else
            {
                return null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtbox_buscar.Text = string.Empty;  // Reemplaza con el control correcto
            TxtResponsable.Text = string.Empty;      // Reemplaza con el control correcto
            dateFechaInicio.Value = DateTime.Today;    // Reemplaza con el control correcto
            DateFechFin.Value = DateTime.Today;       // Reemplaza con el control correcto
            dateFechaInicio.ShowCheckBox = true;
            dateFechaInicio.Checked = false; // Inicialmente no hay fecha seleccionada
            CargarEstadoTareaFiltro();
            // Configura el DateTimePicker de fin
            DateFechFin.ShowCheckBox = true;
            DateFechFin.Checked = false;
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Gerente)
            {

                CargarTareasGerentes();
            }
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Programador)
            {

                CargarTareasProgrmadores();
            }

        }
    }
}
