﻿using DOMINIO.Models;
using PRESENTACION.Administracion_Tareas;
using PRESENTACION.Proyecto;
using System.Data;

namespace PRESENTACION
{
    public partial class FormProyectos : Form
    {
        public string TareaId;
        public FormProyectos()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_agregar);
            btn_icon_hover.AplicarFormaRedonda(btn_editar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);

        }
        public void FormProyectos_Load(object sender, EventArgs e)
        {
            // Suscribirse al evento TemaCambiado del formulario principal
            FormPrincipal.TemaCambiado += FormPrincipal_TemaCambiado;

            // Obtener y aplicar el tema actual
            string temaActual = FormPrincipal.TemaSeleccionado;
            panel1.BackColor = TemaColores.PanelBotones;
            label1.ForeColor = TemaColores.TextBusqueda;
            dataGridView1.BackgroundColor = TemaColores.TextBusqueda;
            dataGridView1.GridColor = TemaColores.TextBusqueda;

            txtbox_buscar.MaxLength = 100;

            CargarProyectos();
        }
        private void FormPrincipal_TemaCambiado(object sender, EventArgs e)
        {
            // El tema en el formulario principal cambió, actualizar el tema en este formulario
            string temaActual = FormPrincipal.TemaSeleccionado;
            AplicarTema(temaActual);
        }
        private void AplicarTema(string tema)
        {
            panel1.BackColor = TemaColores.PanelBotones;
            label1.ForeColor = TemaColores.TextBusqueda;
            dataGridView1.BackgroundColor = TemaColores.TextBusqueda;
            dataGridView1.GridColor = TemaColores.TextBusqueda;
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

            if (dataGridView1.SelectedRows.Count > 0)
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
                form.txtNombreProyecto.Text = selectedRow[1].ToString();
                form.txtDescripcionProyecto.Text = selectedRow[2].ToString();
                form.cmbEstadoProyecto.Text = selectedRow[7].ToString();

                // Valida y asigna la fecha de entrega
                if (DateTime.TryParse(selectedRow["Fecha de inicio programado"].ToString(), out DateTime fechaInicioProgramada))
                {
                    form.dateTimeInicioPro.Value = fechaInicioProgramada;
                }

                // Valida y asigna la fecha de inicio programada
                if (DateTime.TryParse(selectedRow["Fecha final programada"].ToString(), out DateTime fechaFinProgrammada))
                {
                    form.dateTimeFinPro.Value = fechaFinProgrammada;
                }

                // Valida y asigna la fecha de fin real
                if (DateTime.TryParse(selectedRow["Fecha final"].ToString(), out DateTime fechaFinReal))
                {
                    form.dateTimePickerEntrega.Value = fechaFinReal;
                }

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
            if (idproyecto != null)
            {
                Tareas cargar = new Tareas();
                this.dataGridViewTareas.AutoGenerateColumns = true;
                this.dataGridViewTareas.DataSource = cargar.BuscarTareaPorIdPoryecto(Convert.ToInt32(idproyecto));
                this.dataGridViewTareas.Columns[0].Visible = false;
                this.dataGridViewTareas.Columns[1].Visible = false;
                this.dataGridViewTareas.Columns[2].Visible = false;
                this.dataGridViewTareas.Columns[4].Visible = false;
                this.dataGridViewTareas.Columns[5].Visible = false;
                this.dataGridViewTareas.Columns[6].Visible = true;
                this.dataGridViewTareas.Columns[7].Visible = false;
                this.dataGridViewTareas.Columns[8].Visible = false;
                this.dataGridViewTareas.Columns[9].Visible = true;
            }
        }

        public void CargarMiembros(int idproyecto)
        {
            if (idproyecto != null)
            {
                ProyectoMiembro miembro = new ProyectoMiembro();
                dataGridViewEquipoProgramadores.AutoGenerateColumns = true;
                dataGridViewEquipoProgramadores.DataSource = miembro.GetProyectoMiembro(Convert.ToInt32(idproyecto));
                this.dataGridViewEquipoProgramadores.Columns[0].Visible = false;
            }
        }

        public void dataGridView1_SelectionChanged(object sender, EventArgs e)
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

        private void dataGridViewTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewTareas.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Nueva")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                if (Convert.ToString(e.Value) == "Iniciada")
                {
                    e.CellStyle.ForeColor = Color.GreenYellow;
                }
                if (Convert.ToString(e.Value) == "QA")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
                if (Convert.ToString(e.Value) == "Terminada")
                {
                    e.CellStyle.ForeColor = Color.LawnGreen;
                }
                if (Convert.ToString(e.Value) == "Cancelada")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        public void CargarEstadoTareaProgra(Frm_RealizarTarea form)
        {
            Tareas cargar = new Tareas();

            // Configura el ComboBox en el formulario pasado como argumento
            form.cmbEstadoTarea.DataSource = cargar.TareaEstado();
            form.cmbEstadoTarea.DisplayMember = "Estado";
            form.cmbEstadoTarea.ValueMember = "EstadoTareaid";
        }
        private void dataGridViewTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewTareas.SelectedRows.Count > 0)
            {
                var frm = new Frm_RealizarTarea();
                CargarEstadoTareaProgra(frm);

                DataTable dataTable = (DataTable)dataGridViewTareas.DataSource;

                frm.TipoOperacion = "Editar";
                DataRow selectedRow = dataTable.Rows[dataGridView1.SelectedRows[0].Index];

                TareaId = dataGridViewTareas.SelectedRows[0].Cells["TareaId"].Value.ToString();

                frm.TareaId = TareaId;

                frm.txtNombreTarea.Text = selectedRow["Nombre de la tarea"].ToString();
                frm.cmbEstadoTarea.Text = selectedRow["Estado"].ToString();
                frm.txtDescripcionTarea.Text = selectedRow["Descripción"].ToString();
                frm.dateTimePickerInicio.Value = DateTime.Parse(selectedRow["Fecha de inicio"].ToString());
                frm.dateTimePickerFin.Value = DateTime.Parse(selectedRow["Fecha final"].ToString());

                // Establece la propiedad FormTareas
                //frm.FormTareas = this;
                // Llamar al método AbrirFormulario con el formulario Frm_NuevaTarea
                AbrirFormulario<Frm_RealizarTarea>(frm);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }
    }



}

