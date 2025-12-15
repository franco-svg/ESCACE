namespace UI
{
    partial class frmAbmHitos
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
            this.grbRegistrar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarAlta = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlcanzadoAlta = new System.Windows.Forms.Label();
            this.ccbAlcanzadoAlta = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dtpFechaAlta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCriterioAlcanceAlta = new System.Windows.Forms.Label();
            this.txtCriterioAlcanceAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTituloAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.grbModificar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarMod = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlcanzadoMod = new System.Windows.Forms.Label();
            this.ccbAlcanzadoMod = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dtpFechaMod = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCriterioAlcanceMod = new System.Windows.Forms.Label();
            this.txtCriterioAlcanceMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTituloMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.lblFechaMod = new System.Windows.Forms.Label();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.grbRegistrar.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(10, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(562, 43);
            this.pnlHeader.TabIndex = 42;
            // 
            // grbRegistrar
            // 
            this.grbRegistrar.BorderRadius = 15;
            this.grbRegistrar.Controls.Add(this.btnLimpiarAlta);
            this.grbRegistrar.Controls.Add(this.lblAlcanzadoAlta);
            this.grbRegistrar.Controls.Add(this.ccbAlcanzadoAlta);
            this.grbRegistrar.Controls.Add(this.dtpFechaAlta);
            this.grbRegistrar.Controls.Add(this.lblCriterioAlcanceAlta);
            this.grbRegistrar.Controls.Add(this.txtCriterioAlcanceAlta);
            this.grbRegistrar.Controls.Add(this.txtTituloAlta);
            this.grbRegistrar.Controls.Add(this.lblTituloAlta);
            this.grbRegistrar.Controls.Add(this.lblFechaAlta);
            this.grbRegistrar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistrar.ForeColor = System.Drawing.Color.White;
            this.grbRegistrar.Location = new System.Drawing.Point(39, 71);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(487, 391);
            this.grbRegistrar.TabIndex = 47;
            this.grbRegistrar.Text = "Registrar hito";
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
            this.btnLimpiarAlta.Location = new System.Drawing.Point(232, 359);
            this.btnLimpiarAlta.Name = "btnLimpiarAlta";
            this.btnLimpiarAlta.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarAlta.TabIndex = 51;
            this.btnLimpiarAlta.Text = "Limpiar";
            this.btnLimpiarAlta.Click += new System.EventHandler(this.btnLimpiarAlta_Click);
            // 
            // lblAlcanzadoAlta
            // 
            this.lblAlcanzadoAlta.AutoSize = true;
            this.lblAlcanzadoAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblAlcanzadoAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcanzadoAlta.ForeColor = System.Drawing.Color.Black;
            this.lblAlcanzadoAlta.Location = new System.Drawing.Point(30, 327);
            this.lblAlcanzadoAlta.Name = "lblAlcanzadoAlta";
            this.lblAlcanzadoAlta.Size = new System.Drawing.Size(97, 23);
            this.lblAlcanzadoAlta.TabIndex = 49;
            this.lblAlcanzadoAlta.Text = "Alcanzado";
            // 
            // ccbAlcanzadoAlta
            // 
            this.ccbAlcanzadoAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ccbAlcanzadoAlta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoAlta.CheckedState.BorderRadius = 2;
            this.ccbAlcanzadoAlta.CheckedState.BorderThickness = 0;
            this.ccbAlcanzadoAlta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoAlta.ForeColor = System.Drawing.Color.Black;
            this.ccbAlcanzadoAlta.Location = new System.Drawing.Point(232, 330);
            this.ccbAlcanzadoAlta.Name = "ccbAlcanzadoAlta";
            this.ccbAlcanzadoAlta.Size = new System.Drawing.Size(20, 20);
            this.ccbAlcanzadoAlta.TabIndex = 48;
            this.ccbAlcanzadoAlta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoAlta.UncheckedState.BorderRadius = 2;
            this.ccbAlcanzadoAlta.UncheckedState.BorderThickness = 0;
            this.ccbAlcanzadoAlta.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.AutoRoundedCorners = true;
            this.dtpFechaAlta.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaAlta.Checked = true;
            this.dtpFechaAlta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaAlta.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaAlta.Location = new System.Drawing.Point(232, 280);
            this.dtpFechaAlta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaAlta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaAlta.TabIndex = 47;
            this.dtpFechaAlta.Value = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // lblCriterioAlcanceAlta
            // 
            this.lblCriterioAlcanceAlta.AutoSize = true;
            this.lblCriterioAlcanceAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblCriterioAlcanceAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioAlcanceAlta.ForeColor = System.Drawing.Color.Black;
            this.lblCriterioAlcanceAlta.Location = new System.Drawing.Point(30, 95);
            this.lblCriterioAlcanceAlta.Name = "lblCriterioAlcanceAlta";
            this.lblCriterioAlcanceAlta.Size = new System.Drawing.Size(169, 23);
            this.lblCriterioAlcanceAlta.TabIndex = 12;
            this.lblCriterioAlcanceAlta.Text = "Criterio de alcance";
            // 
            // txtCriterioAlcanceAlta
            // 
            this.txtCriterioAlcanceAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtCriterioAlcanceAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCriterioAlcanceAlta.BorderRadius = 15;
            this.txtCriterioAlcanceAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCriterioAlcanceAlta.DefaultText = "";
            this.txtCriterioAlcanceAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCriterioAlcanceAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCriterioAlcanceAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcanceAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcanceAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcanceAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterioAlcanceAlta.ForeColor = System.Drawing.Color.Black;
            this.txtCriterioAlcanceAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcanceAlta.Location = new System.Drawing.Point(232, 95);
            this.txtCriterioAlcanceAlta.Multiline = true;
            this.txtCriterioAlcanceAlta.Name = "txtCriterioAlcanceAlta";
            this.txtCriterioAlcanceAlta.PlaceholderText = "";
            this.txtCriterioAlcanceAlta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCriterioAlcanceAlta.SelectedText = "";
            this.txtCriterioAlcanceAlta.Size = new System.Drawing.Size(233, 163);
            this.txtCriterioAlcanceAlta.TabIndex = 7;
            // 
            // txtTituloAlta
            // 
            this.txtTituloAlta.AutoRoundedCorners = true;
            this.txtTituloAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTituloAlta.BorderRadius = 15;
            this.txtTituloAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTituloAlta.DefaultText = "";
            this.txtTituloAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTituloAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTituloAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTituloAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTituloAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTituloAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloAlta.ForeColor = System.Drawing.Color.Black;
            this.txtTituloAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTituloAlta.Location = new System.Drawing.Point(232, 48);
            this.txtTituloAlta.Name = "txtTituloAlta";
            this.txtTituloAlta.PlaceholderText = "";
            this.txtTituloAlta.SelectedText = "";
            this.txtTituloAlta.Size = new System.Drawing.Size(233, 33);
            this.txtTituloAlta.TabIndex = 6;
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlta.ForeColor = System.Drawing.Color.Black;
            this.lblTituloAlta.Location = new System.Drawing.Point(30, 48);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(57, 23);
            this.lblTituloAlta.TabIndex = 5;
            this.lblTituloAlta.Text = "Titulo";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.Color.Black;
            this.lblFechaAlta.Location = new System.Drawing.Point(30, 280);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(162, 23);
            this.lblFechaAlta.TabIndex = 5;
            this.lblFechaAlta.Text = "Fecha establecida";
            // 
            // grbModificar
            // 
            this.grbModificar.BorderRadius = 15;
            this.grbModificar.Controls.Add(this.btnLimpiarMod);
            this.grbModificar.Controls.Add(this.lblAlcanzadoMod);
            this.grbModificar.Controls.Add(this.ccbAlcanzadoMod);
            this.grbModificar.Controls.Add(this.dtpFechaMod);
            this.grbModificar.Controls.Add(this.lblCriterioAlcanceMod);
            this.grbModificar.Controls.Add(this.txtCriterioAlcanceMod);
            this.grbModificar.Controls.Add(this.txtTituloMod);
            this.grbModificar.Controls.Add(this.lblTituloMod);
            this.grbModificar.Controls.Add(this.lblFechaMod);
            this.grbModificar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificar.ForeColor = System.Drawing.Color.White;
            this.grbModificar.Location = new System.Drawing.Point(39, 71);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(487, 391);
            this.grbModificar.TabIndex = 48;
            this.grbModificar.Text = "Modificar hito";
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
            this.btnLimpiarMod.Location = new System.Drawing.Point(232, 359);
            this.btnLimpiarMod.Name = "btnLimpiarMod";
            this.btnLimpiarMod.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarMod.TabIndex = 51;
            this.btnLimpiarMod.Text = "Limpiar";
            this.btnLimpiarMod.Click += new System.EventHandler(this.btnLimpiarMod_Click);
            // 
            // lblAlcanzadoMod
            // 
            this.lblAlcanzadoMod.AutoSize = true;
            this.lblAlcanzadoMod.BackColor = System.Drawing.Color.Transparent;
            this.lblAlcanzadoMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcanzadoMod.ForeColor = System.Drawing.Color.Black;
            this.lblAlcanzadoMod.Location = new System.Drawing.Point(30, 327);
            this.lblAlcanzadoMod.Name = "lblAlcanzadoMod";
            this.lblAlcanzadoMod.Size = new System.Drawing.Size(97, 23);
            this.lblAlcanzadoMod.TabIndex = 49;
            this.lblAlcanzadoMod.Text = "Alcanzado";
            // 
            // ccbAlcanzadoMod
            // 
            this.ccbAlcanzadoMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ccbAlcanzadoMod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoMod.CheckedState.BorderRadius = 2;
            this.ccbAlcanzadoMod.CheckedState.BorderThickness = 0;
            this.ccbAlcanzadoMod.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoMod.ForeColor = System.Drawing.Color.Black;
            this.ccbAlcanzadoMod.Location = new System.Drawing.Point(232, 330);
            this.ccbAlcanzadoMod.Name = "ccbAlcanzadoMod";
            this.ccbAlcanzadoMod.Size = new System.Drawing.Size(20, 20);
            this.ccbAlcanzadoMod.TabIndex = 48;
            this.ccbAlcanzadoMod.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzadoMod.UncheckedState.BorderRadius = 2;
            this.ccbAlcanzadoMod.UncheckedState.BorderThickness = 0;
            this.ccbAlcanzadoMod.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            // 
            // dtpFechaMod
            // 
            this.dtpFechaMod.AutoRoundedCorners = true;
            this.dtpFechaMod.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaMod.Checked = true;
            this.dtpFechaMod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaMod.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMod.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaMod.Location = new System.Drawing.Point(232, 280);
            this.dtpFechaMod.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaMod.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaMod.Name = "dtpFechaMod";
            this.dtpFechaMod.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaMod.TabIndex = 47;
            this.dtpFechaMod.Value = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // lblCriterioAlcanceMod
            // 
            this.lblCriterioAlcanceMod.AutoSize = true;
            this.lblCriterioAlcanceMod.BackColor = System.Drawing.Color.Transparent;
            this.lblCriterioAlcanceMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioAlcanceMod.ForeColor = System.Drawing.Color.Black;
            this.lblCriterioAlcanceMod.Location = new System.Drawing.Point(30, 95);
            this.lblCriterioAlcanceMod.Name = "lblCriterioAlcanceMod";
            this.lblCriterioAlcanceMod.Size = new System.Drawing.Size(169, 23);
            this.lblCriterioAlcanceMod.TabIndex = 12;
            this.lblCriterioAlcanceMod.Text = "Criterio de alcance";
            // 
            // txtCriterioAlcanceMod
            // 
            this.txtCriterioAlcanceMod.BackColor = System.Drawing.Color.Transparent;
            this.txtCriterioAlcanceMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCriterioAlcanceMod.BorderRadius = 15;
            this.txtCriterioAlcanceMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCriterioAlcanceMod.DefaultText = "";
            this.txtCriterioAlcanceMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCriterioAlcanceMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCriterioAlcanceMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcanceMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcanceMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcanceMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterioAlcanceMod.ForeColor = System.Drawing.Color.Black;
            this.txtCriterioAlcanceMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcanceMod.Location = new System.Drawing.Point(232, 95);
            this.txtCriterioAlcanceMod.Multiline = true;
            this.txtCriterioAlcanceMod.Name = "txtCriterioAlcanceMod";
            this.txtCriterioAlcanceMod.PlaceholderText = "";
            this.txtCriterioAlcanceMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCriterioAlcanceMod.SelectedText = "";
            this.txtCriterioAlcanceMod.Size = new System.Drawing.Size(233, 163);
            this.txtCriterioAlcanceMod.TabIndex = 7;
            // 
            // txtTituloMod
            // 
            this.txtTituloMod.AutoRoundedCorners = true;
            this.txtTituloMod.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTituloMod.BorderRadius = 15;
            this.txtTituloMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTituloMod.DefaultText = "";
            this.txtTituloMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTituloMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTituloMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTituloMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTituloMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTituloMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloMod.ForeColor = System.Drawing.Color.Black;
            this.txtTituloMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTituloMod.Location = new System.Drawing.Point(232, 48);
            this.txtTituloMod.Name = "txtTituloMod";
            this.txtTituloMod.PlaceholderText = "";
            this.txtTituloMod.SelectedText = "";
            this.txtTituloMod.Size = new System.Drawing.Size(233, 33);
            this.txtTituloMod.TabIndex = 6;
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMod.Location = new System.Drawing.Point(30, 48);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(57, 23);
            this.lblTituloMod.TabIndex = 5;
            this.lblTituloMod.Text = "Titulo";
            // 
            // lblFechaMod
            // 
            this.lblFechaMod.AutoSize = true;
            this.lblFechaMod.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMod.ForeColor = System.Drawing.Color.Black;
            this.lblFechaMod.Location = new System.Drawing.Point(30, 280);
            this.lblFechaMod.Name = "lblFechaMod";
            this.lblFechaMod.Size = new System.Drawing.Size(162, 23);
            this.lblFechaMod.TabIndex = 5;
            this.lblFechaMod.Text = "Fecha establecida";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(172)))), ((int)(((byte)(119)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(106, 479);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 45);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(324, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAbmHitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grbRegistrar);
            this.Controls.Add(this.grbModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbmHitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmHitos_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2GroupBox grbRegistrar;
        private System.Windows.Forms.Label lblAlcanzadoAlta;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ccbAlcanzadoAlta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblCriterioAlcanceAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtCriterioAlcanceAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtTituloAlta;
        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private Guna.UI2.WinForms.Guna2GroupBox grbModificar;
        private System.Windows.Forms.Label lblAlcanzadoMod;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ccbAlcanzadoMod;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaMod;
        private System.Windows.Forms.Label lblCriterioAlcanceMod;
        private Guna.UI2.WinForms.Guna2TextBox txtCriterioAlcanceMod;
        private Guna.UI2.WinForms.Guna2TextBox txtTituloMod;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.Label lblFechaMod;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarAlta;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarMod;
    }
}