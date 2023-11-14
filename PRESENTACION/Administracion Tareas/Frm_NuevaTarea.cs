using DATOS.Tareas;
using DOMINIO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION.Administracion_Tareas
{
    public partial class Frm_NuevaTarea : Form
    {
        public String TipoOperacion = "Insertar";
        public string TareaId;
        public Frm_NuevaTarea()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_volver);
            btn_icon_hover.AplicarFormaRedonda(btn_guardar);
            btn_icon_hover.AplicarFormaRedonda(btn_limpiar);
        }
        public FormTareas FormTareas { get; set; }

        FormTareas form = new FormTareas();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_NuevaTarea_Load(object sender, EventArgs e)
        {
           
        }


        private void Frm_NuevaTarea_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void EstadoTareas()
        {

            Tareas cargar = new Tareas();

            this.cmbEstadoTarea.DataSource = cargar.TareaEstado();
            this.cmbEstadoTarea.DisplayMember = "Estado";
            this.cmbEstadoTarea.ValueMember = "EstadoTareaid";
        }

        private void ListadoProyectos()
        {

            Tareas cargar = new Tareas();

            this.CmbNombreProyecto.DataSource = cargar.CargarListadoProyectos();
            this.CmbNombreProyecto.DisplayMember = "NombreProyecto";
            this.CmbNombreProyecto.ValueMember = "IdProyecto";
        }

        private void ListaMiembros(int IdProyecto)
        {

            Tareas cargar = new Tareas();

            this.cmbResponsableTarea.DataSource = cargar.CargarMiembros(IdProyecto);
            this.cmbResponsableTarea.DisplayMember = "Nombres";
            this.cmbResponsableTarea.ValueMember = "ID";
        }


        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombreTarea.Text = "";
            txtDescripcionTarea.Text = "";
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerEntrega.Value = DateTime.Now;
            cmbEstadoTarea.SelectedIndex = -1;
            cmbResponsableTarea.SelectedIndex = -1;
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
        #endregion
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

        private void CmbNombreProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbNombreProyecto.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)CmbNombreProyecto.SelectedItem;

                // Accede al valor del campo "ID" de la fila seleccionada
                int idProyectoSeleccionado = Convert.ToInt32(selectedRow["IdProyecto"]);

                // Llamamos al método ListaMiembros con el ID del proyecto seleccionado
                ListaMiembros(idProyectoSeleccionado);
                // Verifica si el ComboBox cmbResponsableTarea está vacío
                if (cmbResponsableTarea.Items.Count == 0)
                {
                    // Mostrar un mensaje si está vacío
                    MessageBox.Show("No hay miembros disponibles para este proyecto.", "Mensaje");
                }
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == "Insertar")
            {

                // Realiza las validaciones necesarias en la capa de presentación
                if (string.IsNullOrWhiteSpace(txtNombreTarea.Text))
                {
                    MessageBox.Show("El nombre de la tarea es obligatorio.");
                    return; // Detener la operación de guardar
                }
                else
                {
                    EstadoTareas();
                    ListadoProyectos();

                    // Si todas las validaciones pasan, crea un objeto TareasProyecto y guarda la tarea
                    TareasProyecto nuevaTarea = new TareasProyecto
                    (
                        Convert.ToInt32(CmbNombreProyecto.SelectedValue), // Agrega una coma para separar las propiedades
                        Convert.ToInt32(cmbEstadoTarea.SelectedValue), // Asigna el ID del estado de la tarea adecuado
                        Convert.ToInt32(cmbResponsableTarea.SelectedValue), // Asigna el ID del miembro de proyecto adecuado
                        txtNombreTarea.Text,
                        txtDescripcionTarea.Text,
                        dateTimePickerInicio.Value,
                        dateTimePickerEntrega.Value
                    );

                    // Llama al método para guardar la tarea
                    Tareas cargar = new Tareas();
                    cargar.InsertTarea(nuevaTarea);
                }

            }else if (TipoOperacion == "Editar")
            {
              
                Tareas cargar = new Tareas();
                TareasProyecto ActualizarTarea = new TareasProyecto
                    (
                        Convert.ToInt32(TareaId),
                        Convert.ToInt32(CmbNombreProyecto.SelectedValue), // Agrega una coma para separar las propiedades
                        Convert.ToInt32(cmbEstadoTarea.SelectedValue), // Asigna el ID del estado de la tarea adecuado
                        Convert.ToInt32(cmbResponsableTarea.SelectedValue), // Asigna el ID del miembro de proyecto adecuado
                        txtNombreTarea.Text,
                        txtDescripcionTarea.Text,
                        dateTimePickerInicio.Value,
                        dateTimePickerEntrega.Value
                    ) ;

                cargar.UpdateTarea(ActualizarTarea);


            }

            form.CargarTareas();
            // Llama al método CargarTareas del formulario FormTareas para actualizar el DataGridView
            if (FormTareas != null)
            {
                FormTareas.CargarTareas();
            }
            MessageBox.Show("La tarea se ha guardado correctamente.");
            this.Hide();


        }
    }
}
