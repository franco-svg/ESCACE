namespace UI
{
    partial class frmModuloFichasProyecto
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
            this.grbDatosFicha = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtContrato = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoras = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtPresupuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.dtpFechaFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.grbListaFichas = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaFichas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbDatosFicha.SuspendLayout();
            this.grbListaFichas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFichas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(27, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(412, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(347, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "MÓDULO DE FICHAS DE PROYECTO";
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // grbDatosFicha
            // 
            this.grbDatosFicha.BorderRadius = 15;
            this.grbDatosFicha.Controls.Add(this.txtContrato);
            this.grbDatosFicha.Controls.Add(this.txtEstado);
            this.grbDatosFicha.Controls.Add(this.txtHoras);
            this.grbDatosFicha.Controls.Add(this.lblHoras);
            this.grbDatosFicha.Controls.Add(this.txtPresupuesto);
            this.grbDatosFicha.Controls.Add(this.lblPresupuesto);
            this.grbDatosFicha.Controls.Add(this.dtpFechaFin);
            this.grbDatosFicha.Controls.Add(this.lblFechaFin);
            this.grbDatosFicha.Controls.Add(this.dtpFechaInicio);
            this.grbDatosFicha.Controls.Add(this.txtDescripcion);
            this.grbDatosFicha.Controls.Add(this.txtTitulo);
            this.grbDatosFicha.Controls.Add(this.lblTitulo1);
            this.grbDatosFicha.Controls.Add(this.lblDescripcion);
            this.grbDatosFicha.Controls.Add(this.lblEstado);
            this.grbDatosFicha.Controls.Add(this.lblContrato);
            this.grbDatosFicha.Controls.Add(this.lblFechaInicio);
            this.grbDatosFicha.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosFicha.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosFicha.ForeColor = System.Drawing.Color.White;
            this.grbDatosFicha.Location = new System.Drawing.Point(405, 111);
            this.grbDatosFicha.Name = "grbDatosFicha";
            this.grbDatosFicha.Size = new System.Drawing.Size(538, 537);
            this.grbDatosFicha.TabIndex = 31;
            this.grbDatosFicha.Text = "Datos de la ficha de proyecto";
            // 
            // txtContrato
            // 
            this.txtContrato.AutoRoundedCorners = true;
            this.txtContrato.BackColor = System.Drawing.Color.Transparent;
            this.txtContrato.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContrato.BorderRadius = 17;
            this.txtContrato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrato.DefaultText = "";
            this.txtContrato.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrato.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.ForeColor = System.Drawing.Color.Black;
            this.txtContrato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrato.Location = new System.Drawing.Point(272, 217);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.PlaceholderText = "";
            this.txtContrato.ReadOnly = true;
            this.txtContrato.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtContrato.SelectedText = "";
            this.txtContrato.Size = new System.Drawing.Size(233, 36);
            this.txtContrato.TabIndex = 26;
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
            this.txtEstado.Location = new System.Drawing.Point(272, 425);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.SelectedText = "";
            this.txtEstado.Size = new System.Drawing.Size(146, 36);
            this.txtEstado.TabIndex = 25;
            // 
            // txtHoras
            // 
            this.txtHoras.AutoRoundedCorners = true;
            this.txtHoras.BackColor = System.Drawing.Color.Transparent;
            this.txtHoras.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHoras.BorderRadius = 17;
            this.txtHoras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoras.DefaultText = "";
            this.txtHoras.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoras.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoras.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoras.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.ForeColor = System.Drawing.Color.Black;
            this.txtHoras.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoras.Location = new System.Drawing.Point(272, 374);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.PlaceholderText = "";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.SelectedText = "";
            this.txtHoras.Size = new System.Drawing.Size(92, 36);
            this.txtHoras.TabIndex = 24;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.Transparent;
            this.lblHoras.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(35, 382);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(154, 23);
            this.lblHoras.TabIndex = 23;
            this.lblHoras.Text = "Horas a entregar";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.AutoRoundedCorners = true;
            this.txtPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.txtPresupuesto.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPresupuesto.BorderRadius = 17;
            this.txtPresupuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPresupuesto.DefaultText = "";
            this.txtPresupuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresupuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresupuesto.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.txtPresupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresupuesto.Location = new System.Drawing.Point(272, 474);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.PlaceholderText = "";
            this.txtPresupuesto.ReadOnly = true;
            this.txtPresupuesto.SelectedText = "";
            this.txtPresupuesto.Size = new System.Drawing.Size(92, 36);
            this.txtPresupuesto.TabIndex = 22;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPresupuesto.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.lblPresupuesto.Location = new System.Drawing.Point(33, 487);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(170, 23);
            this.lblPresupuesto.TabIndex = 21;
            this.lblPresupuesto.Text = "Presupuesto (U$D)";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.AutoRoundedCorners = true;
            this.dtpFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaFin.Checked = true;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaFin.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaFin.Location = new System.Drawing.Point(272, 312);
            this.dtpFechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaFin.TabIndex = 20;
            this.dtpFechaFin.Value = new System.DateTime(2025, 9, 29, 20, 4, 55, 285);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(30, 321);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(187, 23);
            this.lblFechaFin.TabIndex = 19;
            this.lblFechaFin.Text = "Fecha de fin prevista";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.AutoRoundedCorners = true;
            this.dtpFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaInicio.Checked = true;
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaInicio.Location = new System.Drawing.Point(272, 265);
            this.dtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(233, 36);
            this.dtpFechaInicio.TabIndex = 18;
            this.dtpFechaInicio.Value = new System.DateTime(2025, 9, 29, 20, 4, 55, 285);
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
            this.txtDescripcion.Location = new System.Drawing.Point(272, 97);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(233, 108);
            this.txtDescripcion.TabIndex = 17;
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
            this.txtTitulo.Location = new System.Drawing.Point(272, 54);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(233, 36);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo1.Location = new System.Drawing.Point(30, 56);
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
            this.lblDescripcion.Location = new System.Drawing.Point(30, 97);
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
            this.lblEstado.Location = new System.Drawing.Point(33, 438);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.BackColor = System.Drawing.Color.Transparent;
            this.lblContrato.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.ForeColor = System.Drawing.Color.Black;
            this.lblContrato.Location = new System.Drawing.Point(30, 217);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(83, 23);
            this.lblContrato.TabIndex = 5;
            this.lblContrato.Text = "Contrato";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(30, 270);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(210, 23);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de inicio prevista";
            // 
            // grbListaFichas
            // 
            this.grbListaFichas.BorderRadius = 15;
            this.grbListaFichas.Controls.Add(this.dgvListaFichas);
            this.grbListaFichas.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaFichas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaFichas.ForeColor = System.Drawing.Color.White;
            this.grbListaFichas.Location = new System.Drawing.Point(50, 111);
            this.grbListaFichas.Name = "grbListaFichas";
            this.grbListaFichas.Size = new System.Drawing.Size(321, 533);
            this.grbListaFichas.TabIndex = 32;
            this.grbListaFichas.Text = "Lista de fichas de proyecto";
            // 
            // dgvListaFichas
            // 
            this.dgvListaFichas.AllowUserToAddRows = false;
            this.dgvListaFichas.AllowUserToDeleteRows = false;
            this.dgvListaFichas.AllowUserToResizeColumns = false;
            this.dgvListaFichas.AllowUserToResizeRows = false;
            this.dgvListaFichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaFichas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dgvListaFichas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFichas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(175)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFichas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaFichas.EnableHeadersVisualStyles = false;
            this.dgvListaFichas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaFichas.Location = new System.Drawing.Point(15, 51);
            this.dgvListaFichas.MultiSelect = false;
            this.dgvListaFichas.Name = "dgvListaFichas";
            this.dgvListaFichas.ReadOnly = true;
            this.dgvListaFichas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaFichas.RowHeadersVisible = false;
            this.dgvListaFichas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaFichas.Size = new System.Drawing.Size(293, 459);
            this.dgvListaFichas.TabIndex = 36;
            this.dgvListaFichas.SelectionChanged += new System.EventHandler(this.dgvListaFichas_SelectionChanged);
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
            this.btnEliminar.Location = new System.Drawing.Point(989, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 54);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar ficha de proyecto";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(989, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 54);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar ficha de proyecto";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
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
            this.btnRegistrar.Location = new System.Drawing.Point(989, 262);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 54);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Registrar ficha de proyecto";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // frmModuloFichasProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbListaFichas);
            this.Controls.Add(this.grbDatosFicha);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloFichasProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloFichasProyecto_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbDatosFicha.ResumeLayout(false);
            this.grbDatosFicha.PerformLayout();
            this.grbListaFichas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFichas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosFicha;
        private Guna.UI2.WinForms.Guna2TextBox txtHoras;
        private System.Windows.Forms.Label lblHoras;
        private Guna.UI2.WinForms.Guna2TextBox txtPresupuesto;
        private System.Windows.Forms.Label lblPresupuesto;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblFechaInicio;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaFichas;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtContrato;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvListaFichas;
    }
}