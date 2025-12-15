namespace UI
{
    partial class frmModuloBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ucBackButton1 = new UI.UCBackButton();
            this.grbDatosUsuario = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.btnListarTodo = new Guna.UI2.WinForms.Guna2Button();
            this.grbListaBitacoras = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaBitacoras = new System.Windows.Forms.DataGridView();
            this.btnListarBackups = new Guna.UI2.WinForms.Guna2Button();
            this.btnListarRestores = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            this.grbListaBitacoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBitacoras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.ucBackButton1);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(29, 32);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(452, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "MÓDULO DE BITACORA";
            // 
            // ucBackButton1
            // 
            this.ucBackButton1.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton1.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton1.Name = "ucBackButton1";
            this.ucBackButton1.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton1.TabIndex = 2;
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.BorderRadius = 15;
            this.grbDatosUsuario.Controls.Add(this.txtUsername);
            this.grbDatosUsuario.Controls.Add(this.lblTituloMod);
            this.grbDatosUsuario.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.grbDatosUsuario.Location = new System.Drawing.Point(528, 238);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(482, 109);
            this.grbDatosUsuario.TabIndex = 55;
            this.grbDatosUsuario.Text = "Datos del usuario que realizó el restore/backup";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.BorderRadius = 17;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(272, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(173, 36);
            this.txtUsername.TabIndex = 6;
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMod.Location = new System.Drawing.Point(30, 56);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(97, 23);
            this.lblTituloMod.TabIndex = 5;
            this.lblTituloMod.Text = "Username";
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BorderRadius = 10;
            this.btnListarTodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListarTodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListarTodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarTodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarTodo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnListarTodo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.White;
            this.btnListarTodo.Location = new System.Drawing.Point(528, 407);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(119, 54);
            this.btnListarTodo.TabIndex = 54;
            this.btnListarTodo.Text = "Listar todo";
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // grbListaBitacoras
            // 
            this.grbListaBitacoras.BorderRadius = 15;
            this.grbListaBitacoras.Controls.Add(this.dgvListaBitacoras);
            this.grbListaBitacoras.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaBitacoras.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaBitacoras.ForeColor = System.Drawing.Color.White;
            this.grbListaBitacoras.Location = new System.Drawing.Point(104, 122);
            this.grbListaBitacoras.Name = "grbListaBitacoras";
            this.grbListaBitacoras.Size = new System.Drawing.Size(340, 446);
            this.grbListaBitacoras.TabIndex = 53;
            this.grbListaBitacoras.Text = "Lista de bitacoras";
            // 
            // dgvListaBitacoras
            // 
            this.dgvListaBitacoras.AllowUserToAddRows = false;
            this.dgvListaBitacoras.AllowUserToDeleteRows = false;
            this.dgvListaBitacoras.AllowUserToResizeColumns = false;
            this.dgvListaBitacoras.AllowUserToResizeRows = false;
            this.dgvListaBitacoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaBitacoras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dgvListaBitacoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaBitacoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(175)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaBitacoras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaBitacoras.EnableHeadersVisualStyles = false;
            this.dgvListaBitacoras.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaBitacoras.Location = new System.Drawing.Point(35, 62);
            this.dgvListaBitacoras.MultiSelect = false;
            this.dgvListaBitacoras.Name = "dgvListaBitacoras";
            this.dgvListaBitacoras.ReadOnly = true;
            this.dgvListaBitacoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaBitacoras.RowHeadersVisible = false;
            this.dgvListaBitacoras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaBitacoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaBitacoras.Size = new System.Drawing.Size(268, 358);
            this.dgvListaBitacoras.TabIndex = 56;
            this.dgvListaBitacoras.SelectionChanged += new System.EventHandler(this.dgvListaBitacoras_SelectionChanged);
            // 
            // btnListarBackups
            // 
            this.btnListarBackups.BorderRadius = 10;
            this.btnListarBackups.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListarBackups.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListarBackups.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarBackups.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarBackups.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnListarBackups.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarBackups.ForeColor = System.Drawing.Color.White;
            this.btnListarBackups.Location = new System.Drawing.Point(718, 407);
            this.btnListarBackups.Name = "btnListarBackups";
            this.btnListarBackups.Size = new System.Drawing.Size(119, 54);
            this.btnListarBackups.TabIndex = 56;
            this.btnListarBackups.Text = "Listar solo backups";
            this.btnListarBackups.Click += new System.EventHandler(this.btnListarBackups_Click);
            // 
            // btnListarRestores
            // 
            this.btnListarRestores.BorderRadius = 10;
            this.btnListarRestores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListarRestores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListarRestores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarRestores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnListarRestores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnListarRestores.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarRestores.ForeColor = System.Drawing.Color.White;
            this.btnListarRestores.Location = new System.Drawing.Point(891, 407);
            this.btnListarRestores.Name = "btnListarRestores";
            this.btnListarRestores.Size = new System.Drawing.Size(119, 54);
            this.btnListarRestores.TabIndex = 57;
            this.btnListarRestores.Text = "Listar solo restores";
            this.btnListarRestores.Click += new System.EventHandler(this.btnListarRestores_Click);
            // 
            // frmModuloBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 759);
            this.Controls.Add(this.btnListarRestores);
            this.Controls.Add(this.btnListarBackups);
            this.Controls.Add(this.grbDatosUsuario);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.grbListaBitacoras);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloBitacora_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.grbListaBitacoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBitacoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private UCBackButton ucBackButton1;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblTituloMod;
        private Guna.UI2.WinForms.Guna2Button btnListarTodo;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaBitacoras;
        private System.Windows.Forms.DataGridView dgvListaBitacoras;
        private Guna.UI2.WinForms.Guna2Button btnListarBackups;
        private Guna.UI2.WinForms.Guna2Button btnListarRestores;
    }
}