using Comun.Biblioteca.Enums;
using Comun.Cache;
using System.Runtime.InteropServices;
//hello word again
namespace PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deceas cerrar la aplicacion", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginCache.Nombres;
            lblApellido.Text = UserLoginCache.Apellidos;

            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Administrador)
            {
                lblRol.Text = "Administrador";
                btnUsuarios.Visible = true;
                btnProyectos.Visible = false;
                btnTareas.Visible = false;
                AbrirFormulario<Frm_Usuarios>();

            }
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Gerente)
            {
                lblRol.Text = "Gerente";
                btnUsuarios.Visible = false;
                btnProyectos.Visible = true;
                btnTareas.Visible = true;
                AbrirFormulario<FormProyectos>();
            }
            if (UserLoginCache.RolUsuario == (int)EnumRolUsuario.Puesto.Programador)
            {
                lblRol.Text = "Programador";
                btnUsuarios.Visible = false;
                btnProyectos.Visible = false;
                btnTareas.Visible = true;
                AbrirFormulario<FormTareas>();
            }
        }

        //Constructor
        //public FormMenuPrincipal()
        //{
        //    InitializeComponent();
        //    //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
        //    this.SetStyle(ControlStyles.ResizeRedraw, true);
        //    this.DoubleBuffered = true;
        //}

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Usuarios>();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProyectos>();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTareas>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        #endregion

        //Metodo abrir formulario dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                if (formulario is FormProyectos)
                {
                    (formulario as FormProyectos).FormProyectos_Load(this, EventArgs.Empty);
                    (formulario as FormProyectos).dataGridView1_SelectionChanged(this, EventArgs.Empty);
                }
                formulario.BringToFront();
            }
            formulario.Parent = panelFormularios; // Establecer el formulario como hijo del panelFormularios
            formulario.Dock = DockStyle.Fill; // Asegurarse de que el formulario ocupe todo el espacio del panel
        }
    }
}