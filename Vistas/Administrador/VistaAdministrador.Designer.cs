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
            this.Usuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNauxiliar = new System.Windows.Forms.Button();
            this.ComboRol = new System.Windows.Forms.ComboBox();
            this.LBLrol = new System.Windows.Forms.Label();
            this.TXTcontraseña = new System.Windows.Forms.TextBox();
            this.LBLcontraseña = new System.Windows.Forms.Label();
            this.ComboTablaBD = new System.Windows.Forms.ComboBox();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.LBLcorreo = new System.Windows.Forms.Label();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNaccion = new System.Windows.Forms.Button();
            this.GridBD = new System.Windows.Forms.DataGridView();
            this.TABadministrador = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PanelCartasAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.LBLraro = new System.Windows.Forms.Label();
            this.LBLclase = new System.Windows.Forms.Label();
            this.LBLraza = new System.Windows.Forms.Label();
            this.LBLcoste = new System.Windows.Forms.Label();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.LBLtipo = new System.Windows.Forms.Label();
            this.LBLataque = new System.Windows.Forms.Label();
            this.LBLvida = new System.Windows.Forms.Label();
            this.LBLnombreCarta = new System.Windows.Forms.Label();
            this.LBLcargaCartas = new System.Windows.Forms.Label();
            this.PBcargaCartas = new System.Windows.Forms.ProgressBar();
            this.BTNsiguiente = new System.Windows.Forms.Button();
            this.BTNanterior = new System.Windows.Forms.Button();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1223, 698);
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
            this.Usuario,
            this.Administrador});
            this.GridPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPermisos.Location = new System.Drawing.Point(3, 3);
            this.GridPermisos.Name = "GridPermisos";
            this.GridPermisos.RowHeadersWidth = 62;
            this.GridPermisos.RowTemplate.Height = 28;
            this.GridPermisos.Size = new System.Drawing.Size(1217, 692);
            this.GridPermisos.TabIndex = 13;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Usuario.Width = 150;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.MinimumWidth = 8;
            this.Administrador.Name = "Administrador";
            this.Administrador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Administrador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Administrador.Width = 150;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.GridBD);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1223, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bases de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.BTNsalir);
            this.panel2.Controls.Add(this.BTNauxiliar);
            this.panel2.Controls.Add(this.ComboRol);
            this.panel2.Controls.Add(this.LBLrol);
            this.panel2.Controls.Add(this.TXTcontraseña);
            this.panel2.Controls.Add(this.LBLcontraseña);
            this.panel2.Controls.Add(this.ComboTablaBD);
            this.panel2.Controls.Add(this.TXTcorreo);
            this.panel2.Controls.Add(this.LBLcorreo);
            this.panel2.Controls.Add(this.TXTnombre);
            this.panel2.Controls.Add(this.LBLnombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BTNaccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 692);
            this.panel2.TabIndex = 2;
            // 
            // BTNsalir
            // 
            this.BTNsalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNsalir.Location = new System.Drawing.Point(17, 628);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(141, 32);
            this.BTNsalir.TabIndex = 15;
            this.BTNsalir.Text = "Cerrar sesión";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNauxiliar
            // 
            this.BTNauxiliar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNauxiliar.Location = new System.Drawing.Point(68, 463);
            this.BTNauxiliar.Name = "BTNauxiliar";
            this.BTNauxiliar.Size = new System.Drawing.Size(155, 61);
            this.BTNauxiliar.TabIndex = 14;
            this.BTNauxiliar.Text = "Agregar registro";
            this.BTNauxiliar.UseVisualStyleBackColor = true;
            this.BTNauxiliar.Click += new System.EventHandler(this.BTNauxiliar_Click);
            // 
            // ComboRol
            // 
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Items.AddRange(new object[] {
            "Jugador",
            "Administrador"});
            this.ComboRol.Location = new System.Drawing.Point(32, 321);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(228, 28);
            this.ComboRol.TabIndex = 13;
            // 
            // LBLrol
            // 
            this.LBLrol.AutoSize = true;
            this.LBLrol.BackColor = System.Drawing.Color.Transparent;
            this.LBLrol.ForeColor = System.Drawing.Color.White;
            this.LBLrol.Location = new System.Drawing.Point(28, 298);
            this.LBLrol.Name = "LBLrol";
            this.LBLrol.Size = new System.Drawing.Size(33, 20);
            this.LBLrol.TabIndex = 12;
            this.LBLrol.Text = "Rol";
            // 
            // TXTcontraseña
            // 
            this.TXTcontraseña.Location = new System.Drawing.Point(32, 253);
            this.TXTcontraseña.Name = "TXTcontraseña";
            this.TXTcontraseña.Size = new System.Drawing.Size(228, 26);
            this.TXTcontraseña.TabIndex = 11;
            // 
            // LBLcontraseña
            // 
            this.LBLcontraseña.AutoSize = true;
            this.LBLcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.LBLcontraseña.ForeColor = System.Drawing.Color.White;
            this.LBLcontraseña.Location = new System.Drawing.Point(28, 230);
            this.LBLcontraseña.Name = "LBLcontraseña";
            this.LBLcontraseña.Size = new System.Drawing.Size(92, 20);
            this.LBLcontraseña.TabIndex = 10;
            this.LBLcontraseña.Text = "Contraseña";
            // 
            // ComboTablaBD
            // 
            this.ComboTablaBD.FormattingEnabled = true;
            this.ComboTablaBD.Items.AddRange(new object[] {
            "Usuarios",
            "Administradores",
            "Cartas"});
            this.ComboTablaBD.Location = new System.Drawing.Point(32, 40);
            this.ComboTablaBD.Name = "ComboTablaBD";
            this.ComboTablaBD.Size = new System.Drawing.Size(220, 28);
            this.ComboTablaBD.TabIndex = 9;
            this.ComboTablaBD.SelectedIndexChanged += new System.EventHandler(this.ComboTablaBD_SelectedIndexChanged);
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.Location = new System.Drawing.Point(32, 182);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(228, 26);
            this.TXTcorreo.TabIndex = 8;
            // 
            // LBLcorreo
            // 
            this.LBLcorreo.AutoSize = true;
            this.LBLcorreo.BackColor = System.Drawing.Color.Transparent;
            this.LBLcorreo.ForeColor = System.Drawing.Color.White;
            this.LBLcorreo.Location = new System.Drawing.Point(28, 159);
            this.LBLcorreo.Name = "LBLcorreo";
            this.LBLcorreo.Size = new System.Drawing.Size(57, 20);
            this.LBLcorreo.TabIndex = 7;
            this.LBLcorreo.Text = "Correo";
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(32, 113);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(228, 26);
            this.TXTnombre.TabIndex = 6;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.BackColor = System.Drawing.Color.Transparent;
            this.LBLnombre.ForeColor = System.Drawing.Color.White;
            this.LBLnombre.Location = new System.Drawing.Point(28, 90);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(65, 20);
            this.LBLnombre.TabIndex = 5;
            this.LBLnombre.Text = "Nombre";
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
            // BTNaccion
            // 
            this.BTNaccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNaccion.Location = new System.Drawing.Point(68, 376);
            this.BTNaccion.Name = "BTNaccion";
            this.BTNaccion.Size = new System.Drawing.Size(155, 61);
            this.BTNaccion.TabIndex = 2;
            this.BTNaccion.Text = "Agregar registro";
            this.BTNaccion.UseVisualStyleBackColor = true;
            this.BTNaccion.Click += new System.EventHandler(this.BTNaccion_Click);
            // 
            // GridBD
            // 
            this.GridBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBD.Location = new System.Drawing.Point(314, 6);
            this.GridBD.Name = "GridBD";
            this.GridBD.RowHeadersWidth = 62;
            this.GridBD.RowTemplate.Height = 28;
            this.GridBD.Size = new System.Drawing.Size(885, 662);
            this.GridBD.TabIndex = 1;
            this.GridBD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBD_CellClick);
            // 
            // TABadministrador
            // 
            this.TABadministrador.Controls.Add(this.tabPage1);
            this.TABadministrador.Controls.Add(this.tabPage2);
            this.TABadministrador.Controls.Add(this.tabPage3);
            this.TABadministrador.Location = new System.Drawing.Point(0, 0);
            this.TABadministrador.Name = "TABadministrador";
            this.TABadministrador.SelectedIndex = 0;
            this.TABadministrador.Size = new System.Drawing.Size(1231, 731);
            this.TABadministrador.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Bisque;
            this.tabPage3.Controls.Add(this.PanelCartasAdmin);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1223, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contenido";
            // 
            // PanelCartasAdmin
            // 
            this.PanelCartasAdmin.AutoScroll = true;
            this.PanelCartasAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.PanelCartasAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCartasAdmin.Location = new System.Drawing.Point(8, 145);
            this.PanelCartasAdmin.Name = "PanelCartasAdmin";
            this.PanelCartasAdmin.Size = new System.Drawing.Size(1213, 545);
            this.PanelCartasAdmin.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.BTNborrar);
            this.panel3.Controls.Add(this.LBLraro);
            this.panel3.Controls.Add(this.LBLclase);
            this.panel3.Controls.Add(this.LBLraza);
            this.panel3.Controls.Add(this.LBLcoste);
            this.panel3.Controls.Add(this.BTNagregar);
            this.panel3.Controls.Add(this.LBLtipo);
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
            // BTNborrar
            // 
            this.BTNborrar.Location = new System.Drawing.Point(1069, 70);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(123, 49);
            this.BTNborrar.TabIndex = 17;
            this.BTNborrar.Text = "borrar";
            this.BTNborrar.UseVisualStyleBackColor = true;
            // 
            // LBLraro
            // 
            this.LBLraro.AutoSize = true;
            this.LBLraro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLraro.Location = new System.Drawing.Point(625, 39);
            this.LBLraro.Name = "LBLraro";
            this.LBLraro.Size = new System.Drawing.Size(51, 20);
            this.LBLraro.TabIndex = 16;
            this.LBLraro.Text = "label4";
            // 
            // LBLclase
            // 
            this.LBLclase.AutoSize = true;
            this.LBLclase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLclase.Location = new System.Drawing.Point(503, 70);
            this.LBLclase.Name = "LBLclase";
            this.LBLclase.Size = new System.Drawing.Size(51, 20);
            this.LBLclase.TabIndex = 15;
            this.LBLclase.Text = "label4";
            // 
            // LBLraza
            // 
            this.LBLraza.AutoSize = true;
            this.LBLraza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLraza.Location = new System.Drawing.Point(503, 103);
            this.LBLraza.Name = "LBLraza";
            this.LBLraza.Size = new System.Drawing.Size(51, 20);
            this.LBLraza.TabIndex = 14;
            this.LBLraza.Text = "label4";
            // 
            // LBLcoste
            // 
            this.LBLcoste.AutoSize = true;
            this.LBLcoste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLcoste.Location = new System.Drawing.Point(330, 103);
            this.LBLcoste.Name = "LBLcoste";
            this.LBLcoste.Size = new System.Drawing.Size(51, 20);
            this.LBLcoste.TabIndex = 13;
            this.LBLcoste.Text = "label4";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(1069, 7);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(123, 49);
            this.BTNagregar.TabIndex = 12;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // LBLtipo
            // 
            this.LBLtipo.AutoSize = true;
            this.LBLtipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLtipo.Location = new System.Drawing.Point(503, 39);
            this.LBLtipo.Name = "LBLtipo";
            this.LBLtipo.Size = new System.Drawing.Size(51, 20);
            this.LBLtipo.TabIndex = 11;
            this.LBLtipo.Text = "label4";
            // 
            // LBLataque
            // 
            this.LBLataque.AutoSize = true;
            this.LBLataque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLataque.Location = new System.Drawing.Point(330, 70);
            this.LBLataque.Name = "LBLataque";
            this.LBLataque.Size = new System.Drawing.Size(51, 20);
            this.LBLataque.TabIndex = 10;
            this.LBLataque.Text = "label4";
            // 
            // LBLvida
            // 
            this.LBLvida.AutoSize = true;
            this.LBLvida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLvida.Location = new System.Drawing.Point(330, 39);
            this.LBLvida.Name = "LBLvida";
            this.LBLvida.Size = new System.Drawing.Size(51, 20);
            this.LBLvida.TabIndex = 9;
            this.LBLvida.Text = "label4";
            // 
            // LBLnombreCarta
            // 
            this.LBLnombreCarta.AutoSize = true;
            this.LBLnombreCarta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLnombreCarta.Location = new System.Drawing.Point(330, 10);
            this.LBLnombreCarta.Name = "LBLnombreCarta";
            this.LBLnombreCarta.Size = new System.Drawing.Size(51, 20);
            this.LBLnombreCarta.TabIndex = 8;
            this.LBLnombreCarta.Text = "label4";
            // 
            // LBLcargaCartas
            // 
            this.LBLcargaCartas.AutoSize = true;
            this.LBLcargaCartas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 774);
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
        private System.Windows.Forms.Button BTNaccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLcorreo;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Button BTNanterior;
        private System.Windows.Forms.Button BTNsiguiente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PanelCartasAdmin;
        private System.Windows.Forms.ProgressBar PBcargaCartas;
        public System.Windows.Forms.DataGridView GridBD;
        public System.Windows.Forms.ComboBox ComboTablaBD;
        public System.Windows.Forms.Label LBLcargaCartas;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label LBLtipo;
        public System.Windows.Forms.Label LBLataque;
        public System.Windows.Forms.Label LBLvida;
        public System.Windows.Forms.Label LBLnombreCarta;
        public System.Windows.Forms.Label LBLcoste;
        public System.Windows.Forms.Label LBLclase;
        public System.Windows.Forms.Label LBLraza;
        public System.Windows.Forms.Label LBLraro;
        private System.Windows.Forms.Label LBLrol;
        private System.Windows.Forms.Label LBLcontraseña;
        private System.Windows.Forms.Button BTNauxiliar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Administrador;
        public System.Windows.Forms.DataGridView GridPermisos;
        public System.Windows.Forms.Button BTNborrar;
        public System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.Button BTNsalir;
        public System.Windows.Forms.TextBox TXTcorreo;
        public System.Windows.Forms.TextBox TXTnombre;
        public System.Windows.Forms.ComboBox ComboRol;
        public System.Windows.Forms.TextBox TXTcontraseña;
    }
}