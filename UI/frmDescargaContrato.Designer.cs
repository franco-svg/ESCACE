namespace UI
{
    partial class frmDescargaContrato
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
            this.grbDatosContrato = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.dtpFechaVigencia = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFechaVigencia = new System.Windows.Forms.Label();
            this.dtpFechaFirma = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTerminosCondiciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTerminosCondiciones = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFechaFirma = new System.Windows.Forms.Label();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.grbDatosContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosContrato
            // 
            this.grbDatosContrato.BorderRadius = 15;
            this.grbDatosContrato.Controls.Add(this.txtMonto);
            this.grbDatosContrato.Controls.Add(this.txtEstado);
            this.grbDatosContrato.Controls.Add(this.txtCliente);
            this.grbDatosContrato.Controls.Add(this.txtTitulo);
            this.grbDatosContrato.Controls.Add(this.lblMonto);
            this.grbDatosContrato.Controls.Add(this.dtpFechaVigencia);
            this.grbDatosContrato.Controls.Add(this.lblFechaVigencia);
            this.grbDatosContrato.Controls.Add(this.dtpFechaFirma);
            this.grbDatosContrato.Controls.Add(this.txtDescripcion);
            this.grbDatosContrato.Controls.Add(this.txtTerminosCondiciones);
            this.grbDatosContrato.Controls.Add(this.lblTitulo1);
            this.grbDatosContrato.Controls.Add(this.lblDescripcion);
            this.grbDatosContrato.Controls.Add(this.lblEstado);
            this.grbDatosContrato.Controls.Add(this.lblTerminosCondiciones);
            this.grbDatosContrato.Controls.Add(this.lblCliente);
            this.grbDatosContrato.Controls.Add(this.lblFechaFirma);
            this.grbDatosContrato.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosContrato.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosContrato.ForeColor = System.Drawing.Color.White;
            this.grbDatosContrato.Location = new System.Drawing.Point(24, 71);
            this.grbDatosContrato.Name = "grbDatosContrato";
            this.grbDatosContrato.Size = new System.Drawing.Size(538, 608);
            this.grbDatosContrato.TabIndex = 47;
            this.grbDatosContrato.Text = "Datos del contrato a descargar";
            // 
            // txtMonto
            // 
            this.txtMonto.AutoRoundedCorners = true;
            this.txtMonto.BackColor = System.Drawing.Color.Transparent;
            this.txtMonto.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMonto.BorderRadius = 17;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Black;
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtMonto.Location = new System.Drawing.Point(270, 546);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(90, 36);
            this.txtMonto.TabIndex = 55;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoRoundedCorners = true;
            this.txtEstado.BackColor = System.Drawing.Color.Transparent;
            this.txtEstado.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEstado.BorderRadius = 17;
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.DefaultText = "";
            this.txtEstado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtEstado.Location = new System.Drawing.Point(270, 497);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.SelectedText = "";
            this.txtEstado.Size = new System.Drawing.Size(157, 36);
            this.txtEstado.TabIndex = 54;
            // 
            // txtCliente
            // 
            this.txtCliente.AutoRoundedCorners = true;
            this.txtCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtCliente.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCliente.BorderRadius = 17;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.DefaultText = "";
            this.txtCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtCliente.Location = new System.Drawing.Point(270, 346);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.SelectedText = "";
            this.txtCliente.Size = new System.Drawing.Size(235, 36);
            this.txtCliente.TabIndex = 53;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoRoundedCorners = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTitulo.BorderRadius = 17;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtTitulo.Location = new System.Drawing.Point(272, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(235, 36);
            this.txtTitulo.TabIndex = 52;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(35, 559);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(62, 23);
            this.lblMonto.TabIndex = 21;
            this.lblMonto.Text = "Monto";
            // 
            // dtpFechaVigencia
            // 
            this.dtpFechaVigencia.AutoRoundedCorners = true;
            this.dtpFechaVigencia.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaVigencia.Checked = true;
            this.dtpFechaVigencia.Enabled = false;
            this.dtpFechaVigencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaVigencia.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaVigencia.Location = new System.Drawing.Point(274, 444);
            this.dtpFechaVigencia.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVigencia.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVigencia.Name = "dtpFechaVigencia";
            this.dtpFechaVigencia.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaVigencia.TabIndex = 20;
            this.dtpFechaVigencia.Value = new System.DateTime(2025, 9, 29, 20, 4, 55, 285);
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.AutoSize = true;
            this.lblFechaVigencia.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVigencia.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVigencia.ForeColor = System.Drawing.Color.Black;
            this.lblFechaVigencia.Location = new System.Drawing.Point(32, 450);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(236, 23);
            this.lblFechaVigencia.TabIndex = 19;
            this.lblFechaVigencia.Text = "Fecha de inicio de vigencia";
            // 
            // dtpFechaFirma
            // 
            this.dtpFechaFirma.AutoRoundedCorners = true;
            this.dtpFechaFirma.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaFirma.Checked = true;
            this.dtpFechaFirma.Enabled = false;
            this.dtpFechaFirma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaFirma.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFirma.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaFirma.Location = new System.Drawing.Point(274, 399);
            this.dtpFechaFirma.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFirma.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFirma.Name = "dtpFechaFirma";
            this.dtpFechaFirma.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaFirma.TabIndex = 18;
            this.dtpFechaFirma.Value = new System.DateTime(2025, 9, 29, 20, 4, 55, 285);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcion.BorderRadius = 15;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Location = new System.Drawing.Point(272, 102);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(233, 108);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtTerminosCondiciones
            // 
            this.txtTerminosCondiciones.BackColor = System.Drawing.Color.Transparent;
            this.txtTerminosCondiciones.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTerminosCondiciones.BorderRadius = 15;
            this.txtTerminosCondiciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerminosCondiciones.DefaultText = "";
            this.txtTerminosCondiciones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTerminosCondiciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTerminosCondiciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTerminosCondiciones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTerminosCondiciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTerminosCondiciones.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminosCondiciones.ForeColor = System.Drawing.Color.Black;
            this.txtTerminosCondiciones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTerminosCondiciones.Location = new System.Drawing.Point(272, 226);
            this.txtTerminosCondiciones.Multiline = true;
            this.txtTerminosCondiciones.Name = "txtTerminosCondiciones";
            this.txtTerminosCondiciones.PlaceholderText = "";
            this.txtTerminosCondiciones.ReadOnly = true;
            this.txtTerminosCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTerminosCondiciones.SelectedText = "";
            this.txtTerminosCondiciones.Size = new System.Drawing.Size(233, 108);
            this.txtTerminosCondiciones.TabIndex = 15;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo1.Location = new System.Drawing.Point(30, 49);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(57, 23);
            this.lblTitulo1.TabIndex = 5;
            this.lblTitulo1.Text = "Titulo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 102);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 23);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(35, 510);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblTerminosCondiciones
            // 
            this.lblTerminosCondiciones.AutoSize = true;
            this.lblTerminosCondiciones.BackColor = System.Drawing.Color.Transparent;
            this.lblTerminosCondiciones.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminosCondiciones.ForeColor = System.Drawing.Color.Black;
            this.lblTerminosCondiciones.Location = new System.Drawing.Point(30, 226);
            this.lblTerminosCondiciones.Name = "lblTerminosCondiciones";
            this.lblTerminosCondiciones.Size = new System.Drawing.Size(207, 23);
            this.lblTerminosCondiciones.TabIndex = 5;
            this.lblTerminosCondiciones.Text = "Términos y condiciones";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(32, 346);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 23);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFechaFirma
            // 
            this.lblFechaFirma.AutoSize = true;
            this.lblFechaFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFirma.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFirma.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFirma.Location = new System.Drawing.Point(32, 399);
            this.lblFechaFirma.Name = "lblFechaFirma";
            this.lblFechaFirma.Size = new System.Drawing.Size(136, 23);
            this.lblFechaFirma.TabIndex = 5;
            this.lblFechaFirma.Text = "Fecha de firma";
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
            this.btnConfirmar.Location = new System.Drawing.Point(118, 704);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 45);
            this.btnConfirmar.TabIndex = 49;
            this.btnConfirmar.Text = "Confirmar descarga";
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
            this.btnCancelar.Location = new System.Drawing.Point(336, 704);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar descarga";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(562, 43);
            this.pnlHeader.TabIndex = 46;
            // 
            // frmDescargaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDatosContrato);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDescargaContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDescargaContrato_Load);
            this.grbDatosContrato.ResumeLayout(false);
            this.grbDatosContrato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosContrato;
        private System.Windows.Forms.Label lblMonto;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaVigencia;
        private System.Windows.Forms.Label lblFechaVigencia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaFirma;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtTerminosCondiciones;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTerminosCondiciones;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFechaFirma;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
    }
}