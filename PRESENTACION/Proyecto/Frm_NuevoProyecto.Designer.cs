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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtDescripcionProyecto = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.dateTimePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            this.labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstadoProyecto = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(539, 253);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 39);
            this.btn_agregar.TabIndex = 76;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.AutoSize = true;
            this.txtDescripcionProyecto.Depth = 0;
            this.txtDescripcionProyecto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(12, 126);
            this.txtDescripcionProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(174, 19);
            this.txtDescripcionProyecto.TabIndex = 75;
            this.txtDescripcionProyecto.Text = "Descripción del proyecto";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(12, 148);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(679, 48);
            this.materialTextBox21.TabIndex = 74;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // dateTimePickerEntrega
            // 
            this.dateTimePickerEntrega.Location = new System.Drawing.Point(275, 259);
            this.dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            this.dateTimePickerEntrega.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerEntrega.TabIndex = 73;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(12, 259);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerInicio.TabIndex = 72;
            // 
            // labelFechaEntrega
            // 
            this.labelFechaEntrega.AutoSize = true;
            this.labelFechaEntrega.Depth = 0;
            this.labelFechaEntrega.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFechaEntrega.Location = new System.Drawing.Point(320, 219);
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
            this.labelFechaInicio.Location = new System.Drawing.Point(12, 219);
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
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(208, 49);
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
            // Frm_NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txtDescripcionProyecto);
            this.Controls.Add(this.materialTextBox21);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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