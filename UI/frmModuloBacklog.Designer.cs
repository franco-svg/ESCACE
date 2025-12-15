namespace UI
{
    partial class frmModuloBacklog
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
            this.label3 = new System.Windows.Forms.Label();
            this.ucBackButton2 = new UI.UCBackButton();
            this.grbListaProyectos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaProyectos = new System.Windows.Forms.DataGridView();
            this.grbBacklog = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblFasesTareas = new System.Windows.Forms.Label();
            this.tvwBacklog = new System.Windows.Forms.TreeView();
            this.grbDatosWI = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHorasCompletadas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasCompletadas = new System.Windows.Forms.Label();
            this.txtHorasEstimadas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasEstimadas = new System.Windows.Forms.Label();
            this.txtHorasRestantes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasRestantes = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnRegistrarFase = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarFase = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarFase = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarTarea = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarTarea = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificarTarea = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.grbListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).BeginInit();
            this.grbBacklog.SuspendLayout();
            this.grbDatosWI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(32, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(468, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "MÓDULO DE BACKLOG";
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
            this.grbListaProyectos.Location = new System.Drawing.Point(41, 82);
            this.grbListaProyectos.Name = "grbListaProyectos";
            this.grbListaProyectos.Size = new System.Drawing.Size(292, 573);
            this.grbListaProyectos.TabIndex = 47;
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
            this.dgvListaProyectos.Location = new System.Drawing.Point(11, 51);
            this.dgvListaProyectos.MultiSelect = false;
            this.dgvListaProyectos.Name = "dgvListaProyectos";
            this.dgvListaProyectos.ReadOnly = true;
            this.dgvListaProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProyectos.RowHeadersVisible = false;
            this.dgvListaProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProyectos.Size = new System.Drawing.Size(267, 508);
            this.dgvListaProyectos.TabIndex = 56;
            this.dgvListaProyectos.SelectionChanged += new System.EventHandler(this.dgvListaProyectos_SelectionChanged);
            // 
            // grbBacklog
            // 
            this.grbBacklog.BorderRadius = 15;
            this.grbBacklog.Controls.Add(this.lblFasesTareas);
            this.grbBacklog.Controls.Add(this.tvwBacklog);
            this.grbBacklog.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbBacklog.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBacklog.ForeColor = System.Drawing.Color.White;
            this.grbBacklog.Location = new System.Drawing.Point(351, 82);
            this.grbBacklog.Name = "grbBacklog";
            this.grbBacklog.Size = new System.Drawing.Size(292, 573);
            this.grbBacklog.TabIndex = 48;
            this.grbBacklog.Text = "Backlog del proyecto";
            // 
            // lblFasesTareas
            // 
            this.lblFasesTareas.AutoSize = true;
            this.lblFasesTareas.BackColor = System.Drawing.Color.White;
            this.lblFasesTareas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFasesTareas.ForeColor = System.Drawing.Color.Black;
            this.lblFasesTareas.Location = new System.Drawing.Point(15, 51);
            this.lblFasesTareas.Name = "lblFasesTareas";
            this.lblFasesTareas.Size = new System.Drawing.Size(115, 19);
            this.lblFasesTareas.TabIndex = 43;
            this.lblFasesTareas.Text = "Fases y tareas";
            // 
            // tvwBacklog
            // 
            this.tvwBacklog.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwBacklog.Location = new System.Drawing.Point(19, 76);
            this.tvwBacklog.Name = "tvwBacklog";
            this.tvwBacklog.Size = new System.Drawing.Size(255, 473);
            this.tvwBacklog.TabIndex = 42;
            this.tvwBacklog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwBacklog_AfterSelect);
            // 
            // grbDatosWI
            // 
            this.grbDatosWI.BorderRadius = 15;
            this.grbDatosWI.Controls.Add(this.txtEstado);
            this.grbDatosWI.Controls.Add(this.txtHorasCompletadas);
            this.grbDatosWI.Controls.Add(this.lblHorasCompletadas);
            this.grbDatosWI.Controls.Add(this.txtHorasEstimadas);
            this.grbDatosWI.Controls.Add(this.lblHorasEstimadas);
            this.grbDatosWI.Controls.Add(this.txtHorasRestantes);
            this.grbDatosWI.Controls.Add(this.lblHorasRestantes);
            this.grbDatosWI.Controls.Add(this.txtDescripcion);
            this.grbDatosWI.Controls.Add(this.txtTitulo);
            this.grbDatosWI.Controls.Add(this.lblTituloMod);
            this.grbDatosWI.Controls.Add(this.lblDescripcionMod);
            this.grbDatosWI.Controls.Add(this.lblEstado);
            this.grbDatosWI.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosWI.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosWI.ForeColor = System.Drawing.Color.White;
            this.grbDatosWI.Location = new System.Drawing.Point(665, 82);
            this.grbDatosWI.Name = "grbDatosWI";
            this.grbDatosWI.Size = new System.Drawing.Size(482, 399);
            this.grbDatosWI.TabIndex = 49;
            this.grbDatosWI.Text = "Datos de la fase";
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
            this.txtEstado.Location = new System.Drawing.Point(272, 337);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.SelectedText = "";
            this.txtEstado.Size = new System.Drawing.Size(173, 36);
            this.txtEstado.TabIndex = 51;
            // 
            // txtHorasCompletadas
            // 
            this.txtHorasCompletadas.AutoRoundedCorners = true;
            this.txtHorasCompletadas.BackColor = System.Drawing.Color.Transparent;
            this.txtHorasCompletadas.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHorasCompletadas.BorderRadius = 17;
            this.txtHorasCompletadas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasCompletadas.DefaultText = "";
            this.txtHorasCompletadas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasCompletadas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasCompletadas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasCompletadas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasCompletadas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasCompletadas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasCompletadas.ForeColor = System.Drawing.Color.Black;
            this.txtHorasCompletadas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasCompletadas.Location = new System.Drawing.Point(272, 295);
            this.txtHorasCompletadas.Name = "txtHorasCompletadas";
            this.txtHorasCompletadas.PlaceholderText = "";
            this.txtHorasCompletadas.ReadOnly = true;
            this.txtHorasCompletadas.SelectedText = "";
            this.txtHorasCompletadas.Size = new System.Drawing.Size(66, 36);
            this.txtHorasCompletadas.TabIndex = 50;
            // 
            // lblHorasCompletadas
            // 
            this.lblHorasCompletadas.AutoSize = true;
            this.lblHorasCompletadas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasCompletadas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasCompletadas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasCompletadas.Location = new System.Drawing.Point(30, 295);
            this.lblHorasCompletadas.Name = "lblHorasCompletadas";
            this.lblHorasCompletadas.Size = new System.Drawing.Size(173, 23);
            this.lblHorasCompletadas.TabIndex = 49;
            this.lblHorasCompletadas.Text = "Horas completadas";
            // 
            // txtHorasEstimadas
            // 
            this.txtHorasEstimadas.AutoRoundedCorners = true;
            this.txtHorasEstimadas.BackColor = System.Drawing.Color.Transparent;
            this.txtHorasEstimadas.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHorasEstimadas.BorderRadius = 17;
            this.txtHorasEstimadas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasEstimadas.DefaultText = "";
            this.txtHorasEstimadas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasEstimadas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasEstimadas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasEstimadas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasEstimadas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasEstimadas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasEstimadas.ForeColor = System.Drawing.Color.Black;
            this.txtHorasEstimadas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasEstimadas.Location = new System.Drawing.Point(272, 211);
            this.txtHorasEstimadas.Name = "txtHorasEstimadas";
            this.txtHorasEstimadas.PlaceholderText = "";
            this.txtHorasEstimadas.ReadOnly = true;
            this.txtHorasEstimadas.SelectedText = "";
            this.txtHorasEstimadas.Size = new System.Drawing.Size(66, 36);
            this.txtHorasEstimadas.TabIndex = 48;
            // 
            // lblHorasEstimadas
            // 
            this.lblHorasEstimadas.AutoSize = true;
            this.lblHorasEstimadas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasEstimadas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasEstimadas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasEstimadas.Location = new System.Drawing.Point(30, 218);
            this.lblHorasEstimadas.Name = "lblHorasEstimadas";
            this.lblHorasEstimadas.Size = new System.Drawing.Size(153, 23);
            this.lblHorasEstimadas.TabIndex = 47;
            this.lblHorasEstimadas.Text = "Horas estimadas";
            // 
            // txtHorasRestantes
            // 
            this.txtHorasRestantes.AutoRoundedCorners = true;
            this.txtHorasRestantes.BackColor = System.Drawing.Color.Transparent;
            this.txtHorasRestantes.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHorasRestantes.BorderRadius = 17;
            this.txtHorasRestantes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasRestantes.DefaultText = "";
            this.txtHorasRestantes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasRestantes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasRestantes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasRestantes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasRestantes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasRestantes.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasRestantes.ForeColor = System.Drawing.Color.Black;
            this.txtHorasRestantes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasRestantes.Location = new System.Drawing.Point(272, 253);
            this.txtHorasRestantes.Name = "txtHorasRestantes";
            this.txtHorasRestantes.PlaceholderText = "";
            this.txtHorasRestantes.ReadOnly = true;
            this.txtHorasRestantes.SelectedText = "";
            this.txtHorasRestantes.Size = new System.Drawing.Size(66, 36);
            this.txtHorasRestantes.TabIndex = 28;
            // 
            // lblHorasRestantes
            // 
            this.lblHorasRestantes.AutoSize = true;
            this.lblHorasRestantes.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasRestantes.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasRestantes.ForeColor = System.Drawing.Color.Black;
            this.lblHorasRestantes.Location = new System.Drawing.Point(30, 257);
            this.lblHorasRestantes.Name = "lblHorasRestantes";
            this.lblHorasRestantes.Size = new System.Drawing.Size(147, 23);
            this.lblHorasRestantes.TabIndex = 27;
            this.lblHorasRestantes.Text = "Horas restantes";
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
            this.txtDescripcion.Size = new System.Drawing.Size(173, 108);
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
            this.txtTitulo.Size = new System.Drawing.Size(173, 36);
            this.txtTitulo.TabIndex = 6;
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
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(30, 344);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // btnRegistrarFase
            // 
            this.btnRegistrarFase.BorderRadius = 10;
            this.btnRegistrarFase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarFase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarFase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarFase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarFase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarFase.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarFase.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarFase.Location = new System.Drawing.Point(679, 503);
            this.btnRegistrarFase.Name = "btnRegistrarFase";
            this.btnRegistrarFase.Size = new System.Drawing.Size(119, 54);
            this.btnRegistrarFase.TabIndex = 50;
            this.btnRegistrarFase.Text = "Registrar fase";
            this.btnRegistrarFase.Click += new System.EventHandler(this.btnRegistrarFase_Click_1);
            // 
            // btnModificarFase
            // 
            this.btnModificarFase.BorderRadius = 10;
            this.btnModificarFase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarFase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarFase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarFase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarFase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarFase.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFase.ForeColor = System.Drawing.Color.White;
            this.btnModificarFase.Location = new System.Drawing.Point(847, 503);
            this.btnModificarFase.Name = "btnModificarFase";
            this.btnModificarFase.Size = new System.Drawing.Size(119, 54);
            this.btnModificarFase.TabIndex = 51;
            this.btnModificarFase.Text = "Modificar fase";
            this.btnModificarFase.Click += new System.EventHandler(this.btnModificarFase_Click_1);
            // 
            // btnEliminarFase
            // 
            this.btnEliminarFase.BorderRadius = 10;
            this.btnEliminarFase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarFase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarFase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarFase.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFase.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFase.Location = new System.Drawing.Point(1004, 503);
            this.btnEliminarFase.Name = "btnEliminarFase";
            this.btnEliminarFase.Size = new System.Drawing.Size(119, 54);
            this.btnEliminarFase.TabIndex = 52;
            this.btnEliminarFase.Text = "Eliminar fase";
            this.btnEliminarFase.Click += new System.EventHandler(this.btnEliminarFase_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BorderRadius = 10;
            this.btnEliminarTarea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTarea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTarea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarTarea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarTarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEliminarTarea.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTarea.Location = new System.Drawing.Point(1004, 577);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(119, 54);
            this.btnEliminarTarea.TabIndex = 55;
            this.btnEliminarTarea.Text = "Eliminar tarea";
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.BorderRadius = 10;
            this.btnRegistrarTarea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarTarea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarTarea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarTarea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarTarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRegistrarTarea.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTarea.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTarea.Location = new System.Drawing.Point(679, 577);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Size = new System.Drawing.Size(119, 54);
            this.btnRegistrarTarea.TabIndex = 54;
            this.btnRegistrarTarea.Text = "Registrar tarea";
            this.btnRegistrarTarea.Click += new System.EventHandler(this.btnRegistrarTarea_Click_1);
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.BorderRadius = 10;
            this.btnModificarTarea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarTarea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarTarea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarTarea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarTarea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnModificarTarea.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTarea.ForeColor = System.Drawing.Color.White;
            this.btnModificarTarea.Location = new System.Drawing.Point(847, 577);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(119, 54);
            this.btnModificarTarea.TabIndex = 53;
            this.btnModificarTarea.Text = "Modificar tarea";
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click_1);
            // 
            // frmModuloBacklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.grbDatosWI);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnRegistrarTarea);
            this.Controls.Add(this.btnModificarTarea);
            this.Controls.Add(this.btnEliminarFase);
            this.Controls.Add(this.btnModificarFase);
            this.Controls.Add(this.btnRegistrarFase);
            this.Controls.Add(this.grbBacklog);
            this.Controls.Add(this.grbListaProyectos);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloBacklog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloBacklog_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).EndInit();
            this.grbBacklog.ResumeLayout(false);
            this.grbBacklog.PerformLayout();
            this.grbDatosWI.ResumeLayout(false);
            this.grbDatosWI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaProyectos;
        private Guna.UI2.WinForms.Guna2GroupBox grbBacklog;
        private System.Windows.Forms.Label lblFasesTareas;
        private System.Windows.Forms.TreeView tvwBacklog;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosWI;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasRestantes;
        private System.Windows.Forms.Label lblHorasRestantes;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.Label lblDescripcionMod;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasCompletadas;
        private System.Windows.Forms.Label lblHorasCompletadas;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasEstimadas;
        private System.Windows.Forms.Label lblHorasEstimadas;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarFase;
        private Guna.UI2.WinForms.Guna2Button btnModificarFase;
        private Guna.UI2.WinForms.Guna2Button btnEliminarFase;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTarea;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarTarea;
        private Guna.UI2.WinForms.Guna2Button btnModificarTarea;
        private System.Windows.Forms.DataGridView dgvListaProyectos;
    }
}