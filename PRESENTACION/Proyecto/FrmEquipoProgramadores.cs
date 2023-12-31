﻿using DOMINIO.Models;
using System.Runtime.InteropServices;

namespace PRESENTACION.Proyecto
{
    public partial class FrmEquipoProgramadores : Form
    {

        private string IdProyecto;
        public FrmEquipoProgramadores(string idProyecto)
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_volver);
            btn_icon_hover.AplicarFormaRedonda(btn_guardar);
            btn_icon_hover.AplicarFormaRedonda(btn_eliminar);
            IdProyecto = idProyecto;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmEquipoProgramadores_Load(object sender, EventArgs e)
        {
            CagarProgramadores();
            CargarMiembros();

            // Suscribirse al evento TemaCambiado del formulario principal
            FormPrincipal.TemaCambiado += FormPrincipal_TemaCambiado;

            // Obtener y aplicar el tema actual
            string temaActual = FormPrincipal.TemaSeleccionado;
            panel1.BackColor = TemaColores.PanelPadre;
            dataGridView1.BackgroundColor = TemaColores.BarraTitulo;
            dataGridView1.GridColor = TemaColores.BarraTitulo;
        }
        private void FormPrincipal_TemaCambiado(object sender, EventArgs e)
        {
            // El tema en el formulario principal cambió, actualizar el tema en este formulario
            string temaActual = FormPrincipal.TemaSeleccionado;
            AplicarTema(temaActual);
        }
        private void AplicarTema(string tema)
        {
            panel1.BackColor = TemaColores.PanelPadre;
            dataGridView1.BackgroundColor = TemaColores.BarraTitulo;
            dataGridView1.GridColor = TemaColores.BarraTitulo;
        }

        public void CagarProgramadores()
        {

            ProyectoMiembro miembro = new ProyectoMiembro();

            this.CmbProgramadores.DataSource = miembro.GetUsuarioMiembrosProgramador();
            this.CmbProgramadores.DisplayMember = "Nombres";
            this.CmbProgramadores.ValueMember = "IdUsuario";
            //this.dataGridView1.Columns[0].Visible = false;
        }

        private void CargarMiembros()
        {
            ProyectoMiembro miembro = new ProyectoMiembro();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = miembro.GetProyectoMiembro(Convert.ToInt32(IdProyecto.ToString()));
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void FrmEquipoProgramadores_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (CmbProgramadores.SelectedIndex == -1)
            {
                MostrarError("Debe seleccionar un miembro para el proyecto.");
            }
            else
            {
                AgregarMiembro();
                CargarMiembros();
            }
        }

        private void AgregarMiembro()
        {

            ProyectoMiembro miembro = new ProyectoMiembro();
            try
            {
                // Llamar al método que puede lanzar la excepción
                miembro.InsertarMiembros(Convert.ToInt32(IdProyecto)
                    , Convert.ToInt32(this.CmbProgramadores.SelectedValue));
                // Si no se lanza ninguna excepción, significa que la inserción fue exitosa
                MessageBox.Show("Miembro agregado exitosamente al proyecto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                // Capturar la excepción específica lanzada por el método
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes realizar otras acciones según tus necesidades aquí
            }
            catch (Exception ex)
            {
                // Capturar otras excepciones que no sean InvalidOperationException
                MessageBox.Show("Se produjo un error al agregar el miembro al proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes registrar o manejar de otra manera estas excepciones generales
            }

        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ProyectoMiembro miembro = new ProyectoMiembro();

            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Preguntar al usuario si está seguro de eliminar el proyecto
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este miembro del equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    miembro.BorrarMiembroProyecto(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    CargarMiembros();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para poder eliminar al integrante");
            }

        }

        #region btn_hover
        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
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
        private void btnEquipoProyecto_MouseEnter(object sender, EventArgs e)
        {
            btn_icon_hover.CambiarColorHover(sender, e);
        }
        private void btnEquipoProyecto_MouseLeave(object sender, EventArgs e)
        {
            btn_icon_hover.RestaurarColorOriginal(sender, e);
        }
        #endregion

    }
}
