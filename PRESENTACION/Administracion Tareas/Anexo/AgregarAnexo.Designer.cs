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
            lblAgregarAnexo = new Label();
            label1 = new Label();
            label2 = new Label();
            txtRuta = new TextBox();
            TxtNombreArchivo = new TextBox();
            BntAnexoGuardar = new Button();
            BtnCancelar = new Button();
            BtnExaminar = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblAgregarAnexo
            // 
            lblAgregarAnexo.AutoSize = true;
            lblAgregarAnexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarAnexo.Location = new Point(88, 9);
            lblAgregarAnexo.Name = "lblAgregarAnexo";
            lblAgregarAnexo.Size = new Size(266, 17);
            lblAgregarAnexo.TabIndex = 0;
            lblAgregarAnexo.Text = "Busque y seleccione el documento a subir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Titulo del archivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Ruta del archivo:";
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(110, 51);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(207, 23);
            txtRuta.TabIndex = 3;
            // 
            // TxtNombreArchivo
            // 
            TxtNombreArchivo.Location = new Point(110, 87);
            TxtNombreArchivo.Name = "TxtNombreArchivo";
            TxtNombreArchivo.Size = new Size(207, 23);
            TxtNombreArchivo.TabIndex = 4;
            // 
            // BntAnexoGuardar
            // 
            BntAnexoGuardar.Location = new Point(110, 128);
            BntAnexoGuardar.Name = "BntAnexoGuardar";
            BntAnexoGuardar.Size = new Size(75, 23);
            BntAnexoGuardar.TabIndex = 5;
            BntAnexoGuardar.Text = "Guardar";
            BntAnexoGuardar.UseVisualStyleBackColor = true;
            BntAnexoGuardar.Click += BntAnexoGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(205, 128);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnExaminar
            // 
            BtnExaminar.Location = new Point(333, 51);
            BtnExaminar.Name = "BtnExaminar";
            BtnExaminar.Size = new Size(75, 23);
            BtnExaminar.TabIndex = 7;
            BtnExaminar.Text = "Examinar";
            BtnExaminar.UseVisualStyleBackColor = true;
            BtnExaminar.Click += BtnExaminar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AgregarAnexo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 177);
            Controls.Add(BtnExaminar);
            Controls.Add(BtnCancelar);
            Controls.Add(BntAnexoGuardar);
            Controls.Add(TxtNombreArchivo);
            Controls.Add(txtRuta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAgregarAnexo);
            Name = "AgregarAnexo";
            Text = "ENJOYMANAGEMENT-Tareas-Anexo";
            ResumeLayout(false);
            PerformLayout();
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