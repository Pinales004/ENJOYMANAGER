namespace PRESENTACION.Administracion_Tareas
{
    partial class Frm_RealizarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RealizarTarea));
            this.txtDescripcionTarea = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.btn_volver = new System.Windows.Forms.PictureBox();
            this.labelDescripcionTarea = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEntrega = new MaterialSkin.Controls.MaterialLabel();
            this.labelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstadoTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreTarea = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbResponsableTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbNombreProyecto = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComentario = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntVerAnexo = new System.Windows.Forms.Button();
            this.EditarAnexo = new System.Windows.Forms.Button();
            this.bntNuevoAnexo = new System.Windows.Forms.Button();
            this.datagridAnexo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.AnimateReadOnly = false;
            this.txtDescripcionTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcionTarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcionTarea.Depth = 0;
            this.txtDescripcionTarea.HideSelection = true;
            this.txtDescripcionTarea.Location = new System.Drawing.Point(15, 199);
            this.txtDescripcionTarea.MaxLength = 32767;
            this.txtDescripcionTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.PasswordChar = '\0';
            this.txtDescripcionTarea.ReadOnly = false;
            this.txtDescripcionTarea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionTarea.SelectedText = "";
            this.txtDescripcionTarea.SelectionLength = 0;
            this.txtDescripcionTarea.SelectionStart = 0;
            this.txtDescripcionTarea.ShortcutsEnabled = true;
            this.txtDescripcionTarea.Size = new System.Drawing.Size(903, 171);
            this.txtDescripcionTarea.TabIndex = 84;
            this.txtDescripcionTarea.TabStop = false;
            this.txtDescripcionTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionTarea.UseSystemPasswordChar = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(822, 654);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(45, 45);
            this.btn_limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_limpiar.TabIndex = 94;
            this.btn_limpiar.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(873, 654);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(45, 45);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 93;
            this.btn_guardar.TabStop = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Location = new System.Drawing.Point(12, 654);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(45, 45);
            this.btn_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_volver.TabIndex = 92;
            this.btn_volver.TabStop = false;
            // 
            // labelDescripcionTarea
            // 
            this.labelDescripcionTarea.AutoSize = true;
            this.labelDescripcionTarea.Depth = 0;
            this.labelDescripcionTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescripcionTarea.Location = new System.Drawing.Point(15, 177);
            this.labelDescripcionTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescripcionTarea.Name = "labelDescripcionTarea";
            this.labelDescripcionTarea.Size = new System.Drawing.Size(162, 19);
            this.labelDescripcionTarea.TabIndex = 91;
            this.labelDescripcionTarea.Text = "Descripción de la tarea";
            // 
            // dateTimePickerEntrega
            // 
            this.dateTimePickerEntrega.Location = new System.Drawing.Point(689, 138);
            this.dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            this.dateTimePickerEntrega.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerEntrega.TabIndex = 86;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(685, 53);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerInicio.TabIndex = 85;
            // 
            // labelFechaEntrega
            // 
            this.labelFechaEntrega.AutoSize = true;
            this.labelFechaEntrega.Depth = 0;
            this.labelFechaEntrega.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFechaEntrega.Location = new System.Drawing.Point(743, 116);
            this.labelFechaEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFechaEntrega.Name = "labelFechaEntrega";
            this.labelFechaEntrega.Size = new System.Drawing.Size(123, 19);
            this.labelFechaEntrega.TabIndex = 88;
            this.labelFechaEntrega.Text = "Fecha de Entrega";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Depth = 0;
            this.labelFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFechaInicio.Location = new System.Drawing.Point(743, 31);
            this.labelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(107, 19);
            this.labelFechaInicio.TabIndex = 87;
            this.labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(477, 9);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(128, 19);
            this.materialLabel7.TabIndex = 86;
            this.materialLabel7.Text = "Estado de la tarea";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 19);
            this.materialLabel1.TabIndex = 85;
            this.materialLabel1.Text = "Nombre de la tarea";
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.AutoResize = false;
            this.cmbEstadoTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstadoTarea.Depth = 0;
            this.cmbEstadoTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstadoTarea.DropDownHeight = 174;
            this.cmbEstadoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoTarea.DropDownWidth = 121;
            this.cmbEstadoTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstadoTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstadoTarea.FormattingEnabled = true;
            this.cmbEstadoTarea.IntegralHeight = false;
            this.cmbEstadoTarea.ItemHeight = 43;
            this.cmbEstadoTarea.Location = new System.Drawing.Point(477, 31);
            this.cmbEstadoTarea.MaxDropDownItems = 4;
            this.cmbEstadoTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(195, 49);
            this.cmbEstadoTarea.StartIndex = 0;
            this.cmbEstadoTarea.TabIndex = 81;
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.AnimateReadOnly = false;
            this.txtNombreTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreTarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreTarea.Depth = 0;
            this.txtNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreTarea.HideSelection = true;
            this.txtNombreTarea.LeadingIcon = null;
            this.txtNombreTarea.Location = new System.Drawing.Point(15, 31);
            this.txtNombreTarea.MaxLength = 32767;
            this.txtNombreTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.PasswordChar = '\0';
            this.txtNombreTarea.PrefixSuffixText = null;
            this.txtNombreTarea.ReadOnly = false;
            this.txtNombreTarea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreTarea.SelectedText = "";
            this.txtNombreTarea.SelectionLength = 0;
            this.txtNombreTarea.SelectionStart = 0;
            this.txtNombreTarea.ShortcutsEnabled = true;
            this.txtNombreTarea.Size = new System.Drawing.Size(447, 48);
            this.txtNombreTarea.TabIndex = 80;
            this.txtNombreTarea.TabStop = false;
            this.txtNombreTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreTarea.TrailingIcon = null;
            this.txtNombreTarea.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(477, 94);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(170, 19);
            this.materialLabel2.TabIndex = 99;
            this.materialLabel2.Text = "Responsable de la tarea";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(15, 94);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 19);
            this.materialLabel3.TabIndex = 98;
            this.materialLabel3.Text = "Nombre del proyecto";
            // 
            // cmbResponsableTarea
            // 
            this.cmbResponsableTarea.AutoResize = false;
            this.cmbResponsableTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbResponsableTarea.Depth = 0;
            this.cmbResponsableTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbResponsableTarea.DropDownHeight = 174;
            this.cmbResponsableTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsableTarea.DropDownWidth = 121;
            this.cmbResponsableTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbResponsableTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbResponsableTarea.FormattingEnabled = true;
            this.cmbResponsableTarea.IntegralHeight = false;
            this.cmbResponsableTarea.ItemHeight = 43;
            this.cmbResponsableTarea.Location = new System.Drawing.Point(477, 116);
            this.cmbResponsableTarea.MaxDropDownItems = 4;
            this.cmbResponsableTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbResponsableTarea.Name = "cmbResponsableTarea";
            this.cmbResponsableTarea.Size = new System.Drawing.Size(195, 49);
            this.cmbResponsableTarea.StartIndex = 0;
            this.cmbResponsableTarea.TabIndex = 83;
            // 
            // CmbNombreProyecto
            // 
            this.CmbNombreProyecto.AutoResize = false;
            this.CmbNombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbNombreProyecto.Depth = 0;
            this.CmbNombreProyecto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbNombreProyecto.DropDownHeight = 174;
            this.CmbNombreProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNombreProyecto.DropDownWidth = 121;
            this.CmbNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbNombreProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbNombreProyecto.FormattingEnabled = true;
            this.CmbNombreProyecto.IntegralHeight = false;
            this.CmbNombreProyecto.ItemHeight = 43;
            this.CmbNombreProyecto.Location = new System.Drawing.Point(15, 116);
            this.CmbNombreProyecto.MaxDropDownItems = 4;
            this.CmbNombreProyecto.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbNombreProyecto.Name = "CmbNombreProyecto";
            this.CmbNombreProyecto.Size = new System.Drawing.Size(447, 49);
            this.CmbNombreProyecto.StartIndex = 0;
            this.CmbNombreProyecto.TabIndex = 82;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(15, 392);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 19);
            this.materialLabel4.TabIndex = 100;
            this.materialLabel4.Text = "Comentarios";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(725, 392);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 19);
            this.materialLabel5.TabIndex = 101;
            this.materialLabel5.Text = "Anexo";
            // 
            // txtComentario
            // 
            this.txtComentario.AnimateReadOnly = false;
            this.txtComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComentario.Depth = 0;
            this.txtComentario.HideSelection = true;
            this.txtComentario.Location = new System.Drawing.Point(12, 414);
            this.txtComentario.MaxLength = 32767;
            this.txtComentario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.ReadOnly = false;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComentario.SelectedText = "";
            this.txtComentario.SelectionLength = 0;
            this.txtComentario.SelectionStart = 0;
            this.txtComentario.ShortcutsEnabled = true;
            this.txtComentario.Size = new System.Drawing.Size(540, 234);
            this.txtComentario.TabIndex = 102;
            this.txtComentario.TabStop = false;
            this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComentario.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntVerAnexo);
            this.groupBox1.Controls.Add(this.EditarAnexo);
            this.groupBox1.Controls.Add(this.bntNuevoAnexo);
            this.groupBox1.Controls.Add(this.datagridAnexo);
            this.groupBox1.Location = new System.Drawing.Point(570, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 234);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos Anexados";
            // 
            // bntVerAnexo
            // 
            this.bntVerAnexo.Location = new System.Drawing.Point(173, 205);
            this.bntVerAnexo.Name = "bntVerAnexo";
            this.bntVerAnexo.Size = new System.Drawing.Size(75, 23);
            this.bntVerAnexo.TabIndex = 3;
            this.bntVerAnexo.Text = "Ver Archivo";
            this.bntVerAnexo.UseVisualStyleBackColor = true;
            // 
            // EditarAnexo
            // 
            this.EditarAnexo.Location = new System.Drawing.Point(87, 205);
            this.EditarAnexo.Name = "EditarAnexo";
            this.EditarAnexo.Size = new System.Drawing.Size(75, 23);
            this.EditarAnexo.TabIndex = 2;
            this.EditarAnexo.Text = "Editar";
            this.EditarAnexo.UseVisualStyleBackColor = true;
            this.EditarAnexo.Click += new System.EventHandler(this.EditarAnexo_Click);
            // 
            // bntNuevoAnexo
            // 
            this.bntNuevoAnexo.Location = new System.Drawing.Point(6, 205);
            this.bntNuevoAnexo.Name = "bntNuevoAnexo";
            this.bntNuevoAnexo.Size = new System.Drawing.Size(75, 23);
            this.bntNuevoAnexo.TabIndex = 1;
            this.bntNuevoAnexo.Text = "Agregar";
            this.bntNuevoAnexo.UseVisualStyleBackColor = true;
            this.bntNuevoAnexo.Click += new System.EventHandler(this.bntNuevoAnexo_Click);
            // 
            // datagridAnexo
            // 
            this.datagridAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAnexo.Location = new System.Drawing.Point(0, 13);
            this.datagridAnexo.Name = "datagridAnexo";
            this.datagridAnexo.RowTemplate.Height = 25;
            this.datagridAnexo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridAnexo.Size = new System.Drawing.Size(342, 179);
            this.datagridAnexo.TabIndex = 0;
            // 
            // Frm_RealizarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.CmbNombreProyecto);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cmbResponsableTarea);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.labelDescripcionTarea);
            this.Controls.Add(this.dateTimePickerEntrega);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.labelFechaEntrega);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.txtNombreTarea);
            this.Name = "Frm_RealizarTarea";
            this.Text = "Frm_NuevaTarea";
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_volver)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridAnexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox btn_limpiar;
        private PictureBox btn_guardar;
        private PictureBox btn_volver;
        private MaterialSkin.Controls.MaterialLabel labelDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel labelFechaEntrega;
        private MaterialSkin.Controls.MaterialLabel labelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialComboBox cmbEstadoTarea;
        public MaterialSkin.Controls.MaterialTextBox2 txtNombreTarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialComboBox cmbResponsableTarea;
        public MaterialSkin.Controls.MaterialComboBox CmbNombreProyecto;
        public DateTimePicker dateTimePickerEntrega;
        public DateTimePicker dateTimePickerInicio;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtComentario;
        private GroupBox groupBox1;
        private Button bntVerAnexo;
        private Button EditarAnexo;
        private Button bntNuevoAnexo;
        private DataGridView datagridAnexo;
    }
}