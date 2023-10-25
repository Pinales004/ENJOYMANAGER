namespace PRESENTACION
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnCerrarSesion = new Button();
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            panelMenu = new Panel();
            pboxCerrarSesion = new PictureBox();
            pboxTareas = new PictureBox();
            pboxProyectos = new PictureBox();
            pboxUsuarios = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblRol = new Label();
            pictureBox1 = new PictureBox();
            btnUsuarios = new Button();
            btnTareas = new Button();
            btnProyectos = new Button();
            panelBarraTitulo = new Panel();
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(54, 452);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(158, 30);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1150, 550);
            panelContenedor.TabIndex = 1;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.FromArgb(15, 15, 15);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(233, 47);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(917, 503);
            panelFormularios.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(pboxCerrarSesion);
            panelMenu.Controls.Add(pboxTareas);
            panelMenu.Controls.Add(pboxProyectos);
            panelMenu.Controls.Add(pboxUsuarios);
            panelMenu.Controls.Add(lblNombre);
            panelMenu.Controls.Add(lblApellido);
            panelMenu.Controls.Add(lblRol);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnTareas);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnProyectos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 47);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 503);
            panelMenu.TabIndex = 1;
            // 
            // pboxCerrarSesion
            // 
            pboxCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pboxCerrarSesion.BackColor = Color.Transparent;
            pboxCerrarSesion.Cursor = Cursors.Hand;
            pboxCerrarSesion.Image = (Image)resources.GetObject("pboxCerrarSesion.Image");
            pboxCerrarSesion.Location = new Point(25, 452);
            pboxCerrarSesion.Name = "pboxCerrarSesion";
            pboxCerrarSesion.Size = new Size(30, 30);
            pboxCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCerrarSesion.TabIndex = 12;
            pboxCerrarSesion.TabStop = false;
            // 
            // pboxTareas
            // 
            pboxTareas.BackColor = Color.Transparent;
            pboxTareas.Cursor = Cursors.Hand;
            pboxTareas.Image = (Image)resources.GetObject("pboxTareas.Image");
            pboxTareas.Location = new Point(25, 214);
            pboxTareas.Name = "pboxTareas";
            pboxTareas.Size = new Size(30, 30);
            pboxTareas.SizeMode = PictureBoxSizeMode.Zoom;
            pboxTareas.TabIndex = 10;
            pboxTareas.TabStop = false;
            // 
            // pboxProyectos
            // 
            pboxProyectos.BackColor = Color.Transparent;
            pboxProyectos.Cursor = Cursors.Hand;
            pboxProyectos.Image = (Image)resources.GetObject("pboxProyectos.Image");
            pboxProyectos.Location = new Point(25, 165);
            pboxProyectos.Name = "pboxProyectos";
            pboxProyectos.Size = new Size(30, 30);
            pboxProyectos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxProyectos.TabIndex = 9;
            pboxProyectos.TabStop = false;
            // 
            // pboxUsuarios
            // 
            pboxUsuarios.BackColor = Color.Transparent;
            pboxUsuarios.Cursor = Cursors.Hand;
            pboxUsuarios.Image = (Image)resources.GetObject("pboxUsuarios.Image");
            pboxUsuarios.Location = new Point(25, 115);
            pboxUsuarios.Name = "pboxUsuarios";
            pboxUsuarios.Size = new Size(30, 30);
            pboxUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUsuarios.TabIndex = 8;
            pboxUsuarios.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(103, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 19);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "nombre/s";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(103, 36);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(62, 19);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "apellidos";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.Location = new Point(103, 7);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(25, 19);
            lblRol.TabIndex = 5;
            lblRol.Text = "rol";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.Location = new Point(54, 115);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(158, 30);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnTareas
            // 
            btnTareas.Cursor = Cursors.Hand;
            btnTareas.FlatAppearance.BorderSize = 0;
            btnTareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnTareas.FlatStyle = FlatStyle.Flat;
            btnTareas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTareas.ForeColor = Color.Gainsboro;
            btnTareas.Location = new Point(54, 214);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(158, 30);
            btnTareas.TabIndex = 4;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Cursor = Cursors.Hand;
            btnProyectos.FlatAppearance.BorderSize = 0;
            btnProyectos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnProyectos.FlatStyle = FlatStyle.Flat;
            btnProyectos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProyectos.ForeColor = Color.Gainsboro;
            btnProyectos.Location = new Point(54, 165);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(158, 30);
            btnProyectos.TabIndex = 3;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = SystemColors.ControlLight;
            panelBarraTitulo.Controls.Add(panel1);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1150, 47);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 100);
            panel1.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1066, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 20);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 7;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1092, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 20);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 6;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1092, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 20);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 5;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1118, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 550);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1120, 450);
            Name = "FormPrincipal";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private Panel panelContenedor;
        private Panel panelFormularios;
        private Panel panelMenu;
        private Panel panelBarraTitulo;
        private Button btnProyectos;
        private Button btnUsuarios;
        private Button btnTareas;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblRol;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pboxTareas;
        private PictureBox pboxProyectos;
        private PictureBox pboxUsuarios;
        private PictureBox pboxCerrarSesion;
    }
}