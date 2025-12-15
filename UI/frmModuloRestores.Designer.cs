namespace UI
{
    partial class frmModuloRestores
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
            this.grbListaBackups = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ltbListaArchivosBackup = new System.Windows.Forms.ListBox();
            this.btnRealizarRestore = new Guna.UI2.WinForms.Guna2Button();
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbListaBackups.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaBackups
            // 
            this.grbListaBackups.BorderRadius = 15;
            this.grbListaBackups.Controls.Add(this.ltbListaArchivosBackup);
            this.grbListaBackups.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaBackups.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaBackups.ForeColor = System.Drawing.Color.White;
            this.grbListaBackups.Location = new System.Drawing.Point(215, 131);
            this.grbListaBackups.Name = "grbListaBackups";
            this.grbListaBackups.Size = new System.Drawing.Size(327, 446);
            this.grbListaBackups.TabIndex = 50;
            this.grbListaBackups.Text = "Backups disponibles para restorear";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(28, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "MÓDULO DE RESTORE";
            // 
            // ltbListaArchivosBackup
            // 
            this.ltbListaArchivosBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbListaArchivosBackup.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaArchivosBackup.FormattingEnabled = true;
            this.ltbListaArchivosBackup.HorizontalScrollbar = true;
            this.ltbListaArchivosBackup.ItemHeight = 16;
            this.ltbListaArchivosBackup.Location = new System.Drawing.Point(25, 59);
            this.ltbListaArchivosBackup.Name = "ltbListaArchivosBackup";
            this.ltbListaArchivosBackup.Size = new System.Drawing.Size(281, 356);
            this.ltbListaArchivosBackup.TabIndex = 51;
            // 
            // btnRealizarRestore
            // 
            this.btnRealizarRestore.BorderRadius = 10;
            this.btnRealizarRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRealizarRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRealizarRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRealizarRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRealizarRestore.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarRestore.ForeColor = System.Drawing.Color.White;
            this.btnRealizarRestore.Location = new System.Drawing.Point(604, 321);
            this.btnRealizarRestore.Name = "btnRealizarRestore";
            this.btnRealizarRestore.Size = new System.Drawing.Size(167, 61);
            this.btnRealizarRestore.TabIndex = 52;
            this.btnRealizarRestore.Text = "Realizar restore";
            this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // frmModuloRestores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnRealizarRestore);
            this.Controls.Add(this.grbListaBackups);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloRestores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloRestores_Load);
            this.grbListaBackups.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grbListaBackups;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private UCBackButton ucBackButton2;
        private System.Windows.Forms.ListBox ltbListaArchivosBackup;
        private Guna.UI2.WinForms.Guna2Button btnRealizarRestore;
    }
}