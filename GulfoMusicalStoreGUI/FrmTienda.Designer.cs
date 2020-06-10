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
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.labelsede = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.FLPItems = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelTitulo.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.FLPItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(1045, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 34);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.DodgerBlue;
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
            // labelsede
            // 
            this.labelsede.AutoSize = true;
            this.labelsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Location = new System.Drawing.Point(808, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sede: ";
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(373, 15);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(357, 35);
            this.LabelTitulo.TabIndex = 23;
            this.LabelTitulo.Text = "Gulfo Musical Store";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Location = new System.Drawing.Point(291, 70);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 29;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.Controls.Add(this.FLPItems);
            this.Panel1.Controls.Add(this.BtnLogo);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Location = new System.Drawing.Point(0, 70);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(290, 600);
            this.Panel1.TabIndex = 24;
            // 
            // FLPItems
            // 
            this.FLPItems.AutoScroll = true;
            this.FLPItems.BackColor = System.Drawing.Color.White;
            this.FLPItems.Controls.Add(this.BtnInventario);
            this.FLPItems.Controls.Add(this.BtnVenta);
            this.FLPItems.Controls.Add(this.BtnFacturas);
            this.FLPItems.Controls.Add(this.BtnCurso);
            this.FLPItems.Controls.Add(this.BtnCursos);
            this.FLPItems.Controls.Add(this.BtnEstadisticas);
            this.FLPItems.Location = new System.Drawing.Point(12, 153);
            this.FLPItems.Name = "FLPItems";
            this.FLPItems.Size = new System.Drawing.Size(268, 441);
            this.FLPItems.TabIndex = 0;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.White;
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.Black;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(3, 3);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(261, 66);
            this.BtnInventario.TabIndex = 10;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click_1);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.White;
            this.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.ForeColor = System.Drawing.Color.Black;
            this.BtnVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnVenta.Image")));
            this.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVenta.Location = new System.Drawing.Point(3, 75);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(261, 66);
            this.BtnVenta.TabIndex = 13;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.BackColor = System.Drawing.Color.White;
            this.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.Black;
            this.BtnFacturas.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturas.Image")));
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(3, 147);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(261, 66);
            this.BtnFacturas.TabIndex = 8;
            this.BtnFacturas.Text = "Facturas";
            this.BtnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFacturas.UseVisualStyleBackColor = false;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // BtnCurso
            // 
            this.BtnCurso.BackColor = System.Drawing.Color.White;
            this.BtnCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurso.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnCurso.Image = ((System.Drawing.Image)(resources.GetObject("BtnCurso.Image")));
            this.BtnCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCurso.Location = new System.Drawing.Point(3, 219);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(261, 66);
            this.BtnCurso.TabIndex = 14;
            this.BtnCurso.Text = "Curso";
            this.BtnCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCurso.UseVisualStyleBackColor = false;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.BackColor = System.Drawing.Color.White;
            this.BtnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCursos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.ForeColor = System.Drawing.Color.Black;
            this.BtnCursos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCursos.Image")));
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(3, 291);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(261, 66);
            this.BtnCursos.TabIndex = 16;
            this.BtnCursos.Text = "Clientes";
            this.BtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCursos.UseVisualStyleBackColor = false;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.White;
            this.BtnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEstadisticas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.ForeColor = System.Drawing.Color.Black;
            this.BtnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadisticas.Image")));
            this.BtnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.Location = new System.Drawing.Point(3, 363);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(261, 66);
            this.BtnEstadisticas.TabIndex = 9;
            this.BtnEstadisticas.Text = "Estadisticas";
            this.BtnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // BtnLogo
            // 
            this.BtnLogo.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogo.BackgroundImage")));
            this.BtnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogo.FlatAppearance.BorderSize = 0;
            this.BtnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogo.ForeColor = System.Drawing.Color.Black;
            this.BtnLogo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLogo.Location = new System.Drawing.Point(3, 3);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(284, 142);
            this.BtnLogo.TabIndex = 15;
            this.BtnLogo.Text = "Gulfo Musical Store";
            this.BtnLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLogo.UseVisualStyleBackColor = false;
            this.BtnLogo.Click += new System.EventHandler(this.BtnLogo_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 2);
            this.label2.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 670);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienda";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.FLPItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnInventario;
        public System.Windows.Forms.Button BtnVenta;
        public System.Windows.Forms.Button BtnFacturas;
        public System.Windows.Forms.Button BtnCurso;
        public System.Windows.Forms.Button BtnCursos;
        public System.Windows.Forms.Button BtnEstadisticas;
        public System.Windows.Forms.Button BtnLogo;
        public System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.Panel PanelTitulo;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.Label LabelTitulo;
        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.FlowLayoutPanel FLPItems;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsede;
    }
}