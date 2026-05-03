namespace FPETDesktopApp.Recursos.Vistas
{
    partial class AutentificacionRegistro
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
            this.CKterminos = new System.Windows.Forms.CheckBox();
            this.BTNautentificar = new System.Windows.Forms.Button();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CKmostrar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.CKterminos);
            this.panel1.Controls.Add(this.BTNautentificar);
            this.panel1.Controls.Add(this.CKmostrar);
            this.panel1.Controls.Add(this.TXTcodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 528);
            this.panel1.TabIndex = 2;
            // 
            // CKterminos
            // 
            this.CKterminos.AutoSize = true;
            this.CKterminos.Location = new System.Drawing.Point(0, 402);
            this.CKterminos.Name = "CKterminos";
            this.CKterminos.Size = new System.Drawing.Size(255, 24);
            this.CKterminos.TabIndex = 10;
            this.CKterminos.Text = "Aceptar terminos y condiciones";
            this.CKterminos.UseVisualStyleBackColor = true;
            // 
            // BTNautentificar
            // 
            this.BTNautentificar.Location = new System.Drawing.Point(327, 218);
            this.BTNautentificar.Name = "BTNautentificar";
            this.BTNautentificar.Size = new System.Drawing.Size(123, 67);
            this.BTNautentificar.TabIndex = 6;
            this.BTNautentificar.Text = "Inicio";
            this.BTNautentificar.UseVisualStyleBackColor = true;
            this.BTNautentificar.Click += new System.EventHandler(this.BTNautentificar_Click);
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.TXTcodigo.Location = new System.Drawing.Point(263, 170);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.Size = new System.Drawing.Size(286, 28);
            this.TXTcodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(341, 121);
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
            this.panel2.Size = new System.Drawing.Size(800, 76);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CKmostrar
            // 
            this.CKmostrar.AutoSize = true;
            this.CKmostrar.Location = new System.Drawing.Point(0, 372);
            this.CKmostrar.Name = "CKmostrar";
            this.CKmostrar.Size = new System.Drawing.Size(89, 24);
            this.CKmostrar.TabIndex = 8;
            this.CKmostrar.Text = "Mostrar";
            this.CKmostrar.UseVisualStyleBackColor = true;
            // 
            // AutentificacionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.panel1);
            this.Name = "AutentificacionRegistro";
            this.Text = "AutentificacionRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CKterminos;
        private System.Windows.Forms.Button BTNautentificar;
        private System.Windows.Forms.TextBox TXTcodigo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CKmostrar;
    }
}