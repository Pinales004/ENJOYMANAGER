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
        public Frm_NuevaTarea()
        {
            InitializeComponent();
            btn_icon_hover.AplicarFormaRedonda(btn_volver);
            btn_icon_hover.AplicarFormaRedonda(btn_guardar);
            btn_icon_hover.AplicarFormaRedonda(btn_limpiar);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_NuevaTarea_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpiarCampos()
        {
            // Limpia los campos del formulario para futuras entradas
            txtNombreTarea.Text = "";
            txtNombreProyecto.Text = "";
            txtDescripcionTarea.Text = "";
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerEntrega.Value = DateTime.Now;
            cmbEstadoTarea.SelectedIndex = -1;
            cmbResponsableTarea.SelectedIndex = -1;
        }

        #region botones
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
