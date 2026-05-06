namespace FPETDesktopApp.Recursos.Vistas.Jugador
{
    partial class FormMenu
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
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNguarda = new System.Windows.Forms.Button();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.BTNborra = new System.Windows.Forms.Button();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.BTNjuego = new System.Windows.Forms.Button();
            this.BTNcartas = new System.Windows.Forms.Button();
            this.BTNmazo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.BTNsalir);
            this.panel1.Controls.Add(this.BTNguarda);
            this.panel1.Controls.Add(this.BTNguardar);
            this.panel1.Controls.Add(this.BTNborra);
            this.panel1.Controls.Add(this.BTNborrar);
            this.panel1.Controls.Add(this.BTNjuego);
            this.panel1.Controls.Add(this.BTNcartas);
            this.panel1.Controls.Add(this.BTNmazo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 663);
            this.panel1.TabIndex = 0;
            // 
            // BTNsalir
            // 
            this.BTNsalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNsalir.Location = new System.Drawing.Point(35, 541);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(141, 32);
            this.BTNsalir.TabIndex = 16;
            this.BTNsalir.Text = "Cerrar sesión";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNguarda
            // 
            this.BTNguarda.Location = new System.Drawing.Point(35, 312);
            this.BTNguarda.Name = "BTNguarda";
            this.BTNguarda.Size = new System.Drawing.Size(156, 47);
            this.BTNguarda.TabIndex = 5;
            this.BTNguarda.Text = "Guardar";
            this.BTNguarda.UseVisualStyleBackColor = true;
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(30, 312);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(156, 47);
            this.BTNguardar.TabIndex = 5;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
            // 
            // BTNborra
            // 
            this.BTNborra.Location = new System.Drawing.Point(35, 365);
            this.BTNborra.Name = "BTNborra";
            this.BTNborra.Size = new System.Drawing.Size(156, 47);
            this.BTNborra.TabIndex = 3;
            this.BTNborra.Text = "Borrar";
            this.BTNborra.UseVisualStyleBackColor = true;
            // 
            // BTNborrar
            // 
            this.BTNborrar.Location = new System.Drawing.Point(30, 365);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(156, 47);
            this.BTNborrar.TabIndex = 3;
            this.BTNborrar.Text = "Borrar";
            this.BTNborrar.UseVisualStyleBackColor = true;
            // 
            // BTNjuego
            // 
            this.BTNjuego.Location = new System.Drawing.Point(35, 61);
            this.BTNjuego.Name = "BTNjuego";
            this.BTNjuego.Size = new System.Drawing.Size(156, 47);
            this.BTNjuego.TabIndex = 2;
            this.BTNjuego.Text = "Conbate";
            this.BTNjuego.UseVisualStyleBackColor = true;
            this.BTNjuego.Click += new System.EventHandler(this.BTNjuego_Click);
            // 
            // BTNcartas
            // 
            this.BTNcartas.Location = new System.Drawing.Point(35, 167);
            this.BTNcartas.Name = "BTNcartas";
            this.BTNcartas.Size = new System.Drawing.Size(151, 47);
            this.BTNcartas.TabIndex = 1;
            this.BTNcartas.Text = "Cartas";
            this.BTNcartas.UseVisualStyleBackColor = true;
            // 
            // BTNmazo
            // 
            this.BTNmazo.Location = new System.Drawing.Point(35, 114);
            this.BTNmazo.Name = "BTNmazo";
            this.BTNmazo.Size = new System.Drawing.Size(156, 47);
            this.BTNmazo.TabIndex = 0;
            this.BTNmazo.Text = "Cartas de Combate";
            this.BTNmazo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 639);
            this.panel2.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNcartas;
        private System.Windows.Forms.Button BTNmazo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNjuego;
        private System.Windows.Forms.Button BTNguardar;
        private System.Windows.Forms.Button BTNborrar;
        public System.Windows.Forms.Button BTNguarda;
        public System.Windows.Forms.Button BTNborra;
        private System.Windows.Forms.Button BTNsalir;
    }
}