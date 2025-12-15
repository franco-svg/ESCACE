namespace UI
{
    partial class frmModuloRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucBackButton1 = new UI.UCBackButton();
            this.grbListaRoles = new System.Windows.Forms.GroupBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.grbDatosRol = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificarColaborador = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grbListaRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.grbDatosRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "abm roles";
            // 
            // ucBackButton1
            // 
            this.ucBackButton1.BackColor = System.Drawing.Color.RosyBrown;
            this.ucBackButton1.Location = new System.Drawing.Point(12, 12);
            this.ucBackButton1.Name = "ucBackButton1";
            this.ucBackButton1.Size = new System.Drawing.Size(33, 27);
            this.ucBackButton1.TabIndex = 3;
            // 
            // grbListaRoles
            // 
            this.grbListaRoles.AutoSize = true;
            this.grbListaRoles.BackColor = System.Drawing.Color.Transparent;
            this.grbListaRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbListaRoles.Controls.Add(this.dgvRoles);
            this.grbListaRoles.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaRoles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbListaRoles.Location = new System.Drawing.Point(147, 150);
            this.grbListaRoles.Name = "grbListaRoles";
            this.grbListaRoles.Padding = new System.Windows.Forms.Padding(0);
            this.grbListaRoles.Size = new System.Drawing.Size(272, 378);
            this.grbListaRoles.TabIndex = 12;
            this.grbListaRoles.TabStop = false;
            this.grbListaRoles.Text = "Lista de roles";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(22, 39);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(225, 310);
            this.dgvRoles.TabIndex = 5;
            // 
            // grbDatosRol
            // 
            this.grbDatosRol.AutoSize = true;
            this.grbDatosRol.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbDatosRol.Controls.Add(this.btnLimpiar);
            this.grbDatosRol.Controls.Add(this.comboBox1);
            this.grbDatosRol.Controls.Add(this.txtNombre);
            this.grbDatosRol.Controls.Add(this.lblNombre);
            this.grbDatosRol.Controls.Add(this.lblCategoría);
            this.grbDatosRol.Controls.Add(this.lblDescripcion);
            this.grbDatosRol.Controls.Add(this.txtDescripcion);
            this.grbDatosRol.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbDatosRol.Location = new System.Drawing.Point(595, 155);
            this.grbDatosRol.Name = "grbDatosRol";
            this.grbDatosRol.Padding = new System.Windows.Forms.Padding(10);
            this.grbDatosRol.Size = new System.Drawing.Size(458, 365);
            this.grbDatosRol.TabIndex = 13;
            this.grbDatosRol.TabStop = false;
            this.grbDatosRol.Text = "Datos del rol";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 33);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.Location = new System.Drawing.Point(42, 264);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(91, 23);
            this.lblCategoría.TabIndex = 5;
            this.lblCategoría.Text = "Categoría";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(42, 87);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 23);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(182, 87);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(213, 166);
            this.txtDescripcion.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(915, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Eliminar rol";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(610, 557);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 32);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar rol";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnModificarColaborador
            // 
            this.btnModificarColaborador.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarColaborador.Location = new System.Drawing.Point(763, 557);
            this.btnModificarColaborador.Name = "btnModificarColaborador";
            this.btnModificarColaborador.Size = new System.Drawing.Size(127, 32);
            this.btnModificarColaborador.TabIndex = 16;
            this.btnModificarColaborador.Text = "Modificar rol";
            this.btnModificarColaborador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarColaborador.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(182, 303);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(54, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmModuloRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificarColaborador);
            this.Controls.Add(this.grbDatosRol);
            this.Controls.Add(this.grbListaRoles);
            this.Controls.Add(this.ucBackButton1);
            this.Controls.Add(this.label1);
            this.Name = "frmModuloRoles";
            this.grbListaRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.grbDatosRol.ResumeLayout(false);
            this.grbDatosRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UCBackButton ucBackButton1;
        private System.Windows.Forms.GroupBox grbListaRoles;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.GroupBox grbDatosRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificarColaborador;
        private System.Windows.Forms.Button btnLimpiar;
    }
}