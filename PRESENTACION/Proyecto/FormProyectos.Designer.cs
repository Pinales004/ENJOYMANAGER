﻿namespace PRESENTACION
{
    partial class FormProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectos));
            panelContenedor = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            dataGridViewEquipoProgramadores = new DataGridView();
            dataGridViewTareas = new DataGridView();
            lblDGVequipo = new Label();
            lblDGVtareas = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btn_buscar = new PictureBox();
            label1 = new Label();
            txtbox_buscar = new TextBox();
            btn_editar = new PictureBox();
            btn_eliminar = new PictureBox();
            btn_agregar = new PictureBox();
            panelContenedor.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipoProgramadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(groupBox1);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(884, 461);
            panelContenedor.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridViewEquipoProgramadores);
            groupBox1.Controls.Add(dataGridViewTareas);
            groupBox1.Controls.Add(lblDGVequipo);
            groupBox1.Controls.Add(lblDGVtareas);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(485, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 384);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(176, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 66;
            label3.Text = "Detalle";
            // 
            // dataGridViewEquipoProgramadores
            // 
            dataGridViewEquipoProgramadores.AllowUserToAddRows = false;
            dataGridViewEquipoProgramadores.AllowUserToDeleteRows = false;
            dataGridViewEquipoProgramadores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewEquipoProgramadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEquipoProgramadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipoProgramadores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewEquipoProgramadores.Location = new Point(9, 213);
            dataGridViewEquipoProgramadores.Name = "dataGridViewEquipoProgramadores";
            dataGridViewEquipoProgramadores.RowTemplate.Height = 25;
            dataGridViewEquipoProgramadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipoProgramadores.Size = new Size(381, 165);
            dataGridViewEquipoProgramadores.TabIndex = 63;
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.AllowUserToAddRows = false;
            dataGridViewTareas.AllowUserToDeleteRows = false;
            dataGridViewTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTareas.Location = new Point(6, 36);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.RowTemplate.Height = 25;
            dataGridViewTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTareas.Size = new Size(384, 156);
            dataGridViewTareas.TabIndex = 62;
            dataGridViewTareas.CellDoubleClick += dataGridViewTareas_CellDoubleClick;
            dataGridViewTareas.CellFormatting += dataGridViewTareas_CellFormatting;
            // 
            // lblDGVequipo
            // 
            lblDGVequipo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDGVequipo.AutoSize = true;
            lblDGVequipo.ForeColor = SystemColors.ButtonHighlight;
            lblDGVequipo.Location = new Point(15, 195);
            lblDGVequipo.Name = "lblDGVequipo";
            lblDGVequipo.Size = new Size(213, 15);
            lblDGVequipo.TabIndex = 64;
            lblDGVequipo.Text = "Equipo de programadores del proyecto";
            // 
            // lblDGVtareas
            // 
            lblDGVtareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDGVtareas.AutoSize = true;
            lblDGVtareas.ForeColor = SystemColors.ButtonHighlight;
            lblDGVtareas.Location = new Point(6, 18);
            lblDGVtareas.Name = "lblDGVtareas";
            lblDGVtareas.Size = new Size(108, 15);
            lblDGVtareas.TabIndex = 65;
            lblDGVtareas.Text = "Tareas del proyecto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(467, 384);
            dataGridView1.TabIndex = 61;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbox_buscar);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(btn_agregar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 68);
            panel1.TabIndex = 2;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.Location = new Point(449, 27);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(30, 30);
            btn_buscar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_buscar.TabIndex = 8;
            btn_buscar.TabStop = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 7;
            label1.Text = "Busqueda de proyecto";
            // 
            // txtbox_buscar
            // 
            txtbox_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_buscar.Cursor = Cursors.IBeam;
            txtbox_buscar.Location = new Point(27, 30);
            txtbox_buscar.Name = "txtbox_buscar";
            txtbox_buscar.PlaceholderText = "Buscar Proyecto por Nombre";
            txtbox_buscar.Size = new Size(416, 23);
            txtbox_buscar.TabIndex = 6;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(776, 12);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(45, 45);
            btn_editar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_editar.TabIndex = 5;
            btn_editar.TabStop = false;
            btn_editar.Click += btn_editar_Click;
            btn_editar.MouseEnter += btn_editar_MouseEnter;
            btn_editar.MouseLeave += btn_editar_MouseLeave;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(827, 12);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(45, 45);
            btn_eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_eliminar.TabIndex = 4;
            btn_eliminar.TabStop = false;
            btn_eliminar.Click += btn_eliminar_Click;
            btn_eliminar.MouseEnter += btn_eliminar_MouseEnter;
            btn_eliminar.MouseLeave += btn_eliminar_MouseLeave;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Image = (Image)resources.GetObject("btn_agregar.Image");
            btn_agregar.Location = new Point(725, 12);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(45, 45);
            btn_agregar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_agregar.TabIndex = 2;
            btn_agregar.TabStop = false;
            btn_agregar.Click += btn_agregar_Click;
            btn_agregar.MouseEnter += btn_agregar_MouseEnter;
            btn_agregar.MouseLeave += btn_agregar_MouseLeave;
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(884, 461);
            Controls.Add(panelContenedor);
            ForeColor = SystemColors.ControlText;
            Name = "FormProyectos";
            Text = "ENJOYMANAGEMENT-Proyectos";
            Load += FormProyectos_Load;
            panelContenedor.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipoProgramadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private Panel panel1;
        private PictureBox btn_buscar;
        private Label label1;
        private TextBox txtbox_buscar;
        private PictureBox btn_editar;
        private PictureBox btn_eliminar;
        private PictureBox btn_agregar;
        public DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label3;
        private DataGridView dataGridViewEquipoProgramadores;
        private DataGridView dataGridViewTareas;
        private Label lblDGVequipo;
        private Label lblDGVtareas;
    }
}