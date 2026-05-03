namespace Trabajo_final.Cartas
{
    partial class Carta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBheroe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBheroe)).BeginInit();
            this.SuspendLayout();
            // 
            // PBheroe
            // 
            this.PBheroe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBheroe.Location = new System.Drawing.Point(0, 0);
            this.PBheroe.Name = "PBheroe";
            this.PBheroe.Size = new System.Drawing.Size(344, 478);
            this.PBheroe.TabIndex = 0;
            this.PBheroe.TabStop = false;
            this.PBheroe.Click += new System.EventHandler(this.PBheroe_Click);
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PBheroe);
            this.Name = "Carta";
            this.Size = new System.Drawing.Size(344, 478);
            ((System.ComponentModel.ISupportInitialize)(this.PBheroe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBheroe;
    }
}
