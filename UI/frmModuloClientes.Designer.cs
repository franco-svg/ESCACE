namespace UI
{
    partial class frmModuloClientes
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
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbListaClientes = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grbDatosCliente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtIndustria = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumeroTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrefijoTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdFiscal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaís = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRazonSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblIndustria = new System.Windows.Forms.Label();
            this.lblIdFiscal = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grbListaClientes.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(33, 27);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(441, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "MÓDULO DE CLIENTES";
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // grbListaClientes
            // 
            this.grbListaClientes.BorderRadius = 15;
            this.grbListaClientes.Controls.Add(this.dgvListaClientes);
            this.grbListaClientes.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaClientes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaClientes.ForeColor = System.Drawing.Color.White;
            this.grbListaClientes.Location = new System.Drawing.Point(55, 122);
            this.grbListaClientes.Name = "grbListaClientes";
            this.grbListaClientes.Size = new System.Drawing.Size(487, 480);
            this.grbListaClientes.TabIndex = 23;
            this.grbListaClientes.Text = "Lista de clientes";
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.BorderRadius = 15;
            this.grbDatosCliente.Controls.Add(this.txtIndustria);
            this.grbDatosCliente.Controls.Add(this.txtNumeroTelefono);
            this.grbDatosCliente.Controls.Add(this.txtPrefijoTelefono);
            this.grbDatosCliente.Controls.Add(this.txtEmail);
            this.grbDatosCliente.Controls.Add(this.txtIdFiscal);
            this.grbDatosCliente.Controls.Add(this.txtPaís);
            this.grbDatosCliente.Controls.Add(this.txtRazonSocial);
            this.grbDatosCliente.Controls.Add(this.lblRazonSocial);
            this.grbDatosCliente.Controls.Add(this.lblPais);
            this.grbDatosCliente.Controls.Add(this.lblIndustria);
            this.grbDatosCliente.Controls.Add(this.lblIdFiscal);
            this.grbDatosCliente.Controls.Add(this.lblEmail);
            this.grbDatosCliente.Controls.Add(this.lblTelefono);
            this.grbDatosCliente.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosCliente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.ForeColor = System.Drawing.Color.White;
            this.grbDatosCliente.Location = new System.Drawing.Point(622, 122);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(487, 350);
            this.grbDatosCliente.TabIndex = 24;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // txtIndustria
            // 
            this.txtIndustria.AutoRoundedCorners = true;
            this.txtIndustria.BackColor = System.Drawing.Color.Transparent;
            this.txtIndustria.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIndustria.BorderRadius = 14;
            this.txtIndustria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIndustria.DefaultText = "";
            this.txtIndustria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIndustria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIndustria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIndustria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIndustria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIndustria.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustria.ForeColor = System.Drawing.Color.Black;
            this.txtIndustria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIndustria.Location = new System.Drawing.Point(241, 299);
            this.txtIndustria.Name = "txtIndustria";
            this.txtIndustria.PlaceholderText = "";
            this.txtIndustria.ReadOnly = true;
            this.txtIndustria.SelectedText = "";
            this.txtIndustria.Size = new System.Drawing.Size(200, 30);
            this.txtIndustria.TabIndex = 28;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.AutoRoundedCorners = true;
            this.txtNumeroTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroTelefono.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumeroTelefono.BorderRadius = 14;
            this.txtNumeroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTelefono.DefaultText = "";
            this.txtNumeroTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefono.Location = new System.Drawing.Point(288, 245);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.PlaceholderText = "";
            this.txtNumeroTelefono.ReadOnly = true;
            this.txtNumeroTelefono.SelectedText = "";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(153, 30);
            this.txtNumeroTelefono.TabIndex = 13;
            // 
            // txtPrefijoTelefono
            // 
            this.txtPrefijoTelefono.AutoRoundedCorners = true;
            this.txtPrefijoTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtPrefijoTelefono.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrefijoTelefono.BorderRadius = 14;
            this.txtPrefijoTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrefijoTelefono.DefaultText = "";
            this.txtPrefijoTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrefijoTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrefijoTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrefijoTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrefijoTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrefijoTelefono.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefijoTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtPrefijoTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrefijoTelefono.Location = new System.Drawing.Point(241, 245);
            this.txtPrefijoTelefono.Name = "txtPrefijoTelefono";
            this.txtPrefijoTelefono.PlaceholderText = "";
            this.txtPrefijoTelefono.ReadOnly = true;
            this.txtPrefijoTelefono.SelectedText = "";
            this.txtPrefijoTelefono.Size = new System.Drawing.Size(41, 30);
            this.txtPrefijoTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.BorderRadius = 14;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(241, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtIdFiscal
            // 
            this.txtIdFiscal.AutoRoundedCorners = true;
            this.txtIdFiscal.BackColor = System.Drawing.Color.Transparent;
            this.txtIdFiscal.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdFiscal.BorderRadius = 14;
            this.txtIdFiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdFiscal.DefaultText = "";
            this.txtIdFiscal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdFiscal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdFiscal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdFiscal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdFiscal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdFiscal.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFiscal.ForeColor = System.Drawing.Color.Black;
            this.txtIdFiscal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdFiscal.Location = new System.Drawing.Point(241, 147);
            this.txtIdFiscal.Name = "txtIdFiscal";
            this.txtIdFiscal.PlaceholderText = "";
            this.txtIdFiscal.ReadOnly = true;
            this.txtIdFiscal.SelectedText = "";
            this.txtIdFiscal.Size = new System.Drawing.Size(200, 30);
            this.txtIdFiscal.TabIndex = 8;
            // 
            // txtPaís
            // 
            this.txtPaís.AutoRoundedCorners = true;
            this.txtPaís.BackColor = System.Drawing.Color.Transparent;
            this.txtPaís.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPaís.BorderRadius = 14;
            this.txtPaís.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaís.DefaultText = "";
            this.txtPaís.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaís.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaís.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaís.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaís.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaís.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaís.ForeColor = System.Drawing.Color.Black;
            this.txtPaís.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaís.Location = new System.Drawing.Point(241, 102);
            this.txtPaís.Name = "txtPaís";
            this.txtPaís.PlaceholderText = "";
            this.txtPaís.ReadOnly = true;
            this.txtPaís.SelectedText = "";
            this.txtPaís.Size = new System.Drawing.Size(200, 30);
            this.txtPaís.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AutoRoundedCorners = true;
            this.txtRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.txtRazonSocial.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRazonSocial.BorderRadius = 14;
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazonSocial.DefaultText = "";
            this.txtRazonSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRazonSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRazonSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazonSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazonSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazonSocial.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazonSocial.Location = new System.Drawing.Point(241, 52);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PlaceholderText = "";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.Size = new System.Drawing.Size(200, 30);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.lblRazonSocial.Location = new System.Drawing.Point(30, 56);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(117, 23);
            this.lblRazonSocial.TabIndex = 5;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.Black;
            this.lblPais.Location = new System.Drawing.Point(30, 109);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(47, 23);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País";
            // 
            // lblIndustria
            // 
            this.lblIndustria.AutoSize = true;
            this.lblIndustria.BackColor = System.Drawing.Color.Transparent;
            this.lblIndustria.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustria.ForeColor = System.Drawing.Color.Black;
            this.lblIndustria.Location = new System.Drawing.Point(32, 306);
            this.lblIndustria.Name = "lblIndustria";
            this.lblIndustria.Size = new System.Drawing.Size(86, 23);
            this.lblIndustria.TabIndex = 5;
            this.lblIndustria.Text = "Industria";
            // 
            // lblIdFiscal
            // 
            this.lblIdFiscal.AutoSize = true;
            this.lblIdFiscal.BackColor = System.Drawing.Color.Transparent;
            this.lblIdFiscal.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFiscal.ForeColor = System.Drawing.Color.Black;
            this.lblIdFiscal.Location = new System.Drawing.Point(32, 154);
            this.lblIdFiscal.Name = "lblIdFiscal";
            this.lblIdFiscal.Size = new System.Drawing.Size(154, 23);
            this.lblIdFiscal.TabIndex = 5;
            this.lblIdFiscal.Text = "IdFiscalDinamico";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(32, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Correo electrónico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(32, 252);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 23);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(814, 512);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 45);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar cliente";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(982, 512);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 45);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar cliente";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 10;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(622, 512);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 45);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar cliente";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.AllowUserToResizeColumns = false;
            this.dgvListaClientes.AllowUserToResizeRows = false;
            this.dgvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dgvListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(175)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaClientes.EnableHeadersVisualStyles = false;
            this.dgvListaClientes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaClientes.Location = new System.Drawing.Point(16, 56);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaClientes.RowHeadersVisible = false;
            this.dgvListaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(455, 402);
            this.dgvListaClientes.TabIndex = 19;
            this.dgvListaClientes.SelectionChanged += new System.EventHandler(this.dgvListaClientes_SelectionChanged_1);
            // 
            // frmModuloClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.grbListaClientes);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloClientes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbListaClientes.ResumeLayout(false);
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaClientes;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtPrefijoTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtIdFiscal;
        private Guna.UI2.WinForms.Guna2TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblIndustria;
        private System.Windows.Forms.Label lblIdFiscal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtPaís;
        private Guna.UI2.WinForms.Guna2TextBox txtIndustria;
        private System.Windows.Forms.DataGridView dgvListaClientes;
    }
}