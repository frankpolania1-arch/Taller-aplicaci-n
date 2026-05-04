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
            this.BTNjuego = new System.Windows.Forms.Button();
            this.BTNcartas = new System.Windows.Forms.Button();
            this.BTNmazo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.BTNguardar);
            this.panel1.Controls.Add(this.button2);
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
            // BTNjuego
            // 
            this.BTNjuego.Location = new System.Drawing.Point(29, 139);
            this.BTNjuego.Name = "BTNjuego";
            this.BTNjuego.Size = new System.Drawing.Size(156, 47);
            this.BTNjuego.TabIndex = 2;
            this.BTNjuego.Text = "Conbate";
            this.BTNjuego.UseVisualStyleBackColor = true;
            this.BTNjuego.Click += new System.EventHandler(this.BTNjuego_Click);
            // 
            // BTNcartas
            // 
            this.BTNcartas.Location = new System.Drawing.Point(29, 245);
            this.BTNcartas.Name = "BTNcartas";
            this.BTNcartas.Size = new System.Drawing.Size(151, 47);
            this.BTNcartas.TabIndex = 1;
            this.BTNcartas.Text = "Cartas";
            this.BTNcartas.UseVisualStyleBackColor = true;
            // 
            // BTNmazo
            // 
            this.BTNmazo.Location = new System.Drawing.Point(29, 192);
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
            // BTNborrar
            // 
            this.BTNborrar.Location = new System.Drawing.Point(24, 443);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(156, 47);
            this.BTNborrar.TabIndex = 3;
            this.BTNborrar.Text = "Borrar";
            this.BTNborrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cartas de Combate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(24, 390);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(156, 47);
            this.BTNguardar.TabIndex = 5;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNborrar;
    }
}