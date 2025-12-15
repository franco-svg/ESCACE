namespace UI
{
    partial class frmModuloPermisos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbUsuarios = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbListaUsuarios = new System.Windows.Forms.ListBox();
            this.grbRoles = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbListaRoles = new System.Windows.Forms.ListBox();
            this.grbPermisos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbListaPermisos = new System.Windows.Forms.ListBox();
            this.grbPermisosRol = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tvwRolesPermisosRol = new System.Windows.Forms.TreeView();
            this.grbRolesPermisosUsuario = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tvwRolesPermisosUsuario = new System.Windows.Forms.TreeView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDesasignarRolUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnAsignarRolUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDesasignarPermisoUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnAsignarPermisoUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDesasignarPermisoRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnAsignarPermisoRol = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblRolAsignable = new System.Windows.Forms.Label();
            this.cbxRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDesasignarRolRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnAsignarRolRol = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnEliminarPermiso = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarPermiso = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnEliminarRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarRol = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarRol = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbUsuarios.SuspendLayout();
            this.grbRoles.SuspendLayout();
            this.grbPermisos.SuspendLayout();
            this.grbPermisosRol.SuspendLayout();
            this.grbRolesPermisosUsuario.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(374, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "MÓDULO DE ROLES Y PERMISOS";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(27, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 29;
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.BorderRadius = 15;
            this.grbUsuarios.Controls.Add(this.ltbListaUsuarios);
            this.grbUsuarios.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grbUsuarios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbUsuarios.Location = new System.Drawing.Point(27, 331);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(178, 369);
            this.grbUsuarios.TabIndex = 48;
            this.grbUsuarios.Text = "Usuarios disponibles";
            // 
            // ltbListaUsuarios
            // 
            this.ltbListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbListaUsuarios.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaUsuarios.FormattingEnabled = true;
            this.ltbListaUsuarios.HorizontalScrollbar = true;
            this.ltbListaUsuarios.ItemHeight = 16;
            this.ltbListaUsuarios.Location = new System.Drawing.Point(14, 47);
            this.ltbListaUsuarios.Name = "ltbListaUsuarios";
            this.ltbListaUsuarios.Size = new System.Drawing.Size(147, 308);
            this.ltbListaUsuarios.TabIndex = 18;
            this.ltbListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.ltbListaUsuarios_SelectedIndexChanged);
            // 
            // grbRoles
            // 
            this.grbRoles.BorderRadius = 15;
            this.grbRoles.Controls.Add(this.ltbListaRoles);
            this.grbRoles.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRoles.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grbRoles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRoles.ForeColor = System.Drawing.Color.White;
            this.grbRoles.Location = new System.Drawing.Point(211, 331);
            this.grbRoles.Name = "grbRoles";
            this.grbRoles.Size = new System.Drawing.Size(178, 369);
            this.grbRoles.TabIndex = 49;
            this.grbRoles.Text = "Roles disponibles";
            // 
            // ltbListaRoles
            // 
            this.ltbListaRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbListaRoles.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaRoles.FormattingEnabled = true;
            this.ltbListaRoles.HorizontalScrollbar = true;
            this.ltbListaRoles.ItemHeight = 16;
            this.ltbListaRoles.Location = new System.Drawing.Point(14, 47);
            this.ltbListaRoles.Name = "ltbListaRoles";
            this.ltbListaRoles.Size = new System.Drawing.Size(147, 308);
            this.ltbListaRoles.TabIndex = 18;
            this.ltbListaRoles.SelectedIndexChanged += new System.EventHandler(this.ltbListaRoles_SelectedIndexChanged);
            // 
            // grbPermisos
            // 
            this.grbPermisos.BorderRadius = 15;
            this.grbPermisos.Controls.Add(this.ltbListaPermisos);
            this.grbPermisos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbPermisos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grbPermisos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPermisos.ForeColor = System.Drawing.Color.White;
            this.grbPermisos.Location = new System.Drawing.Point(395, 331);
            this.grbPermisos.Name = "grbPermisos";
            this.grbPermisos.Size = new System.Drawing.Size(178, 369);
            this.grbPermisos.TabIndex = 49;
            this.grbPermisos.Text = "Permisos disponibles";
            // 
            // ltbListaPermisos
            // 
            this.ltbListaPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbListaPermisos.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaPermisos.FormattingEnabled = true;
            this.ltbListaPermisos.HorizontalScrollbar = true;
            this.ltbListaPermisos.ItemHeight = 16;
            this.ltbListaPermisos.Location = new System.Drawing.Point(14, 47);
            this.ltbListaPermisos.Name = "ltbListaPermisos";
            this.ltbListaPermisos.Size = new System.Drawing.Size(147, 308);
            this.ltbListaPermisos.TabIndex = 18;
            // 
            // grbPermisosRol
            // 
            this.grbPermisosRol.BorderRadius = 15;
            this.grbPermisosRol.Controls.Add(this.tvwRolesPermisosRol);
            this.grbPermisosRol.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbPermisosRol.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grbPermisosRol.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPermisosRol.ForeColor = System.Drawing.Color.White;
            this.grbPermisosRol.Location = new System.Drawing.Point(579, 331);
            this.grbPermisosRol.Name = "grbPermisosRol";
            this.grbPermisosRol.Size = new System.Drawing.Size(236, 369);
            this.grbPermisosRol.TabIndex = 49;
            this.grbPermisosRol.Text = "Roles y permisos por rol";
            // 
            // tvwRolesPermisosRol
            // 
            this.tvwRolesPermisosRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwRolesPermisosRol.Location = new System.Drawing.Point(14, 47);
            this.tvwRolesPermisosRol.Name = "tvwRolesPermisosRol";
            this.tvwRolesPermisosRol.Size = new System.Drawing.Size(208, 308);
            this.tvwRolesPermisosRol.TabIndex = 51;
            // 
            // grbRolesPermisosUsuario
            // 
            this.grbRolesPermisosUsuario.BorderRadius = 15;
            this.grbRolesPermisosUsuario.Controls.Add(this.tvwRolesPermisosUsuario);
            this.grbRolesPermisosUsuario.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRolesPermisosUsuario.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grbRolesPermisosUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRolesPermisosUsuario.ForeColor = System.Drawing.Color.White;
            this.grbRolesPermisosUsuario.Location = new System.Drawing.Point(821, 331);
            this.grbRolesPermisosUsuario.Name = "grbRolesPermisosUsuario";
            this.grbRolesPermisosUsuario.Size = new System.Drawing.Size(325, 369);
            this.grbRolesPermisosUsuario.TabIndex = 49;
            this.grbRolesPermisosUsuario.Text = "Roles y permisos del usuario";
            // 
            // tvwRolesPermisosUsuario
            // 
            this.tvwRolesPermisosUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwRolesPermisosUsuario.Location = new System.Drawing.Point(16, 47);
            this.tvwRolesPermisosUsuario.Name = "tvwRolesPermisosUsuario";
            this.tvwRolesPermisosUsuario.Size = new System.Drawing.Size(294, 308);
            this.tvwRolesPermisosUsuario.TabIndex = 50;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.btnDesasignarRolUsuario);
            this.guna2GroupBox1.Controls.Add(this.btnAsignarRolUsuario);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(27, 59);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(178, 130);
            this.guna2GroupBox1.TabIndex = 49;
            this.guna2GroupBox1.Text = "Usuarios y roles";
            // 
            // btnDesasignarRolUsuario
            // 
            this.btnDesasignarRolUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignarRolUsuario.BorderRadius = 10;
            this.btnDesasignarRolUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarRolUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarRolUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarRolUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarRolUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnDesasignarRolUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarRolUsuario.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarRolUsuario.Location = new System.Drawing.Point(9, 85);
            this.btnDesasignarRolUsuario.Name = "btnDesasignarRolUsuario";
            this.btnDesasignarRolUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnDesasignarRolUsuario.TabIndex = 53;
            this.btnDesasignarRolUsuario.Text = "Desasignar rol de usuario";
            this.btnDesasignarRolUsuario.Click += new System.EventHandler(this.btnDesasignarRolUsuario_Click);
            // 
            // btnAsignarRolUsuario
            // 
            this.btnAsignarRolUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarRolUsuario.BorderRadius = 10;
            this.btnAsignarRolUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarRolUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarRolUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarRolUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarRolUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnAsignarRolUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRolUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRolUsuario.Location = new System.Drawing.Point(9, 40);
            this.btnAsignarRolUsuario.Name = "btnAsignarRolUsuario";
            this.btnAsignarRolUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnAsignarRolUsuario.TabIndex = 52;
            this.btnAsignarRolUsuario.Text = "Asignar rol a usuario";
            this.btnAsignarRolUsuario.Click += new System.EventHandler(this.btnAsignarRolUsuario_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.btnDesasignarPermisoUsuario);
            this.guna2GroupBox2.Controls.Add(this.btnAsignarPermisoUsuario);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(27, 195);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(178, 130);
            this.guna2GroupBox2.TabIndex = 54;
            this.guna2GroupBox2.Text = "Usuarios y permisos";
            // 
            // btnDesasignarPermisoUsuario
            // 
            this.btnDesasignarPermisoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignarPermisoUsuario.BorderRadius = 10;
            this.btnDesasignarPermisoUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarPermisoUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarPermisoUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarPermisoUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarPermisoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnDesasignarPermisoUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarPermisoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarPermisoUsuario.Location = new System.Drawing.Point(9, 85);
            this.btnDesasignarPermisoUsuario.Name = "btnDesasignarPermisoUsuario";
            this.btnDesasignarPermisoUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnDesasignarPermisoUsuario.TabIndex = 53;
            this.btnDesasignarPermisoUsuario.Text = "Desasignar permiso de usuario";
            this.btnDesasignarPermisoUsuario.Click += new System.EventHandler(this.btnDesasignarPermisoUsuario_Click);
            // 
            // btnAsignarPermisoUsuario
            // 
            this.btnAsignarPermisoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarPermisoUsuario.BorderRadius = 10;
            this.btnAsignarPermisoUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPermisoUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPermisoUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarPermisoUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarPermisoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnAsignarPermisoUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPermisoUsuario.Location = new System.Drawing.Point(9, 40);
            this.btnAsignarPermisoUsuario.Name = "btnAsignarPermisoUsuario";
            this.btnAsignarPermisoUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnAsignarPermisoUsuario.TabIndex = 52;
            this.btnAsignarPermisoUsuario.Text = "Asignar permiso a usuario";
            this.btnAsignarPermisoUsuario.Click += new System.EventHandler(this.btnAsignarPermisoUsuario_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 15;
            this.guna2GroupBox3.Controls.Add(this.btnDesasignarPermisoRol);
            this.guna2GroupBox3.Controls.Add(this.btnAsignarPermisoRol);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(211, 59);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(178, 266);
            this.guna2GroupBox3.TabIndex = 54;
            this.guna2GroupBox3.Text = "Roles y permisos";
            // 
            // btnDesasignarPermisoRol
            // 
            this.btnDesasignarPermisoRol.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignarPermisoRol.BorderRadius = 10;
            this.btnDesasignarPermisoRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarPermisoRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarPermisoRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarPermisoRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarPermisoRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnDesasignarPermisoRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarPermisoRol.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarPermisoRol.Location = new System.Drawing.Point(9, 152);
            this.btnDesasignarPermisoRol.Name = "btnDesasignarPermisoRol";
            this.btnDesasignarPermisoRol.Size = new System.Drawing.Size(157, 39);
            this.btnDesasignarPermisoRol.TabIndex = 53;
            this.btnDesasignarPermisoRol.Text = "Desasignar permiso de rol";
            this.btnDesasignarPermisoRol.Click += new System.EventHandler(this.btnDesasignarPermisoRol_Click);
            // 
            // btnAsignarPermisoRol
            // 
            this.btnAsignarPermisoRol.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarPermisoRol.BorderRadius = 10;
            this.btnAsignarPermisoRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPermisoRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarPermisoRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarPermisoRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarPermisoRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnAsignarPermisoRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisoRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPermisoRol.Location = new System.Drawing.Point(9, 80);
            this.btnAsignarPermisoRol.Name = "btnAsignarPermisoRol";
            this.btnAsignarPermisoRol.Size = new System.Drawing.Size(157, 39);
            this.btnAsignarPermisoRol.TabIndex = 52;
            this.btnAsignarPermisoRol.Text = "Asignar permiso a rol";
            this.btnAsignarPermisoRol.Click += new System.EventHandler(this.btnAsignarPermisoRol_Click);
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 15;
            this.guna2GroupBox4.Controls.Add(this.lblRolAsignable);
            this.guna2GroupBox4.Controls.Add(this.cbxRoles);
            this.guna2GroupBox4.Controls.Add(this.btnDesasignarRolRol);
            this.guna2GroupBox4.Controls.Add(this.btnAsignarRolRol);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(395, 59);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(420, 266);
            this.guna2GroupBox4.TabIndex = 55;
            this.guna2GroupBox4.Text = "Roles y roles";
            // 
            // lblRolAsignable
            // 
            this.lblRolAsignable.AutoSize = true;
            this.lblRolAsignable.BackColor = System.Drawing.Color.Transparent;
            this.lblRolAsignable.ForeColor = System.Drawing.Color.Black;
            this.lblRolAsignable.Location = new System.Drawing.Point(180, 58);
            this.lblRolAsignable.Name = "lblRolAsignable";
            this.lblRolAsignable.Size = new System.Drawing.Size(105, 19);
            this.lblRolAsignable.TabIndex = 55;
            this.lblRolAsignable.Text = "Rol a asignar";
            // 
            // cbxRoles
            // 
            this.cbxRoles.AutoRoundedCorners = true;
            this.cbxRoles.BackColor = System.Drawing.Color.Transparent;
            this.cbxRoles.BorderColor = System.Drawing.Color.Black;
            this.cbxRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRoles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRoles.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoles.ForeColor = System.Drawing.Color.Black;
            this.cbxRoles.ItemHeight = 30;
            this.cbxRoles.Location = new System.Drawing.Point(173, 80);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(202, 36);
            this.cbxRoles.TabIndex = 54;
            // 
            // btnDesasignarRolRol
            // 
            this.btnDesasignarRolRol.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignarRolRol.BorderRadius = 10;
            this.btnDesasignarRolRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarRolRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignarRolRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarRolRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignarRolRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnDesasignarRolRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarRolRol.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarRolRol.Location = new System.Drawing.Point(39, 152);
            this.btnDesasignarRolRol.Name = "btnDesasignarRolRol";
            this.btnDesasignarRolRol.Size = new System.Drawing.Size(118, 39);
            this.btnDesasignarRolRol.TabIndex = 53;
            this.btnDesasignarRolRol.Text = "Desasignar rol de otro rol";
            this.btnDesasignarRolRol.Click += new System.EventHandler(this.btnDesasignarRolRol_Click);
            // 
            // btnAsignarRolRol
            // 
            this.btnAsignarRolRol.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarRolRol.BorderRadius = 10;
            this.btnAsignarRolRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarRolRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignarRolRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarRolRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignarRolRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnAsignarRolRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRolRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRolRol.Location = new System.Drawing.Point(39, 80);
            this.btnAsignarRolRol.Name = "btnAsignarRolRol";
            this.btnAsignarRolRol.Size = new System.Drawing.Size(118, 39);
            this.btnAsignarRolRol.TabIndex = 52;
            this.btnAsignarRolRol.Text = "Asignar rol a otro rol";
            this.btnAsignarRolRol.Click += new System.EventHandler(this.btnAsignarRolRol_Click);
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderRadius = 15;
            this.guna2GroupBox5.Controls.Add(this.btnEliminarPermiso);
            this.guna2GroupBox5.Controls.Add(this.btnAgregarPermiso);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox5.Location = new System.Drawing.Point(821, 59);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(325, 113);
            this.guna2GroupBox5.TabIndex = 55;
            this.guna2GroupBox5.Text = "Permisos";
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPermiso.BorderRadius = 10;
            this.btnEliminarPermiso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPermiso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPermiso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarPermiso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarPermiso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarPermiso.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPermiso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPermiso.Location = new System.Drawing.Point(185, 51);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(90, 39);
            this.btnEliminarPermiso.TabIndex = 55;
            this.btnEliminarPermiso.Text = "Eliminar permiso";
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPermiso.BorderRadius = 10;
            this.btnAgregarPermiso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPermiso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPermiso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarPermiso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarPermiso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarPermiso.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermiso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPermiso.Location = new System.Drawing.Point(48, 51);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(90, 39);
            this.btnAgregarPermiso.TabIndex = 52;
            this.btnAgregarPermiso.Text = "Agregar permiso";
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BorderRadius = 15;
            this.guna2GroupBox6.Controls.Add(this.btnEliminarRol);
            this.guna2GroupBox6.Controls.Add(this.btnModificarRol);
            this.guna2GroupBox6.Controls.Add(this.btnAgregarRol);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox6.Location = new System.Drawing.Point(821, 212);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.Size = new System.Drawing.Size(325, 113);
            this.guna2GroupBox6.TabIndex = 56;
            this.guna2GroupBox6.Text = "Roles";
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarRol.BorderRadius = 10;
            this.btnEliminarRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRol.Location = new System.Drawing.Point(220, 51);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(90, 39);
            this.btnEliminarRol.TabIndex = 55;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarRol.BorderRadius = 10;
            this.btnModificarRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRol.ForeColor = System.Drawing.Color.White;
            this.btnModificarRol.Location = new System.Drawing.Point(120, 51);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Size = new System.Drawing.Size(90, 39);
            this.btnModificarRol.TabIndex = 54;
            this.btnModificarRol.Text = "Modificar rol";
            this.btnModificarRol.Click += new System.EventHandler(this.btnModificarRol_Click);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarRol.BorderRadius = 10;
            this.btnAgregarRol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarRol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarRol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarRol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAgregarRol.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRol.Location = new System.Drawing.Point(16, 51);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(90, 39);
            this.btnAgregarRol.TabIndex = 52;
            this.btnAgregarRol.Text = "Agregar rol";
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // frmModuloPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.guna2GroupBox6);
            this.Controls.Add(this.guna2GroupBox5);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.grbRolesPermisosUsuario);
            this.Controls.Add(this.grbPermisosRol);
            this.Controls.Add(this.grbPermisos);
            this.Controls.Add(this.grbRoles);
            this.Controls.Add(this.grbUsuarios);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloPermisos_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbUsuarios.ResumeLayout(false);
            this.grbRoles.ResumeLayout(false);
            this.grbPermisos.ResumeLayout(false);
            this.grbPermisosRol.ResumeLayout(false);
            this.grbRolesPermisosUsuario.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCBackButton ucBackButton2;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2GroupBox grbUsuarios;
        private System.Windows.Forms.ListBox ltbListaUsuarios;
        private Guna.UI2.WinForms.Guna2GroupBox grbRoles;
        private System.Windows.Forms.ListBox ltbListaRoles;
        private Guna.UI2.WinForms.Guna2GroupBox grbPermisos;
        private System.Windows.Forms.ListBox ltbListaPermisos;
        private Guna.UI2.WinForms.Guna2GroupBox grbPermisosRol;
        private Guna.UI2.WinForms.Guna2GroupBox grbRolesPermisosUsuario;
        private System.Windows.Forms.TreeView tvwRolesPermisosUsuario;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDesasignarRolUsuario;
        private Guna.UI2.WinForms.Guna2Button btnAsignarRolUsuario;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnDesasignarPermisoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnAsignarPermisoUsuario;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button btnDesasignarPermisoRol;
        private Guna.UI2.WinForms.Guna2Button btnAsignarPermisoRol;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2Button btnDesasignarRolRol;
        private Guna.UI2.WinForms.Guna2Button btnAsignarRolRol;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPermiso;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPermiso;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private Guna.UI2.WinForms.Guna2Button btnEliminarRol;
        private Guna.UI2.WinForms.Guna2Button btnModificarRol;
        private Guna.UI2.WinForms.Guna2Button btnAgregarRol;
        private Guna.UI2.WinForms.Guna2ComboBox cbxRoles;
        private System.Windows.Forms.Label lblRolAsignable;
        private System.Windows.Forms.TreeView tvwRolesPermisosRol;
    }
}