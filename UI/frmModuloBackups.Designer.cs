namespace UI
{
    partial class frmModuloBackups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grbListaBackups = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaBackups = new System.Windows.Forms.DataGridView();
            this.btnRegistrarBackup = new Guna.UI2.WinForms.Guna2Button();
            this.grbDatosUsuario = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.ucBackButton2 = new UI.UCBackButton();
            this.pnlHeader.SuspendLayout();
            this.grbListaBackups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBackups)).BeginInit();
            this.grbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(28, 29);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "MÓDULO DE BACKUP";
            // 
            // grbListaBackups
            // 
            this.grbListaBackups.BorderRadius = 15;
            this.grbListaBackups.Controls.Add(this.dgvListaBackups);
            this.grbListaBackups.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaBackups.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaBackups.ForeColor = System.Drawing.Color.White;
            this.grbListaBackups.Location = new System.Drawing.Point(129, 113);
            this.grbListaBackups.Name = "grbListaBackups";
            this.grbListaBackups.Size = new System.Drawing.Size(340, 446);
            this.grbListaBackups.TabIndex = 48;
            this.grbListaBackups.Text = "Historial de backups";
            // 
            // dgvListaBackups
            // 
            this.dgvListaBackups.AllowUserToAddRows = false;
            this.dgvListaBackups.AllowUserToDeleteRows = false;
            this.dgvListaBackups.AllowUserToResizeColumns = false;
            this.dgvListaBackups.AllowUserToResizeRows = false;
            this.dgvListaBackups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaBackups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dgvListaBackups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaBackups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(175)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaBackups.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaBackups.EnableHeadersVisualStyles = false;
            this.dgvListaBackups.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaBackups.Location = new System.Drawing.Point(25, 56);
            this.dgvListaBackups.MultiSelect = false;
            this.dgvListaBackups.Name = "dgvListaBackups";
            this.dgvListaBackups.ReadOnly = true;
            this.dgvListaBackups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaBackups.RowHeadersVisible = false;
            this.dgvListaBackups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaBackups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaBackups.Size = new System.Drawing.Size(290, 370);
            this.dgvListaBackups.TabIndex = 56;
            this.dgvListaBackups.SelectionChanged += new System.EventHandler(this.dgvListaBackups_SelectionChanged);
            // 
            // btnRegistrarBackup
            // 
            this.btnRegistrarBackup.BorderRadius = 10;
            this.btnRegistrarBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarBackup.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarBackup.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarBackup.Location = new System.Drawing.Point(727, 371);
            this.btnRegistrarBackup.Name = "btnRegistrarBackup";
            this.btnRegistrarBackup.Size = new System.Drawing.Size(119, 54);
            this.btnRegistrarBackup.TabIndex = 51;
            this.btnRegistrarBackup.Text = "Registrar backup";
            this.btnRegistrarBackup.Click += new System.EventHandler(this.btnRegistrarBackup_Click_1);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.BorderRadius = 15;
            this.grbDatosUsuario.Controls.Add(this.txtUsername);
            this.grbDatosUsuario.Controls.Add(this.lblTituloMod);
            this.grbDatosUsuario.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.grbDatosUsuario.Location = new System.Drawing.Point(553, 229);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(482, 109);
            this.grbDatosUsuario.TabIndex = 52;
            this.grbDatosUsuario.Text = "Datos del usuario que realizó el backup";
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
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // frmModuloBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.grbDatosUsuario);
            this.Controls.Add(this.btnRegistrarBackup);
            this.Controls.Add(this.grbListaBackups);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloBackups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloBackups_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbListaBackups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBackups)).EndInit();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaBackups;
        private System.Windows.Forms.DataGridView dgvListaBackups;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarBackup;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblTituloMod;
    }
}