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

        private string IdProyecto;
        public FrmEquipoProgramadores(string idProyecto)
        {
            InitializeComponent();
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
    }
}
