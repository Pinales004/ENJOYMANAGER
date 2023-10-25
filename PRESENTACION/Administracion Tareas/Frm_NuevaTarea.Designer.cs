namespace PRESENTACION.Administracion_Tareas
{
    partial class Frm_NuevaTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevaTarea));
            txtDescripcionTarea = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btn_limpiar = new PictureBox();
            btn_guardar = new PictureBox();
            btn_volver = new PictureBox();
            labelDescripcionTarea = new MaterialSkin.Controls.MaterialLabel();
            dateTimePickerEntrega = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbEstadoTarea = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreTarea = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cmbResponsableTarea = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDescripcionTarea.AnimateReadOnly = false;
            txtDescripcionTarea.BackgroundImageLayout = ImageLayout.None;
            txtDescripcionTarea.CharacterCasing = CharacterCasing.Normal;
            txtDescripcionTarea.Depth = 0;
            txtDescripcionTarea.HideSelection = true;
            txtDescripcionTarea.Location = new Point(20, 221);
            txtDescripcionTarea.MaxLength = 32767;
            txtDescripcionTarea.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.PasswordChar = '\0';
            txtDescripcionTarea.ReadOnly = false;
            txtDescripcionTarea.ScrollBars = ScrollBars.None;
            txtDescripcionTarea.SelectedText = "";
            txtDescripcionTarea.SelectionLength = 0;
            txtDescripcionTarea.SelectionStart = 0;
            txtDescripcionTarea.ShortcutsEnabled = true;
            txtDescripcionTarea.Size = new Size(760, 171);
            txtDescripcionTarea.TabIndex = 95;
            txtDescripcionTarea.TabStop = false;
            txtDescripcionTarea.TextAlign = HorizontalAlignment.Left;
            txtDescripcionTarea.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(692, 462);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 94;
            btn_limpiar.TabStop = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(743, 462);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 93;
            btn_guardar.TabStop = false;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(12, 462);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 92;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // labelDescripcionTarea
            // 
            labelDescripcionTarea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDescripcionTarea.AutoSize = true;
            labelDescripcionTarea.Depth = 0;
            labelDescripcionTarea.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDescripcionTarea.Location = new Point(20, 199);
            labelDescripcionTarea.MouseState = MaterialSkin.MouseState.HOVER;
            labelDescripcionTarea.Name = "labelDescripcionTarea";
            labelDescripcionTarea.Size = new Size(162, 19);
            labelDescripcionTarea.TabIndex = 91;
            labelDescripcionTarea.Text = "Descripción de la tarea";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerEntrega.Location = new Point(379, 434);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(233, 23);
            dateTimePickerEntrega.TabIndex = 90;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerInicio.Location = new Point(116, 434);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(233, 23);
            dateTimePickerInicio.TabIndex = 89;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Depth = 0;
            labelFechaEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaEntrega.Location = new Point(433, 412);
            labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(123, 19);
            labelFechaEntrega.TabIndex = 88;
            labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Depth = 0;
            labelFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaInicio.Location = new Point(174, 412);
            labelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(107, 19);
            labelFechaInicio.TabIndex = 87;
            labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(524, 29);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(128, 19);
            materialLabel7.TabIndex = 86;
            materialLabel7.Text = "Estado de la tarea";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 29);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(135, 19);
            materialLabel1.TabIndex = 85;
            materialLabel1.Text = "Nombre de la tarea";
            // 
            // cmbEstadoTarea
            // 
            cmbEstadoTarea.AutoResize = false;
            cmbEstadoTarea.BackColor = Color.FromArgb(255, 255, 255);
            cmbEstadoTarea.Depth = 0;
            cmbEstadoTarea.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEstadoTarea.DropDownHeight = 174;
            cmbEstadoTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoTarea.DropDownWidth = 121;
            cmbEstadoTarea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEstadoTarea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEstadoTarea.FormattingEnabled = true;
            cmbEstadoTarea.IntegralHeight = false;
            cmbEstadoTarea.ItemHeight = 43;
            cmbEstadoTarea.Location = new Point(514, 51);
            cmbEstadoTarea.MaxDropDownItems = 4;
            cmbEstadoTarea.MouseState = MaterialSkin.MouseState.OUT;
            cmbEstadoTarea.Name = "cmbEstadoTarea";
            cmbEstadoTarea.Size = new Size(266, 49);
            cmbEstadoTarea.StartIndex = 0;
            cmbEstadoTarea.TabIndex = 84;
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.AnimateReadOnly = false;
            txtNombreTarea.BackgroundImageLayout = ImageLayout.None;
            txtNombreTarea.CharacterCasing = CharacterCasing.Normal;
            txtNombreTarea.Depth = 0;
            txtNombreTarea.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreTarea.HideSelection = true;
            txtNombreTarea.LeadingIcon = null;
            txtNombreTarea.Location = new Point(20, 51);
            txtNombreTarea.MaxLength = 32767;
            txtNombreTarea.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.PasswordChar = '\0';
            txtNombreTarea.PrefixSuffixText = null;
            txtNombreTarea.ReadOnly = false;
            txtNombreTarea.RightToLeft = RightToLeft.No;
            txtNombreTarea.SelectedText = "";
            txtNombreTarea.SelectionLength = 0;
            txtNombreTarea.SelectionStart = 0;
            txtNombreTarea.ShortcutsEnabled = true;
            txtNombreTarea.Size = new Size(475, 48);
            txtNombreTarea.TabIndex = 83;
            txtNombreTarea.TabStop = false;
            txtNombreTarea.TextAlign = HorizontalAlignment.Left;
            txtNombreTarea.TrailingIcon = null;
            txtNombreTarea.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(524, 117);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(170, 19);
            materialLabel2.TabIndex = 99;
            materialLabel2.Text = "Responsable de la tarea";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 117);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(147, 19);
            materialLabel3.TabIndex = 98;
            materialLabel3.Text = "Nombre del proyecto";
            // 
            // cmbResponsableTarea
            // 
            cmbResponsableTarea.AutoResize = false;
            cmbResponsableTarea.BackColor = Color.FromArgb(255, 255, 255);
            cmbResponsableTarea.Depth = 0;
            cmbResponsableTarea.DrawMode = DrawMode.OwnerDrawVariable;
            cmbResponsableTarea.DropDownHeight = 174;
            cmbResponsableTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResponsableTarea.DropDownWidth = 121;
            cmbResponsableTarea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbResponsableTarea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbResponsableTarea.FormattingEnabled = true;
            cmbResponsableTarea.IntegralHeight = false;
            cmbResponsableTarea.ItemHeight = 43;
            cmbResponsableTarea.Location = new Point(514, 139);
            cmbResponsableTarea.MaxDropDownItems = 4;
            cmbResponsableTarea.MouseState = MaterialSkin.MouseState.OUT;
            cmbResponsableTarea.Name = "cmbResponsableTarea";
            cmbResponsableTarea.Size = new Size(266, 49);
            cmbResponsableTarea.StartIndex = 0;
            cmbResponsableTarea.TabIndex = 97;
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
            txtNombreProyecto.Location = new Point(20, 139);
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
            txtNombreProyecto.TabIndex = 96;
            txtNombreProyecto.TabStop = false;
            txtNombreProyecto.TextAlign = HorizontalAlignment.Left;
            txtNombreProyecto.TrailingIcon = null;
            txtNombreProyecto.UseSystemPasswordChar = false;
            // 
            // Frm_NuevaTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel3);
            Controls.Add(cmbResponsableTarea);
            Controls.Add(txtNombreProyecto);
            Controls.Add(txtDescripcionTarea);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Controls.Add(labelDescripcionTarea);
            Controls.Add(dateTimePickerEntrega);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(labelFechaEntrega);
            Controls.Add(labelFechaInicio);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel1);
            Controls.Add(cmbEstadoTarea);
            Controls.Add(txtNombreTarea);
            Name = "Frm_NuevaTarea";
            Text = "Frm_NuevaTarea";
            MouseMove += Frm_NuevaTarea_MouseMove;
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionTarea;
        private PictureBox btn_limpiar;
        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialLabel labelDescripcionTarea;
        private DateTimePicker dateTimePickerEntrega;
        private DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoTarea;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreTarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialComboBox cmbResponsableTarea;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreProyecto;
    }
}