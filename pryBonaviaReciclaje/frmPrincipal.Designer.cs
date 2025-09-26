namespace pryBonaviaReciclaje
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            lblMostrarUsuario = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            registrarTareasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            historialDeTareasToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            auditoriaToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirDelProgramaToolStripMenuItem = new ToolStripMenuItem();
            timerSesion = new System.Windows.Forms.Timer(components);
            mostrarTiempoSesion = new Label();
            lblMostrarFecha = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(14, 32, 37);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUsuario, lblMostrarUsuario });
            statusStrip1.Location = new Point(0, 430);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(641, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Padding = new Padding(0, 0, 3, 0);
            toolStripStatusLabel1.Size = new Size(3, 17);
            // 
            // lblUsuario
            // 
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 17);
            lblUsuario.Text = "Usuario:";
            // 
            // lblMostrarUsuario
            // 
            lblMostrarUsuario.ForeColor = SystemColors.Control;
            lblMostrarUsuario.Name = "lblMostrarUsuario";
            lblMostrarUsuario.Size = new Size(22, 17);
            lblMostrarUsuario.Text = "---";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(14, 32, 37);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tareasToolStripMenuItem, administraciónToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(641, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTareasToolStripMenuItem, toolStripSeparator2, historialDeTareasToolStripMenuItem });
            tareasToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tareasToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(61, 20);
            tareasToolStripMenuItem.Text = "Tareas...";
            // 
            // registrarTareasToolStripMenuItem
            // 
            registrarTareasToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            registrarTareasToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            registrarTareasToolStripMenuItem.Name = "registrarTareasToolStripMenuItem";
            registrarTareasToolStripMenuItem.Size = new Size(179, 22);
            registrarTareasToolStripMenuItem.Text = "Registrar Tareas..";
            registrarTareasToolStripMenuItem.Click += registrarTareasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(176, 6);
            // 
            // historialDeTareasToolStripMenuItem
            // 
            historialDeTareasToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            historialDeTareasToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            historialDeTareasToolStripMenuItem.Name = "historialDeTareasToolStripMenuItem";
            historialDeTareasToolStripMenuItem.Size = new Size(179, 22);
            historialDeTareasToolStripMenuItem.Text = "Historial de Tareas...";
            historialDeTareasToolStripMenuItem.Click += historialDeTareasToolStripMenuItem_Click;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, toolStripMenuItem1, auditoriaToolStripMenuItem });
            administraciónToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administraciónToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(109, 20);
            administraciónToolStripMenuItem.Text = "Administración...";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            usuariosToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios...";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(14, 32, 37);
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // auditoriaToolStripMenuItem
            // 
            auditoriaToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            auditoriaToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            auditoriaToolStripMenuItem.Size = new Size(180, 22);
            auditoriaToolStripMenuItem.Text = "Auditoria...";
            auditoriaToolStripMenuItem.Click += auditoriaToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, toolStripSeparator1, salirDelProgramaToolStripMenuItem });
            opcionesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opcionesToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(78, 20);
            opcionesToolStripMenuItem.Text = "Opciones...";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            cerrarSesiónToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión...";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            salirDelProgramaToolStripMenuItem.BackColor = Color.FromArgb(14, 32, 37);
            salirDelProgramaToolStripMenuItem.ForeColor = Color.FromArgb(29, 180, 98);
            salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            salirDelProgramaToolStripMenuItem.Size = new Size(180, 22);
            salirDelProgramaToolStripMenuItem.Text = "Salir del programa...";
            salirDelProgramaToolStripMenuItem.Click += salirDelProgramaToolStripMenuItem_Click;
            // 
            // timerSesion
            // 
            timerSesion.Interval = 1000;
            timerSesion.Tick += timerSesion_Tick;
            // 
            // mostrarTiempoSesion
            // 
            mostrarTiempoSesion.AutoSize = true;
            mostrarTiempoSesion.BackColor = Color.Transparent;
            mostrarTiempoSesion.Dock = DockStyle.Bottom;
            mostrarTiempoSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mostrarTiempoSesion.ForeColor = Color.FromArgb(29, 180, 98);
            mostrarTiempoSesion.Location = new Point(0, 415);
            mostrarTiempoSesion.Margin = new Padding(4, 0, 4, 0);
            mostrarTiempoSesion.Name = "mostrarTiempoSesion";
            mostrarTiempoSesion.Size = new Size(159, 15);
            mostrarTiempoSesion.TabIndex = 2;
            mostrarTiempoSesion.Text = "Tiempo en Sesión: 00:00:00";
            // 
            // lblMostrarFecha
            // 
            lblMostrarFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMostrarFecha.AutoSize = true;
            lblMostrarFecha.BackColor = Color.FromArgb(14, 32, 37);
            lblMostrarFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarFecha.ForeColor = SystemColors.Control;
            lblMostrarFecha.Location = new Point(508, 433);
            lblMostrarFecha.Margin = new Padding(4, 0, 4, 0);
            lblMostrarFecha.Name = "lblMostrarFecha";
            lblMostrarFecha.Size = new Size(114, 15);
            lblMostrarFecha.TabIndex = 3;
            lblMostrarFecha.Text = "Fecha: dd/MM/yyyy";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(641, 452);
            Controls.Add(lblMostrarFecha);
            Controls.Add(mostrarTiempoSesion);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMostrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.Timer timerSesion;
        private System.Windows.Forms.Label mostrarTiempoSesion;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem historialDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}