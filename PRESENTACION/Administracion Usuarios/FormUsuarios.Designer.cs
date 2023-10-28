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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btm_editar = new System.Windows.Forms.Button();
            this.btn_eliminar2 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_buscar = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.PictureBox();
            this.btn_agregar2 = new System.Windows.Forms.Button();
            this.CheckActivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Black;
            this.panelContenedor.Controls.Add(this.btm_editar);
            this.panelContenedor.Controls.Add(this.btn_eliminar2);
            this.panelContenedor.Controls.Add(this.btnLimpiar);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.dataGridView1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 461);
            this.panelContenedor.TabIndex = 0;
            // 
            // btm_editar
            // 
            this.btm_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btm_editar.Location = new System.Drawing.Point(796, 291);
            this.btm_editar.Name = "btm_editar";
            this.btm_editar.Size = new System.Drawing.Size(75, 23);
            this.btm_editar.TabIndex = 49;
            this.btm_editar.Text = "EDITAR";
            this.btm_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar2
            // 
            this.btn_eliminar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar2.Location = new System.Drawing.Point(796, 320);
            this.btn_eliminar2.Name = "btn_eliminar2";
            this.btn_eliminar2.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar2.TabIndex = 50;
            this.btn_eliminar2.Text = "ELIMINAR";
            this.btn_eliminar2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(796, 349);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 259);
            this.panel1.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbox_buscar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.btn_agregar2);
            this.groupBox1.Controls.Add(this.CheckActivo);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.TxtContrasena2);
            this.groupBox1.Controls.Add(this.TxtContrasena);
            this.groupBox1.Controls.Add(this.txtUsuarioNombre);
            this.groupBox1.Controls.Add(this.CmbSexo);
            this.groupBox1.Controls.Add(this.CmbRol);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.TxtNombres);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(434, 225);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 30);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 52;
            this.btn_buscar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Busqueda de Usuarios";
            // 
            // txtbox_buscar
            // 
            this.txtbox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_buscar.Location = new System.Drawing.Point(12, 228);
            this.txtbox_buscar.Name = "txtbox_buscar";
            this.txtbox_buscar.Size = new System.Drawing.Size(416, 23);
            this.txtbox_buscar.TabIndex = 50;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(776, 204);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(45, 45);
            this.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_editar.TabIndex = 49;
            this.btn_editar.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(827, 204);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(45, 45);
            this.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_eliminar.TabIndex = 48;
            this.btn_eliminar.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(725, 204);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(45, 45);
            this.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_agregar.TabIndex = 47;
            this.btn_agregar.TabStop = false;
            // 
            // btn_agregar2
            // 
            this.btn_agregar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar2.Location = new System.Drawing.Point(403, 99);
            this.btn_agregar2.Name = "btn_agregar2";
            this.btn_agregar2.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar2.TabIndex = 40;
            this.btn_agregar2.Text = "AGREGAR";
            this.btn_agregar2.UseVisualStyleBackColor = true;
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;
            this.CheckActivo.Depth = 0;
            this.CheckActivo.Location = new System.Drawing.Point(332, 33);
            this.CheckActivo.Margin = new System.Windows.Forms.Padding(0);
            this.CheckActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.ReadOnly = false;
            this.CheckActivo.Ripple = true;
            this.CheckActivo.Size = new System.Drawing.Size(79, 37);
            this.CheckActivo.TabIndex = 37;
            this.CheckActivo.Text = "Activo";
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(242, 78);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(130, 19);
            this.materialLabel8.TabIndex = 46;
            this.materialLabel8.Text = "Repite Contraseña";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(153, 78);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Contraseña";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(200, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(115, 19);
            this.materialLabel6.TabIndex = 44;
            this.materialLabel6.Text = "Nombre Usuario";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(81, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Genero";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(0, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(24, 19);
            this.materialLabel7.TabIndex = 42;
            this.materialLabel7.Text = "Rol";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(153, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(81, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 40;
            this.materialLabel2.Text = "Apellidos";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Nombre/s";
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
            this.TxtContrasena2.Location = new System.Drawing.Point(242, 100);
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
            this.TxtContrasena2.Size = new System.Drawing.Size(127, 48);
            this.TxtContrasena2.TabIndex = 39;
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
            this.TxtContrasena.Location = new System.Drawing.Point(153, 100);
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
            this.TxtContrasena.Size = new System.Drawing.Size(83, 48);
            this.TxtContrasena.TabIndex = 38;
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
            this.txtUsuarioNombre.Location = new System.Drawing.Point(200, 22);
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
            this.txtUsuarioNombre.Size = new System.Drawing.Size(115, 48);
            this.txtUsuarioNombre.TabIndex = 36;
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
            this.CmbSexo.Location = new System.Drawing.Point(81, 99);
            this.CmbSexo.MaxDropDownItems = 4;
            this.CmbSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(66, 49);
            this.CmbSexo.StartIndex = 0;
            this.CmbSexo.TabIndex = 35;
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
            this.CmbRol.Location = new System.Drawing.Point(3, 95);
            this.CmbRol.MaxDropDownItems = 4;
            this.CmbRol.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(62, 49);
            this.CmbRol.StartIndex = 0;
            this.CmbRol.TabIndex = 34;
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
            this.TxtEmail.Location = new System.Drawing.Point(153, 22);
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
            this.TxtEmail.Size = new System.Drawing.Size(41, 48);
            this.TxtEmail.SkipLiterals = true;
            this.TxtEmail.TabIndex = 33;
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
            this.TxtApellido.Location = new System.Drawing.Point(81, 22);
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
            this.TxtApellido.Size = new System.Drawing.Size(66, 48);
            this.TxtApellido.TabIndex = 32;
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
            this.TxtNombres.Location = new System.Drawing.Point(0, 22);
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
            this.TxtNombres.Size = new System.Drawing.Size(75, 48);
            this.TxtNombres.TabIndex = 31;
            this.TxtNombres.TabStop = false;
            this.TxtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombres.TrailingIcon = null;
            this.TxtNombres.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(764, 190);
            this.dataGridView1.TabIndex = 60;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Name = "Frm_Usuarios";
            this.Text = "Administracion Usuarios";
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private PictureBox btn_eliminar;
        private PictureBox btn_agregar;
        private PictureBox btn_buscar;
        private Label label1;
        private TextBox txtbox_buscar;
    }
}