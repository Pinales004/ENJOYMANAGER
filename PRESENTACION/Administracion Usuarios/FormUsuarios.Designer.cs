namespace PRESENTACION
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckActivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtContrasena2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtContrasena = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsuarioNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.CmbSexo = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbRol = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TxtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNombres = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtnEditar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(908, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.CheckActivo);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.TxtContrasena2);
            this.panel1.Controls.Add(this.TxtContrasena);
            this.panel1.Controls.Add(this.txtUsuarioNombre);
            this.panel1.Controls.Add(this.CmbSexo);
            this.panel1.Controls.Add(this.CmbRol);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtNombres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 280);
            this.panel1.TabIndex = 1;
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;
            this.CheckActivo.Depth = 0;
            this.CheckActivo.Location = new System.Drawing.Point(784, 105);
            this.CheckActivo.Margin = new System.Windows.Forms.Padding(0);
            this.CheckActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.ReadOnly = false;
            this.CheckActivo.Ripple = true;
            this.CheckActivo.Size = new System.Drawing.Size(79, 37);
            this.CheckActivo.TabIndex = 29;
            this.CheckActivo.Text = "Activo";
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(233, 156);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(130, 19);
            this.materialLabel8.TabIndex = 28;
            this.materialLabel8.Text = "Repite Contraseña";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(457, 188);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Agregar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(27, 156);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Contraseña";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(469, 83);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(115, 19);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "Nombre Usuario";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(233, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Genero";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(12, 73);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(24, 19);
            this.materialLabel7.TabIndex = 24;
            this.materialLabel7.Text = "Rol";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(457, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(329, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Apellido";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Nombre";
            // 
            // TxtContrasena2
            // 
            this.TxtContrasena2.AnimateReadOnly = false;
            this.TxtContrasena2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtContrasena2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtContrasena2.Depth = 0;
            this.TxtContrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContrasena2.HideSelection = true;
            this.TxtContrasena2.LeadingIcon = null;
            this.TxtContrasena2.Location = new System.Drawing.Point(233, 176);
            this.TxtContrasena2.MaxLength = 32767;
            this.TxtContrasena2.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtContrasena2.Name = "TxtContrasena2";
            this.TxtContrasena2.PasswordChar = '\0';
            this.TxtContrasena2.PrefixSuffixText = null;
            this.TxtContrasena2.ReadOnly = false;
            this.TxtContrasena2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtContrasena2.SelectedText = "";
            this.TxtContrasena2.SelectionLength = 0;
            this.TxtContrasena2.SelectionStart = 0;
            this.TxtContrasena2.ShortcutsEnabled = true;
            this.TxtContrasena2.Size = new System.Drawing.Size(201, 48);
            this.TxtContrasena2.TabIndex = 20;
            this.TxtContrasena2.TabStop = false;
            this.TxtContrasena2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtContrasena2.TrailingIcon = null;
            this.TxtContrasena2.UseSystemPasswordChar = false;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.AnimateReadOnly = false;
            this.TxtContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtContrasena.Depth = 0;
            this.TxtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContrasena.HideSelection = true;
            this.TxtContrasena.LeadingIcon = null;
            this.TxtContrasena.Location = new System.Drawing.Point(12, 176);
            this.TxtContrasena.MaxLength = 32767;
            this.TxtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '\0';
            this.TxtContrasena.PrefixSuffixText = null;
            this.TxtContrasena.ReadOnly = false;
            this.TxtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtContrasena.SelectedText = "";
            this.TxtContrasena.SelectionLength = 0;
            this.TxtContrasena.SelectionStart = 0;
            this.TxtContrasena.ShortcutsEnabled = true;
            this.TxtContrasena.Size = new System.Drawing.Size(201, 48);
            this.TxtContrasena.TabIndex = 19;
            this.TxtContrasena.TabStop = false;
            this.TxtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtContrasena.TrailingIcon = null;
            this.TxtContrasena.UseSystemPasswordChar = false;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.AnimateReadOnly = false;
            this.txtUsuarioNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuarioNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuarioNombre.Depth = 0;
            this.txtUsuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioNombre.HideSelection = true;
            this.txtUsuarioNombre.LeadingIcon = null;
            this.txtUsuarioNombre.Location = new System.Drawing.Point(457, 105);
            this.txtUsuarioNombre.MaxLength = 32767;
            this.txtUsuarioNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.PasswordChar = '\0';
            this.txtUsuarioNombre.PrefixSuffixText = null;
            this.txtUsuarioNombre.ReadOnly = false;
            this.txtUsuarioNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioNombre.SelectedText = "";
            this.txtUsuarioNombre.SelectionLength = 0;
            this.txtUsuarioNombre.SelectionStart = 0;
            this.txtUsuarioNombre.ShortcutsEnabled = true;
            this.txtUsuarioNombre.Size = new System.Drawing.Size(293, 48);
            this.txtUsuarioNombre.TabIndex = 18;
            this.txtUsuarioNombre.TabStop = false;
            this.txtUsuarioNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuarioNombre.TrailingIcon = null;
            this.txtUsuarioNombre.UseSystemPasswordChar = false;
            // 
            // CmbSexo
            // 
            this.CmbSexo.AutoResize = false;
            this.CmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbSexo.Depth = 0;
            this.CmbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbSexo.DropDownHeight = 174;
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.DropDownWidth = 121;
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.IntegralHeight = false;
            this.CmbSexo.ItemHeight = 43;
            this.CmbSexo.Location = new System.Drawing.Point(233, 104);
            this.CmbSexo.MaxDropDownItems = 4;
            this.CmbSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(179, 49);
            this.CmbSexo.StartIndex = 0;
            this.CmbSexo.TabIndex = 14;
            // 
            // CmbRol
            // 
            this.CmbRol.AutoResize = false;
            this.CmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbRol.Depth = 0;
            this.CmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbRol.DropDownHeight = 174;
            this.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRol.DropDownWidth = 121;
            this.CmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.IntegralHeight = false;
            this.CmbRol.ItemHeight = 43;
            this.CmbRol.Location = new System.Drawing.Point(12, 104);
            this.CmbRol.MaxDropDownItems = 4;
            this.CmbRol.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(177, 49);
            this.CmbRol.StartIndex = 0;
            this.CmbRol.TabIndex = 13;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AllowPromptAsInput = true;
            this.TxtEmail.AnimateReadOnly = false;
            this.TxtEmail.AsciiOnly = false;
            this.TxtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtEmail.BeepOnError = false;
            this.TxtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmail.HidePromptOnLeave = false;
            this.TxtEmail.HideSelection = true;
            this.TxtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TxtEmail.LeadingIcon = null;
            this.TxtEmail.Location = new System.Drawing.Point(457, 31);
            this.TxtEmail.Mask = "";
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PrefixSuffixText = null;
            this.TxtEmail.PromptChar = '_';
            this.TxtEmail.ReadOnly = false;
            this.TxtEmail.RejectInputOnFirstFailure = false;
            this.TxtEmail.ResetOnPrompt = true;
            this.TxtEmail.ResetOnSpace = true;
            this.TxtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(406, 48);
            this.TxtEmail.SkipLiterals = true;
            this.TxtEmail.TabIndex = 12;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TxtEmail.TrailingIcon = null;
            this.TxtEmail.UseSystemPasswordChar = false;
            this.TxtEmail.ValidatingType = null;
            // 
            // TxtApellido
            // 
            this.TxtApellido.AnimateReadOnly = false;
            this.TxtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtApellido.Depth = 0;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellido.HideSelection = true;
            this.TxtApellido.LeadingIcon = null;
            this.TxtApellido.Location = new System.Drawing.Point(233, 22);
            this.TxtApellido.MaxLength = 32767;
            this.TxtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.PasswordChar = '\0';
            this.TxtApellido.PrefixSuffixText = null;
            this.TxtApellido.ReadOnly = false;
            this.TxtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtApellido.SelectedText = "";
            this.TxtApellido.SelectionLength = 0;
            this.TxtApellido.SelectionStart = 0;
            this.TxtApellido.ShortcutsEnabled = true;
            this.TxtApellido.Size = new System.Drawing.Size(194, 48);
            this.TxtApellido.TabIndex = 10;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtApellido.TrailingIcon = null;
            this.TxtApellido.UseSystemPasswordChar = false;
            // 
            // TxtNombres
            // 
            this.TxtNombres.AnimateReadOnly = false;
            this.TxtNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombres.Depth = 0;
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombres.HideSelection = true;
            this.TxtNombres.LeadingIcon = null;
            this.TxtNombres.Location = new System.Drawing.Point(3, 22);
            this.TxtNombres.MaxLength = 32767;
            this.TxtNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.PasswordChar = '\0';
            this.TxtNombres.PrefixSuffixText = null;
            this.TxtNombres.ReadOnly = false;
            this.TxtNombres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombres.SelectedText = "";
            this.TxtNombres.SelectionLength = 0;
            this.TxtNombres.SelectionStart = 0;
            this.TxtNombres.ShortcutsEnabled = true;
            this.TxtNombres.Size = new System.Drawing.Size(201, 48);
            this.TxtNombres.TabIndex = 9;
            this.TxtNombres.TabStop = false;
            this.TxtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombres.TrailingIcon = null;
            this.TxtNombres.UseSystemPasswordChar = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEditar.Depth = 0;
            this.BtnEditar.HighEmphasis = true;
            this.BtnEditar.Icon = null;
            this.BtnEditar.Location = new System.Drawing.Point(915, 289);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEditar.Size = new System.Drawing.Size(71, 36);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEditar.UseAccentColor = false;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.IndianRed;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(915, 337);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(88, 36);
            this.materialButton2.TabIndex = 30;
            this.materialButton2.Text = "Eliminar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(911, 382);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1003, 586);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Usuarios";
            this.Text = "Administracion Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        public DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        public MaterialSkin.Controls.MaterialTextBox2 TxtNombres;
        public MaterialSkin.Controls.MaterialTextBox2 TxtApellido;
        public MaterialSkin.Controls.MaterialMaskedTextBox TxtEmail;
        public MaterialSkin.Controls.MaterialComboBox CmbRol;
        public MaterialSkin.Controls.MaterialComboBox CmbSexo;
        public MaterialSkin.Controls.MaterialTextBox2 txtUsuarioNombre;
        public MaterialSkin.Controls.MaterialTextBox2 TxtContrasena;
        public MaterialSkin.Controls.MaterialTextBox2 TxtContrasena2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        public MaterialSkin.Controls.MaterialCheckbox CheckActivo;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private Button btnLimpiar;
    }
}