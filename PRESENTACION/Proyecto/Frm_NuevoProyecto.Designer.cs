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
            labelDescripcionProyecto = new MaterialSkin.Controls.MaterialLabel();
            dateTimePickerEntrega = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbEstadoProyecto = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            btn_volver = new PictureBox();
            btn_guardar = new PictureBox();
            txtDescripcionProyecto = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btn_limpiar = new PictureBox();
            btnEquipoProyecto = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEquipoProyecto).BeginInit();
            SuspendLayout();
            // 
            // labelDescripcionProyecto
            // 
            labelDescripcionProyecto.AutoSize = true;
            labelDescripcionProyecto.Depth = 0;
            labelDescripcionProyecto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDescripcionProyecto.Location = new Point(12, 114);
            labelDescripcionProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            labelDescripcionProyecto.Name = "labelDescripcionProyecto";
            labelDescripcionProyecto.Size = new Size(174, 19);
            labelDescripcionProyecto.TabIndex = 75;
            labelDescripcionProyecto.Text = "Descripción del proyecto";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Location = new Point(275, 346);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(233, 23);
            dateTimePickerEntrega.TabIndex = 73;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(12, 346);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(233, 23);
            dateTimePickerInicio.TabIndex = 72;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Depth = 0;
            labelFechaEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaEntrega.Location = new Point(329, 324);
            labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(123, 19);
            labelFechaEntrega.TabIndex = 71;
            labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Depth = 0;
            labelFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaInicio.Location = new Point(70, 324);
            labelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(107, 19);
            labelFechaInicio.TabIndex = 70;
            labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(516, 28);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(140, 19);
            materialLabel7.TabIndex = 69;
            materialLabel7.Text = "Estado del proyecto";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 28);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(147, 19);
            materialLabel1.TabIndex = 68;
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
            cmbEstadoProyecto.Location = new Point(506, 50);
            cmbEstadoProyecto.MaxDropDownItems = 4;
            cmbEstadoProyecto.MouseState = MaterialSkin.MouseState.OUT;
            cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            cmbEstadoProyecto.Size = new Size(266, 49);
            cmbEstadoProyecto.StartIndex = 0;
            cmbEstadoProyecto.TabIndex = 67;
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
            txtNombreProyecto.Location = new Point(12, 50);
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
            txtNombreProyecto.Size = new Size(475, 48);
            txtNombreProyecto.TabIndex = 66;
            txtNombreProyecto.TabStop = false;
            txtNombreProyecto.TextAlign = HorizontalAlignment.Left;
            txtNombreProyecto.TrailingIcon = null;
            txtNombreProyecto.UseSystemPasswordChar = false;
            // 
            // btn_volver
            // 
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(12, 375);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 77;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(727, 375);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 78;
            btn_guardar.TabStop = false;
            btn_guardar.Click += btn_guardar_Click_1;
            // 
            // txtDescripcionProyecto
            // 
            txtDescripcionProyecto.AnimateReadOnly = false;
            txtDescripcionProyecto.BackgroundImageLayout = ImageLayout.None;
            txtDescripcionProyecto.CharacterCasing = CharacterCasing.Normal;
            txtDescripcionProyecto.Depth = 0;
            txtDescripcionProyecto.HideSelection = true;
            txtDescripcionProyecto.Location = new Point(12, 136);
            txtDescripcionProyecto.MaxLength = 32767;
            txtDescripcionProyecto.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            txtDescripcionProyecto.PasswordChar = '\0';
            txtDescripcionProyecto.ReadOnly = false;
            txtDescripcionProyecto.ScrollBars = ScrollBars.None;
            txtDescripcionProyecto.SelectedText = "";
            txtDescripcionProyecto.SelectionLength = 0;
            txtDescripcionProyecto.SelectionStart = 0;
            txtDescripcionProyecto.ShortcutsEnabled = true;
            txtDescripcionProyecto.Size = new Size(760, 171);
            txtDescripcionProyecto.TabIndex = 80;
            txtDescripcionProyecto.TabStop = false;
            txtDescripcionProyecto.TextAlign = HorizontalAlignment.Left;
            txtDescripcionProyecto.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(676, 375);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 79;
            btn_limpiar.TabStop = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btnEquipoProyecto
            // 
            btnEquipoProyecto.Cursor = Cursors.Hand;
            btnEquipoProyecto.Image = (Image)resources.GetObject("btnEquipoProyecto.Image");
            btnEquipoProyecto.Location = new Point(587, 346);
            btnEquipoProyecto.Name = "btnEquipoProyecto";
            btnEquipoProyecto.Size = new Size(45, 45);
            btnEquipoProyecto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEquipoProyecto.TabIndex = 81;
            btnEquipoProyecto.TabStop = false;
            btnEquipoProyecto.Click += btnEquipoProyecto_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(547, 324);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(140, 19);
            materialLabel2.TabIndex = 82;
            materialLabel2.Text = "Equipo del proyecto";
            // 
            // Frm_NuevoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 429);
            Controls.Add(materialLabel2);
            Controls.Add(btnEquipoProyecto);
            Controls.Add(txtDescripcionProyecto);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Controls.Add(labelDescripcionProyecto);
            Controls.Add(dateTimePickerEntrega);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(labelFechaEntrega);
            Controls.Add(labelFechaInicio);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel1);
            Controls.Add(cmbEstadoProyecto);
            Controls.Add(txtNombreProyecto);
            Name = "Frm_NuevoProyecto";
            Text = "Frm_NuevoProyecto";
            Load += Frm_NuevoProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEquipoProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelDescripcionProyecto;
        private DateTimePicker dateTimePickerEntrega;
        private DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoProyecto;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreProyecto;
        private PictureBox btn_volver;
        private PictureBox btn_guardar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionProyecto;
        private PictureBox btn_limpiar;
        private PictureBox btnEquipoProyecto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}