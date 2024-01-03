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
            panel1 = new Panel();
            dateTimeFinPro = new DateTimePicker();
            dateTimeInicioPro = new DateTimePicker();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            IdProyecto = new Label();
            LblEquipoProyecto = new MaterialSkin.Controls.MaterialLabel();
            btnEquipoProyecto = new PictureBox();
            txtDescripcionProyecto = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btn_limpiar = new PictureBox();
            btn_guardar = new PictureBox();
            btn_volver = new PictureBox();
            labelDescripcionProyecto = new MaterialSkin.Controls.MaterialLabel();
            dateTimePickerEntrega = new DateTimePicker();
            labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbEstadoProyecto = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreProyecto = new MaterialSkin.Controls.MaterialTextBox2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEquipoProyecto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(dateTimeFinPro);
            panel1.Controls.Add(dateTimeInicioPro);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(IdProyecto);
            panel1.Controls.Add(LblEquipoProyecto);
            panel1.Controls.Add(btnEquipoProyecto);
            panel1.Controls.Add(txtDescripcionProyecto);
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_guardar);
            panel1.Controls.Add(btn_volver);
            panel1.Controls.Add(labelDescripcionProyecto);
            panel1.Controls.Add(dateTimePickerEntrega);
            panel1.Controls.Add(labelFechaEntrega);
            panel1.Controls.Add(materialLabel7);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(cmbEstadoProyecto);
            panel1.Controls.Add(txtNombreProyecto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 508);
            panel1.TabIndex = 0;
            panel1.MouseMove += Frm_NuevoProyecto_MouseDown;
            // 
            // dateTimeFinPro
            // 
            dateTimeFinPro.Location = new Point(280, 348);
            dateTimeFinPro.Name = "dateTimeFinPro";
            dateTimeFinPro.Size = new Size(233, 23);
            dateTimeFinPro.TabIndex = 105;
            // 
            // dateTimeInicioPro
            // 
            dateTimeInicioPro.Location = new Point(10, 348);
            dateTimeInicioPro.Name = "dateTimeInicioPro";
            dateTimeInicioPro.Size = new Size(233, 23);
            dateTimeInicioPro.TabIndex = 104;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(318, 326);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(171, 19);
            materialLabel2.TabIndex = 103;
            materialLabel2.Text = "Fecha final programada";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(31, 326);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(198, 19);
            materialLabel3.TabIndex = 102;
            materialLabel3.Text = "Fecha de inicio programado";
            // 
            // IdProyecto
            // 
            IdProyecto.AutoSize = true;
            IdProyecto.Location = new Point(710, 11);
            IdProyecto.Name = "IdProyecto";
            IdProyecto.Size = new Size(64, 15);
            IdProyecto.TabIndex = 101;
            IdProyecto.Text = "IdProyectp";
            IdProyecto.Visible = false;
            // 
            // LblEquipoProyecto
            // 
            LblEquipoProyecto.AutoSize = true;
            LblEquipoProyecto.Depth = 0;
            LblEquipoProyecto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblEquipoProyecto.Location = new Point(583, 326);
            LblEquipoProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            LblEquipoProyecto.Name = "LblEquipoProyecto";
            LblEquipoProyecto.Size = new Size(140, 19);
            LblEquipoProyecto.TabIndex = 100;
            LblEquipoProyecto.Text = "Equipo del proyecto";
            LblEquipoProyecto.Visible = false;
            // 
            // btnEquipoProyecto
            // 
            btnEquipoProyecto.Cursor = Cursors.Hand;
            btnEquipoProyecto.Image = (Image)resources.GetObject("btnEquipoProyecto.Image");
            btnEquipoProyecto.Location = new Point(631, 348);
            btnEquipoProyecto.Name = "btnEquipoProyecto";
            btnEquipoProyecto.Size = new Size(45, 45);
            btnEquipoProyecto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEquipoProyecto.TabIndex = 99;
            btnEquipoProyecto.TabStop = false;
            btnEquipoProyecto.Visible = false;
            btnEquipoProyecto.Click += btnEquipoProyecto_Click;
            btnEquipoProyecto.MouseEnter += btnEquipoProyecto_MouseEnter;
            btnEquipoProyecto.MouseLeave += btnEquipoProyecto_MouseLeave;
            // 
            // txtDescripcionProyecto
            // 
            txtDescripcionProyecto.AnimateReadOnly = false;
            txtDescripcionProyecto.BackgroundImageLayout = ImageLayout.None;
            txtDescripcionProyecto.CharacterCasing = CharacterCasing.Normal;
            txtDescripcionProyecto.Depth = 0;
            txtDescripcionProyecto.HideSelection = true;
            txtDescripcionProyecto.Location = new Point(14, 138);
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
            txtDescripcionProyecto.TabIndex = 91;
            txtDescripcionProyecto.TabStop = false;
            txtDescripcionProyecto.TextAlign = HorizontalAlignment.Left;
            txtDescripcionProyecto.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(678, 453);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 98;
            btn_limpiar.TabStop = false;
            btn_limpiar.Click += btn_limpiar_Click;
            btn_limpiar.MouseEnter += btn_limpiar_MouseEnter;
            btn_limpiar.MouseLeave += btn_limpiar_MouseLeave;
            // 
            // btn_guardar
            // 
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(729, 453);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 97;
            btn_guardar.TabStop = false;
            btn_guardar.Click += btn_guardar_Click_1;
            btn_guardar.MouseEnter += btn_guardar_MouseEnter;
            btn_guardar.MouseLeave += btn_guardar_MouseLeave;
            // 
            // btn_volver
            // 
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(14, 453);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 96;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            btn_volver.MouseEnter += btn_volver_MouseEnter;
            btn_volver.MouseLeave += btn_volver_MouseLeave;
            // 
            // labelDescripcionProyecto
            // 
            labelDescripcionProyecto.AutoSize = true;
            labelDescripcionProyecto.Depth = 0;
            labelDescripcionProyecto.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDescripcionProyecto.Location = new Point(14, 116);
            labelDescripcionProyecto.MouseState = MaterialSkin.MouseState.HOVER;
            labelDescripcionProyecto.Name = "labelDescripcionProyecto";
            labelDescripcionProyecto.Size = new Size(174, 19);
            labelDescripcionProyecto.TabIndex = 95;
            labelDescripcionProyecto.Text = "Descripción del proyecto";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Location = new Point(152, 428);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(233, 23);
            dateTimePickerEntrega.TabIndex = 94;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Depth = 0;
            labelFechaEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFechaEntrega.Location = new Point(222, 406);
            labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(80, 19);
            labelFechaEntrega.TabIndex = 93;
            labelFechaEntrega.Text = "Fecha final";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(518, 30);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(140, 19);
            materialLabel7.TabIndex = 92;
            materialLabel7.Text = "Estado del proyecto";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(14, 30);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(147, 19);
            materialLabel1.TabIndex = 90;
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
            cmbEstadoProyecto.Location = new Point(508, 52);
            cmbEstadoProyecto.MaxDropDownItems = 4;
            cmbEstadoProyecto.MouseState = MaterialSkin.MouseState.OUT;
            cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            cmbEstadoProyecto.Size = new Size(266, 49);
            cmbEstadoProyecto.StartIndex = 0;
            cmbEstadoProyecto.TabIndex = 89;
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
            txtNombreProyecto.Location = new Point(14, 52);
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
            txtNombreProyecto.TabIndex = 88;
            txtNombreProyecto.TabStop = false;
            txtNombreProyecto.TextAlign = HorizontalAlignment.Left;
            txtNombreProyecto.TrailingIcon = null;
            txtNombreProyecto.UseSystemPasswordChar = false;
            // 
            // Frm_NuevoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 508);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_NuevoProyecto";
            Text = "ENJOYMANAGEMENT-Proyectos";
            Load += Frm_NuevoProyecto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEquipoProyecto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public DateTimePicker dateTimeFinPro;
        public DateTimePicker dateTimeInicioPro;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public Label IdProyecto;
        public MaterialSkin.Controls.MaterialLabel LblEquipoProyecto;
        public PictureBox btnEquipoProyecto;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionProyecto;
        private PictureBox btn_limpiar;
        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialLabel labelDescripcionProyecto;
        public DateTimePicker dateTimePickerEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoProyecto;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreProyecto;
    }
}