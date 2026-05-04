namespace FPETDesktopApp.Recursos.Vistas
{
    partial class FormRegistro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboRol = new System.Windows.Forms.ComboBox();
            this.TXTcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CKterminos = new System.Windows.Forms.CheckBox();
            this.BTNregistroNuevo = new System.Windows.Forms.Button();
            this.CKmostrar = new System.Windows.Forms.CheckBox();
            this.BTNinicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ComboRol);
            this.panel1.Controls.Add(this.TXTcontraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXTcorreo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CKterminos);
            this.panel1.Controls.Add(this.BTNregistroNuevo);
            this.panel1.Controls.Add(this.CKmostrar);
            this.panel1.Controls.Add(this.BTNinicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTusuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 610);
            this.panel1.TabIndex = 1;
            // 
            // ComboRol
            // 
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Items.AddRange(new object[] {
            "Jugador",
            "Administrador"});
            this.ComboRol.Location = new System.Drawing.Point(32, 401);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(121, 28);
            this.ComboRol.TabIndex = 15;
            // 
            // TXTcontraseña
            // 
            this.TXTcontraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTcontraseña.Location = new System.Drawing.Point(32, 299);
            this.TXTcontraseña.Name = "TXTcontraseña";
            this.TXTcontraseña.Size = new System.Drawing.Size(286, 28);
            this.TXTcontraseña.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(27, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña";
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTcorreo.Location = new System.Drawing.Point(32, 219);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(286, 28);
            this.TXTcorreo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo";
            // 
            // CKterminos
            // 
            this.CKterminos.AutoSize = true;
            this.CKterminos.Location = new System.Drawing.Point(32, 438);
            this.CKterminos.Name = "CKterminos";
            this.CKterminos.Size = new System.Drawing.Size(255, 24);
            this.CKterminos.TabIndex = 10;
            this.CKterminos.Text = "Aceptar terminos y condiciones";
            this.CKterminos.UseVisualStyleBackColor = true;
            this.CKterminos.CheckedChanged += new System.EventHandler(this.CKterminos_CheckedChanged);
            // 
            // BTNregistroNuevo
            // 
            this.BTNregistroNuevo.Location = new System.Drawing.Point(168, 468);
            this.BTNregistroNuevo.Name = "BTNregistroNuevo";
            this.BTNregistroNuevo.Size = new System.Drawing.Size(109, 48);
            this.BTNregistroNuevo.TabIndex = 9;
            this.BTNregistroNuevo.Text = "Registro";
            this.BTNregistroNuevo.UseVisualStyleBackColor = true;
            this.BTNregistroNuevo.Click += new System.EventHandler(this.BTNregistroNuevo_Click);
            // 
            // CKmostrar
            // 
            this.CKmostrar.AutoSize = true;
            this.CKmostrar.Location = new System.Drawing.Point(32, 333);
            this.CKmostrar.Name = "CKmostrar";
            this.CKmostrar.Size = new System.Drawing.Size(89, 24);
            this.CKmostrar.TabIndex = 8;
            this.CKmostrar.Text = "Mostrar";
            this.CKmostrar.UseVisualStyleBackColor = true;
            // 
            // BTNinicio
            // 
            this.BTNinicio.Location = new System.Drawing.Point(32, 468);
            this.BTNinicio.Name = "BTNinicio";
            this.BTNinicio.Size = new System.Drawing.Size(109, 48);
            this.BTNinicio.TabIndex = 6;
            this.BTNinicio.Text = "Inicio";
            this.BTNinicio.UseVisualStyleBackColor = true;
            this.BTNinicio.Click += new System.EventHandler(this.BTNinicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(27, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol";
            // 
            // TXTusuario
            // 
            this.TXTusuario.BackColor = System.Drawing.SystemColors.Window;
            this.TXTusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTusuario.Location = new System.Drawing.Point(32, 145);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(286, 28);
            this.TXTusuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 57);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 91);
            this.panel3.TabIndex = 0;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 610);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CKterminos;
        private System.Windows.Forms.Button BTNregistroNuevo;
        private System.Windows.Forms.CheckBox CKmostrar;
        private System.Windows.Forms.Button BTNinicio;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTusuario;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panel3;
        private System.Windows.Forms.TextBox TXTcontraseña;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTcorreo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox ComboRol;
    }
}