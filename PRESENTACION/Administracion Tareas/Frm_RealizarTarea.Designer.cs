namespace PRESENTACION.Administracion_Tareas
{
    partial class Frm_RealizarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RealizarTarea));
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
            CmbNombreProyecto = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtComentario = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.AnimateReadOnly = false;
            txtDescripcionTarea.BackgroundImageLayout = ImageLayout.None;
            txtDescripcionTarea.CharacterCasing = CharacterCasing.Normal;
            txtDescripcionTarea.Depth = 0;
            txtDescripcionTarea.HideSelection = true;
            txtDescripcionTarea.Location = new Point(15, 199);
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
            txtDescripcionTarea.Size = new Size(903, 171);
            txtDescripcionTarea.TabIndex = 84;
            txtDescripcionTarea.TabStop = false;
            txtDescripcionTarea.TextAlign = HorizontalAlignment.Left;
            txtDescripcionTarea.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(822, 654);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 94;
            btn_limpiar.TabStop = false;
            btn_limpiar.Click += btn_limpiar_Click;
            btn_limpiar.MouseEnter += btn_limpiar_MouseEnter;
            btn_limpiar.MouseLeave += btn_limpiar_MouseLeave;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(873, 654);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 93;
            btn_guardar.TabStop = false;
            btn_guardar.Click += btn_guardar_Click;
            btn_guardar.MouseEnter += btn_guardar_MouseEnter;
            btn_guardar.MouseLeave += btn_guardar_MouseLeave;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(12, 654);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 92;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            btn_volver.MouseEnter += btn_volver_MouseEnter;
            btn_volver.MouseLeave += btn_volver_MouseLeave;
            // 
            // labelDescripcionTarea
            // 
            labelDescripcionTarea.AutoSize = true;
            labelDescripcionTarea.Depth = 0;
            labelDescripcionTarea.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDescripcionTarea.Location = new Point(15, 177);
            labelDescripcionTarea.MouseState = MaterialSkin.MouseState.HOVER;
            labelDescripcionTarea.Name = "labelDescripcionTarea";
            labelDescripcionTarea.Size = new Size(162, 19);
            labelDescripcionTarea.TabIndex = 91;
            labelDescripcionTarea.Text = "Descripción de la tarea";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Location = new Point(689, 138);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(233, 23);
            dateTimePickerEntrega.TabIndex = 86;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(685, 53);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(233, 23);
            dateTimePickerInicio.TabIndex = 85;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Depth = 0;
            labelFechaEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaEntrega.Location = new Point(743, 116);
            labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(123, 19);
            labelFechaEntrega.TabIndex = 88;
            labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Depth = 0;
            labelFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaInicio.Location = new Point(743, 31);
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
            materialLabel7.Location = new Point(477, 9);
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
            materialLabel1.Location = new Point(15, 9);
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
            cmbEstadoTarea.Location = new Point(477, 31);
            cmbEstadoTarea.MaxDropDownItems = 4;
            cmbEstadoTarea.MouseState = MaterialSkin.MouseState.OUT;
            cmbEstadoTarea.Name = "cmbEstadoTarea";
            cmbEstadoTarea.Size = new Size(195, 49);
            cmbEstadoTarea.StartIndex = 0;
            cmbEstadoTarea.TabIndex = 81;
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
            txtNombreTarea.Location = new Point(15, 31);
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
            txtNombreTarea.Size = new Size(447, 48);
            txtNombreTarea.TabIndex = 80;
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
            materialLabel2.Location = new Point(477, 94);
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
            materialLabel3.Location = new Point(15, 94);
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
            cmbResponsableTarea.Location = new Point(477, 116);
            cmbResponsableTarea.MaxDropDownItems = 4;
            cmbResponsableTarea.MouseState = MaterialSkin.MouseState.OUT;
            cmbResponsableTarea.Name = "cmbResponsableTarea";
            cmbResponsableTarea.Size = new Size(195, 49);
            cmbResponsableTarea.StartIndex = 0;
            cmbResponsableTarea.TabIndex = 83;
            // 
            // CmbNombreProyecto
            // 
            CmbNombreProyecto.AutoResize = false;
            CmbNombreProyecto.BackColor = Color.FromArgb(255, 255, 255);
            CmbNombreProyecto.Depth = 0;
            CmbNombreProyecto.DrawMode = DrawMode.OwnerDrawVariable;
            CmbNombreProyecto.DropDownHeight = 174;
            CmbNombreProyecto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbNombreProyecto.DropDownWidth = 121;
            CmbNombreProyecto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbNombreProyecto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbNombreProyecto.FormattingEnabled = true;
            CmbNombreProyecto.IntegralHeight = false;
            CmbNombreProyecto.ItemHeight = 43;
            CmbNombreProyecto.Location = new Point(15, 116);
            CmbNombreProyecto.MaxDropDownItems = 4;
            CmbNombreProyecto.MouseState = MaterialSkin.MouseState.OUT;
            CmbNombreProyecto.Name = "CmbNombreProyecto";
            CmbNombreProyecto.Size = new Size(447, 49);
            CmbNombreProyecto.StartIndex = 0;
            CmbNombreProyecto.TabIndex = 82;
            CmbNombreProyecto.SelectedIndexChanged += CmbNombreProyecto_SelectedIndexChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(15, 392);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(91, 19);
            materialLabel4.TabIndex = 100;
            materialLabel4.Text = "Comentarios";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(725, 392);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(45, 19);
            materialLabel5.TabIndex = 101;
            materialLabel5.Text = "Anexo";
            // 
            // txtComentario
            // 
            txtComentario.AnimateReadOnly = false;
            txtComentario.BackgroundImageLayout = ImageLayout.None;
            txtComentario.CharacterCasing = CharacterCasing.Normal;
            txtComentario.Depth = 0;
            txtComentario.HideSelection = true;
            txtComentario.Location = new Point(12, 414);
            txtComentario.MaxLength = 32767;
            txtComentario.MouseState = MaterialSkin.MouseState.OUT;
            txtComentario.Name = "txtComentario";
            txtComentario.PasswordChar = '\0';
            txtComentario.ReadOnly = false;
            txtComentario.ScrollBars = ScrollBars.None;
            txtComentario.SelectedText = "";
            txtComentario.SelectionLength = 0;
            txtComentario.SelectionStart = 0;
            txtComentario.ShortcutsEnabled = true;
            txtComentario.Size = new Size(540, 234);
            txtComentario.TabIndex = 102;
            txtComentario.TabStop = false;
            txtComentario.TextAlign = HorizontalAlignment.Left;
            txtComentario.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(570, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 234);
            groupBox1.TabIndex = 103;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cajita de ejemplo";
            // 
            // Frm_RealizarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 711);
            Controls.Add(groupBox1);
            Controls.Add(txtComentario);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(CmbNombreProyecto);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel3);
            Controls.Add(cmbResponsableTarea);
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
            Name = "Frm_RealizarTarea";
            Text = "Frm_NuevaTarea";
            Load += Frm_RealizarTarea_Load;
            MouseMove += Frm_RealizarTarea_MouseMove;
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btn_limpiar;
        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialLabel labelDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoTarea;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreTarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialComboBox cmbResponsableTarea;
        public MaterialSkin.Controls.MaterialComboBox CmbNombreProyecto;
        public DateTimePicker dateTimePickerEntrega;
        public DateTimePicker dateTimePickerInicio;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtComentario;
        private GroupBox groupBox1;
    }
}