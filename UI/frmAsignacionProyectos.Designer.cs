namespace UI
{
    partial class frmAsignacionProyectos
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbListaColaboradores = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbColaboradoresDisponibles = new System.Windows.Forms.ListBox();
            this.grbProyectosColaborador = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbProyectosColaborador = new System.Windows.Forms.ListBox();
            this.grbListaProyectos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbProyectosDisponibles = new System.Windows.Forms.ListBox();
            this.grbColaboradoresProyecto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbColaboradoresProyecto = new System.Windows.Forms.ListBox();
            this.btnAsignar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesasignar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbListaColaboradores.SuspendLayout();
            this.grbProyectosColaborador.SuspendLayout();
            this.grbListaProyectos.SuspendLayout();
            this.grbColaboradoresProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(29, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1170, 45);
            this.pnlHeader.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(384, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(424, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "MÓDULO DE ASIGNACIONES A PROYECTOS";
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // grbListaColaboradores
            // 
            this.grbListaColaboradores.BorderRadius = 15;
            this.grbListaColaboradores.Controls.Add(this.ltbColaboradoresDisponibles);
            this.grbListaColaboradores.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaColaboradores.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaColaboradores.ForeColor = System.Drawing.Color.White;
            this.grbListaColaboradores.Location = new System.Drawing.Point(38, 88);
            this.grbListaColaboradores.Name = "grbListaColaboradores";
            this.grbListaColaboradores.Size = new System.Drawing.Size(371, 410);
            this.grbListaColaboradores.TabIndex = 24;
            this.grbListaColaboradores.Text = "Colaboradores disponibles";
            // 
            // ltbColaboradoresDisponibles
            // 
            this.ltbColaboradoresDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbColaboradoresDisponibles.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbColaboradoresDisponibles.FormattingEnabled = true;
            this.ltbColaboradoresDisponibles.HorizontalScrollbar = true;
            this.ltbColaboradoresDisponibles.ItemHeight = 16;
            this.ltbColaboradoresDisponibles.Location = new System.Drawing.Point(18, 52);
            this.ltbColaboradoresDisponibles.Name = "ltbColaboradoresDisponibles";
            this.ltbColaboradoresDisponibles.Size = new System.Drawing.Size(337, 340);
            this.ltbColaboradoresDisponibles.TabIndex = 30;
            this.ltbColaboradoresDisponibles.SelectedIndexChanged += new System.EventHandler(this.ltbColaboradoresDisponibles_SelectedIndexChanged);
            // 
            // grbProyectosColaborador
            // 
            this.grbProyectosColaborador.BorderRadius = 15;
            this.grbProyectosColaborador.Controls.Add(this.ltbProyectosColaborador);
            this.grbProyectosColaborador.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.grbProyectosColaborador.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProyectosColaborador.ForeColor = System.Drawing.Color.White;
            this.grbProyectosColaborador.Location = new System.Drawing.Point(38, 524);
            this.grbProyectosColaborador.Name = "grbProyectosColaborador";
            this.grbProyectosColaborador.Size = new System.Drawing.Size(371, 161);
            this.grbProyectosColaborador.TabIndex = 25;
            this.grbProyectosColaborador.Text = "Proyectos asignados al colaborador";
            // 
            // ltbProyectosColaborador
            // 
            this.ltbProyectosColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbProyectosColaborador.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbProyectosColaborador.FormattingEnabled = true;
            this.ltbProyectosColaborador.HorizontalScrollbar = true;
            this.ltbProyectosColaborador.ItemHeight = 16;
            this.ltbProyectosColaborador.Location = new System.Drawing.Point(18, 54);
            this.ltbProyectosColaborador.Name = "ltbProyectosColaborador";
            this.ltbProyectosColaborador.Size = new System.Drawing.Size(337, 84);
            this.ltbProyectosColaborador.TabIndex = 31;
            // 
            // grbListaProyectos
            // 
            this.grbListaProyectos.BorderRadius = 15;
            this.grbListaProyectos.Controls.Add(this.ltbProyectosDisponibles);
            this.grbListaProyectos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaProyectos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProyectos.ForeColor = System.Drawing.Color.White;
            this.grbListaProyectos.Location = new System.Drawing.Point(551, 88);
            this.grbListaProyectos.Name = "grbListaProyectos";
            this.grbListaProyectos.Size = new System.Drawing.Size(369, 410);
            this.grbListaProyectos.TabIndex = 25;
            this.grbListaProyectos.Text = "Proyectos disponibles";
            // 
            // ltbProyectosDisponibles
            // 
            this.ltbProyectosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbProyectosDisponibles.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbProyectosDisponibles.FormattingEnabled = true;
            this.ltbProyectosDisponibles.HorizontalScrollbar = true;
            this.ltbProyectosDisponibles.ItemHeight = 16;
            this.ltbProyectosDisponibles.Location = new System.Drawing.Point(21, 52);
            this.ltbProyectosDisponibles.Name = "ltbProyectosDisponibles";
            this.ltbProyectosDisponibles.Size = new System.Drawing.Size(331, 340);
            this.ltbProyectosDisponibles.TabIndex = 31;
            this.ltbProyectosDisponibles.SelectedIndexChanged += new System.EventHandler(this.ltbProyectosDisponibles_SelectedIndexChanged);
            // 
            // grbColaboradoresProyecto
            // 
            this.grbColaboradoresProyecto.BorderRadius = 15;
            this.grbColaboradoresProyecto.Controls.Add(this.ltbColaboradoresProyecto);
            this.grbColaboradoresProyecto.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.grbColaboradoresProyecto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbColaboradoresProyecto.ForeColor = System.Drawing.Color.White;
            this.grbColaboradoresProyecto.Location = new System.Drawing.Point(551, 524);
            this.grbColaboradoresProyecto.Name = "grbColaboradoresProyecto";
            this.grbColaboradoresProyecto.Size = new System.Drawing.Size(369, 161);
            this.grbColaboradoresProyecto.TabIndex = 26;
            this.grbColaboradoresProyecto.Text = "Colaboradores asignados al proyecto";
            // 
            // ltbColaboradoresProyecto
            // 
            this.ltbColaboradoresProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbColaboradoresProyecto.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbColaboradoresProyecto.FormattingEnabled = true;
            this.ltbColaboradoresProyecto.HorizontalScrollbar = true;
            this.ltbColaboradoresProyecto.ItemHeight = 16;
            this.ltbColaboradoresProyecto.Location = new System.Drawing.Point(21, 54);
            this.ltbColaboradoresProyecto.Name = "ltbColaboradoresProyecto";
            this.ltbColaboradoresProyecto.Size = new System.Drawing.Size(331, 84);
            this.ltbColaboradoresProyecto.TabIndex = 32;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BorderRadius = 10;
            this.btnAsignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAsignar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(967, 258);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(181, 66);
            this.btnAsignar.TabIndex = 27;
            this.btnAsignar.Text = "Asignar colaborador al proyecto";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BorderRadius = 10;
            this.btnDesasignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesasignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnDesasignar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.Color.White;
            this.btnDesasignar.Location = new System.Drawing.Point(967, 584);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(181, 66);
            this.btnDesasignar.TabIndex = 29;
            this.btnDesasignar.Text = "Des-asignar colaborador del proyecto";
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // frmAsignacionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.grbColaboradoresProyecto);
            this.Controls.Add(this.grbListaProyectos);
            this.Controls.Add(this.grbProyectosColaborador);
            this.Controls.Add(this.grbListaColaboradores);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAsignacionProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAsignacionProyectos_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbListaColaboradores.ResumeLayout(false);
            this.grbProyectosColaborador.ResumeLayout(false);
            this.grbListaProyectos.ResumeLayout(false);
            this.grbColaboradoresProyecto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaColaboradores;
        private Guna.UI2.WinForms.Guna2GroupBox grbProyectosColaborador;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaProyectos;
        private Guna.UI2.WinForms.Guna2GroupBox grbColaboradoresProyecto;
        private Guna.UI2.WinForms.Guna2Button btnAsignar;
        private Guna.UI2.WinForms.Guna2Button btnDesasignar;
        private System.Windows.Forms.ListBox ltbColaboradoresDisponibles;
        private System.Windows.Forms.ListBox ltbProyectosColaborador;
        private System.Windows.Forms.ListBox ltbProyectosDisponibles;
        private System.Windows.Forms.ListBox ltbColaboradoresProyecto;
    }
}