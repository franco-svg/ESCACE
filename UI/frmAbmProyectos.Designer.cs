namespace UI
{
    partial class frmAbmProyectos
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
            this.txtHorasAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasAlta = new System.Windows.Forms.Label();
            this.txtEstadoAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescripcionAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTituloAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.lblDescripcionAlta = new System.Windows.Forms.Label();
            this.lblEstadoAlta = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.grbModificar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFichaMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFichaMod = new System.Windows.Forms.Label();
            this.cbxEstadoMod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLimpiarMod = new Guna.UI2.WinForms.Guna2Button();
            this.txtHorasMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasMod = new System.Windows.Forms.Label();
            this.txtDescripcionMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTituloMod = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.lblEstadoMod = new System.Windows.Forms.Label();
            this.grbFichasDisponibles = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbListaFichas = new System.Windows.Forms.ListBox();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.grbRegistrar.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.grbFichasDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistrar
            // 
            this.grbRegistrar.BorderRadius = 15;
            this.grbRegistrar.Controls.Add(this.btnLimpiarAlta);
            this.grbRegistrar.Controls.Add(this.txtHorasAlta);
            this.grbRegistrar.Controls.Add(this.lblHorasAlta);
            this.grbRegistrar.Controls.Add(this.txtEstadoAlta);
            this.grbRegistrar.Controls.Add(this.txtDescripcionAlta);
            this.grbRegistrar.Controls.Add(this.txtTituloAlta);
            this.grbRegistrar.Controls.Add(this.lblTituloAlta);
            this.grbRegistrar.Controls.Add(this.lblDescripcionAlta);
            this.grbRegistrar.Controls.Add(this.lblEstadoAlta);
            this.grbRegistrar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistrar.ForeColor = System.Drawing.Color.White;
            this.grbRegistrar.Location = new System.Drawing.Point(20, 65);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(529, 347);
            this.grbRegistrar.TabIndex = 44;
            this.grbRegistrar.Text = "Registrar proyecto";
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
            this.btnLimpiarAlta.Location = new System.Drawing.Point(272, 310);
            this.btnLimpiarAlta.Name = "btnLimpiarAlta";
            this.btnLimpiarAlta.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarAlta.TabIndex = 29;
            this.btnLimpiarAlta.Text = "Limpiar";
            this.btnLimpiarAlta.Click += new System.EventHandler(this.btnLimpiarAlta_Click);
            // 
            // txtHorasAlta
            // 
            this.txtHorasAlta.AutoRoundedCorners = true;
            this.txtHorasAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtHorasAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHorasAlta.BorderRadius = 17;
            this.txtHorasAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasAlta.DefaultText = "";
            this.txtHorasAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.txtHorasAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasAlta.Location = new System.Drawing.Point(272, 222);
            this.txtHorasAlta.Name = "txtHorasAlta";
            this.txtHorasAlta.PlaceholderText = "";
            this.txtHorasAlta.ReadOnly = true;
            this.txtHorasAlta.SelectedText = "";
            this.txtHorasAlta.Size = new System.Drawing.Size(92, 36);
            this.txtHorasAlta.TabIndex = 28;
            // 
            // lblHorasAlta
            // 
            this.lblHorasAlta.AutoSize = true;
            this.lblHorasAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasAlta.ForeColor = System.Drawing.Color.Black;
            this.lblHorasAlta.Location = new System.Drawing.Point(35, 230);
            this.lblHorasAlta.Name = "lblHorasAlta";
            this.lblHorasAlta.Size = new System.Drawing.Size(153, 23);
            this.lblHorasAlta.TabIndex = 27;
            this.lblHorasAlta.Text = "Horas estimadas";
            // 
            // txtEstadoAlta
            // 
            this.txtEstadoAlta.AutoRoundedCorners = true;
            this.txtEstadoAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtEstadoAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEstadoAlta.BorderRadius = 17;
            this.txtEstadoAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadoAlta.DefaultText = "Pendiente";
            this.txtEstadoAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstadoAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstadoAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.txtEstadoAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoAlta.Location = new System.Drawing.Point(272, 270);
            this.txtEstadoAlta.Name = "txtEstadoAlta";
            this.txtEstadoAlta.PlaceholderText = "";
            this.txtEstadoAlta.ReadOnly = true;
            this.txtEstadoAlta.SelectedText = "";
            this.txtEstadoAlta.Size = new System.Drawing.Size(146, 36);
            this.txtEstadoAlta.TabIndex = 25;
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
            this.txtDescripcionAlta.Location = new System.Drawing.Point(272, 97);
            this.txtDescripcionAlta.Multiline = true;
            this.txtDescripcionAlta.Name = "txtDescripcionAlta";
            this.txtDescripcionAlta.PlaceholderText = "";
            this.txtDescripcionAlta.SelectedText = "";
            this.txtDescripcionAlta.Size = new System.Drawing.Size(233, 108);
            this.txtDescripcionAlta.TabIndex = 17;
            // 
            // txtTituloAlta
            // 
            this.txtTituloAlta.AutoRoundedCorners = true;
            this.txtTituloAlta.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloAlta.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTituloAlta.BorderRadius = 17;
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
            this.txtTituloAlta.Location = new System.Drawing.Point(272, 54);
            this.txtTituloAlta.Name = "txtTituloAlta";
            this.txtTituloAlta.PlaceholderText = "";
            this.txtTituloAlta.SelectedText = "";
            this.txtTituloAlta.Size = new System.Drawing.Size(233, 36);
            this.txtTituloAlta.TabIndex = 6;
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlta.ForeColor = System.Drawing.Color.Black;
            this.lblTituloAlta.Location = new System.Drawing.Point(30, 56);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(57, 23);
            this.lblTituloAlta.TabIndex = 5;
            this.lblTituloAlta.Text = "Titulo";
            // 
            // lblDescripcionAlta
            // 
            this.lblDescripcionAlta.AutoSize = true;
            this.lblDescripcionAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAlta.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionAlta.Location = new System.Drawing.Point(30, 97);
            this.lblDescripcionAlta.Name = "lblDescripcionAlta";
            this.lblDescripcionAlta.Size = new System.Drawing.Size(109, 23);
            this.lblDescripcionAlta.TabIndex = 5;
            this.lblDescripcionAlta.Text = "Descripción";
            // 
            // lblEstadoAlta
            // 
            this.lblEstadoAlta.AutoSize = true;
            this.lblEstadoAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoAlta.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAlta.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoAlta.Location = new System.Drawing.Point(33, 283);
            this.lblEstadoAlta.Name = "lblEstadoAlta";
            this.lblEstadoAlta.Size = new System.Drawing.Size(67, 23);
            this.lblEstadoAlta.TabIndex = 5;
            this.lblEstadoAlta.Text = "Estado";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(12, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(806, 43);
            this.pnlHeader.TabIndex = 45;
            // 
            // grbModificar
            // 
            this.grbModificar.BorderRadius = 15;
            this.grbModificar.Controls.Add(this.txtFichaMod);
            this.grbModificar.Controls.Add(this.lblFichaMod);
            this.grbModificar.Controls.Add(this.cbxEstadoMod);
            this.grbModificar.Controls.Add(this.btnLimpiarMod);
            this.grbModificar.Controls.Add(this.txtHorasMod);
            this.grbModificar.Controls.Add(this.lblHorasMod);
            this.grbModificar.Controls.Add(this.txtDescripcionMod);
            this.grbModificar.Controls.Add(this.txtTituloMod);
            this.grbModificar.Controls.Add(this.lblTituloMod);
            this.grbModificar.Controls.Add(this.lblDescripcionMod);
            this.grbModificar.Controls.Add(this.lblEstadoMod);
            this.grbModificar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificar.ForeColor = System.Drawing.Color.White;
            this.grbModificar.Location = new System.Drawing.Point(20, 65);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(529, 395);
            this.grbModificar.TabIndex = 45;
            this.grbModificar.Text = "Modificar proyecto";
            // 
            // txtFichaMod
            // 
            this.txtFichaMod.AutoRoundedCorners = true;
            this.txtFichaMod.BackColor = System.Drawing.Color.Transparent;
            this.txtFichaMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFichaMod.BorderRadius = 17;
            this.txtFichaMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFichaMod.DefaultText = "fhca x";
            this.txtFichaMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFichaMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFichaMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFichaMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFichaMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFichaMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFichaMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.txtFichaMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFichaMod.Location = new System.Drawing.Point(272, 222);
            this.txtFichaMod.Name = "txtFichaMod";
            this.txtFichaMod.PlaceholderText = "";
            this.txtFichaMod.ReadOnly = true;
            this.txtFichaMod.SelectedText = "";
            this.txtFichaMod.Size = new System.Drawing.Size(233, 36);
            this.txtFichaMod.TabIndex = 48;
            // 
            // lblFichaMod
            // 
            this.lblFichaMod.AutoSize = true;
            this.lblFichaMod.BackColor = System.Drawing.Color.Transparent;
            this.lblFichaMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaMod.ForeColor = System.Drawing.Color.Black;
            this.lblFichaMod.Location = new System.Drawing.Point(30, 222);
            this.lblFichaMod.Name = "lblFichaMod";
            this.lblFichaMod.Size = new System.Drawing.Size(158, 23);
            this.lblFichaMod.TabIndex = 47;
            this.lblFichaMod.Text = "Ficha de proyecto";
            // 
            // cbxEstadoMod
            // 
            this.cbxEstadoMod.AutoRoundedCorners = true;
            this.cbxEstadoMod.BackColor = System.Drawing.Color.Transparent;
            this.cbxEstadoMod.BorderColor = System.Drawing.Color.Black;
            this.cbxEstadoMod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEstadoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoMod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstadoMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEstadoMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoMod.ForeColor = System.Drawing.Color.Black;
            this.cbxEstadoMod.ItemHeight = 30;
            this.cbxEstadoMod.Location = new System.Drawing.Point(272, 323);
            this.cbxEstadoMod.Name = "cbxEstadoMod";
            this.cbxEstadoMod.Size = new System.Drawing.Size(233, 36);
            this.cbxEstadoMod.TabIndex = 46;
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
            this.btnLimpiarMod.Location = new System.Drawing.Point(272, 365);
            this.btnLimpiarMod.Name = "btnLimpiarMod";
            this.btnLimpiarMod.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiarMod.TabIndex = 29;
            this.btnLimpiarMod.Text = "Limpiar";
            this.btnLimpiarMod.Click += new System.EventHandler(this.btnLimpiarMod_Click);
            // 
            // txtHorasMod
            // 
            this.txtHorasMod.AutoRoundedCorners = true;
            this.txtHorasMod.BackColor = System.Drawing.Color.Transparent;
            this.txtHorasMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHorasMod.BorderRadius = 17;
            this.txtHorasMod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasMod.DefaultText = "";
            this.txtHorasMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasMod.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.txtHorasMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasMod.Location = new System.Drawing.Point(272, 272);
            this.txtHorasMod.Name = "txtHorasMod";
            this.txtHorasMod.PlaceholderText = "";
            this.txtHorasMod.ReadOnly = true;
            this.txtHorasMod.SelectedText = "";
            this.txtHorasMod.Size = new System.Drawing.Size(92, 36);
            this.txtHorasMod.TabIndex = 28;
            // 
            // lblHorasMod
            // 
            this.lblHorasMod.AutoSize = true;
            this.lblHorasMod.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasMod.ForeColor = System.Drawing.Color.Black;
            this.lblHorasMod.Location = new System.Drawing.Point(30, 277);
            this.lblHorasMod.Name = "lblHorasMod";
            this.lblHorasMod.Size = new System.Drawing.Size(153, 23);
            this.lblHorasMod.TabIndex = 27;
            this.lblHorasMod.Text = "Horas estimadas";
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
            this.txtDescripcionMod.Location = new System.Drawing.Point(272, 97);
            this.txtDescripcionMod.Multiline = true;
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.PlaceholderText = "";
            this.txtDescripcionMod.SelectedText = "";
            this.txtDescripcionMod.Size = new System.Drawing.Size(233, 108);
            this.txtDescripcionMod.TabIndex = 17;
            // 
            // txtTituloMod
            // 
            this.txtTituloMod.AutoRoundedCorners = true;
            this.txtTituloMod.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloMod.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTituloMod.BorderRadius = 17;
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
            this.txtTituloMod.Location = new System.Drawing.Point(272, 54);
            this.txtTituloMod.Name = "txtTituloMod";
            this.txtTituloMod.PlaceholderText = "";
            this.txtTituloMod.SelectedText = "";
            this.txtTituloMod.Size = new System.Drawing.Size(233, 36);
            this.txtTituloMod.TabIndex = 6;
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMod.Location = new System.Drawing.Point(30, 56);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(57, 23);
            this.lblTituloMod.TabIndex = 5;
            this.lblTituloMod.Text = "Titulo";
            // 
            // lblDescripcionMod
            // 
            this.lblDescripcionMod.AutoSize = true;
            this.lblDescripcionMod.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMod.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMod.Location = new System.Drawing.Point(30, 97);
            this.lblDescripcionMod.Name = "lblDescripcionMod";
            this.lblDescripcionMod.Size = new System.Drawing.Size(109, 23);
            this.lblDescripcionMod.TabIndex = 5;
            this.lblDescripcionMod.Text = "Descripción";
            // 
            // lblEstadoMod
            // 
            this.lblEstadoMod.AutoSize = true;
            this.lblEstadoMod.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoMod.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMod.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoMod.Location = new System.Drawing.Point(30, 325);
            this.lblEstadoMod.Name = "lblEstadoMod";
            this.lblEstadoMod.Size = new System.Drawing.Size(67, 23);
            this.lblEstadoMod.TabIndex = 5;
            this.lblEstadoMod.Text = "Estado";
            // 
            // grbFichasDisponibles
            // 
            this.grbFichasDisponibles.BorderRadius = 15;
            this.grbFichasDisponibles.Controls.Add(this.ltbListaFichas);
            this.grbFichasDisponibles.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbFichasDisponibles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFichasDisponibles.ForeColor = System.Drawing.Color.White;
            this.grbFichasDisponibles.Location = new System.Drawing.Point(562, 65);
            this.grbFichasDisponibles.Name = "grbFichasDisponibles";
            this.grbFichasDisponibles.Size = new System.Drawing.Size(256, 475);
            this.grbFichasDisponibles.TabIndex = 47;
            this.grbFichasDisponibles.Text = "Fichas de proyecto disponibles";
            // 
            // ltbListaFichas
            // 
            this.ltbListaFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbListaFichas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaFichas.FormattingEnabled = true;
            this.ltbListaFichas.HorizontalScrollbar = true;
            this.ltbListaFichas.ItemHeight = 16;
            this.ltbListaFichas.Location = new System.Drawing.Point(14, 55);
            this.ltbListaFichas.Name = "ltbListaFichas";
            this.ltbListaFichas.Size = new System.Drawing.Size(227, 404);
            this.ltbListaFichas.TabIndex = 18;
            this.ltbListaFichas.SelectedIndexChanged += new System.EventHandler(this.ltbListaFichas_SelectedIndexChanged);
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
            this.btnConfirmar.Location = new System.Drawing.Point(117, 482);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 45);
            this.btnConfirmar.TabIndex = 49;
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
            this.btnCancelar.Location = new System.Drawing.Point(335, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAbmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbFichasDisponibles);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grbModificar);
            this.Controls.Add(this.grbRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmProyectos_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.grbFichasDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grbRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasAlta;
        private System.Windows.Forms.Label lblHorasAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionAlta;
        private Guna.UI2.WinForms.Guna2TextBox txtTituloAlta;
        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Label lblDescripcionAlta;
        private System.Windows.Forms.Label lblEstadoAlta;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarAlta;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2GroupBox grbModificar;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEstadoMod;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarMod;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasMod;
        private System.Windows.Forms.Label lblHorasMod;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionMod;
        private Guna.UI2.WinForms.Guna2TextBox txtTituloMod;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.Label lblDescripcionMod;
        private System.Windows.Forms.Label lblEstadoMod;
        private Guna.UI2.WinForms.Guna2GroupBox grbFichasDisponibles;
        private System.Windows.Forms.ListBox ltbListaFichas;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtFichaMod;
        private System.Windows.Forms.Label lblFichaMod;
    }
}