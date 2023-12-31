﻿using Comun.Biblioteca.Enums;
using Comun.Cache;
using DATOS.Tareas;
using DOMINIO.Models;
using PRESENTACION.Administracion_Tareas.Anexo;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PRESENTACION.Administracion_Tareas
{
    public partial class Frm_RealizarTarea : Form
    {
        public String TipoOperacion = "Agregar";
        public string TareaId;

        private bool modoEdicion = false;

        public int ComentarioId;
        public Frm_RealizarTarea()
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

        private void Frm_RealizarTarea_Load(object sender, EventArgs e)
        {
            txtNombreTarea.MaxLength = 100;
            txtDescripcionTarea.MaxLength = 100;
            txtComentario.MaxLength = 255;

            CargarAnexos();
            CargarComentarios();
            txtNombreTarea.Enabled = false;
            txtDescripcionTarea.Enabled = false;
            dateTimePickerInicio.Enabled = false;
            dateTimePickerFin.Enabled = false;

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

        private void Frm_RealizarTarea_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtComentario.Text = "";
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == "Agregar")
            {

            }
            else if (TipoOperacion == "Editar")
            {
                Tareas cargar = new Tareas();
                int tareaId = Convert.ToInt32(TareaId);
                int nuevoEstadoTareaId = Convert.ToInt32(cmbEstadoTarea.SelectedValue);

                cargar.UpdateEstadoTarea(tareaId, nuevoEstadoTareaId);

                if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Gerente)
                {
                    // Llama al método CargarTareas del formulario FormTareas para actualizar el DataGridView
                    if (FormTareas != null)
                    {
                        FormTareas.CargarTareasGerentes();
                    }
                }
                if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Programador)
                {
                    // Llama al método CargarTareas del formulario FormTareas para actualizar el DataGridView
                    if (FormTareas != null)
                    {
                        FormTareas.CargarTareasProgrmadores();
                    }
                }

                MessageBox.Show("La tarea se ha realizado correctamente.");
                this.Hide();
            }
        }

        #region Anexos
        private void bntNuevoAnexo_Click(object sender, EventArgs e)
        {
            AgregarAnexo fg = new AgregarAnexo(TareaId);
            fg.ShowDialog();
            CargarAnexos();
        }


        public void CargarAnexos()
        {
            AnexoTarea cargar = new AnexoTarea();
            this.datagridAnexo.AutoGenerateColumns = true; // Desactiva la generación automática de columnas
            this.datagridAnexo.DataSource = cargar.GetAnexosPorTarea(Convert.ToInt32(TareaId));

            // Ocultar las columnas que no deseas mostrar
            this.datagridAnexo.Columns["TareaId"].Visible = false;
            this.datagridAnexo.Columns["AnexoId"].Visible = false;

            // Asegúrate de que las columnas "Nombre" y "Extension" estén visibles
            this.datagridAnexo.Columns["Nombre"].Visible = true;
            this.datagridAnexo.Columns[4].Visible = true;
            this.datagridAnexo.Columns[3].Visible = false;
            this.datagridAnexo.Columns[5].Visible = true;
            this.datagridAnexo.Columns[6].Visible = true;

        }
        //Anexo


        private void bntVerAnexo_Click(object sender, EventArgs e)
        {
            if (datagridAnexo.SelectedRows.Count > 0)
            {
                try
                {
                    AnexoTarea Ver = new AnexoTarea();
                    int id = Convert.ToInt32(datagridAnexo.CurrentRow.Cells["AnexoId"].Value);

                    Anexos Anexar = new Anexos(id);
                    List<Anexos> Lista = Ver.FiltroDocumentos(Anexar);

                    foreach (Anexos item in Lista)
                    {
                        // Carpeta temporal
                        string direccion = AppDomain.CurrentDomain.BaseDirectory;
                        string carpeta = Path.Combine(direccion, "temp");
                        string UbicacionCompleta = Path.Combine(carpeta, item.Extension);

                        if (!Directory.Exists(carpeta))
                        {
                            Directory.CreateDirectory(carpeta);
                        }

                        // Verifica si el archivo ya existe y elimínalo si es necesario
                        if (File.Exists(UbicacionCompleta))
                        {
                            File.Delete(UbicacionCompleta);
                        }

                        // Escribe el archivo
                        File.WriteAllBytes(UbicacionCompleta, item.Documento);

                        // Abre el archivo con la aplicación predeterminada
                        Process.Start(new ProcessStartInfo(UbicacionCompleta)
                        {
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Maneja las excepciones adecuadamente, por ejemplo, muestra un mensaje de error.
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EliminarAnexo_Click(object sender, EventArgs e)
        {
            AnexoTarea anexo = new AnexoTarea();
            int anexoId = 0;
            if (datagridAnexo.SelectedRows.Count > 0)
            {
                // Obtén el anexo seleccionado
                DataGridViewRow selectedRow = datagridAnexo.SelectedRows[0];
                anexoId = (int)selectedRow.Cells["AnexoId"].Value; // Asume que "AnexoId" es el nombre de la columna con el ID del anexo

                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este anexo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Elimina el anexo
                    anexo.SoftDeleteAnexo(anexoId);

                    // Vuelve a cargar los anexos después de eliminar
                    CargarAnexos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un anexo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }





        #endregion


        #region Comentarios

        public void CargarComentarios()
        {

            ComentarioTarea comentarios = new ComentarioTarea();
            this.dataGridComentarios.AutoGenerateColumns = true; // Desactiva la generación automática de columnas
            this.dataGridComentarios.DataSource = comentarios.GetComentariosPorIdTarea(Convert.ToInt32(TareaId));

            this.dataGridComentarios.Columns["Comentario"].Visible = true;
            this.dataGridComentarios.Columns["IdUsuario"].Visible = false;
            this.dataGridComentarios.Columns["FechaCreacion"].Visible = true;
            this.dataGridComentarios.Columns["UsuarioCrea"].Visible = true;

            this.dataGridComentarios.Columns["ComentarioTareaId"].Visible = false;
            this.dataGridComentarios.Columns["TareaId"].Visible = false;
            this.dataGridComentarios.Columns["Borrado"].Visible = false;
        }

        private void bntAgregarComentario_Click(object sender, EventArgs e)
        {
            ComentarioTarea comentario = new ComentarioTarea();
            if (!string.IsNullOrWhiteSpace(this.txtComentario.Text))
            {

                if (this.txtComentario.Text.Length > 255)
                {
                    MessageBox.Show("El comentario debe ser menor a 255 caracteres");
                }

                if (modoEdicion && ComentarioId > 0)
                {
                    ComentariosTarea comentariosActualiza = new ComentariosTarea(Convert.ToInt32(ComentarioId), txtComentario.Text);
                    // Estás en modo de edición, actualiza el comentario existente
                    comentario.UpdateComentarioTarea(comentariosActualiza);
                    CargarComentarios();

                }
                else
                {
                    ComentariosTarea comentarios = new ComentariosTarea(
                         this.txtComentario.Text,
                         Convert.ToInt32(TareaId),
                         UserLoginCache.IdUsuario,
                         DateTime.Now
                         );

                    comentario.InsertComentarioTarea(comentarios);
                    CargarComentarios();
                }
                modoEdicion = false;
                txtComentario.Text = "";
            }
        }

        private void BtnEliminarComentario_Click(object sender, EventArgs e)
        {
            ComentarioTarea comentario = new ComentarioTarea();
            if (dataGridComentarios.SelectedRows.Count > 0)
            {
                // Obtén el comentario seleccionado
                DataGridViewRow selectedRow = dataGridComentarios.SelectedRows[0];
                ComentarioId = (int)selectedRow.Cells["ComentarioTareaId"].Value; // Asume que "ComentarioTareaId" es el nombre de la columna con el ID del comentario

                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este comentario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LimpiarCampos();

                    // Elimina el comentario
                    comentario.SoftDeleteComentarioTarea(ComentarioId);

                    // Vuelve a cargar los comentarios después de eliminar
                    CargarComentarios();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un comentario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntEditarComentario_Click(object sender, EventArgs e)
        {
            if (dataGridComentarios.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dataGridComentarios.SelectedRows[0];

                // Asegúrate de que la columna "Comentario" existe en tu DataGridView y tiene el nombre correcto
                if (selectedRow.Cells["Comentario"].Value != null)
                {
                    // Obtén el valor de la celda de la columna "Comentario"
                    string comentario = selectedRow.Cells["Comentario"].Value.ToString();
                    ComentarioId = (int)selectedRow.Cells["ComentarioTareaId"].Value;
                    // Asigna el valor al TextBox
                    txtComentario.Text = comentario;
                    modoEdicion = true;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila en el DataGridView para llenar el TextBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


    }
}
