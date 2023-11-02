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

namespace PRESENTACION.Proyecto
{
    public partial class FrmEquipoProgramadores : Form
    {
        public FrmEquipoProgramadores()
        {
            InitializeComponent();
        }

        Frm_NuevoProyecto newproyec = new Frm_NuevoProyecto();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmEquipoProgramadores_Load(object sender, EventArgs e)
        {
            CagarProgramadores();
        }

        public void CagarProgramadores() {

            ProyectoMiembro miembro = new ProyectoMiembro();

            this.CmbProgramadores.DataSource = miembro.GetUsuarioMiembrosProgramador();
            this.CmbProgramadores.DisplayMember = "Nombres";
            this.CmbProgramadores.ValueMember = "IdUsuario";


        }

        private void CargarMiembros()
        {
            ProyectoMiembro miembro = new ProyectoMiembro();
            dataGridView1.AutoGenerateColumns = true;
           // dataGridView1.DataSource =;

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
            }
        }

        private void AgregarMiembro() {

            ProyectoMiembro miembro = new ProyectoMiembro();
            miembro.InsertarMiembros(Convert.ToInt32(newproyec.IdProyecto.Text)
                                    , Convert.ToInt32(this.CmbProgramadores.SelectedValue));


        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
