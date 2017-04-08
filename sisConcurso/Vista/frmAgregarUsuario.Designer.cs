namespace sisConcurso.Vista
{
    partial class frmAgregarUsuario
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sisConcurso.Properties.Resources.MUO_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(555, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Correo";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(83, 119);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(364, 26);
            this.txtCuenta.TabIndex = 25;
            this.txtCuenta.Leave += new System.EventHandler(this.txtCuenta_Leave);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(152, 151);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(323, 26);
            this.txtContra.TabIndex = 27;
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Repita Contrasena";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(585, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 33);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(152, 184);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.PasswordChar = '*';
            this.txtContra2.Size = new System.Drawing.Size(323, 26);
            this.txtContra2.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 26);
            this.textBox2.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 35;
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAgregarUsuario";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.frmAgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}