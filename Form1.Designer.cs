namespace FPETDesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CKrecordar = new System.Windows.Forms.CheckBox();
            this.BTNregistro = new System.Windows.Forms.Button();
            this.CKmostrar = new System.Windows.Forms.CheckBox();
            this.BTNinicio = new System.Windows.Forms.Button();
            this.TXTcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.CKrecordar);
            this.panel1.Controls.Add(this.BTNregistro);
            this.panel1.Controls.Add(this.CKmostrar);
            this.panel1.Controls.Add(this.BTNinicio);
            this.panel1.Controls.Add(this.TXTcontraseña);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTcorreo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 528);
            this.panel1.TabIndex = 0;
            // 
            // CKrecordar
            // 
            this.CKrecordar.AutoSize = true;
            this.CKrecordar.Location = new System.Drawing.Point(32, 346);
            this.CKrecordar.Name = "CKrecordar";
            this.CKrecordar.Size = new System.Drawing.Size(140, 24);
            this.CKrecordar.TabIndex = 10;
            this.CKrecordar.Text = "Recordar inicio";
            this.CKrecordar.UseVisualStyleBackColor = true;
            // 
            // BTNregistro
            // 
            this.BTNregistro.Location = new System.Drawing.Point(36, 375);
            this.BTNregistro.Name = "BTNregistro";
            this.BTNregistro.Size = new System.Drawing.Size(109, 61);
            this.BTNregistro.TabIndex = 9;
            this.BTNregistro.Text = "Registro";
            this.BTNregistro.UseVisualStyleBackColor = true;
            this.BTNregistro.Click += new System.EventHandler(this.BTNregistro_Click);
            // 
            // CKmostrar
            // 
            this.CKmostrar.AutoSize = true;
            this.CKmostrar.Location = new System.Drawing.Point(32, 316);
            this.CKmostrar.Name = "CKmostrar";
            this.CKmostrar.Size = new System.Drawing.Size(89, 24);
            this.CKmostrar.TabIndex = 8;
            this.CKmostrar.Text = "Mostrar";
            this.CKmostrar.UseVisualStyleBackColor = true;
            this.CKmostrar.CheckedChanged += new System.EventHandler(this.CKmostrar_CheckedChanged);
            // 
            // BTNinicio
            // 
            this.BTNinicio.Location = new System.Drawing.Point(185, 375);
            this.BTNinicio.Name = "BTNinicio";
            this.BTNinicio.Size = new System.Drawing.Size(123, 61);
            this.BTNinicio.TabIndex = 6;
            this.BTNinicio.Text = "Inicio";
            this.BTNinicio.UseVisualStyleBackColor = true;
            this.BTNinicio.Click += new System.EventHandler(this.BTNinicio_Click);
            // 
            // TXTcontraseña
            // 
            this.TXTcontraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTcontraseña.Location = new System.Drawing.Point(32, 272);
            this.TXTcontraseña.Name = "TXTcontraseña";
            this.TXTcontraseña.Size = new System.Drawing.Size(286, 28);
            this.TXTcontraseña.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(27, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTcorreo.Location = new System.Drawing.Point(32, 162);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(286, 28);
            this.TXTcorreo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 76);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTcorreo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TXTcontraseña;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNinicio;
        private System.Windows.Forms.CheckBox CKmostrar;
        private System.Windows.Forms.CheckBox CKrecordar;
        private System.Windows.Forms.Button BTNregistro;
    }
}

