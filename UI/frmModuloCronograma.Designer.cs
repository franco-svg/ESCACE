namespace UI
{
    partial class frmModuloCronograma
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
            this.ltbHitos = new System.Windows.Forms.ListBox();
            this.lblHitos = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbListaProyectos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaProyectos = new System.Windows.Forms.DataGridView();
            this.grbCronogramaProyecto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grbDatosHito = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblAlcanzado = new System.Windows.Forms.Label();
            this.ccbAlcanzado = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCriterioAlcance = new System.Windows.Forms.Label();
            this.txtCriterioAlcance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).BeginInit();
            this.grbCronogramaProyecto.SuspendLayout();
            this.grbDatosHito.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbHitos
            // 
            this.ltbHitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ltbHitos.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHitos.FormattingEnabled = true;
            this.ltbHitos.HorizontalScrollbar = true;
            this.ltbHitos.ItemHeight = 18;
            this.ltbHitos.Location = new System.Drawing.Point(21, 74);
            this.ltbHitos.Name = "ltbHitos";
            this.ltbHitos.Size = new System.Drawing.Size(240, 274);
            this.ltbHitos.TabIndex = 41;
            this.ltbHitos.SelectedIndexChanged += new System.EventHandler(this.ltbHitos_SelectedIndexChanged);
            // 
            // lblHitos
            // 
            this.lblHitos.AutoSize = true;
            this.lblHitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHitos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitos.ForeColor = System.Drawing.Color.Black;
            this.lblHitos.Location = new System.Drawing.Point(17, 52);
            this.lblHitos.Name = "lblHitos";
            this.lblHitos.Size = new System.Drawing.Size(46, 19);
            this.lblHitos.TabIndex = 40;
            this.lblHitos.Text = "Hitos";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(28, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "MÓDULO DE CRONOGRAMA";
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // grbListaProyectos
            // 
            this.grbListaProyectos.BorderRadius = 15;
            this.grbListaProyectos.Controls.Add(this.dgvListaProyectos);
            this.grbListaProyectos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaProyectos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProyectos.ForeColor = System.Drawing.Color.White;
            this.grbListaProyectos.Location = new System.Drawing.Point(28, 98);
            this.grbListaProyectos.Name = "grbListaProyectos";
            this.grbListaProyectos.Size = new System.Drawing.Size(321, 573);
            this.grbListaProyectos.TabIndex = 44;
            this.grbListaProyectos.Text = "Lista de proyectos";
            // 
            // dgvListaProyectos
            // 
            this.dgvListaProyectos.AllowUserToAddRows = false;
            this.dgvListaProyectos.AllowUserToDeleteRows = false;
            this.dgvListaProyectos.AllowUserToResizeColumns = false;
            this.dgvListaProyectos.AllowUserToResizeRows = false;
            this.dgvListaProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.dgvListaProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(175)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProyectos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProyectos.EnableHeadersVisualStyles = false;
            this.dgvListaProyectos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaProyectos.Location = new System.Drawing.Point(21, 55);
            this.dgvListaProyectos.MultiSelect = false;
            this.dgvListaProyectos.Name = "dgvListaProyectos";
            this.dgvListaProyectos.ReadOnly = true;
            this.dgvListaProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProyectos.RowHeadersVisible = false;
            this.dgvListaProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProyectos.Size = new System.Drawing.Size(281, 498);
            this.dgvListaProyectos.TabIndex = 50;
            this.dgvListaProyectos.SelectionChanged += new System.EventHandler(this.dgvListaProyectos_SelectionChanged);
            // 
            // grbCronogramaProyecto
            // 
            this.grbCronogramaProyecto.BorderRadius = 15;
            this.grbCronogramaProyecto.Controls.Add(this.ltbHitos);
            this.grbCronogramaProyecto.Controls.Add(this.lblHitos);
            this.grbCronogramaProyecto.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbCronogramaProyecto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCronogramaProyecto.ForeColor = System.Drawing.Color.White;
            this.grbCronogramaProyecto.Location = new System.Drawing.Point(364, 144);
            this.grbCronogramaProyecto.Name = "grbCronogramaProyecto";
            this.grbCronogramaProyecto.Size = new System.Drawing.Size(281, 376);
            this.grbCronogramaProyecto.TabIndex = 45;
            this.grbCronogramaProyecto.Text = "Cronograma del proyecto";
            // 
            // grbDatosHito
            // 
            this.grbDatosHito.BorderRadius = 15;
            this.grbDatosHito.Controls.Add(this.lblAlcanzado);
            this.grbDatosHito.Controls.Add(this.ccbAlcanzado);
            this.grbDatosHito.Controls.Add(this.dtpFecha);
            this.grbDatosHito.Controls.Add(this.lblCriterioAlcance);
            this.grbDatosHito.Controls.Add(this.txtCriterioAlcance);
            this.grbDatosHito.Controls.Add(this.txtTitulo);
            this.grbDatosHito.Controls.Add(this.lblTitulo);
            this.grbDatosHito.Controls.Add(this.lblFecha);
            this.grbDatosHito.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosHito.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosHito.ForeColor = System.Drawing.Color.White;
            this.grbDatosHito.Location = new System.Drawing.Point(660, 144);
            this.grbDatosHito.Name = "grbDatosHito";
            this.grbDatosHito.Size = new System.Drawing.Size(487, 376);
            this.grbDatosHito.TabIndex = 46;
            this.grbDatosHito.Text = "Datos del hito";
            // 
            // lblAlcanzado
            // 
            this.lblAlcanzado.AutoSize = true;
            this.lblAlcanzado.BackColor = System.Drawing.Color.Transparent;
            this.lblAlcanzado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcanzado.ForeColor = System.Drawing.Color.Black;
            this.lblAlcanzado.Location = new System.Drawing.Point(30, 327);
            this.lblAlcanzado.Name = "lblAlcanzado";
            this.lblAlcanzado.Size = new System.Drawing.Size(97, 23);
            this.lblAlcanzado.TabIndex = 49;
            this.lblAlcanzado.Text = "Alcanzado";
            // 
            // ccbAlcanzado
            // 
            this.ccbAlcanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ccbAlcanzado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzado.CheckedState.BorderRadius = 2;
            this.ccbAlcanzado.CheckedState.BorderThickness = 0;
            this.ccbAlcanzado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzado.Enabled = false;
            this.ccbAlcanzado.ForeColor = System.Drawing.Color.Black;
            this.ccbAlcanzado.Location = new System.Drawing.Point(232, 330);
            this.ccbAlcanzado.Name = "ccbAlcanzado";
            this.ccbAlcanzado.Size = new System.Drawing.Size(20, 20);
            this.ccbAlcanzado.TabIndex = 48;
            this.ccbAlcanzado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.ccbAlcanzado.UncheckedState.BorderRadius = 2;
            this.ccbAlcanzado.UncheckedState.BorderThickness = 0;
            this.ccbAlcanzado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            // 
            // dtpFecha
            // 
            this.dtpFecha.AutoRoundedCorners = true;
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.Checked = true;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(155)))));
            this.dtpFecha.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.Location = new System.Drawing.Point(232, 280);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(233, 36);
            this.dtpFecha.TabIndex = 47;
            this.dtpFecha.Value = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // lblCriterioAlcance
            // 
            this.lblCriterioAlcance.AutoSize = true;
            this.lblCriterioAlcance.BackColor = System.Drawing.Color.Transparent;
            this.lblCriterioAlcance.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioAlcance.ForeColor = System.Drawing.Color.Black;
            this.lblCriterioAlcance.Location = new System.Drawing.Point(30, 95);
            this.lblCriterioAlcance.Name = "lblCriterioAlcance";
            this.lblCriterioAlcance.Size = new System.Drawing.Size(169, 23);
            this.lblCriterioAlcance.TabIndex = 12;
            this.lblCriterioAlcance.Text = "Criterio de alcance";
            // 
            // txtCriterioAlcance
            // 
            this.txtCriterioAlcance.BackColor = System.Drawing.Color.Transparent;
            this.txtCriterioAlcance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCriterioAlcance.BorderRadius = 15;
            this.txtCriterioAlcance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCriterioAlcance.DefaultText = "";
            this.txtCriterioAlcance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCriterioAlcance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCriterioAlcance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCriterioAlcance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcance.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterioAlcance.ForeColor = System.Drawing.Color.Black;
            this.txtCriterioAlcance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCriterioAlcance.Location = new System.Drawing.Point(232, 95);
            this.txtCriterioAlcance.Multiline = true;
            this.txtCriterioAlcance.Name = "txtCriterioAlcance";
            this.txtCriterioAlcance.PlaceholderText = "";
            this.txtCriterioAlcance.ReadOnly = true;
            this.txtCriterioAlcance.SelectedText = "";
            this.txtCriterioAlcance.Size = new System.Drawing.Size(233, 163);
            this.txtCriterioAlcance.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoRoundedCorners = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTitulo.BorderRadius = 15;
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
            this.txtTitulo.Location = new System.Drawing.Point(232, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(233, 33);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(30, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(30, 280);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(162, 23);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha establecida";
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
            this.btnRegistrar.Location = new System.Drawing.Point(660, 571);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 54);
            this.btnRegistrar.TabIndex = 47;
            this.btnRegistrar.Text = "Registrar hito";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(846, 571);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 54);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "Modificar hito";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(1022, 571);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 54);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar hito";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmModuloCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbDatosHito);
            this.Controls.Add(this.grbCronogramaProyecto);
            this.Controls.Add(this.grbListaProyectos);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloCronograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloCronograma_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).EndInit();
            this.grbCronogramaProyecto.ResumeLayout(false);
            this.grbCronogramaProyecto.PerformLayout();
            this.grbDatosHito.ResumeLayout(false);
            this.grbDatosHito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHitos;
        private System.Windows.Forms.ListBox ltbHitos;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaProyectos;
        private Guna.UI2.WinForms.Guna2GroupBox grbCronogramaProyecto;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosHito;
        private System.Windows.Forms.Label lblCriterioAlcance;
        private Guna.UI2.WinForms.Guna2TextBox txtCriterioAlcance;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ccbAlcanzado;
        private System.Windows.Forms.Label lblAlcanzado;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaProyectos;
    }
}