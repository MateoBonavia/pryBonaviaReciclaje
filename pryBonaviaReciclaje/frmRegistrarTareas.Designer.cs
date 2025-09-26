namespace pryBonaviaReciclaje
{
    partial class frmRegistrarTareas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            mrcSeleccionar = new GroupBox();
            lblAvisoSobrecarga = new Label();
            dgvMostrar = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAgregarTarea = new Button();
            cmbLugar = new ComboBox();
            cmbTarea = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblSeleccionarLugar = new Label();
            lblSeleccionarTarea = new Label();
            lblSeleccionarFecha = new Label();
            mrcDetalles = new GroupBox();
            btnGuardarDetalles = new Button();
            lblCompletarDetalles = new Label();
            btnSeleccionarTarea = new Button();
            lblAviso = new Label();
            panelDetalles = new Panel();
            lblReclamo = new Label();
            lblLicencia = new Label();
            lblUniforme = new Label();
            chkRecibo = new CheckBox();
            chkSalario = new CheckBox();
            chkVacacion = new CheckBox();
            chkEstudio = new CheckBox();
            chkInsumo = new CheckBox();
            lblSeleccionarTareaCompletar = new Label();
            btnQuitarTarea = new Button();
            btnRegistrar = new Button();
            cmbSeleccionarTarea = new ComboBox();
            label4 = new Label();
            txtComentario = new TextBox();
            btnVolver = new Button();
            mrcSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            mrcDetalles.SuspendLayout();
            panelDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // mrcSeleccionar
            // 
            mrcSeleccionar.Anchor = AnchorStyles.Top;
            mrcSeleccionar.BackColor = Color.FromArgb(14, 32, 37);
            mrcSeleccionar.Controls.Add(lblAvisoSobrecarga);
            mrcSeleccionar.Controls.Add(dgvMostrar);
            mrcSeleccionar.Controls.Add(btnAgregarTarea);
            mrcSeleccionar.Controls.Add(cmbLugar);
            mrcSeleccionar.Controls.Add(cmbTarea);
            mrcSeleccionar.Controls.Add(dtpFecha);
            mrcSeleccionar.Controls.Add(lblSeleccionarLugar);
            mrcSeleccionar.Controls.Add(lblSeleccionarTarea);
            mrcSeleccionar.Controls.Add(lblSeleccionarFecha);
            mrcSeleccionar.ForeColor = SystemColors.Control;
            mrcSeleccionar.Location = new Point(58, 25);
            mrcSeleccionar.Margin = new Padding(2);
            mrcSeleccionar.Name = "mrcSeleccionar";
            mrcSeleccionar.Padding = new Padding(2);
            mrcSeleccionar.Size = new Size(506, 563);
            mrcSeleccionar.TabIndex = 0;
            mrcSeleccionar.TabStop = false;
            mrcSeleccionar.Text = "Seleccionar...";
            // 
            // lblAvisoSobrecarga
            // 
            lblAvisoSobrecarga.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvisoSobrecarga.Location = new Point(5, 248);
            lblAvisoSobrecarga.Margin = new Padding(2, 0, 2, 0);
            lblAvisoSobrecarga.Name = "lblAvisoSobrecarga";
            lblAvisoSobrecarga.Size = new Size(495, 28);
            lblAvisoSobrecarga.TabIndex = 8;
            lblAvisoSobrecarga.Text = "(Por favor, considere que no puede agregar más de 5 tareas a la vez por registro.)";
            lblAvisoSobrecarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvMostrar
            // 
            dgvMostrar.AllowUserToAddRows = false;
            dgvMostrar.AllowUserToDeleteRows = false;
            dgvMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostrar.BackgroundColor = Color.FromArgb(14, 32, 47);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 32, 37);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrar.Columns.AddRange(new DataGridViewColumn[] { Column5, Column2, Column1, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 32, 37);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMostrar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMostrar.Location = new Point(22, 278);
            dgvMostrar.Margin = new Padding(2);
            dgvMostrar.MultiSelect = false;
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 32, 47);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMostrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMostrar.RowHeadersVisible = false;
            dgvMostrar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(14, 32, 47);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dgvMostrar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMostrar.RowTemplate.Height = 24;
            dgvMostrar.Size = new Size(460, 268);
            dgvMostrar.TabIndex = 7;
            // 
            // Column5
            // 
            Column5.HeaderText = "N°";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tarea";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Lugar";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.FromArgb(29, 180, 98);
            btnAgregarTarea.FlatStyle = FlatStyle.Flat;
            btnAgregarTarea.ForeColor = SystemColors.ControlText;
            btnAgregarTarea.Location = new Point(201, 193);
            btnAgregarTarea.Margin = new Padding(2);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(111, 29);
            btnAgregarTarea.TabIndex = 6;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // cmbLugar
            // 
            cmbLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(201, 141);
            cmbLugar.Margin = new Padding(2);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(179, 23);
            cmbLugar.TabIndex = 5;
            cmbLugar.SelectedIndexChanged += cmbLugar_SelectedIndexChanged;
            // 
            // cmbTarea
            // 
            cmbTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarea.FormattingEnabled = true;
            cmbTarea.Location = new Point(201, 92);
            cmbTarea.Margin = new Padding(2);
            cmbTarea.Name = "cmbTarea";
            cmbTarea.Size = new Size(179, 23);
            cmbTarea.TabIndex = 4;
            cmbTarea.SelectedIndexChanged += cmbTarea_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(201, 46);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.MaxDate = new DateTime(2025, 9, 26, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(243, 23);
            dtpFecha.TabIndex = 3;
            dtpFecha.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // lblSeleccionarLugar
            // 
            lblSeleccionarLugar.AutoSize = true;
            lblSeleccionarLugar.Location = new Point(51, 143);
            lblSeleccionarLugar.Margin = new Padding(2, 0, 2, 0);
            lblSeleccionarLugar.Name = "lblSeleccionarLugar";
            lblSeleccionarLugar.Size = new Size(111, 15);
            lblSeleccionarLugar.TabIndex = 2;
            lblSeleccionarLugar.Text = "* Seleccionar Lugar:";
            // 
            // lblSeleccionarTarea
            // 
            lblSeleccionarTarea.AutoSize = true;
            lblSeleccionarTarea.Location = new Point(51, 96);
            lblSeleccionarTarea.Margin = new Padding(2, 0, 2, 0);
            lblSeleccionarTarea.Name = "lblSeleccionarTarea";
            lblSeleccionarTarea.Size = new Size(108, 15);
            lblSeleccionarTarea.TabIndex = 1;
            lblSeleccionarTarea.Text = "* Seleccionar Tarea:";
            // 
            // lblSeleccionarFecha
            // 
            lblSeleccionarFecha.AutoSize = true;
            lblSeleccionarFecha.Location = new Point(51, 51);
            lblSeleccionarFecha.Margin = new Padding(2, 0, 2, 0);
            lblSeleccionarFecha.Name = "lblSeleccionarFecha";
            lblSeleccionarFecha.Size = new Size(112, 15);
            lblSeleccionarFecha.TabIndex = 0;
            lblSeleccionarFecha.Text = "* Seleccionar Fecha:";
            // 
            // mrcDetalles
            // 
            mrcDetalles.Anchor = AnchorStyles.Top;
            mrcDetalles.BackColor = Color.FromArgb(14, 32, 37);
            mrcDetalles.Controls.Add(btnGuardarDetalles);
            mrcDetalles.Controls.Add(lblCompletarDetalles);
            mrcDetalles.Controls.Add(btnSeleccionarTarea);
            mrcDetalles.Controls.Add(lblAviso);
            mrcDetalles.Controls.Add(panelDetalles);
            mrcDetalles.Controls.Add(lblSeleccionarTareaCompletar);
            mrcDetalles.Controls.Add(btnQuitarTarea);
            mrcDetalles.Controls.Add(btnRegistrar);
            mrcDetalles.Controls.Add(cmbSeleccionarTarea);
            mrcDetalles.Controls.Add(label4);
            mrcDetalles.Controls.Add(txtComentario);
            mrcDetalles.ForeColor = SystemColors.Control;
            mrcDetalles.Location = new Point(600, 25);
            mrcDetalles.Margin = new Padding(2);
            mrcDetalles.Name = "mrcDetalles";
            mrcDetalles.Padding = new Padding(2);
            mrcDetalles.Size = new Size(447, 563);
            mrcDetalles.TabIndex = 1;
            mrcDetalles.TabStop = false;
            mrcDetalles.Text = "Detalles...";
            // 
            // btnGuardarDetalles
            // 
            btnGuardarDetalles.BackColor = Color.FromArgb(29, 180, 98);
            btnGuardarDetalles.Enabled = false;
            btnGuardarDetalles.FlatStyle = FlatStyle.Flat;
            btnGuardarDetalles.ForeColor = SystemColors.ControlText;
            btnGuardarDetalles.Location = new Point(174, 443);
            btnGuardarDetalles.Margin = new Padding(2);
            btnGuardarDetalles.Name = "btnGuardarDetalles";
            btnGuardarDetalles.Size = new Size(112, 27);
            btnGuardarDetalles.TabIndex = 15;
            btnGuardarDetalles.Text = "Guardar Detalles";
            btnGuardarDetalles.UseVisualStyleBackColor = false;
            btnGuardarDetalles.Click += btnGuardarDetalles_Click;
            // 
            // lblCompletarDetalles
            // 
            lblCompletarDetalles.AutoSize = true;
            lblCompletarDetalles.Location = new Point(30, 150);
            lblCompletarDetalles.Margin = new Padding(2, 0, 2, 0);
            lblCompletarDetalles.Name = "lblCompletarDetalles";
            lblCompletarDetalles.Size = new Size(118, 15);
            lblCompletarDetalles.TabIndex = 14;
            lblCompletarDetalles.Text = "* Completar Detalles;";
            // 
            // btnSeleccionarTarea
            // 
            btnSeleccionarTarea.BackColor = Color.FromArgb(29, 180, 98);
            btnSeleccionarTarea.FlatStyle = FlatStyle.Flat;
            btnSeleccionarTarea.ForeColor = SystemColors.ControlText;
            btnSeleccionarTarea.Location = new Point(245, 107);
            btnSeleccionarTarea.Margin = new Padding(2);
            btnSeleccionarTarea.Name = "btnSeleccionarTarea";
            btnSeleccionarTarea.Size = new Size(86, 27);
            btnSeleccionarTarea.TabIndex = 13;
            btnSeleccionarTarea.Text = "Seleccionar";
            btnSeleccionarTarea.UseVisualStyleBackColor = false;
            btnSeleccionarTarea.Click += btnSeleccionarTarea_Click;
            // 
            // lblAviso
            // 
            lblAviso.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Firebrick;
            lblAviso.Location = new Point(8, 467);
            lblAviso.Margin = new Padding(2, 0, 2, 0);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(434, 53);
            lblAviso.TabIndex = 12;
            lblAviso.Text = ">> AVISO: Hay X tareas sin completar al menos un detalle.\r\nEn la grilla podrá visualizar el estado de las tareas.";
            lblAviso.TextAlign = ContentAlignment.MiddleCenter;
            lblAviso.Visible = false;
            // 
            // panelDetalles
            // 
            panelDetalles.BackColor = Color.FromArgb(14, 32, 47);
            panelDetalles.Controls.Add(lblReclamo);
            panelDetalles.Controls.Add(lblLicencia);
            panelDetalles.Controls.Add(lblUniforme);
            panelDetalles.Controls.Add(chkRecibo);
            panelDetalles.Controls.Add(chkSalario);
            panelDetalles.Controls.Add(chkVacacion);
            panelDetalles.Controls.Add(chkEstudio);
            panelDetalles.Controls.Add(chkInsumo);
            panelDetalles.Enabled = false;
            panelDetalles.Location = new Point(33, 167);
            panelDetalles.Margin = new Padding(2);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(386, 102);
            panelDetalles.TabIndex = 9;
            // 
            // lblReclamo
            // 
            lblReclamo.Anchor = AnchorStyles.Top;
            lblReclamo.AutoSize = true;
            lblReclamo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblReclamo.Location = new Point(257, 17);
            lblReclamo.Margin = new Padding(2, 0, 2, 0);
            lblReclamo.Name = "lblReclamo";
            lblReclamo.Size = new Size(104, 15);
            lblReclamo.TabIndex = 7;
            lblReclamo.Text = ">> Reclamo <<";
            // 
            // lblLicencia
            // 
            lblLicencia.Anchor = AnchorStyles.Top;
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblLicencia.Location = new Point(134, 17);
            lblLicencia.Margin = new Padding(2, 0, 2, 0);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(101, 15);
            lblLicencia.TabIndex = 6;
            lblLicencia.Text = ">> Licencia <<";
            // 
            // lblUniforme
            // 
            lblUniforme.Anchor = AnchorStyles.Top;
            lblUniforme.AutoSize = true;
            lblUniforme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUniforme.Location = new Point(10, 17);
            lblUniforme.Margin = new Padding(2, 0, 2, 0);
            lblUniforme.Name = "lblUniforme";
            lblUniforme.Size = new Size(106, 15);
            lblUniforme.TabIndex = 5;
            lblUniforme.Text = ">> Uniforme <<";
            // 
            // chkRecibo
            // 
            chkRecibo.Anchor = AnchorStyles.Top;
            chkRecibo.AutoSize = true;
            chkRecibo.Location = new Point(264, 66);
            chkRecibo.Margin = new Padding(2);
            chkRecibo.Name = "chkRecibo";
            chkRecibo.Size = new Size(62, 19);
            chkRecibo.TabIndex = 4;
            chkRecibo.Text = "Recibo";
            chkRecibo.UseVisualStyleBackColor = true;
            chkRecibo.CheckedChanged += chkRecibo_CheckedChanged;
            // 
            // chkSalario
            // 
            chkSalario.Anchor = AnchorStyles.Top;
            chkSalario.AutoSize = true;
            chkSalario.Location = new Point(264, 42);
            chkSalario.Margin = new Padding(2);
            chkSalario.Name = "chkSalario";
            chkSalario.Size = new Size(61, 19);
            chkSalario.TabIndex = 3;
            chkSalario.Text = "Salario";
            chkSalario.UseVisualStyleBackColor = true;
            chkSalario.CheckedChanged += chkSalario_CheckedChanged;
            // 
            // chkVacacion
            // 
            chkVacacion.Anchor = AnchorStyles.Top;
            chkVacacion.AutoSize = true;
            chkVacacion.Location = new Point(142, 66);
            chkVacacion.Margin = new Padding(2);
            chkVacacion.Name = "chkVacacion";
            chkVacacion.Size = new Size(73, 19);
            chkVacacion.TabIndex = 2;
            chkVacacion.Text = "Vacación";
            chkVacacion.UseVisualStyleBackColor = true;
            chkVacacion.CheckedChanged += chkVacacion_CheckedChanged;
            // 
            // chkEstudio
            // 
            chkEstudio.Anchor = AnchorStyles.Top;
            chkEstudio.AutoSize = true;
            chkEstudio.Location = new Point(142, 42);
            chkEstudio.Margin = new Padding(2);
            chkEstudio.Name = "chkEstudio";
            chkEstudio.Size = new Size(65, 19);
            chkEstudio.TabIndex = 1;
            chkEstudio.Text = "Estudio";
            chkEstudio.UseVisualStyleBackColor = true;
            chkEstudio.CheckedChanged += chkEstudio_CheckedChanged;
            // 
            // chkInsumo
            // 
            chkInsumo.Anchor = AnchorStyles.Top;
            chkInsumo.AutoSize = true;
            chkInsumo.Location = new Point(18, 40);
            chkInsumo.Margin = new Padding(2);
            chkInsumo.Name = "chkInsumo";
            chkInsumo.Size = new Size(66, 19);
            chkInsumo.TabIndex = 0;
            chkInsumo.Text = "Insumo";
            chkInsumo.UseVisualStyleBackColor = true;
            chkInsumo.CheckedChanged += chkInsumo_CheckedChanged;
            // 
            // lblSeleccionarTareaCompletar
            // 
            lblSeleccionarTareaCompletar.Location = new Point(5, 29);
            lblSeleccionarTareaCompletar.Margin = new Padding(2, 0, 2, 0);
            lblSeleccionarTareaCompletar.Name = "lblSeleccionarTareaCompletar";
            lblSeleccionarTareaCompletar.Size = new Size(436, 43);
            lblSeleccionarTareaCompletar.TabIndex = 11;
            lblSeleccionarTareaCompletar.Text = "Seleccione una de las tareas agregadas para completar los detalles, o bien, quitarla de la lista de tareas agregadas:";
            lblSeleccionarTareaCompletar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuitarTarea
            // 
            btnQuitarTarea.BackColor = Color.IndianRed;
            btnQuitarTarea.FlatStyle = FlatStyle.Flat;
            btnQuitarTarea.ForeColor = SystemColors.ControlText;
            btnQuitarTarea.Location = new Point(127, 107);
            btnQuitarTarea.Margin = new Padding(2);
            btnQuitarTarea.Name = "btnQuitarTarea";
            btnQuitarTarea.Size = new Size(75, 27);
            btnQuitarTarea.TabIndex = 8;
            btnQuitarTarea.Text = "Quitar";
            btnQuitarTarea.UseVisualStyleBackColor = false;
            btnQuitarTarea.Click += btnQuitarTarea_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(29, 180, 98);
            btnRegistrar.Enabled = false;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlText;
            btnRegistrar.Location = new Point(338, 519);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(80, 29);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbSeleccionarTarea
            // 
            cmbSeleccionarTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeleccionarTarea.FormattingEnabled = true;
            cmbSeleccionarTarea.Location = new Point(127, 75);
            cmbSeleccionarTarea.Margin = new Padding(2);
            cmbSeleccionarTarea.Name = "cmbSeleccionarTarea";
            cmbSeleccionarTarea.Size = new Size(205, 23);
            cmbSeleccionarTarea.TabIndex = 10;
            cmbSeleccionarTarea.SelectedIndexChanged += cmbSeleccionarTarea_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 285);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 3;
            label4.Text = "Comentario (Opcional) :";
            // 
            // txtComentario
            // 
            txtComentario.Enabled = false;
            txtComentario.Location = new Point(33, 302);
            txtComentario.Margin = new Padding(2);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(387, 129);
            txtComentario.TabIndex = 1;
            txtComentario.TextChanged += txtComentario_TextChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(29, 180, 98);
            btnVolver.BackgroundImageLayout = ImageLayout.Center;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.Location = new Point(10, 10);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(34, 35);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "-";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRegistrarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1105, 615);
            Controls.Add(btnVolver);
            Controls.Add(mrcDetalles);
            Controls.Add(mrcSeleccionar);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmRegistrarTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tareas - Registrar Tareas";
            Load += frmRegistrarTareas_Load;
            mrcSeleccionar.ResumeLayout(false);
            mrcSeleccionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            mrcDetalles.ResumeLayout(false);
            mrcDetalles.PerformLayout();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox mrcSeleccionar;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSeleccionarLugar;
        private System.Windows.Forms.Label lblSeleccionarTarea;
        private System.Windows.Forms.Label lblSeleccionarFecha;
        private System.Windows.Forms.GroupBox mrcDetalles;
        private System.Windows.Forms.Button btnQuitarTarea;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblSeleccionarTareaCompletar;
        private System.Windows.Forms.ComboBox cmbSeleccionarTarea;
        private System.Windows.Forms.Label lblCompletarDetalles;
        private System.Windows.Forms.Button btnSeleccionarTarea;
        private System.Windows.Forms.Label lblAvisoSobrecarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnGuardarDetalles;
    }
}