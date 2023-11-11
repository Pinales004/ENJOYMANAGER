namespace PRESENTACION.Administracion_Tareas.Anexo
{
    partial class AgregarAnexo
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
            this.lblAgregarAnexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.TxtNombreArchivo = new System.Windows.Forms.TextBox();
            this.BntAnexoGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblAgregarAnexo
            // 
            this.lblAgregarAnexo.AutoSize = true;
            this.lblAgregarAnexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarAnexo.Location = new System.Drawing.Point(88, 9);
            this.lblAgregarAnexo.Name = "lblAgregarAnexo";
            this.lblAgregarAnexo.Size = new System.Drawing.Size(266, 17);
            this.lblAgregarAnexo.TabIndex = 0;
            this.lblAgregarAnexo.Text = "Busque y seleccione el documento a subir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo del archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta del archivo:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(110, 51);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(207, 23);
            this.txtRuta.TabIndex = 3;
            // 
            // TxtNombreArchivo
            // 
            this.TxtNombreArchivo.Location = new System.Drawing.Point(110, 87);
            this.TxtNombreArchivo.Name = "TxtNombreArchivo";
            this.TxtNombreArchivo.Size = new System.Drawing.Size(207, 23);
            this.TxtNombreArchivo.TabIndex = 4;
            // 
            // BntAnexoGuardar
            // 
            this.BntAnexoGuardar.Location = new System.Drawing.Point(110, 128);
            this.BntAnexoGuardar.Name = "BntAnexoGuardar";
            this.BntAnexoGuardar.Size = new System.Drawing.Size(75, 23);
            this.BntAnexoGuardar.TabIndex = 5;
            this.BntAnexoGuardar.Text = "Guardar";
            this.BntAnexoGuardar.UseVisualStyleBackColor = true;
            this.BntAnexoGuardar.Click += new System.EventHandler(this.BntAnexoGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(205, 128);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Location = new System.Drawing.Point(333, 51);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(75, 23);
            this.BtnExaminar.TabIndex = 7;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AgregarAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 177);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BntAnexoGuardar);
            this.Controls.Add(this.TxtNombreArchivo);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregarAnexo);
            this.Name = "AgregarAnexo";
            this.Text = "AgregarAnexo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAgregarAnexo;
        private Label label1;
        private Label label2;
        private TextBox txtRuta;
        private TextBox TxtNombreArchivo;
        private Button BntAnexoGuardar;
        private Button BtnCancelar;
        private Button BtnExaminar;
        private OpenFileDialog openFileDialog1;
    }
}