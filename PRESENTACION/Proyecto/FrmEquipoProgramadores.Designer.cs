namespace PRESENTACION.Proyecto
{
    partial class FrmEquipoProgramadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipoProgramadores));
            btn_guardar = new PictureBox();
            btn_volver = new PictureBox();
            materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.Location = new Point(462, 404);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 45);
            btn_guardar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_guardar.TabIndex = 80;
            btn_guardar.TabStop = false;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_volver.Cursor = Cursors.Hand;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.Location = new Point(12, 404);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volver.TabIndex = 79;
            btn_volver.TabStop = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // materialCheckedListBox1
            // 
            materialCheckedListBox1.AutoScroll = true;
            materialCheckedListBox1.BackColor = Color.Silver;
            materialCheckedListBox1.BorderStyle = BorderStyle.FixedSingle;
            materialCheckedListBox1.Depth = 0;
            materialCheckedListBox1.Location = new Point(12, 12);
            materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckedListBox1.Name = "materialCheckedListBox1";
            materialCheckedListBox1.Size = new Size(495, 337);
            materialCheckedListBox1.Striped = false;
            materialCheckedListBox1.StripeDarkColor = Color.Empty;
            materialCheckedListBox1.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 362);
            label1.Name = "label1";
            label1.Size = new Size(504, 15);
            label1.TabIndex = 82;
            label1.Text = "En la checkListBox agregate algo para que aparezcan en fila todos los usuarios programadores ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 377);
            label2.Name = "label2";
            label2.Size = new Size(502, 15);
            label2.TabIndex = 83;
            label2.Text = "Este no es el color, solo no queria que fuera blanco porque se confunde con el otro formulario";
            // 
            // FrmEquipoProgramadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(519, 461);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materialCheckedListBox1);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Name = "FrmEquipoProgramadores";
            Text = "FrmEquipoProgramadores";
            MouseMove += FrmEquipoProgramadores_MouseMove;
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private Label label1;
        private Label label2;
    }
}