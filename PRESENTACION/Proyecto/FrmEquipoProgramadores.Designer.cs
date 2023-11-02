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
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.PictureBox();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CmbProgramadores = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).BeginInit();
            this.materialCheckedListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(462, 404);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(45, 45);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 80;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Location = new System.Drawing.Point(12, 404);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(45, 45);
            this.btn_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_volver.TabIndex = 79;
            this.btn_volver.TabStop = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.Color.Silver;
            this.materialCheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCheckedListBox1.Controls.Add(this.materialLabel1);
            this.materialCheckedListBox1.Controls.Add(this.CmbProgramadores);
            this.materialCheckedListBox1.Controls.Add(this.dataGridView1);
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(12, 12);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(495, 337);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 81;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(193, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Agregar Miembro al Equipo";
            // 
            // CmbProgramadores
            // 
            this.CmbProgramadores.AutoResize = false;
            this.CmbProgramadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbProgramadores.Depth = 0;
            this.CmbProgramadores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbProgramadores.DropDownHeight = 174;
            this.CmbProgramadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProgramadores.DropDownWidth = 121;
            this.CmbProgramadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbProgramadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbProgramadores.FormattingEnabled = true;
            this.CmbProgramadores.IntegralHeight = false;
            this.CmbProgramadores.ItemHeight = 43;
            this.CmbProgramadores.Location = new System.Drawing.Point(3, 42);
            this.CmbProgramadores.MaxDropDownItems = 4;
            this.CmbProgramadores.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbProgramadores.Name = "CmbProgramadores";
            this.CmbProgramadores.Size = new System.Drawing.Size(349, 49);
            this.CmbProgramadores.StartIndex = 0;
            this.CmbProgramadores.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(487, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmEquipoProgramadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(519, 461);
            this.Controls.Add(this.materialCheckedListBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_volver);
            this.Name = "FrmEquipoProgramadores";
            this.Text = "FrmEquipoProgramadores";
            this.Load += new System.EventHandler(this.FrmEquipoProgramadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).EndInit();
            this.materialCheckedListBox1.ResumeLayout(false);
            this.materialCheckedListBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox CmbProgramadores;
        private DataGridView dataGridView1;
    }
}