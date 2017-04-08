namespace sisConcurso.Vista
{
    partial class frmMainUsuario
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pkUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(544, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(185, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(95, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 35);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(558, 26);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // grDatos
            // 
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkUsuario,
            this.cNombreCom,
            this.sEmail,
            this.fkRol});
            this.grDatos.Location = new System.Drawing.Point(12, 40);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(607, 259);
            this.grDatos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(544, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Status";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pkUsuario
            // 
            this.pkUsuario.DataPropertyName = "pkUsuario";
            this.pkUsuario.HeaderText = "Id";
            this.pkUsuario.Name = "pkUsuario";
            this.pkUsuario.ReadOnly = true;
            // 
            // cNombreCom
            // 
            this.cNombreCom.DataPropertyName = "cNombreCom";
            this.cNombreCom.HeaderText = "Nombre ";
            this.cNombreCom.Name = "cNombreCom";
            this.cNombreCom.Width = 200;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 150;
            // 
            // fkRol
            // 
            this.fkRol.DataPropertyName = "fkRol";
            this.fkRol.HeaderText = "Rol";
            this.fkRol.Name = "fkRol";
            // 
            // frmMainUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 392);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainUsuario";
            this.Text = "Menu Usuario";
            this.Load += new System.EventHandler(this.frmMainUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkRol;
    }
}