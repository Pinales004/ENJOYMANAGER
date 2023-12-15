namespace PRESENTACION.Login
{
    partial class FormCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarContraseña));
            btn_limpiar = new PictureBox();
            btn_guardar = new PictureBox();
            btn_volver = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtContraseñaComprobar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Image = (Image)resources.GetObject("btn_limpiar.Image");
            btn_limpiar.Location = new Point(476, 204);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(45, 45);
            btn_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_limpiar.TabIndex = 82;
            btn_limpiar.TabStop = false;
            btn_limpiar.Click += btn_limpiar_Click;
            btn_limpiar.MouseEnter += btn_limpiar_MouseEnter;
            btn_limpiar.MouseLeave += btn_limpiar_MouseLeave;
            // 
            // btn_guardar
            // 
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(527, 204);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 81;
            btn_guardar.TabStop = false;
            btn_guardar.Click += btn_guardar_Click;
            btn_guardar.MouseEnter += btn_guardar_MouseEnter;
            btn_guardar.MouseLeave += btn_guardar_MouseLeave;
            // 
            // btn_volver
            // 
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(12, 204);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 80;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            btn_volver.MouseEnter += btn_volver_MouseEnter;
            btn_volver.MouseLeave += btn_volver_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 29);
            label1.TabIndex = 83;
            label1.Text = "Bienvenido a ENJOY MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 49);
            label2.Name = "label2";
            label2.Size = new Size(300, 18);
            label2.TabIndex = 84;
            label2.Text = "Por favor introduzca su nueva contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.AllowPromptAsInput = true;
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.AsciiOnly = false;
            txtContraseña.BackgroundImageLayout = ImageLayout.None;
            txtContraseña.BeepOnError = false;
            txtContraseña.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.HidePromptOnLeave = false;
            txtContraseña.HideSelection = true;
            txtContraseña.InsertKeyMode = InsertKeyMode.Default;
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(122, 70);
            txtContraseña.Mask = "";
            txtContraseña.MaxLength = 32767;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '\0';
            txtContraseña.PrefixSuffixText = null;
            txtContraseña.PromptChar = '_';
            txtContraseña.ReadOnly = false;
            txtContraseña.RejectInputOnFirstFailure = false;
            txtContraseña.ResetOnPrompt = true;
            txtContraseña.ResetOnSpace = true;
            txtContraseña.RightToLeft = RightToLeft.No;
            txtContraseña.SelectedText = "";
            txtContraseña.SelectionLength = 0;
            txtContraseña.SelectionStart = 0;
            txtContraseña.ShortcutsEnabled = true;
            txtContraseña.Size = new Size(300, 48);
            txtContraseña.SkipLiterals = true;
            txtContraseña.TabIndex = 85;
            txtContraseña.TabStop = false;
            txtContraseña.TextAlign = HorizontalAlignment.Left;
            txtContraseña.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtContraseña.TrailingIcon = null;
            txtContraseña.UseSystemPasswordChar = false;
            txtContraseña.ValidatingType = null;
            // 
            // txtContraseñaComprobar
            // 
            txtContraseñaComprobar.AllowPromptAsInput = true;
            txtContraseñaComprobar.AnimateReadOnly = false;
            txtContraseñaComprobar.AsciiOnly = false;
            txtContraseñaComprobar.BackgroundImageLayout = ImageLayout.None;
            txtContraseñaComprobar.BeepOnError = false;
            txtContraseñaComprobar.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtContraseñaComprobar.Depth = 0;
            txtContraseñaComprobar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseñaComprobar.HidePromptOnLeave = false;
            txtContraseñaComprobar.HideSelection = true;
            txtContraseñaComprobar.InsertKeyMode = InsertKeyMode.Default;
            txtContraseñaComprobar.LeadingIcon = null;
            txtContraseñaComprobar.Location = new Point(122, 158);
            txtContraseñaComprobar.Mask = "";
            txtContraseñaComprobar.MaxLength = 32767;
            txtContraseñaComprobar.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseñaComprobar.Name = "txtContraseñaComprobar";
            txtContraseñaComprobar.PasswordChar = '\0';
            txtContraseñaComprobar.PrefixSuffixText = null;
            txtContraseñaComprobar.PromptChar = '_';
            txtContraseñaComprobar.ReadOnly = false;
            txtContraseñaComprobar.RejectInputOnFirstFailure = false;
            txtContraseñaComprobar.ResetOnPrompt = true;
            txtContraseñaComprobar.ResetOnSpace = true;
            txtContraseñaComprobar.RightToLeft = RightToLeft.No;
            txtContraseñaComprobar.SelectedText = "";
            txtContraseñaComprobar.SelectionLength = 0;
            txtContraseñaComprobar.SelectionStart = 0;
            txtContraseñaComprobar.ShortcutsEnabled = true;
            txtContraseñaComprobar.Size = new Size(300, 48);
            txtContraseñaComprobar.SkipLiterals = true;
            txtContraseñaComprobar.TabIndex = 86;
            txtContraseñaComprobar.TabStop = false;
            txtContraseñaComprobar.TextAlign = HorizontalAlignment.Left;
            txtContraseñaComprobar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtContraseñaComprobar.TrailingIcon = null;
            txtContraseñaComprobar.UseSystemPasswordChar = false;
            txtContraseñaComprobar.ValidatingType = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 137);
            label3.Name = "label3";
            label3.Size = new Size(268, 18);
            label3.TabIndex = 87;
            label3.Text = "Por favor repita su nueva contraseña";
            // 
            // FormCambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(label3);
            Controls.Add(txtContraseñaComprobar);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCambiarContraseña";
            Text = "ENJOYMANAGEMENT-Bienvenido";
            Load += FormCambiarContraseña_Load;
            MouseMove += Frm_NuevoProyecto_MouseMove;
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
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContraseñaComprobar;
        private Label label3;
    }
}