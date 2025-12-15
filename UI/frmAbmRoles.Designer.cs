namespace UI
{
    partial class frmAbmRoles
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
            this.grbRegistrar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarAlta = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoriaAlta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDescripcionAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.grbModificar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiarMod = new Guna.UI2.WinForms.Guna2Button();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.cbxCategoriaMod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDescripcionMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.lblCategoriaMod = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.grbRegistrar.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistrar
            // 
            this.grbRegistrar.BorderRadius = 15;
            this.grbRegistrar.Controls.Add(this.btnLimpiarAlta);
            this.grbRegistrar.Controls.Add(this.label4);
            this.grbRegistrar.Controls.Add(this.cbxCategoriaAlta);
            this.grbRegistrar.Controls.Add(this.txtDescripcionAlta);
            this.grbRegistrar.Controls.Add(this.txtNombreAlta);
            this.grbRegistrar.Controls.Add(this.label5);
            this.grbRegistrar.Controls.Add(this.lblCategoria);
            this.grbRegistrar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistrar.ForeColor = System.Drawing.Color.White;
            this.grbRegistrar.Location = new System.Drawing.Point(48, 90);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(487, 354);
            this.grbRegistrar.TabIndex = 21;
            this.grbRegistrar.Text = "Registrar rol";
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
            this.btnLimpiarAlta.Location = new System.Drawing.Point(232, 320);
            this.btnLimpiarAlta.Name = "btnLimpiarAlta";
            this.btnLimpiarAlta.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarAlta.TabIndex = 25;
            this.btnLimpiarAlta.Text = "Limpiar";
            this.btnLimpiarAlta.Click += new System.EventHandler(this.btnLimpiarAlta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción";
            // 
            // cbxCategoriaAlta
            // 
            this.cbxCategoriaAlta.AutoRoundedCorners = true;
            this.cbxCategoriaAlta.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategoriaAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCategoriaAlta.BorderRadius = 17;
            this.cbxCategoriaAlta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategoriaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaAlta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaAlta.ForeColor = System.Drawing.Color.Black;
            this.cbxCategoriaAlta.ItemHeight = 30;
            this.cbxCategoriaAlta.Location = new System.Drawing.Point(232, 275);
            this.cbxCategoriaAlta.Name = "cbxCategoriaAlta";
            this.cbxCategoriaAlta.Size = new System.Drawing.Size(200, 36);
            this.cbxCategoriaAlta.TabIndex = 11;
            // 
            // txtDescripcionAlta
            // 
            this.txtDescripcionAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcionAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcionAlta.BorderRadius = 15;
            this.txtDescripcionAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionAlta.DefaultText = "";
            this.txtDescripcionAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcionAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcionAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionAlta.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionAlta.Location = new System.Drawing.Point(232, 95);
            this.txtDescripcionAlta.Multiline = true;
            this.txtDescripcionAlta.Name = "txtDescripcionAlta";
            this.txtDescripcionAlta.PlaceholderText = "";
            this.txtDescripcionAlta.SelectedText = "";
            this.txtDescripcionAlta.Size = new System.Drawing.Size(200, 163);
            this.txtDescripcionAlta.TabIndex = 7;
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.AutoRoundedCorners = true;
            this.txtNombreAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreAlta.BorderRadius = 15;
            this.txtNombreAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreAlta.DefaultText = "";
            this.txtNombreAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlta.ForeColor = System.Drawing.Color.Black;
            this.txtNombreAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreAlta.Location = new System.Drawing.Point(232, 48);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.PlaceholderText = "";
            this.txtNombreAlta.SelectedText = "";
            this.txtNombreAlta.Size = new System.Drawing.Size(200, 33);
            this.txtNombreAlta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(32, 288);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 23);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // grbModificar
            // 
            this.grbModificar.BorderRadius = 15;
            this.grbModificar.Controls.Add(this.btnLimpiarMod);
            this.grbModificar.Controls.Add(this.lblDescripcionMod);
            this.grbModificar.Controls.Add(this.cbxCategoriaMod);
            this.grbModificar.Controls.Add(this.txtDescripcionMod);
            this.grbModificar.Controls.Add(this.txtNombreMod);
            this.grbModificar.Controls.Add(this.lblNombreMod);
            this.grbModificar.Controls.Add(this.lblCategoriaMod);
            this.grbModificar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificar.ForeColor = System.Drawing.Color.White;
            this.grbModificar.Location = new System.Drawing.Point(48, 90);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(487, 354);
            this.grbModificar.TabIndex = 26;
            this.grbModificar.Text = "Modificar rol";
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
            this.btnLimpiarMod.Location = new System.Drawing.Point(232, 320);
            this.btnLimpiarMod.Name = "btnLimpiarMod";
            this.btnLimpiarMod.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarMod.TabIndex = 25;
            this.btnLimpiarMod.Text = "Limpiar";
            this.btnLimpiarMod.Click += new System.EventHandler(this.btnLimpiarMod_Click);
            // 
            // lblDescripcionMod
            // 
            this.lblDescripcionMod.AutoSize = true;
            this.lblDescripcionMod.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMod.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMod.Location = new System.Drawing.Point(30, 101);
            this.lblDescripcionMod.Name = "lblDescripcionMod";
            this.lblDescripcionMod.Size = new System.Drawing.Size(109, 23);
            this.lblDescripcionMod.TabIndex = 12;
            this.lblDescripcionMod.Text = "Descripción";
            // 
            // cbxCategoriaMod
            // 
            this.cbxCategoriaMod.AutoRoundedCorners = true;
            this.cbxCategoriaMod.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategoriaMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCategoriaMod.BorderRadius = 17;
            this.cbxCategoriaMod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategoriaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaMod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategoriaMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaMod.ForeColor = System.Drawing.Color.Black;
            this.cbxCategoriaMod.ItemHeight = 30;
            this.cbxCategoriaMod.Location = new System.Drawing.Point(232, 275);
            this.cbxCategoriaMod.Name = "cbxCategoriaMod";
            this.cbxCategoriaMod.Size = new System.Drawing.Size(200, 36);
            this.cbxCategoriaMod.TabIndex = 11;
            // 
            // txtDescripcionMod
            // 
            this.txtDescripcionMod.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcionMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcionMod.BorderRadius = 15;
            this.txtDescripcionMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionMod.DefaultText = "";
            this.txtDescripcionMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcionMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcionMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMod.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionMod.Location = new System.Drawing.Point(232, 99);
            this.txtDescripcionMod.Multiline = true;
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.PlaceholderText = "";
            this.txtDescripcionMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcionMod.SelectedText = "";
            this.txtDescripcionMod.Size = new System.Drawing.Size(200, 163);
            this.txtDescripcionMod.TabIndex = 7;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.AutoRoundedCorners = true;
            this.txtNombreMod.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreMod.BorderRadius = 17;
            this.txtNombreMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMod.DefaultText = "";
            this.txtNombreMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMod.ForeColor = System.Drawing.Color.Black;
            this.txtNombreMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMod.Location = new System.Drawing.Point(232, 48);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.PlaceholderText = "";
            this.txtNombreMod.SelectedText = "";
            this.txtNombreMod.Size = new System.Drawing.Size(200, 36);
            this.txtNombreMod.TabIndex = 6;
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMod.ForeColor = System.Drawing.Color.Black;
            this.lblNombreMod.Location = new System.Drawing.Point(30, 55);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(77, 23);
            this.lblNombreMod.TabIndex = 5;
            this.lblNombreMod.Text = "Nombre";
            // 
            // lblCategoriaMod
            // 
            this.lblCategoriaMod.AutoSize = true;
            this.lblCategoriaMod.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaMod.ForeColor = System.Drawing.Color.Black;
            this.lblCategoriaMod.Location = new System.Drawing.Point(32, 277);
            this.lblCategoriaMod.Name = "lblCategoriaMod";
            this.lblCategoriaMod.Size = new System.Drawing.Size(91, 23);
            this.lblCategoriaMod.TabIndex = 5;
            this.lblCategoriaMod.Text = "Categoría";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(562, 43);
            this.pnlHeader.TabIndex = 27;
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
            this.btnConfirmar.Location = new System.Drawing.Point(118, 478);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 45);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(336, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAbmRoles
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
            this.Name = "frmAbmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmRoles_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grbRegistrar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategoriaAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCategoria;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarAlta;
        private Guna.UI2.WinForms.Guna2GroupBox grbModificar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarMod;
        private System.Windows.Forms.Label lblDescripcionMod;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategoriaMod;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionMod;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.Label lblCategoriaMod;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}