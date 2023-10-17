namespace PRESENTACION
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            TxtContrasena = new TextBox();
            label1 = new Label();
            BtnLogin = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BtnCerrar = new PictureBox();
            BtnMinimizar = new PictureBox();
            blErrorMensaje = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 164);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(320, 58);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(415, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // TxtContrasena
            // 
            TxtContrasena.BackColor = Color.FromArgb(15, 15, 15);
            TxtContrasena.BorderStyle = BorderStyle.None;
            TxtContrasena.ForeColor = Color.DimGray;
            TxtContrasena.Location = new Point(320, 136);
            TxtContrasena.Margin = new Padding(5);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.Size = new Size(415, 20);
            TxtContrasena.TabIndex = 2;
            TxtContrasena.Text = "CONTRASEÑA";
            TxtContrasena.Enter += TxtContrasena_Enter;
            TxtContrasena.Leave += TxtContrasena_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(481, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 33);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(40, 40, 40);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.LightGray;
            BtnLogin.Location = new Point(320, 218);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(408, 40);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "ACCEDER";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(759, 0);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(20, 21);
            BtnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            BtnCerrar.TabIndex = 5;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(733, 0);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(20, 21);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            BtnMinimizar.TabIndex = 6;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // blErrorMensaje
            // 
            blErrorMensaje.AutoSize = true;
            blErrorMensaje.Font = new Font("MS Reference Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            blErrorMensaje.ForeColor = Color.DarkGray;
            blErrorMensaje.Image = (Image)resources.GetObject("blErrorMensaje.Image");
            blErrorMensaje.ImageAlign = ContentAlignment.MiddleLeft;
            blErrorMensaje.Location = new Point(320, 175);
            blErrorMensaje.Name = "blErrorMensaje";
            blErrorMensaje.Size = new Size(106, 18);
            blErrorMensaje.TabIndex = 7;
            blErrorMensaje.Text = "Error Mensaje";
            blErrorMensaje.Visible = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(blErrorMensaje);
            Controls.Add(BtnMinimizar);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnLogin);
            Controls.Add(label1);
            Controls.Add(TxtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Frm_Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseMove += Frm_Login_MouseMove;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox TxtContrasena;
        private Label label1;
        private Button BtnLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox BtnCerrar;
        private PictureBox pictureBox3;
        private PictureBox BtnMinimizar;
        private Label blErrorMensaje;
    }
}

