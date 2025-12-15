namespace UI
{
    partial class frmMenu
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

        //ARGB = 255, 50, 100, 150

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesYPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPersonaAProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFichasDeProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeaciónDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCronogramasDeProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarBacklogDeProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteriaDeRecursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteriaDeAdministraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteríaDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstBarraPestanas = new System.Windows.Forms.MenuStrip();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.mstBarraPestanas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.lblTitulo.Location = new System.Drawing.Point(482, 259);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 115);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ESCACE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.rolesYPermisosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.usuariosToolStripMenuItem.Text = "Arquitectura base";
            this.usuariosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // rolesYPermisosToolStripMenuItem
            // 
            this.rolesYPermisosToolStripMenuItem.Name = "rolesYPermisosToolStripMenuItem";
            this.rolesYPermisosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rolesYPermisosToolStripMenuItem.Text = "Roles y permisos";
            this.rolesYPermisosToolStripMenuItem.Click += new System.EventHandler(this.rolesYPermisosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarRolToolStripMenuItem,
            this.registrarPersonaToolStripMenuItem,
            this.asignarPersonaAProyectoToolStripMenuItem});
            this.recursosHumanosToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursosHumanosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.recursosHumanosToolStripMenuItem.Text = "Gestión de recursos humanos";
            this.recursosHumanosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registrarRolToolStripMenuItem
            // 
            this.registrarRolToolStripMenuItem.Name = "registrarRolToolStripMenuItem";
            this.registrarRolToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registrarRolToolStripMenuItem.Text = "Roles";
            this.registrarRolToolStripMenuItem.Click += new System.EventHandler(this.registrarRolToolStripMenuItem_Click);
            // 
            // registrarPersonaToolStripMenuItem
            // 
            this.registrarPersonaToolStripMenuItem.Name = "registrarPersonaToolStripMenuItem";
            this.registrarPersonaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registrarPersonaToolStripMenuItem.Text = "Colaboradores";
            this.registrarPersonaToolStripMenuItem.Click += new System.EventHandler(this.registrarPersonaToolStripMenuItem_Click);
            // 
            // asignarPersonaAProyectoToolStripMenuItem
            // 
            this.asignarPersonaAProyectoToolStripMenuItem.Name = "asignarPersonaAProyectoToolStripMenuItem";
            this.asignarPersonaAProyectoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.asignarPersonaAProyectoToolStripMenuItem.Text = "Asignaciones a proyectos";
            this.asignarPersonaAProyectoToolStripMenuItem.Click += new System.EventHandler(this.asignarPersonaAProyectoToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.registrarContratosToolStripMenuItem,
            this.registrarFichasDeProyectoToolStripMenuItem});
            this.administraciónToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.administraciónToolStripMenuItem.Text = "Gestión de administración";
            this.administraciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registrarClientesToolStripMenuItem
            // 
            this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
            this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarClientesToolStripMenuItem.Text = "Clientes";
            this.registrarClientesToolStripMenuItem.Click += new System.EventHandler(this.registrarClientesToolStripMenuItem_Click);
            // 
            // registrarContratosToolStripMenuItem
            // 
            this.registrarContratosToolStripMenuItem.Name = "registrarContratosToolStripMenuItem";
            this.registrarContratosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarContratosToolStripMenuItem.Text = "Contratos";
            this.registrarContratosToolStripMenuItem.Click += new System.EventHandler(this.registrarContratosToolStripMenuItem_Click);
            // 
            // registrarFichasDeProyectoToolStripMenuItem
            // 
            this.registrarFichasDeProyectoToolStripMenuItem.Name = "registrarFichasDeProyectoToolStripMenuItem";
            this.registrarFichasDeProyectoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarFichasDeProyectoToolStripMenuItem.Text = "Fichas de proyecto";
            this.registrarFichasDeProyectoToolStripMenuItem.Click += new System.EventHandler(this.registrarFichasDeProyectoToolStripMenuItem_Click);
            // 
            // planeaciónDeProyectosToolStripMenuItem
            // 
            this.planeaciónDeProyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProyectoToolStripMenuItem,
            this.gestionarCronogramasDeProyectoToolStripMenuItem,
            this.gestionarBacklogDeProyectoToolStripMenuItem});
            this.planeaciónDeProyectosToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeaciónDeProyectosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.planeaciónDeProyectosToolStripMenuItem.Name = "planeaciónDeProyectosToolStripMenuItem";
            this.planeaciónDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.planeaciónDeProyectosToolStripMenuItem.Text = "Gestión de planeación de proyectos";
            this.planeaciónDeProyectosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registrarProyectoToolStripMenuItem
            // 
            this.registrarProyectoToolStripMenuItem.Name = "registrarProyectoToolStripMenuItem";
            this.registrarProyectoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.registrarProyectoToolStripMenuItem.Text = "Proyectos";
            this.registrarProyectoToolStripMenuItem.Click += new System.EventHandler(this.registrarProyectoToolStripMenuItem_Click);
            // 
            // gestionarCronogramasDeProyectoToolStripMenuItem
            // 
            this.gestionarCronogramasDeProyectoToolStripMenuItem.Name = "gestionarCronogramasDeProyectoToolStripMenuItem";
            this.gestionarCronogramasDeProyectoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.gestionarCronogramasDeProyectoToolStripMenuItem.Text = "Cronograma de proyectos";
            this.gestionarCronogramasDeProyectoToolStripMenuItem.Click += new System.EventHandler(this.gestionarCronogramasDeProyectoToolStripMenuItem_Click);
            // 
            // gestionarBacklogDeProyectoToolStripMenuItem
            // 
            this.gestionarBacklogDeProyectoToolStripMenuItem.Name = "gestionarBacklogDeProyectoToolStripMenuItem";
            this.gestionarBacklogDeProyectoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.gestionarBacklogDeProyectoToolStripMenuItem.Text = "Backlog de proyectos";
            this.gestionarBacklogDeProyectoToolStripMenuItem.Click += new System.EventHandler(this.gestionarBacklogDeProyectoToolStripMenuItem_Click);
            // 
            // reporteríaToolStripMenuItem
            // 
            this.reporteríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteriaDeAdministraciónToolStripMenuItem,
            this.reporteríaDeProyectosToolStripMenuItem,
            this.reporteriaDeRecursosHumanosToolStripMenuItem});
            this.reporteríaToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteríaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reporteríaToolStripMenuItem.Name = "reporteríaToolStripMenuItem";
            this.reporteríaToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.reporteríaToolStripMenuItem.Text = "Gestión de auditoría";
            this.reporteríaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reporteriaDeRecursosHumanosToolStripMenuItem
            // 
            this.reporteriaDeRecursosHumanosToolStripMenuItem.Name = "reporteriaDeRecursosHumanosToolStripMenuItem";
            this.reporteriaDeRecursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.reporteriaDeRecursosHumanosToolStripMenuItem.Text = "Reporteria de recursos humanos";
            this.reporteriaDeRecursosHumanosToolStripMenuItem.Click += new System.EventHandler(this.reporteriaDeRecursosHumanosToolStripMenuItem_Click);
            // 
            // reporteriaDeAdministraciónToolStripMenuItem
            // 
            this.reporteriaDeAdministraciónToolStripMenuItem.Name = "reporteriaDeAdministraciónToolStripMenuItem";
            this.reporteriaDeAdministraciónToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.reporteriaDeAdministraciónToolStripMenuItem.Text = "Reporteria de administración";
            this.reporteriaDeAdministraciónToolStripMenuItem.Click += new System.EventHandler(this.reporteriaDeAdministraciónToolStripMenuItem_Click);
            // 
            // reporteríaDeProyectosToolStripMenuItem
            // 
            this.reporteríaDeProyectosToolStripMenuItem.Name = "reporteríaDeProyectosToolStripMenuItem";
            this.reporteríaDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.reporteríaDeProyectosToolStripMenuItem.Text = "Reporteria de planeación de proyectos";
            this.reporteríaDeProyectosToolStripMenuItem.Click += new System.EventHandler(this.reporteríaDeProyectosToolStripMenuItem_Click);
            // 
            // mstBarraPestanas
            // 
            this.mstBarraPestanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.mstBarraPestanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mstBarraPestanas.Dock = System.Windows.Forms.DockStyle.Left;
            this.mstBarraPestanas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstBarraPestanas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.planeaciónDeProyectosToolStripMenuItem,
            this.reporteríaToolStripMenuItem});
            this.mstBarraPestanas.Location = new System.Drawing.Point(0, 0);
            this.mstBarraPestanas.Name = "mstBarraPestanas";
            this.mstBarraPestanas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mstBarraPestanas.Size = new System.Drawing.Size(227, 711);
            this.mstBarraPestanas.TabIndex = 0;
            this.mstBarraPestanas.Text = "menuStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lblUsuario.Location = new System.Drawing.Point(12, 627);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(36, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "nn";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(848, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESCACE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 655);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 44);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cerrar sesión";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mstBarraPestanas);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mstBarraPestanas;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mstBarraPestanas.ResumeLayout(false);
            this.mstBarraPestanas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPersonaAProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFichasDeProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeaciónDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCronogramasDeProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarBacklogDeProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteriaDeRecursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteriaDeAdministraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteríaDeProyectosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mstBarraPestanas;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolesYPermisosToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
    }
}

