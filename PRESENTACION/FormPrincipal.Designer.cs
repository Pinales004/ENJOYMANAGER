﻿namespace PRESENTACION
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
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btnCerrarSesion = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblApellido = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            panelBarraTitulo = new Panel();
            panel2 = new Panel();
            btnUsuarios = new Button();
            btnProyectos = new Button();
            btnTareas = new Button();
            label1 = new Label();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelFormularios.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1150, 590);
            panelContenedor.TabIndex = 1;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.FromArgb(15, 15, 15);
            panelFormularios.Controls.Add(panel1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(0, 60);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1150, 530);
            panelFormularios.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 30);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 6);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 11;
            label2.Text = "Tema";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveBorder;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Azul", "Celeste", "Marrón", "Rosa", "Verde", "Acua", "Morado" });
            comboBox1.Location = new Point(223, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(12, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(99, 30);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(lblApellido);
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Controls.Add(lblRol);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.ForeColor = Color.Gainsboro;
            flowLayoutPanel1.Location = new Point(479, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(659, 24);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BorderStyle = BorderStyle.FixedSingle;
            lblApellido.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(591, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(65, 18);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(514, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "nombre/s";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BorderStyle = BorderStyle.FixedSingle;
            lblRol.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.Location = new Point(481, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 18);
            lblRol.TabIndex = 5;
            lblRol.Text = "rol";
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = SystemColors.ControlLight;
            panelBarraTitulo.Controls.Add(panel2);
            panelBarraTitulo.Controls.Add(label1);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1150, 60);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnProyectos);
            panel2.Controls.Add(btnTareas);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 30);
            panel2.TabIndex = 9;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.Location = new Point(3, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(99, 24);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Cursor = Cursors.Hand;
            btnProyectos.FlatAppearance.BorderSize = 0;
            btnProyectos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnProyectos.FlatStyle = FlatStyle.Flat;
            btnProyectos.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProyectos.ForeColor = Color.Gainsboro;
            btnProyectos.Location = new Point(108, 3);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(99, 24);
            btnProyectos.TabIndex = 3;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnTareas
            // 
            btnTareas.Cursor = Cursors.Hand;
            btnTareas.FlatAppearance.BorderSize = 0;
            btnTareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnTareas.FlatStyle = FlatStyle.Flat;
            btnTareas.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTareas.ForeColor = Color.Gainsboro;
            btnTareas.Location = new Point(3, 3);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(99, 24);
            btnTareas.TabIndex = 4;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            btnTareas.Click += btnTareas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(240, 23);
            label1.TabIndex = 8;
            label1.Text = "ENJOY MANAGEMENT";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1066, 7);
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
            btnMaximizar.Location = new Point(1092, 7);
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
            btnRestaurar.Location = new Point(1092, 7);
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
            btnCerrar.Location = new Point(1118, 7);
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
            ClientSize = new Size(1150, 590);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1120, 590);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENJOYMANAGEMENT";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private Panel panelFormularios;
        private Panel panelBarraTitulo;
        private Button btnProyectos;
        private Button btnUsuarios;
        private Button btnTareas;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btnCerrarSesion;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblRol;
        private ComboBox comboBox1;
        private Label label2;
    }
}