﻿namespace PRESENTACION
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            panelContenedor = new Panel();
            btm_editar = new Button();
            btn_eliminar2 = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_buscar = new PictureBox();
            label1 = new Label();
            txtbox_buscar = new TextBox();
            btn_editar = new PictureBox();
            btn_eliminar = new PictureBox();
            btn_agregar = new PictureBox();
            btn_agregar2 = new Button();
            CheckActivo = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TxtContrasena2 = new MaterialSkin.Controls.MaterialTextBox2();
            TxtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            txtUsuarioNombre = new MaterialSkin.Controls.MaterialTextBox2();
            CmbSexo = new MaterialSkin.Controls.MaterialComboBox();
            CmbRol = new MaterialSkin.Controls.MaterialComboBox();
            TxtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            TxtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            TxtNombres = new MaterialSkin.Controls.MaterialTextBox2();
            dataGridView1 = new DataGridView();
            panelContenedor.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Black;
            panelContenedor.Controls.Add(btm_editar);
            panelContenedor.Controls.Add(btn_eliminar2);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(884, 461);
            panelContenedor.TabIndex = 0;
            // 
            // btm_editar
            // 
            btm_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btm_editar.Location = new Point(796, 291);
            btm_editar.Name = "btm_editar";
            btm_editar.Size = new Size(75, 23);
            btm_editar.TabIndex = 49;
            btm_editar.Text = "EDITAR";
            btm_editar.UseVisualStyleBackColor = true;
            btm_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar2
            // 
            btn_eliminar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar2.Location = new Point(796, 320);
            btn_eliminar2.Name = "btn_eliminar2";
            btn_eliminar2.Size = new Size(75, 23);
            btn_eliminar2.TabIndex = 50;
            btn_eliminar2.Text = "ELIMINAR";
            btn_eliminar2.UseVisualStyleBackColor = true;
            btn_eliminar2.Click += btn_eliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Location = new Point(796, 349);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 51;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btn_limpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 259);
            panel1.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_buscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtbox_buscar);
            groupBox1.Controls.Add(btn_editar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(btn_agregar2);
            groupBox1.Controls.Add(CheckActivo);
            groupBox1.Controls.Add(materialLabel8);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(materialLabel6);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(materialLabel7);
            groupBox1.Controls.Add(materialLabel4);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(TxtContrasena2);
            groupBox1.Controls.Add(TxtContrasena);
            groupBox1.Controls.Add(txtUsuarioNombre);
            groupBox1.Controls.Add(CmbSexo);
            groupBox1.Controls.Add(CmbRol);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(TxtApellido);
            groupBox1.Controls.Add(TxtNombres);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.Location = new Point(434, 225);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(30, 30);
            btn_buscar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_buscar.TabIndex = 52;
            btn_buscar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 204);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 51;
            label1.Text = "Busqueda de Usuarios";
            // 
            // txtbox_buscar
            // 
            txtbox_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_buscar.Location = new Point(12, 228);
            txtbox_buscar.Name = "txtbox_buscar";
            txtbox_buscar.Size = new Size(416, 23);
            txtbox_buscar.TabIndex = 50;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.Location = new Point(776, 204);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(45, 45);
            btn_editar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_editar.TabIndex = 49;
            btn_editar.TabStop = false;
            btn_editar.MouseEnter += btn_editar_MouseEnter;
            btn_editar.MouseLeave += btn_editar_MouseLeave;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(827, 204);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(45, 45);
            btn_eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_eliminar.TabIndex = 48;
            btn_eliminar.TabStop = false;
            btn_eliminar.MouseEnter += btn_eliminar_MouseEnter;
            btn_eliminar.MouseLeave += btn_eliminar_MouseLeave;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Image = (Image)resources.GetObject("btn_agregar.Image");
            btn_agregar.Location = new Point(725, 204);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(45, 45);
            btn_agregar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_agregar.TabIndex = 47;
            btn_agregar.TabStop = false;
            btn_agregar.Click += btn_agregar_Click_1;
            btn_agregar.MouseEnter += btn_agregar_MouseEnter;
            btn_agregar.MouseLeave += btn_agregar_MouseLeave;
            // 
            // btn_agregar2
            // 
            btn_agregar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_agregar2.Location = new Point(803, 106);
            btn_agregar2.Name = "btn_agregar2";
            btn_agregar2.Size = new Size(75, 23);
            btn_agregar2.TabIndex = 40;
            btn_agregar2.Text = "AGREGAR";
            btn_agregar2.UseVisualStyleBackColor = true;
            btn_agregar2.Click += btn_agregar_Click;
            // 
            // CheckActivo
            // 
            CheckActivo.AutoSize = true;
            CheckActivo.Depth = 0;
            CheckActivo.Location = new Point(792, 33);
            CheckActivo.Margin = new Padding(0);
            CheckActivo.MouseLocation = new Point(-1, -1);
            CheckActivo.MouseState = MaterialSkin.MouseState.HOVER;
            CheckActivo.Name = "CheckActivo";
            CheckActivo.ReadOnly = false;
            CheckActivo.Ripple = true;
            CheckActivo.Size = new Size(79, 37);
            CheckActivo.TabIndex = 37;
            CheckActivo.Text = "Activo";
            CheckActivo.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(614, 84);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(130, 19);
            materialLabel8.TabIndex = 46;
            materialLabel8.Text = "Repite Contraseña";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(384, 84);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(82, 19);
            materialLabel5.TabIndex = 45;
            materialLabel5.Text = "Contraseña";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(558, 0);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(115, 19);
            materialLabel6.TabIndex = 44;
            materialLabel6.Text = "Nombre Usuario";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(231, 85);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(51, 19);
            materialLabel3.TabIndex = 43;
            materialLabel3.Text = "Genero";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(0, 75);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(24, 19);
            materialLabel7.TabIndex = 42;
            materialLabel7.Text = "Rol";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(387, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(41, 19);
            materialLabel4.TabIndex = 41;
            materialLabel4.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(231, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(66, 19);
            materialLabel2.TabIndex = 40;
            materialLabel2.Text = "Apellidos";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 4);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 39;
            materialLabel1.Text = "Nombre/s";
            // 
            // TxtContrasena2
            // 
            TxtContrasena2.AnimateReadOnly = false;
            TxtContrasena2.BackgroundImageLayout = ImageLayout.None;
            TxtContrasena2.CharacterCasing = CharacterCasing.Normal;
            TxtContrasena2.Depth = 0;
            TxtContrasena2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtContrasena2.HideSelection = true;
            TxtContrasena2.LeadingIcon = null;
            TxtContrasena2.Location = new Point(614, 106);
            TxtContrasena2.MaxLength = 32767;
            TxtContrasena2.MouseState = MaterialSkin.MouseState.OUT;
            TxtContrasena2.Name = "TxtContrasena2";
            TxtContrasena2.PasswordChar = '\0';
            TxtContrasena2.PrefixSuffixText = null;
            TxtContrasena2.ReadOnly = false;
            TxtContrasena2.RightToLeft = RightToLeft.No;
            TxtContrasena2.SelectedText = "";
            TxtContrasena2.SelectionLength = 0;
            TxtContrasena2.SelectionStart = 0;
            TxtContrasena2.ShortcutsEnabled = true;
            TxtContrasena2.Size = new Size(127, 48);
            TxtContrasena2.TabIndex = 39;
            TxtContrasena2.TabStop = false;
            TxtContrasena2.TextAlign = HorizontalAlignment.Left;
            TxtContrasena2.TrailingIcon = null;
            TxtContrasena2.UseSystemPasswordChar = false;
            // 
            // TxtContrasena
            // 
            TxtContrasena.AnimateReadOnly = false;
            TxtContrasena.BackgroundImageLayout = ImageLayout.None;
            TxtContrasena.CharacterCasing = CharacterCasing.Normal;
            TxtContrasena.Depth = 0;
            TxtContrasena.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtContrasena.HideSelection = true;
            TxtContrasena.LeadingIcon = null;
            TxtContrasena.Location = new Point(384, 106);
            TxtContrasena.MaxLength = 32767;
            TxtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.PasswordChar = '\0';
            TxtContrasena.PrefixSuffixText = null;
            TxtContrasena.ReadOnly = false;
            TxtContrasena.RightToLeft = RightToLeft.No;
            TxtContrasena.SelectedText = "";
            TxtContrasena.SelectionLength = 0;
            TxtContrasena.SelectionStart = 0;
            TxtContrasena.ShortcutsEnabled = true;
            TxtContrasena.Size = new Size(173, 48);
            TxtContrasena.TabIndex = 38;
            TxtContrasena.TabStop = false;
            TxtContrasena.TextAlign = HorizontalAlignment.Left;
            TxtContrasena.TrailingIcon = null;
            TxtContrasena.UseSystemPasswordChar = false;
            // 
            // txtUsuarioNombre
            // 
            txtUsuarioNombre.AnimateReadOnly = false;
            txtUsuarioNombre.BackgroundImageLayout = ImageLayout.None;
            txtUsuarioNombre.CharacterCasing = CharacterCasing.Normal;
            txtUsuarioNombre.Depth = 0;
            txtUsuarioNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuarioNombre.HideSelection = true;
            txtUsuarioNombre.LeadingIcon = null;
            txtUsuarioNombre.Location = new Point(558, 22);
            txtUsuarioNombre.MaxLength = 32767;
            txtUsuarioNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuarioNombre.Name = "txtUsuarioNombre";
            txtUsuarioNombre.PasswordChar = '\0';
            txtUsuarioNombre.PrefixSuffixText = null;
            txtUsuarioNombre.ReadOnly = false;
            txtUsuarioNombre.RightToLeft = RightToLeft.No;
            txtUsuarioNombre.SelectedText = "";
            txtUsuarioNombre.SelectionLength = 0;
            txtUsuarioNombre.SelectionStart = 0;
            txtUsuarioNombre.ShortcutsEnabled = true;
            txtUsuarioNombre.Size = new Size(170, 48);
            txtUsuarioNombre.TabIndex = 36;
            txtUsuarioNombre.TabStop = false;
            txtUsuarioNombre.TextAlign = HorizontalAlignment.Left;
            txtUsuarioNombre.TrailingIcon = null;
            txtUsuarioNombre.UseSystemPasswordChar = false;
            // 
            // CmbSexo
            // 
            CmbSexo.AutoResize = false;
            CmbSexo.BackColor = Color.FromArgb(255, 255, 255);
            CmbSexo.Depth = 0;
            CmbSexo.DrawMode = DrawMode.OwnerDrawVariable;
            CmbSexo.DropDownHeight = 174;
            CmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSexo.DropDownWidth = 121;
            CmbSexo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbSexo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbSexo.FormattingEnabled = true;
            CmbSexo.IntegralHeight = false;
            CmbSexo.ItemHeight = 43;
            CmbSexo.Location = new Point(231, 106);
            CmbSexo.MaxDropDownItems = 4;
            CmbSexo.MouseState = MaterialSkin.MouseState.OUT;
            CmbSexo.Name = "CmbSexo";
            CmbSexo.Size = new Size(147, 49);
            CmbSexo.StartIndex = 0;
            CmbSexo.TabIndex = 35;
            // 
            // CmbRol
            // 
            CmbRol.AutoResize = false;
            CmbRol.BackColor = Color.FromArgb(255, 255, 255);
            CmbRol.Depth = 0;
            CmbRol.DrawMode = DrawMode.OwnerDrawVariable;
            CmbRol.DropDownHeight = 174;
            CmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRol.DropDownWidth = 121;
            CmbRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbRol.FormattingEnabled = true;
            CmbRol.IntegralHeight = false;
            CmbRol.ItemHeight = 43;
            CmbRol.Location = new Point(3, 95);
            CmbRol.MaxDropDownItems = 4;
            CmbRol.MouseState = MaterialSkin.MouseState.OUT;
            CmbRol.Name = "CmbRol";
            CmbRol.Size = new Size(173, 49);
            CmbRol.StartIndex = 0;
            CmbRol.TabIndex = 34;
            // 
            // TxtEmail
            // 
            TxtEmail.AllowPromptAsInput = true;
            TxtEmail.AnimateReadOnly = false;
            TxtEmail.AsciiOnly = false;
            TxtEmail.BackgroundImageLayout = ImageLayout.None;
            TxtEmail.BeepOnError = false;
            TxtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtEmail.Depth = 0;
            TxtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtEmail.HidePromptOnLeave = false;
            TxtEmail.HideSelection = true;
            TxtEmail.InsertKeyMode = InsertKeyMode.Default;
            TxtEmail.LeadingIcon = null;
            TxtEmail.Location = new Point(387, 22);
            TxtEmail.Mask = "";
            TxtEmail.MaxLength = 32767;
            TxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PasswordChar = '\0';
            TxtEmail.PrefixSuffixText = null;
            TxtEmail.PromptChar = '_';
            TxtEmail.ReadOnly = false;
            TxtEmail.RejectInputOnFirstFailure = false;
            TxtEmail.ResetOnPrompt = true;
            TxtEmail.ResetOnSpace = true;
            TxtEmail.RightToLeft = RightToLeft.No;
            TxtEmail.SelectedText = "";
            TxtEmail.SelectionLength = 0;
            TxtEmail.SelectionStart = 0;
            TxtEmail.ShortcutsEnabled = true;
            TxtEmail.Size = new Size(135, 48);
            TxtEmail.SkipLiterals = true;
            TxtEmail.TabIndex = 33;
            TxtEmail.TabStop = false;
            TxtEmail.TextAlign = HorizontalAlignment.Left;
            TxtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtEmail.TrailingIcon = null;
            TxtEmail.UseSystemPasswordChar = false;
            TxtEmail.ValidatingType = null;
            // 
            // TxtApellido
            // 
            TxtApellido.AnimateReadOnly = false;
            TxtApellido.BackgroundImageLayout = ImageLayout.None;
            TxtApellido.CharacterCasing = CharacterCasing.Normal;
            TxtApellido.Depth = 0;
            TxtApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtApellido.HideSelection = true;
            TxtApellido.LeadingIcon = null;
            TxtApellido.Location = new Point(231, 22);
            TxtApellido.MaxLength = 32767;
            TxtApellido.MouseState = MaterialSkin.MouseState.OUT;
            TxtApellido.Name = "TxtApellido";
            TxtApellido.PasswordChar = '\0';
            TxtApellido.PrefixSuffixText = null;
            TxtApellido.ReadOnly = false;
            TxtApellido.RightToLeft = RightToLeft.No;
            TxtApellido.SelectedText = "";
            TxtApellido.SelectionLength = 0;
            TxtApellido.SelectionStart = 0;
            TxtApellido.ShortcutsEnabled = true;
            TxtApellido.Size = new Size(141, 48);
            TxtApellido.TabIndex = 32;
            TxtApellido.TabStop = false;
            TxtApellido.TextAlign = HorizontalAlignment.Left;
            TxtApellido.TrailingIcon = null;
            TxtApellido.UseSystemPasswordChar = false;
            // 
            // TxtNombres
            // 
            TxtNombres.AnimateReadOnly = false;
            TxtNombres.BackgroundImageLayout = ImageLayout.None;
            TxtNombres.CharacterCasing = CharacterCasing.Normal;
            TxtNombres.Depth = 0;
            TxtNombres.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNombres.HideSelection = true;
            TxtNombres.LeadingIcon = null;
            TxtNombres.Location = new Point(0, 22);
            TxtNombres.MaxLength = 32767;
            TxtNombres.MouseState = MaterialSkin.MouseState.OUT;
            TxtNombres.Name = "TxtNombres";
            TxtNombres.PasswordChar = '\0';
            TxtNombres.PrefixSuffixText = null;
            TxtNombres.ReadOnly = false;
            TxtNombres.RightToLeft = RightToLeft.No;
            TxtNombres.SelectedText = "";
            TxtNombres.SelectionLength = 0;
            TxtNombres.SelectionStart = 0;
            TxtNombres.ShortcutsEnabled = true;
            TxtNombres.Size = new Size(200, 48);
            TxtNombres.TabIndex = 31;
            TxtNombres.TabStop = false;
            TxtNombres.TextAlign = HorizontalAlignment.Left;
            TxtNombres.TrailingIcon = null;
            TxtNombres.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 190);
            dataGridView1.TabIndex = 60;
            // 
            // Frm_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(884, 461);
            Controls.Add(panelContenedor);
            Name = "Frm_Usuarios";
            Text = "Administracion Usuarios";
            Load += FormUsuarios_Load;
            panelContenedor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_agregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Button btnLimpiar;
        private Panel panel1;
        private GroupBox groupBox1;
        public MaterialSkin.Controls.MaterialCheckbox CheckActivo;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox2 TxtContrasena2;
        public MaterialSkin.Controls.MaterialTextBox2 TxtContrasena;
        public MaterialSkin.Controls.MaterialTextBox2 txtUsuarioNombre;
        public MaterialSkin.Controls.MaterialComboBox CmbSexo;
        public MaterialSkin.Controls.MaterialComboBox CmbRol;
        public MaterialSkin.Controls.MaterialMaskedTextBox TxtEmail;
        public MaterialSkin.Controls.MaterialTextBox2 TxtApellido;
        public MaterialSkin.Controls.MaterialTextBox2 TxtNombres;
        public DataGridView dataGridView1;
        private Button btm_editar;
        private Button btn_eliminar2;
        private Button btn_agregar2;
        private PictureBox btn_editar;
        private PictureBox btn_agregar;
        private Label label1;
        private TextBox txtbox_buscar;
        private PictureBox btn_buscar;
        private PictureBox btn_eliminar;
    }
}