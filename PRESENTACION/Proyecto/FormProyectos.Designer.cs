namespace PRESENTACION
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btn_buscar = new PictureBox();
            label1 = new Label();
            txtbox_buscar = new TextBox();
            btn_editar = new PictureBox();
            btn_eliminar = new PictureBox();
            btn_agregar = new PictureBox();
            panelContenedor.SuspendLayout();
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
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(884, 461);
            panelContenedor.TabIndex = 2;
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
            dataGridView1.Size = new Size(860, 384);
            dataGridView1.TabIndex = 61;
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
            Text = "FormProyectos";
            Load += FormProyectos_Load;
            panelContenedor.ResumeLayout(false);
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
    }
}