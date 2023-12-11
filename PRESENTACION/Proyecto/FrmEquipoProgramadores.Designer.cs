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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            CmbProgramadores = new MaterialSkin.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            btn_eliminar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).BeginInit();
            materialCheckedListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).BeginInit();
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
            btn_guardar.Click += btn_guardar_Click;
            btn_guardar.MouseEnter += btn_guardar_MouseEnter;
            btn_guardar.MouseLeave += btn_guardar_MouseLeave;
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
            btn_volver.MouseEnter += btn_volver_MouseEnter;
            btn_volver.MouseLeave += btn_volver_MouseLeave;
            // 
            // materialCheckedListBox1
            // 
            materialCheckedListBox1.AutoScroll = true;
            materialCheckedListBox1.BackColor = Color.Silver;
            materialCheckedListBox1.BorderStyle = BorderStyle.FixedSingle;
            materialCheckedListBox1.Controls.Add(materialLabel1);
            materialCheckedListBox1.Controls.Add(CmbProgramadores);
            materialCheckedListBox1.Controls.Add(dataGridView1);
            materialCheckedListBox1.Depth = 0;
            materialCheckedListBox1.Location = new Point(12, 12);
            materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckedListBox1.Name = "materialCheckedListBox1";
            materialCheckedListBox1.Size = new Size(495, 337);
            materialCheckedListBox1.Striped = false;
            materialCheckedListBox1.StripeDarkColor = Color.Empty;
            materialCheckedListBox1.TabIndex = 81;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 20);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(193, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Agregar Miembro al Equipo";
            // 
            // CmbProgramadores
            // 
            CmbProgramadores.AutoResize = false;
            CmbProgramadores.BackColor = Color.FromArgb(255, 255, 255);
            CmbProgramadores.Depth = 0;
            CmbProgramadores.DrawMode = DrawMode.OwnerDrawVariable;
            CmbProgramadores.DropDownHeight = 174;
            CmbProgramadores.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbProgramadores.DropDownWidth = 121;
            CmbProgramadores.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbProgramadores.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CmbProgramadores.FormattingEnabled = true;
            CmbProgramadores.IntegralHeight = false;
            CmbProgramadores.ItemHeight = 43;
            CmbProgramadores.Location = new Point(3, 42);
            CmbProgramadores.MaxDropDownItems = 4;
            CmbProgramadores.MouseState = MaterialSkin.MouseState.OUT;
            CmbProgramadores.Name = "CmbProgramadores";
            CmbProgramadores.Size = new Size(349, 49);
            CmbProgramadores.StartIndex = 0;
            CmbProgramadores.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(487, 226);
            dataGridView1.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.Location = new Point(411, 404);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(45, 45);
            btn_eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_eliminar.TabIndex = 83;
            btn_eliminar.TabStop = false;
            btn_eliminar.Click += btn_eliminar_Click;
            btn_eliminar.MouseEnter += btn_eliminar_MouseEnter;
            btn_eliminar.MouseLeave += btn_eliminar_MouseLeave;
            // 
            // FrmEquipoProgramadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(519, 461);
            Controls.Add(btn_eliminar);
            Controls.Add(materialCheckedListBox1);
            Controls.Add(btn_guardar);
            Controls.Add(btn_volver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEquipoProgramadores";
            Text = "FrmEquipoProgramadores";
            Load += FrmEquipoProgramadores_Load;
            ((System.ComponentModel.ISupportInitialize)btn_guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volver).EndInit();
            materialCheckedListBox1.ResumeLayout(false);
            materialCheckedListBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox CmbProgramadores;
        private DataGridView dataGridView1;
        private PictureBox btn_eliminar;
    }
}