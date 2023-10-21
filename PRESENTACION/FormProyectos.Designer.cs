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
            panelContenedor = new Panel();
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_agregar = new Button();
            txtDescripcionProyecto = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            dateTimePickerEntrega = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbEstadoProyecto = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(btn_limpiar);
            panelContenedor.Controls.Add(btn_eliminar);
            panelContenedor.Controls.Add(btn_editar);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(884, 461);
            panelContenedor.TabIndex = 2;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.Location = new Point(797, 269);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 56;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar.ForeColor = Color.Black;
            btn_eliminar.Location = new Point(797, 240);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 55;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.ForeColor = Color.Black;
            btn_editar.Location = new Point(797, 211);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 54;
            btn_editar.Text = "EDITAR";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(779, 248);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 195);
            panel1.TabIndex = 2;
            panel1.Resize += panel1_Resize;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(txtDescripcionProyecto);
            groupBox1.Controls.Add(materialTextBox21);
            groupBox1.Controls.Add(dateTimePickerEntrega);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Controls.Add(labelFechaEntrega);
            groupBox1.Controls.Add(labelFechaInicio);
            groupBox1.Controls.Add(materialLabel7);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(cmbEstadoProyecto);
            groupBox1.Controls.Add(txtNombreProyecto);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 195);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_agregar.ForeColor = Color.Black;
            btn_agregar.Location = new Point(640, 166);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 64;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionProyecto
            // 
            txtDescripcionProyecto.AutoSize = true;
            txtDescripcionProyecto.Depth = 0;
            txtDescripcionProyecto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcionProyecto.Location = new Point(12, 102);
            txtDescripcionProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            txtDescripcionProyecto.Size = new Size(174, 19);
            txtDescripcionProyecto.TabIndex = 63;
            txtDescripcionProyecto.Text = "Descripción del proyecto";
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(12, 124);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(384, 48);
            materialTextBox21.TabIndex = 62;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Location = new Point(640, 122);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(233, 23);
            dateTimePickerEntrega.TabIndex = 61;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(640, 38);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(233, 23);
            dateTimePickerInicio.TabIndex = 60;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Depth = 0;
            labelFechaEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaEntrega.Location = new Point(640, 102);
            labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(123, 19);
            labelFechaEntrega.TabIndex = 59;
            labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Depth = 0;
            labelFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaInicio.Location = new Point(640, 20);
            labelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(107, 19);
            labelFechaInicio.TabIndex = 58;
            labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(219, 15);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(140, 19);
            materialLabel7.TabIndex = 57;
            materialLabel7.Text = "Estado del proyecto";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 20);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(147, 19);
            materialLabel1.TabIndex = 56;
            materialLabel1.Text = "Nombre del proyecto";
            // 
            // cmbEstadoProyecto
            // 
            cmbEstadoProyecto.AutoResize = false;
            cmbEstadoProyecto.BackColor = Color.FromArgb(255, 255, 255);
            cmbEstadoProyecto.Depth = 0;
            cmbEstadoProyecto.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEstadoProyecto.DropDownHeight = 174;
            cmbEstadoProyecto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoProyecto.DropDownWidth = 121;
            cmbEstadoProyecto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEstadoProyecto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEstadoProyecto.FormattingEnabled = true;
            cmbEstadoProyecto.IntegralHeight = false;
            cmbEstadoProyecto.ItemHeight = 43;
            cmbEstadoProyecto.Location = new Point(219, 37);
            cmbEstadoProyecto.MaxDropDownItems = 4;
            cmbEstadoProyecto.MouseState = MaterialSkin.MouseState.OUT;
            cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            cmbEstadoProyecto.Size = new Size(177, 49);
            cmbEstadoProyecto.StartIndex = 0;
            cmbEstadoProyecto.TabIndex = 55;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.AnimateReadOnly = false;
            txtNombreProyecto.BackgroundImageLayout = ImageLayout.None;
            txtNombreProyecto.CharacterCasing = CharacterCasing.Normal;
            txtNombreProyecto.Depth = 0;
            txtNombreProyecto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreProyecto.HideSelection = true;
            txtNombreProyecto.LeadingIcon = null;
            txtNombreProyecto.Location = new Point(12, 38);
            txtNombreProyecto.MaxLength = 32767;
            txtNombreProyecto.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.PasswordChar = '\0';
            txtNombreProyecto.PrefixSuffixText = null;
            txtNombreProyecto.ReadOnly = false;
            txtNombreProyecto.RightToLeft = RightToLeft.No;
            txtNombreProyecto.SelectedText = "";
            txtNombreProyecto.SelectionLength = 0;
            txtNombreProyecto.SelectionStart = 0;
            txtNombreProyecto.ShortcutsEnabled = true;
            txtNombreProyecto.Size = new Size(201, 48);
            txtNombreProyecto.TabIndex = 54;
            txtNombreProyecto.TabStop = false;
            txtNombreProyecto.TextAlign = HorizontalAlignment.Left;
            txtNombreProyecto.TrailingIcon = null;
            txtNombreProyecto.UseSystemPasswordChar = false;
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(884, 461);
            Controls.Add(panelContenedor);
            ForeColor = Color.White;
            Name = "FormProyectos";
            Text = "FormProyectos";
            Load += FormProyectos_Load;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenedor;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private GroupBox groupBox1;
        private Button btn_agregar;
        private MaterialSkin.Controls.MaterialLabel txtDescripcionProyecto;
        public MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private DateTimePicker dateTimePickerEntrega;
        private DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoProyecto;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreProyecto;
    }
}