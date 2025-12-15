namespace UI
{
    partial class frmModuloProyectos
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatosProyecto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ltbHitos = new System.Windows.Forms.ListBox();
            this.txtHorasCompletadas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHitos = new System.Windows.Forms.Label();
            this.lblHorasCompletadas = new System.Windows.Forms.Label();
            this.tvwFasesTareas = new System.Windows.Forms.TreeView();
            this.lblFasesTareas = new System.Windows.Forms.Label();
            this.txtHorasEstimadas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasEstimadas = new System.Windows.Forms.Label();
            this.txtFicha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHorasRestantes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHorasRestantes = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFicha = new System.Windows.Forms.Label();
            this.grbListaProyectos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListaProyectos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.ucBackButton2 = new UI.UCBackButton();
            this.pnlHeader.SuspendLayout();
            this.grbDatosProyecto.SuspendLayout();
            this.grbListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.ucBackButton2);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(31, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 45);
            this.pnlHeader.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "MÓDULO DE PROYECTOS";
            // 
            // grbDatosProyecto
            // 
            this.grbDatosProyecto.BorderRadius = 15;
            this.grbDatosProyecto.Controls.Add(this.ltbHitos);
            this.grbDatosProyecto.Controls.Add(this.txtHorasCompletadas);
            this.grbDatosProyecto.Controls.Add(this.lblHitos);
            this.grbDatosProyecto.Controls.Add(this.lblHorasCompletadas);
            this.grbDatosProyecto.Controls.Add(this.tvwFasesTareas);
            this.grbDatosProyecto.Controls.Add(this.lblFasesTareas);
            this.grbDatosProyecto.Controls.Add(this.txtHorasEstimadas);
            this.grbDatosProyecto.Controls.Add(this.lblHorasEstimadas);
            this.grbDatosProyecto.Controls.Add(this.txtFicha);
            this.grbDatosProyecto.Controls.Add(this.txtEstado);
            this.grbDatosProyecto.Controls.Add(this.txtHorasRestantes);
            this.grbDatosProyecto.Controls.Add(this.lblHorasRestantes);
            this.grbDatosProyecto.Controls.Add(this.txtDescripcion);
            this.grbDatosProyecto.Controls.Add(this.txtTitulo);
            this.grbDatosProyecto.Controls.Add(this.lblTitulo);
            this.grbDatosProyecto.Controls.Add(this.lblDescripcion);
            this.grbDatosProyecto.Controls.Add(this.lblEstado);
            this.grbDatosProyecto.Controls.Add(this.lblFicha);
            this.grbDatosProyecto.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbDatosProyecto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosProyecto.ForeColor = System.Drawing.Color.White;
            this.grbDatosProyecto.Location = new System.Drawing.Point(378, 95);
            this.grbDatosProyecto.Name = "grbDatosProyecto";
            this.grbDatosProyecto.Size = new System.Drawing.Size(761, 494);
            this.grbDatosProyecto.TabIndex = 34;
            this.grbDatosProyecto.Text = "Datos del proyecto";
            // 
            // ltbHitos
            // 
            this.ltbHitos.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHitos.FormattingEnabled = true;
            this.ltbHitos.HorizontalScrollbar = true;
            this.ltbHitos.ItemHeight = 14;
            this.ltbHitos.Location = new System.Drawing.Point(530, 378);
            this.ltbHitos.Name = "ltbHitos";
            this.ltbHitos.Size = new System.Drawing.Size(215, 88);
            this.ltbHitos.TabIndex = 47;
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
            this.txtHorasCompletadas.Location = new System.Drawing.Point(272, 376);
            this.txtHorasCompletadas.Name = "txtHorasCompletadas";
            this.txtHorasCompletadas.PlaceholderText = "";
            this.txtHorasCompletadas.ReadOnly = true;
            this.txtHorasCompletadas.SelectedText = "";
            this.txtHorasCompletadas.Size = new System.Drawing.Size(92, 36);
            this.txtHorasCompletadas.TabIndex = 30;
            // 
            // lblHitos
            // 
            this.lblHitos.AutoSize = true;
            this.lblHitos.BackColor = System.Drawing.Color.White;
            this.lblHitos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitos.ForeColor = System.Drawing.Color.Black;
            this.lblHitos.Location = new System.Drawing.Point(526, 356);
            this.lblHitos.Name = "lblHitos";
            this.lblHitos.Size = new System.Drawing.Size(46, 19);
            this.lblHitos.TabIndex = 46;
            this.lblHitos.Text = "Hitos";
            // 
            // lblHorasCompletadas
            // 
            this.lblHorasCompletadas.AutoSize = true;
            this.lblHorasCompletadas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasCompletadas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasCompletadas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasCompletadas.Location = new System.Drawing.Point(30, 378);
            this.lblHorasCompletadas.Name = "lblHorasCompletadas";
            this.lblHorasCompletadas.Size = new System.Drawing.Size(173, 23);
            this.lblHorasCompletadas.TabIndex = 29;
            this.lblHorasCompletadas.Text = "Horas completadas";
            // 
            // tvwFasesTareas
            // 
            this.tvwFasesTareas.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwFasesTareas.Location = new System.Drawing.Point(530, 72);
            this.tvwFasesTareas.Name = "tvwFasesTareas";
            this.tvwFasesTareas.Size = new System.Drawing.Size(215, 261);
            this.tvwFasesTareas.TabIndex = 45;
            // 
            // lblFasesTareas
            // 
            this.lblFasesTareas.AutoSize = true;
            this.lblFasesTareas.BackColor = System.Drawing.Color.White;
            this.lblFasesTareas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFasesTareas.ForeColor = System.Drawing.Color.Black;
            this.lblFasesTareas.Location = new System.Drawing.Point(526, 49);
            this.lblFasesTareas.Name = "lblFasesTareas";
            this.lblFasesTareas.Size = new System.Drawing.Size(115, 19);
            this.lblFasesTareas.TabIndex = 44;
            this.lblFasesTareas.Text = "Fases y tareas";
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
            this.txtHorasEstimadas.Location = new System.Drawing.Point(272, 265);
            this.txtHorasEstimadas.Name = "txtHorasEstimadas";
            this.txtHorasEstimadas.PlaceholderText = "";
            this.txtHorasEstimadas.ReadOnly = true;
            this.txtHorasEstimadas.SelectedText = "";
            this.txtHorasEstimadas.Size = new System.Drawing.Size(92, 36);
            this.txtHorasEstimadas.TabIndex = 28;
            // 
            // lblHorasEstimadas
            // 
            this.lblHorasEstimadas.AutoSize = true;
            this.lblHorasEstimadas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasEstimadas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasEstimadas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasEstimadas.Location = new System.Drawing.Point(30, 278);
            this.lblHorasEstimadas.Name = "lblHorasEstimadas";
            this.lblHorasEstimadas.Size = new System.Drawing.Size(153, 23);
            this.lblHorasEstimadas.TabIndex = 27;
            this.lblHorasEstimadas.Text = "Horas estimadas";
            // 
            // txtFicha
            // 
            this.txtFicha.AutoRoundedCorners = true;
            this.txtFicha.BackColor = System.Drawing.Color.Transparent;
            this.txtFicha.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFicha.BorderRadius = 17;
            this.txtFicha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFicha.DefaultText = "";
            this.txtFicha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFicha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFicha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFicha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFicha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFicha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFicha.ForeColor = System.Drawing.Color.Black;
            this.txtFicha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFicha.Location = new System.Drawing.Point(272, 217);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.PlaceholderText = "";
            this.txtFicha.ReadOnly = true;
            this.txtFicha.SelectedText = "";
            this.txtFicha.Size = new System.Drawing.Size(233, 36);
            this.txtFicha.TabIndex = 26;
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
            this.txtHorasRestantes.Location = new System.Drawing.Point(272, 323);
            this.txtHorasRestantes.Name = "txtHorasRestantes";
            this.txtHorasRestantes.PlaceholderText = "";
            this.txtHorasRestantes.ReadOnly = true;
            this.txtHorasRestantes.SelectedText = "";
            this.txtHorasRestantes.Size = new System.Drawing.Size(92, 36);
            this.txtHorasRestantes.TabIndex = 24;
            // 
            // lblHorasRestantes
            // 
            this.lblHorasRestantes.AutoSize = true;
            this.lblHorasRestantes.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasRestantes.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasRestantes.ForeColor = System.Drawing.Color.Black;
            this.lblHorasRestantes.Location = new System.Drawing.Point(30, 326);
            this.lblHorasRestantes.Name = "lblHorasRestantes";
            this.lblHorasRestantes.Size = new System.Drawing.Size(147, 23);
            this.lblHorasRestantes.TabIndex = 23;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(30, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
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
            this.lblEstado.Location = new System.Drawing.Point(30, 438);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.BackColor = System.Drawing.Color.Transparent;
            this.lblFicha.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicha.ForeColor = System.Drawing.Color.Black;
            this.lblFicha.Location = new System.Drawing.Point(30, 217);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(158, 23);
            this.lblFicha.TabIndex = 5;
            this.lblFicha.Text = "Ficha de proyecto";
            // 
            // grbListaProyectos
            // 
            this.grbListaProyectos.BorderRadius = 15;
            this.grbListaProyectos.Controls.Add(this.dgvListaProyectos);
            this.grbListaProyectos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.grbListaProyectos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProyectos.ForeColor = System.Drawing.Color.White;
            this.grbListaProyectos.Location = new System.Drawing.Point(38, 95);
            this.grbListaProyectos.Name = "grbListaProyectos";
            this.grbListaProyectos.Size = new System.Drawing.Size(321, 573);
            this.grbListaProyectos.TabIndex = 35;
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
            this.dgvListaProyectos.Location = new System.Drawing.Point(13, 56);
            this.dgvListaProyectos.MultiSelect = false;
            this.dgvListaProyectos.Name = "dgvListaProyectos";
            this.dgvListaProyectos.ReadOnly = true;
            this.dgvListaProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProyectos.RowHeadersVisible = false;
            this.dgvListaProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProyectos.Size = new System.Drawing.Size(293, 495);
            this.dgvListaProyectos.TabIndex = 37;
            this.dgvListaProyectos.SelectionChanged += new System.EventHandler(this.dgvListaProyectos_SelectionChanged);
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
            this.btnEliminar.Location = new System.Drawing.Point(870, 614);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 54);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar proyecto";
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
            this.btnModificar.Location = new System.Drawing.Point(682, 614);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 54);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar proyecto";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(496, 614);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 54);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar proyecto";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // ucBackButton2
            // 
            this.ucBackButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton2.Location = new System.Drawing.Point(9, 10);
            this.ucBackButton2.Name = "ucBackButton2";
            this.ucBackButton2.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton2.TabIndex = 2;
            // 
            // frmModuloProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbListaProyectos);
            this.Controls.Add(this.grbDatosProyecto);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModuloProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModuloProyectos_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbDatosProyecto.ResumeLayout(false);
            this.grbDatosProyecto.PerformLayout();
            this.grbListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private UCBackButton ucBackButton2;
        private Guna.UI2.WinForms.Guna2GroupBox grbDatosProyecto;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasCompletadas;
        private System.Windows.Forms.Label lblHorasCompletadas;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasEstimadas;
        private System.Windows.Forms.Label lblHorasEstimadas;
        private Guna.UI2.WinForms.Guna2TextBox txtFicha;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasRestantes;
        private System.Windows.Forms.Label lblHorasRestantes;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.ListBox ltbHitos;
        private System.Windows.Forms.Label lblHitos;
        private System.Windows.Forms.TreeView tvwFasesTareas;
        private System.Windows.Forms.Label lblFasesTareas;
        private Guna.UI2.WinForms.Guna2GroupBox grbListaProyectos;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvListaProyectos;
    }
}