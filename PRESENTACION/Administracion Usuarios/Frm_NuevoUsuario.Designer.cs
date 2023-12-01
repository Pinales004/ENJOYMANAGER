namespace PRESENTACION.Administracion_Usuarios
{
    partial class Frm_NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoUsuario));
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cmbGenero = new MaterialSkin.Controls.MaterialComboBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbRol = new MaterialSkin.Controls.MaterialComboBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtNombreUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtContraseña2 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtContraseña = new MaterialSkin.Controls.MaterialTextBox2();
            ResetPassword = new MaterialSkin.Controls.MaterialCheckbox();
            btn_limpiar = new PictureBox();
            btn_guardar = new PictureBox();
            btn_volver = new PictureBox();
            CboEstadoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(630, 28);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(51, 19);
            materialLabel2.TabIndex = 107;
            materialLabel2.Text = "Género";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(329, 28);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(66, 19);
            materialLabel3.TabIndex = 106;
            materialLabel3.Text = "Apellidos";
            // 
            // cmbGenero
            // 
            cmbGenero.AutoResize = false;
            cmbGenero.BackColor = Color.FromArgb(255, 255, 255);
            cmbGenero.Depth = 0;
            cmbGenero.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGenero.DropDownHeight = 174;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.DropDownWidth = 121;
            cmbGenero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.IntegralHeight = false;
            cmbGenero.ItemHeight = 43;
            cmbGenero.Location = new Point(630, 49);
            cmbGenero.MaxDropDownItems = 4;
            cmbGenero.MouseState = MaterialSkin.MouseState.OUT;
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(158, 49);
            cmbGenero.StartIndex = 0;
            cmbGenero.TabIndex = 102;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BackgroundImageLayout = ImageLayout.None;
            txtApellido.CharacterCasing = CharacterCasing.Normal;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.HideSelection = true;
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(329, 50);
            txtApellido.MaxLength = 32767;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '\0';
            txtApellido.PrefixSuffixText = null;
            txtApellido.ReadOnly = false;
            txtApellido.RightToLeft = RightToLeft.No;
            txtApellido.SelectedText = "";
            txtApellido.SelectionLength = 0;
            txtApellido.SelectionStart = 0;
            txtApellido.ShortcutsEnabled = true;
            txtApellido.Size = new Size(295, 48);
            txtApellido.TabIndex = 101;
            txtApellido.TabStop = false;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.TrailingIcon = null;
            txtApellido.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(448, 201);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(24, 19);
            materialLabel7.TabIndex = 103;
            materialLabel7.Text = "Rol";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 28);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 102;
            materialLabel1.Text = "Nombre/s";
            // 
            // cmbRol
            // 
            cmbRol.AutoResize = false;
            cmbRol.BackColor = Color.FromArgb(255, 255, 255);
            cmbRol.Depth = 0;
            cmbRol.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRol.DropDownHeight = 174;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.DropDownWidth = 121;
            cmbRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.IntegralHeight = false;
            cmbRol.ItemHeight = 43;
            cmbRol.Location = new Point(448, 222);
            cmbRol.MaxDropDownItems = 4;
            cmbRol.MouseState = MaterialSkin.MouseState.OUT;
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(200, 49);
            cmbRol.StartIndex = 0;
            cmbRol.TabIndex = 107;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(12, 50);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(311, 48);
            txtNombre.TabIndex = 100;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(12, 114);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(135, 19);
            materialLabel4.TabIndex = 111;
            materialLabel4.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.AnimateReadOnly = false;
            txtNombreUsuario.BackgroundImageLayout = ImageLayout.None;
            txtNombreUsuario.CharacterCasing = CharacterCasing.Normal;
            txtNombreUsuario.Depth = 0;
            txtNombreUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreUsuario.HideSelection = true;
            txtNombreUsuario.LeadingIcon = null;
            txtNombreUsuario.Location = new Point(12, 136);
            txtNombreUsuario.MaxLength = 32767;
            txtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PasswordChar = '\0';
            txtNombreUsuario.PrefixSuffixText = null;
            txtNombreUsuario.ReadOnly = false;
            txtNombreUsuario.RightToLeft = RightToLeft.No;
            txtNombreUsuario.SelectedText = "";
            txtNombreUsuario.SelectionLength = 0;
            txtNombreUsuario.SelectionStart = 0;
            txtNombreUsuario.ShortcutsEnabled = true;
            txtNombreUsuario.Size = new Size(311, 48);
            txtNombreUsuario.TabIndex = 103;
            txtNombreUsuario.TabStop = false;
            txtNombreUsuario.TextAlign = HorizontalAlignment.Left;
            txtNombreUsuario.TrailingIcon = null;
            txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(329, 114);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(41, 19);
            materialLabel5.TabIndex = 109;
            materialLabel5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(329, 136);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(459, 48);
            txtEmail.TabIndex = 104;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(230, 201);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(149, 19);
            materialLabel6.TabIndex = 115;
            materialLabel6.Text = "Confirme contraseña";
            // 
            // txtContraseña2
            // 
            txtContraseña2.AnimateReadOnly = false;
            txtContraseña2.BackgroundImageLayout = ImageLayout.None;
            txtContraseña2.CharacterCasing = CharacterCasing.Normal;
            txtContraseña2.Depth = 0;
            txtContraseña2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña2.HideSelection = true;
            txtContraseña2.LeadingIcon = null;
            txtContraseña2.Location = new Point(230, 223);
            txtContraseña2.MaxLength = 32767;
            txtContraseña2.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.PasswordChar = '\0';
            txtContraseña2.PrefixSuffixText = null;
            txtContraseña2.ReadOnly = false;
            txtContraseña2.RightToLeft = RightToLeft.No;
            txtContraseña2.SelectedText = "";
            txtContraseña2.SelectionLength = 0;
            txtContraseña2.SelectionStart = 0;
            txtContraseña2.ShortcutsEnabled = true;
            txtContraseña2.Size = new Size(212, 48);
            txtContraseña2.TabIndex = 106;
            txtContraseña2.TabStop = false;
            txtContraseña2.TextAlign = HorizontalAlignment.Left;
            txtContraseña2.TrailingIcon = null;
            txtContraseña2.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(12, 201);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(82, 19);
            materialLabel8.TabIndex = 113;
            materialLabel8.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.BackgroundImageLayout = ImageLayout.None;
            txtContraseña.CharacterCasing = CharacterCasing.Normal;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.HideSelection = true;
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(12, 223);
            txtContraseña.MaxLength = 32767;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '\0';
            txtContraseña.PrefixSuffixText = null;
            txtContraseña.ReadOnly = false;
            txtContraseña.RightToLeft = RightToLeft.No;
            txtContraseña.SelectedText = "";
            txtContraseña.SelectionLength = 0;
            txtContraseña.SelectionStart = 0;
            txtContraseña.ShortcutsEnabled = true;
            txtContraseña.Size = new Size(212, 48);
            txtContraseña.TabIndex = 105;
            txtContraseña.TabStop = false;
            txtContraseña.TextAlign = HorizontalAlignment.Left;
            txtContraseña.TrailingIcon = null;
            txtContraseña.UseSystemPasswordChar = false;
            // 
            // ResetPassword
            // 
            ResetPassword.AutoSize = true;
            ResetPassword.Depth = 0;
            ResetPassword.Location = new Point(353, 290);
            ResetPassword.Margin = new Padding(0);
            ResetPassword.MouseLocation = new Point(-1, -1);
            ResetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            ResetPassword.Name = "ResetPassword";
            ResetPassword.ReadOnly = false;
            ResetPassword.Ripple = true;
            ResetPassword.Size = new Size(96, 37);
            ResetPassword.TabIndex = 108;
            ResetPassword.Text = "Resetear";
            ResetPassword.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(692, 290);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 118;
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
            btn_guardar.Location = new Point(743, 290);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 117;
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
            btn_volver.Location = new Point(12, 290);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 116;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            btn_volver.MouseEnter += btn_volver_MouseEnter;
            btn_volver.MouseLeave += btn_volver_MouseLeave;
            // 
            // CboEstadoUsuario
            // 
            CboEstadoUsuario.AutoResize = false;
            CboEstadoUsuario.BackColor = Color.FromArgb(255, 255, 255);
            CboEstadoUsuario.Depth = 0;
            CboEstadoUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            CboEstadoUsuario.DropDownHeight = 174;
            CboEstadoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            CboEstadoUsuario.DropDownWidth = 121;
            CboEstadoUsuario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboEstadoUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboEstadoUsuario.FormattingEnabled = true;
            CboEstadoUsuario.IntegralHeight = false;
            CboEstadoUsuario.ItemHeight = 43;
            CboEstadoUsuario.Location = new Point(654, 222);
            CboEstadoUsuario.MaxDropDownItems = 4;
            CboEstadoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            CboEstadoUsuario.Name = "CboEstadoUsuario";
            CboEstadoUsuario.Size = new Size(137, 49);
            CboEstadoUsuario.StartIndex = 0;
            CboEstadoUsuario.TabIndex = 119;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(657, 200);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(50, 19);
            materialLabel9.TabIndex = 120;
            materialLabel9.Text = "Estado";
            // 
            // Frm_NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 347);
            Controls.Add(materialLabel9);
            Controls.Add(CboEstadoUsuario);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Controls.Add(ResetPassword);
            Controls.Add(materialLabel6);
            Controls.Add(txtContraseña2);
            Controls.Add(materialLabel8);
            Controls.Add(txtContraseña);
            Controls.Add(materialLabel4);
            Controls.Add(txtNombreUsuario);
            Controls.Add(materialLabel5);
            Controls.Add(txtEmail);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel3);
            Controls.Add(cmbGenero);
            Controls.Add(txtApellido);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel1);
            Controls.Add(cmbRol);
            Controls.Add(txtNombre);
            Name = "Frm_NuevoUsuario";
            Text = "Frm_NuevoUsuario";
            Load += Frm_NuevoUsuario_Load;
            MouseMove += Frm_NuevoUsuario_MouseMove;
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialComboBox cmbGenero;
        public MaterialSkin.Controls.MaterialTextBox2 txtApellido;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbRol;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialTextBox2 txtContraseña2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        public MaterialSkin.Controls.MaterialTextBox2 txtContraseña;
        public MaterialSkin.Controls.MaterialCheckbox ResetPassword;
        private PictureBox btn_limpiar;
        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        public MaterialSkin.Controls.MaterialComboBox CboEstadoUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}