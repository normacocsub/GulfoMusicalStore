namespace GulfoMusicalStoreGUI
{
    partial class FrmTienda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienda));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.labelsede = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PanelIzquierdo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(1032, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 64);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // labelsede
            // 
            this.labelsede.AutoSize = true;
            this.labelsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsede.ForeColor = System.Drawing.Color.White;
            this.labelsede.Location = new System.Drawing.Point(875, 25);
            this.labelsede.Name = "labelsede";
            this.labelsede.Size = new System.Drawing.Size(108, 20);
            this.labelsede.TabIndex = 26;
            this.labelsede.Text = "nombresede";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(808, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sede: ";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContenedor.Location = new System.Drawing.Point(293, 64);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(810, 606);
            this.PanelContenedor.TabIndex = 29;
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelIzquierdo.Controls.Add(this.panel1);
            this.PanelIzquierdo.Controls.Add(this.PanelLogo);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 64);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(293, 600);
            this.PanelIzquierdo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnInventario);
            this.panel1.Controls.Add(this.BtnEstadisticas);
            this.panel1.Controls.Add(this.BtnCursos);
            this.panel1.Controls.Add(this.BtnCurso);
            this.panel1.Controls.Add(this.BtnFacturas);
            this.panel1.Controls.Add(this.BtnVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 404);
            this.panel1.TabIndex = 1;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(0, 335);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(293, 67);
            this.BtnInventario.TabIndex = 10;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click_1);
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.BtnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadisticas.Image")));
            this.BtnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 268);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(293, 67);
            this.BtnEstadisticas.TabIndex = 9;
            this.BtnEstadisticas.Text = "Estadisticas";
            this.BtnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.ForeColor = System.Drawing.Color.White;
            this.BtnCursos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCursos.Image")));
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 201);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(293, 67);
            this.BtnCursos.TabIndex = 16;
            this.BtnCursos.Text = "Clientes";
            this.BtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCursos.UseVisualStyleBackColor = false;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // BtnCurso
            // 
            this.BtnCurso.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCurso.FlatAppearance.BorderSize = 0;
            this.BtnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurso.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurso.ForeColor = System.Drawing.Color.White;
            this.BtnCurso.Image = ((System.Drawing.Image)(resources.GetObject("BtnCurso.Image")));
            this.BtnCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCurso.Location = new System.Drawing.Point(0, 134);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(293, 67);
            this.BtnCurso.TabIndex = 14;
            this.BtnCurso.Text = "Curso";
            this.BtnCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCurso.UseVisualStyleBackColor = false;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.White;
            this.BtnFacturas.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturas.Image")));
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(0, 67);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(293, 67);
            this.BtnFacturas.TabIndex = 8;
            this.BtnFacturas.Text = "Facturas";
            this.BtnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFacturas.UseVisualStyleBackColor = false;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVenta.FlatAppearance.BorderSize = 0;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.ForeColor = System.Drawing.Color.White;
            this.BtnVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnVenta.Image")));
            this.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVenta.Location = new System.Drawing.Point(0, 0);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(293, 67);
            this.BtnVenta.TabIndex = 13;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(293, 196);
            this.PanelLogo.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelTitulo.Location = new System.Drawing.Point(0, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(1032, 64);
            this.LabelTitulo.TabIndex = 23;
            this.LabelTitulo.Text = "Gulfo Musical Store";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelTitulo.Controls.Add(this.LblHora);
            this.PanelTitulo.Controls.Add(this.LblFecha);
            this.PanelTitulo.Controls.Add(this.labelsede);
            this.PanelTitulo.Controls.Add(this.label1);
            this.PanelTitulo.Controls.Add(this.LabelTitulo);
            this.PanelTitulo.Controls.Add(this.BtnSalir);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1103, 64);
            this.PanelTitulo.TabIndex = 10;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Rockwell", 17F);
            this.LblHora.ForeColor = System.Drawing.Color.Transparent;
            this.LblHora.Location = new System.Drawing.Point(143, 23);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(63, 26);
            this.LblHora.TabIndex = 11;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Rockwell", 17F);
            this.LblFecha.ForeColor = System.Drawing.Color.Transparent;
            this.LblFecha.Location = new System.Drawing.Point(12, 23);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(75, 26);
            this.LblFecha.TabIndex = 12;
            this.LblFecha.Text = "Fecha";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 670);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienda";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.PanelIzquierdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnInventario;
        public System.Windows.Forms.Button BtnVenta;
        public System.Windows.Forms.Button BtnFacturas;
        public System.Windows.Forms.Button BtnCurso;
        public System.Windows.Forms.Button BtnCursos;
        public System.Windows.Forms.Button BtnEstadisticas;
        public System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.Panel PanelIzquierdo;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsede;
        public System.Windows.Forms.Label LabelTitulo;
        public System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer2;
    }
}