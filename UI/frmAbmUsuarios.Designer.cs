namespace UI
{
    partial class frmAbmUsuarios
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
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.grbRegistrar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLimpiarAlta = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsernameAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbModificar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLimpiarMod = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsernameMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbRegistrar.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(172)))), ((int)(((byte)(119)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(114, 447);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 45);
            this.btnConfirmar.TabIndex = 35;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(11, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(562, 43);
            this.pnlHeader.TabIndex = 33;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(332, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grbRegistrar
            // 
            this.grbRegistrar.BorderRadius = 15;
            this.grbRegistrar.Controls.Add(this.lblPassword);
            this.grbRegistrar.Controls.Add(this.txtPasswordAlta);
            this.grbRegistrar.Controls.Add(this.btnLimpiarAlta);
            this.grbRegistrar.Controls.Add(this.txtUsernameAlta);
            this.grbRegistrar.Controls.Add(this.label5);
            this.grbRegistrar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistrar.ForeColor = System.Drawing.Color.White;
            this.grbRegistrar.Location = new System.Drawing.Point(44, 190);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(487, 182);
            this.grbRegistrar.TabIndex = 31;
            this.grbRegistrar.Text = "Registrar usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(32, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 23);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password";
            // 
            // txtPasswordAlta
            // 
            this.txtPasswordAlta.AutoRoundedCorners = true;
            this.txtPasswordAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPasswordAlta.BorderRadius = 15;
            this.txtPasswordAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordAlta.DefaultText = "";
            this.txtPasswordAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAlta.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAlta.Location = new System.Drawing.Point(232, 111);
            this.txtPasswordAlta.Name = "txtPasswordAlta";
            this.txtPasswordAlta.PlaceholderText = "";
            this.txtPasswordAlta.SelectedText = "";
            this.txtPasswordAlta.Size = new System.Drawing.Size(200, 33);
            this.txtPasswordAlta.TabIndex = 26;
            // 
            // btnLimpiarAlta
            // 
            this.btnLimpiarAlta.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarAlta.BorderRadius = 10;
            this.btnLimpiarAlta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarAlta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarAlta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnLimpiarAlta.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAlta.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarAlta.Location = new System.Drawing.Point(232, 150);
            this.btnLimpiarAlta.Name = "btnLimpiarAlta";
            this.btnLimpiarAlta.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarAlta.TabIndex = 25;
            this.btnLimpiarAlta.Text = "Limpiar";
            this.btnLimpiarAlta.Click += new System.EventHandler(this.btnLimpiarAlta_Click);
            // 
            // txtUsernameAlta
            // 
            this.txtUsernameAlta.AutoRoundedCorners = true;
            this.txtUsernameAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsernameAlta.BorderRadius = 15;
            this.txtUsernameAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameAlta.DefaultText = "";
            this.txtUsernameAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameAlta.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameAlta.Location = new System.Drawing.Point(232, 48);
            this.txtUsernameAlta.Name = "txtUsernameAlta";
            this.txtUsernameAlta.PlaceholderText = "";
            this.txtUsernameAlta.SelectedText = "";
            this.txtUsernameAlta.Size = new System.Drawing.Size(200, 33);
            this.txtUsernameAlta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // grbModificar
            // 
            this.grbModificar.BorderRadius = 15;
            this.grbModificar.Controls.Add(this.label1);
            this.grbModificar.Controls.Add(this.txtPasswordMod);
            this.grbModificar.Controls.Add(this.btnLimpiarMod);
            this.grbModificar.Controls.Add(this.txtUsernameMod);
            this.grbModificar.Controls.Add(this.label2);
            this.grbModificar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificar.ForeColor = System.Drawing.Color.White;
            this.grbModificar.Location = new System.Drawing.Point(44, 190);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(487, 182);
            this.grbModificar.TabIndex = 32;
            this.grbModificar.Text = "Modificar usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            // 
            // txtPasswordMod
            // 
            this.txtPasswordMod.AutoRoundedCorners = true;
            this.txtPasswordMod.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPasswordMod.BorderRadius = 15;
            this.txtPasswordMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordMod.DefaultText = "";
            this.txtPasswordMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordMod.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordMod.Location = new System.Drawing.Point(232, 111);
            this.txtPasswordMod.Name = "txtPasswordMod";
            this.txtPasswordMod.PlaceholderText = "";
            this.txtPasswordMod.SelectedText = "";
            this.txtPasswordMod.Size = new System.Drawing.Size(200, 33);
            this.txtPasswordMod.TabIndex = 26;
            // 
            // btnLimpiarMod
            // 
            this.btnLimpiarMod.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarMod.BorderRadius = 10;
            this.btnLimpiarMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarMod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.btnLimpiarMod.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMod.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarMod.Location = new System.Drawing.Point(232, 150);
            this.btnLimpiarMod.Name = "btnLimpiarMod";
            this.btnLimpiarMod.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarMod.TabIndex = 25;
            this.btnLimpiarMod.Text = "Limpiar";
            this.btnLimpiarMod.Click += new System.EventHandler(this.btnLimpiarMod_Click);
            // 
            // txtUsernameMod
            // 
            this.txtUsernameMod.AutoRoundedCorners = true;
            this.txtUsernameMod.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsernameMod.BorderRadius = 15;
            this.txtUsernameMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameMod.DefaultText = "";
            this.txtUsernameMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameMod.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameMod.Location = new System.Drawing.Point(232, 48);
            this.txtUsernameMod.Name = "txtUsernameMod";
            this.txtUsernameMod.PlaceholderText = "";
            this.txtUsernameMod.SelectedText = "";
            this.txtUsernameMod.Size = new System.Drawing.Size(200, 33);
            this.txtUsernameMod.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // frmAbmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbRegistrar);
            this.Controls.Add(this.grbModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmUsuarios_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2GroupBox grbRegistrar;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordAlta;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameAlta;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GroupBox grbModificar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordMod;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarMod;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameMod;
        private System.Windows.Forms.Label label2;
    }
}