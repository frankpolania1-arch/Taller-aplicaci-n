using System.Threading.Tasks;

namespace FPETDesktopApp.Recursos.Vistas.Administrador
{
    partial class VistaAdministrador
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridPermisos = new System.Windows.Forms.DataGridView();
            this.PermisoUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PermisoAdministrador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PermisoCarta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboTablaBD = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridBD = new System.Windows.Forms.DataGridView();
            this.TABadministrador = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PanelCartasAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBLcargaCartas = new System.Windows.Forms.Label();
            this.PBcargaCartas = new System.Windows.Forms.ProgressBar();
            this.BTNsiguiente = new System.Windows.Forms.Button();
            this.BTNanterior = new System.Windows.Forms.Button();
            this.LBLnombreCarta = new System.Windows.Forms.Label();
            this.LBLvida = new System.Windows.Forms.Label();
            this.LBLataque = new System.Windows.Forms.Label();
            this.LBLcoste = new System.Windows.Forms.Label();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermisos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBD)).BeginInit();
            this.TABadministrador.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridPermisos);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1382, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Permisos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridPermisos
            // 
            this.GridPermisos.AllowUserToAddRows = false;
            this.GridPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.GridPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermisoUsuario,
            this.PermisoAdministrador,
            this.PermisoCarta});
            this.GridPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPermisos.Location = new System.Drawing.Point(3, 99);
            this.GridPermisos.Name = "GridPermisos";
            this.GridPermisos.RowHeadersWidth = 62;
            this.GridPermisos.RowTemplate.Height = 28;
            this.GridPermisos.Size = new System.Drawing.Size(1376, 596);
            this.GridPermisos.TabIndex = 13;
            // 
            // PermisoUsuario
            // 
            this.PermisoUsuario.HeaderText = "Usuario";
            this.PermisoUsuario.MinimumWidth = 8;
            this.PermisoUsuario.Name = "PermisoUsuario";
            this.PermisoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PermisoUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PermisoUsuario.Width = 150;
            // 
            // PermisoAdministrador
            // 
            this.PermisoAdministrador.HeaderText = "Administrador";
            this.PermisoAdministrador.MinimumWidth = 8;
            this.PermisoAdministrador.Name = "PermisoAdministrador";
            this.PermisoAdministrador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PermisoAdministrador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PermisoAdministrador.Width = 150;
            // 
            // PermisoCarta
            // 
            this.PermisoCarta.HeaderText = "Carta";
            this.PermisoCarta.MinimumWidth = 8;
            this.PermisoCarta.Name = "PermisoCarta";
            this.PermisoCarta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PermisoCarta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PermisoCarta.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 96);
            this.panel1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.GridBD);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1382, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bases de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.ComboTablaBD);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 696);
            this.panel2.TabIndex = 2;
            // 
            // ComboTablaBD
            // 
            this.ComboTablaBD.FormattingEnabled = true;
            this.ComboTablaBD.Items.AddRange(new object[] {
            "Usuarios",
            "Administradores",
            "Jugador",
            "Cartas",
            "Cartas_jugador",
            "Partidas"});
            this.ComboTablaBD.Location = new System.Drawing.Point(32, 40);
            this.ComboTablaBD.Name = "ComboTablaBD";
            this.ComboTablaBD.Size = new System.Drawing.Size(220, 28);
            this.ComboTablaBD.TabIndex = 9;
            this.ComboTablaBD.SelectedIndexChanged += new System.EventHandler(this.ComboTablaBD_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 26);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una tabla:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(78, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GridBD
            // 
            this.GridBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBD.Location = new System.Drawing.Point(306, 10);
            this.GridBD.Name = "GridBD";
            this.GridBD.RowHeadersWidth = 62;
            this.GridBD.RowTemplate.Height = 28;
            this.GridBD.Size = new System.Drawing.Size(1044, 692);
            this.GridBD.TabIndex = 1;
            // 
            // TABadministrador
            // 
            this.TABadministrador.Controls.Add(this.tabPage1);
            this.TABadministrador.Controls.Add(this.tabPage2);
            this.TABadministrador.Controls.Add(this.tabPage3);
            this.TABadministrador.Location = new System.Drawing.Point(0, 0);
            this.TABadministrador.Name = "TABadministrador";
            this.TABadministrador.SelectedIndex = 0;
            this.TABadministrador.Size = new System.Drawing.Size(1390, 731);
            this.TABadministrador.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PanelCartasAdmin);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1382, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contenido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PanelCartasAdmin
            // 
            this.PanelCartasAdmin.AutoScroll = true;
            this.PanelCartasAdmin.Location = new System.Drawing.Point(8, 145);
            this.PanelCartasAdmin.Name = "PanelCartasAdmin";
            this.PanelCartasAdmin.Size = new System.Drawing.Size(1213, 491);
            this.PanelCartasAdmin.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTNagregar);
            this.panel3.Controls.Add(this.LBLcoste);
            this.panel3.Controls.Add(this.LBLataque);
            this.panel3.Controls.Add(this.LBLvida);
            this.panel3.Controls.Add(this.LBLnombreCarta);
            this.panel3.Controls.Add(this.LBLcargaCartas);
            this.panel3.Controls.Add(this.PBcargaCartas);
            this.panel3.Controls.Add(this.BTNsiguiente);
            this.panel3.Controls.Add(this.BTNanterior);
            this.panel3.Location = new System.Drawing.Point(8, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1213, 136);
            this.panel3.TabIndex = 0;
            // 
            // LBLcargaCartas
            // 
            this.LBLcargaCartas.AutoSize = true;
            this.LBLcargaCartas.Location = new System.Drawing.Point(15, 70);
            this.LBLcargaCartas.Name = "LBLcargaCartas";
            this.LBLcargaCartas.Size = new System.Drawing.Size(51, 20);
            this.LBLcargaCartas.TabIndex = 7;
            this.LBLcargaCartas.Text = "label5";
            // 
            // PBcargaCartas
            // 
            this.PBcargaCartas.Location = new System.Drawing.Point(19, 93);
            this.PBcargaCartas.Name = "PBcargaCartas";
            this.PBcargaCartas.Size = new System.Drawing.Size(188, 30);
            this.PBcargaCartas.TabIndex = 6;
            // 
            // BTNsiguiente
            // 
            this.BTNsiguiente.Location = new System.Drawing.Point(139, 10);
            this.BTNsiguiente.Name = "BTNsiguiente";
            this.BTNsiguiente.Size = new System.Drawing.Size(138, 42);
            this.BTNsiguiente.TabIndex = 4;
            this.BTNsiguiente.Text = "Siguiente";
            this.BTNsiguiente.UseVisualStyleBackColor = true;
            this.BTNsiguiente.Click += new System.EventHandler(this.BTNsiguiente_Click);
            // 
            // BTNanterior
            // 
            this.BTNanterior.Location = new System.Drawing.Point(9, 10);
            this.BTNanterior.Name = "BTNanterior";
            this.BTNanterior.Size = new System.Drawing.Size(114, 42);
            this.BTNanterior.TabIndex = 5;
            this.BTNanterior.Text = "Anterior";
            this.BTNanterior.UseVisualStyleBackColor = true;
            this.BTNanterior.Click += new System.EventHandler(this.BTNanterior_Click);
            // 
            // LBLnombreCarta
            // 
            this.LBLnombreCarta.AutoSize = true;
            this.LBLnombreCarta.Location = new System.Drawing.Point(330, 10);
            this.LBLnombreCarta.Name = "LBLnombreCarta";
            this.LBLnombreCarta.Size = new System.Drawing.Size(51, 20);
            this.LBLnombreCarta.TabIndex = 8;
            this.LBLnombreCarta.Text = "label4";
            // 
            // LBLvida
            // 
            this.LBLvida.AutoSize = true;
            this.LBLvida.Location = new System.Drawing.Point(330, 39);
            this.LBLvida.Name = "LBLvida";
            this.LBLvida.Size = new System.Drawing.Size(51, 20);
            this.LBLvida.TabIndex = 9;
            this.LBLvida.Text = "label4";
            // 
            // LBLataque
            // 
            this.LBLataque.AutoSize = true;
            this.LBLataque.Location = new System.Drawing.Point(330, 70);
            this.LBLataque.Name = "LBLataque";
            this.LBLataque.Size = new System.Drawing.Size(51, 20);
            this.LBLataque.TabIndex = 10;
            this.LBLataque.Text = "label4";
            // 
            // LBLcoste
            // 
            this.LBLcoste.AutoSize = true;
            this.LBLcoste.Location = new System.Drawing.Point(330, 101);
            this.LBLcoste.Name = "LBLcoste";
            this.LBLcoste.Size = new System.Drawing.Size(51, 20);
            this.LBLcoste.TabIndex = 11;
            this.LBLcoste.Text = "label4";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(1065, 10);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(123, 52);
            this.BTNagregar.TabIndex = 12;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 731);
            this.Controls.Add(this.TABadministrador);
            this.MinimizeBox = false;
            this.Name = "VistaAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.VistaAdministrador_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPermisos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBD)).EndInit();
            this.TABadministrador.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl TABadministrador;
        private System.Windows.Forms.DataGridView GridPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PermisoUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PermisoAdministrador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PermisoCarta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNanterior;
        private System.Windows.Forms.Button BTNsiguiente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PanelCartasAdmin;
        private System.Windows.Forms.ProgressBar PBcargaCartas;
        public System.Windows.Forms.DataGridView GridBD;
        public System.Windows.Forms.ComboBox ComboTablaBD;
        public System.Windows.Forms.Label LBLcargaCartas;
        private System.Windows.Forms.Button BTNagregar;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label LBLcoste;
        public System.Windows.Forms.Label LBLataque;
        public System.Windows.Forms.Label LBLvida;
        public System.Windows.Forms.Label LBLnombreCarta;
    }
}