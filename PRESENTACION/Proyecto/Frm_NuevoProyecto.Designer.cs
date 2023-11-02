namespace PRESENTACION.Proyecto
{
    partial class Frm_NuevoProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoProyecto));
            this.labelDescripcionProyecto = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            this.labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstadoProyecto = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_volver = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.txtDescripcionProyecto = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.btnEquipoProyecto = new System.Windows.Forms.PictureBox();
            this.LblEquipoProyecto = new MaterialSkin.Controls.MaterialLabel();
            this.IdProyecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEquipoProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcionProyecto
            // 
            this.labelDescripcionProyecto.AutoSize = true;
            this.labelDescripcionProyecto.Depth = 0;
            this.labelDescripcionProyecto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescripcionProyecto.Location = new System.Drawing.Point(12, 114);
            this.labelDescripcionProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescripcionProyecto.Name = "labelDescripcionProyecto";
            this.labelDescripcionProyecto.Size = new System.Drawing.Size(174, 19);
            this.labelDescripcionProyecto.TabIndex = 75;
            this.labelDescripcionProyecto.Text = "Descripción del proyecto";
            // 
            // dateTimePickerEntrega
            // 
            this.dateTimePickerEntrega.Location = new System.Drawing.Point(275, 346);
            this.dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            this.dateTimePickerEntrega.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerEntrega.TabIndex = 73;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(12, 346);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerInicio.TabIndex = 72;
            // 
            // labelFechaEntrega
            // 
            this.labelFechaEntrega.AutoSize = true;
            this.labelFechaEntrega.Depth = 0;
            this.labelFechaEntrega.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFechaEntrega.Location = new System.Drawing.Point(329, 324);
            this.labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFechaEntrega.Name = "labelFechaEntrega";
            this.labelFechaEntrega.Size = new System.Drawing.Size(123, 19);
            this.labelFechaEntrega.TabIndex = 71;
            this.labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Depth = 0;
            this.labelFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFechaInicio.Location = new System.Drawing.Point(70, 324);
            this.labelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(107, 19);
            this.labelFechaInicio.TabIndex = 70;
            this.labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(516, 28);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(140, 19);
            this.materialLabel7.TabIndex = 69;
            this.materialLabel7.Text = "Estado del proyecto";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 68;
            this.materialLabel1.Text = "Nombre del proyecto";
            // 
            // cmbEstadoProyecto
            // 
            this.cmbEstadoProyecto.AutoResize = false;
            this.cmbEstadoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstadoProyecto.Depth = 0;
            this.cmbEstadoProyecto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstadoProyecto.DropDownHeight = 174;
            this.cmbEstadoProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoProyecto.DropDownWidth = 121;
            this.cmbEstadoProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstadoProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstadoProyecto.FormattingEnabled = true;
            this.cmbEstadoProyecto.IntegralHeight = false;
            this.cmbEstadoProyecto.ItemHeight = 43;
            this.cmbEstadoProyecto.Location = new System.Drawing.Point(506, 50);
            this.cmbEstadoProyecto.MaxDropDownItems = 4;
            this.cmbEstadoProyecto.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(266, 49);
            this.cmbEstadoProyecto.StartIndex = 0;
            this.cmbEstadoProyecto.TabIndex = 67;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.AnimateReadOnly = false;
            this.txtNombreProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreProyecto.Depth = 0;
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProyecto.HideSelection = true;
            this.txtNombreProyecto.LeadingIcon = null;
            this.txtNombreProyecto.Location = new System.Drawing.Point(12, 50);
            this.txtNombreProyecto.MaxLength = 32767;
            this.txtNombreProyecto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.PasswordChar = '\0';
            this.txtNombreProyecto.PrefixSuffixText = null;
            this.txtNombreProyecto.ReadOnly = false;
            this.txtNombreProyecto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreProyecto.SelectedText = "";
            this.txtNombreProyecto.SelectionLength = 0;
            this.txtNombreProyecto.SelectionStart = 0;
            this.txtNombreProyecto.ShortcutsEnabled = true;
            this.txtNombreProyecto.Size = new System.Drawing.Size(475, 48);
            this.txtNombreProyecto.TabIndex = 66;
            this.txtNombreProyecto.TabStop = false;
            this.txtNombreProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreProyecto.TrailingIcon = null;
            this.txtNombreProyecto.UseSystemPasswordChar = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Location = new System.Drawing.Point(12, 375);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(45, 45);
            this.btn_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_volver.TabIndex = 77;
            this.btn_volver.TabStop = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(727, 375);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(45, 45);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.AnimateReadOnly = false;
            this.txtDescripcionProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcionProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcionProyecto.Depth = 0;
            this.txtDescripcionProyecto.HideSelection = true;
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(12, 136);
            this.txtDescripcionProyecto.MaxLength = 32767;
            this.txtDescripcionProyecto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.PasswordChar = '\0';
            this.txtDescripcionProyecto.ReadOnly = false;
            this.txtDescripcionProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionProyecto.SelectedText = "";
            this.txtDescripcionProyecto.SelectionLength = 0;
            this.txtDescripcionProyecto.SelectionStart = 0;
            this.txtDescripcionProyecto.ShortcutsEnabled = true;
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(760, 171);
            this.txtDescripcionProyecto.TabIndex = 68;
            this.txtDescripcionProyecto.TabStop = false;
            this.txtDescripcionProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionProyecto.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(676, 375);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(45, 45);
            this.btn_limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_limpiar.TabIndex = 79;
            this.btn_limpiar.TabStop = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btnEquipoProyecto
            // 
            this.btnEquipoProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipoProyecto.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipoProyecto.Image")));
            this.btnEquipoProyecto.Location = new System.Drawing.Point(587, 346);
            this.btnEquipoProyecto.Name = "btnEquipoProyecto";
            this.btnEquipoProyecto.Size = new System.Drawing.Size(45, 45);
            this.btnEquipoProyecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEquipoProyecto.TabIndex = 81;
            this.btnEquipoProyecto.TabStop = false;
            this.btnEquipoProyecto.Visible = false;
            this.btnEquipoProyecto.Click += new System.EventHandler(this.btnEquipoProyecto_Click);
            // 
            // LblEquipoProyecto
            // 
            this.LblEquipoProyecto.AutoSize = true;
            this.LblEquipoProyecto.Depth = 0;
            this.LblEquipoProyecto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblEquipoProyecto.Location = new System.Drawing.Point(547, 324);
            this.LblEquipoProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEquipoProyecto.Name = "LblEquipoProyecto";
            this.LblEquipoProyecto.Size = new System.Drawing.Size(140, 19);
            this.LblEquipoProyecto.TabIndex = 82;
            this.LblEquipoProyecto.Text = "Equipo del proyecto";
            this.LblEquipoProyecto.Visible = false;
            // 
            // IdProyecto
            // 
            this.IdProyecto.AutoSize = true;
            this.IdProyecto.Location = new System.Drawing.Point(606, 405);
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.Size = new System.Drawing.Size(64, 15);
            this.IdProyecto.TabIndex = 83;
            this.IdProyecto.Text = "IdProyectp";
            // 
            // Frm_NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 429);
            this.Controls.Add(this.IdProyecto);
            this.Controls.Add(this.LblEquipoProyecto);
            this.Controls.Add(this.btnEquipoProyecto);
            this.Controls.Add(this.txtDescripcionProyecto);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.labelDescripcionProyecto);
            this.Controls.Add(this.dateTimePickerEntrega);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.labelFechaEntrega);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbEstadoProyecto);
            this.Controls.Add(this.txtNombreProyecto);
            this.Name = "Frm_NuevoProyecto";
            this.Text = "Frm_NuevoProyecto";
            this.Load += new System.EventHandler(this.Frm_NuevoProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEquipoProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelDescripcionProyecto;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoProyecto;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreProyecto;
        private PictureBox btn_volver;
        private PictureBox btn_guardar;
        private PictureBox btn_limpiar;
        public DateTimePicker dateTimePickerEntrega;
        public DateTimePicker dateTimePickerInicio;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionProyecto;
        public Label IdProyecto;
        public PictureBox btnEquipoProyecto;
        public MaterialSkin.Controls.MaterialLabel LblEquipoProyecto;
    }
}