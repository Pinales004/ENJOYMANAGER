namespace PRESENTACION
{
    partial class FormTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTareas));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refrescar = new System.Windows.Forms.PictureBox();
            this.cbmFiltroEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFechFin = new System.Windows.Forms.DateTimePicker();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtResponsable = new System.Windows.Forms.TextBox();
            this.btn_realizar = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_buscar = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_realizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.dataGridView1);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 461);
            this.panelContenedor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 312);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_refrescar);
            this.panel1.Controls.Add(this.cbmFiltroEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateFechFin);
            this.panel1.Controls.Add(this.dateFechaInicio);
            this.panel1.Controls.Add(this.TxtResponsable);
            this.panel1.Controls.Add(this.btn_realizar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbox_buscar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 140);
            this.panel1.TabIndex = 0;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.Location = new System.Drawing.Point(485, 27);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(30, 30);
            this.btn_refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_refrescar.TabIndex = 23;
            this.btn_refrescar.TabStop = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // cbmFiltroEstado
            // 
            this.cbmFiltroEstado.BackColor = System.Drawing.Color.White;
            this.cbmFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmFiltroEstado.FormattingEnabled = true;
            this.cbmFiltroEstado.Location = new System.Drawing.Point(243, 59);
            this.cbmFiltroEstado.Name = "cbmFiltroEstado";
            this.cbmFiltroEstado.Size = new System.Drawing.Size(200, 23);
            this.cbmFiltroEstado.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha de inicio";
            // 
            // DateFechFin
            // 
            this.DateFechFin.Checked = false;
            this.DateFechFin.Location = new System.Drawing.Point(243, 110);
            this.DateFechFin.Name = "DateFechFin";
            this.DateFechFin.Size = new System.Drawing.Size(200, 23);
            this.DateFechFin.TabIndex = 16;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Checked = false;
            this.dateFechaInicio.Location = new System.Drawing.Point(27, 110);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(200, 23);
            this.dateFechaInicio.TabIndex = 15;
            // 
            // TxtResponsable
            // 
            this.TxtResponsable.Location = new System.Drawing.Point(27, 59);
            this.TxtResponsable.Name = "TxtResponsable";
            this.TxtResponsable.PlaceholderText = "Responsable";
            this.TxtResponsable.Size = new System.Drawing.Size(200, 23);
            this.TxtResponsable.TabIndex = 13;
            // 
            // btn_realizar
            // 
            this.btn_realizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_realizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_realizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_realizar.Image")));
            this.btn_realizar.Location = new System.Drawing.Point(674, 12);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(45, 45);
            this.btn_realizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_realizar.TabIndex = 15;
            this.btn_realizar.TabStop = false;
            this.btn_realizar.Click += new System.EventHandler(this.btn_realizar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(449, 27);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 30);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 14;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busqueda de tareas";
            // 
            // txtbox_buscar
            // 
            this.txtbox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_buscar.Location = new System.Drawing.Point(27, 30);
            this.txtbox_buscar.Name = "txtbox_buscar";
            this.txtbox_buscar.PlaceholderText = "Buscar tarea por proyecto";
            this.txtbox_buscar.Size = new System.Drawing.Size(416, 23);
            this.txtbox_buscar.TabIndex = 12;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(776, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(45, 45);
            this.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_editar.TabIndex = 11;
            this.btn_editar.TabStop = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(827, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(45, 45);
            this.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.TabStop = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(725, 12);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(45, 45);
            this.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.TabStop = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FormTareas";
            this.Text = "FormTareas";
            this.Load += new System.EventHandler(this.FormTareas_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_realizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            this.ResumeLayout(false);

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
        private PictureBox btn_realizar;
        public DataGridView dataGridView1;
        private TextBox TxtResponsable;
        private DateTimePicker DateFechFin;
        private DateTimePicker dateFechaInicio;
        private Label label3;
        private Label label2;
        private PictureBox btn_refrescar;
        private ComboBox cbmFiltroEstado;
    }
}