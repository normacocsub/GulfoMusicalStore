namespace GulfoMusicalStoreGUI
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.GBFactura = new System.Windows.Forms.GroupBox();
            this.DtgCursos = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelCodigoProducto = new System.Windows.Forms.Label();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Labelinstrumento = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCurso = new System.Windows.Forms.ComboBox();
            this.LabelFechaFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.BtnClienteActual = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.LabelCurso = new System.Windows.Forms.Label();
            this.CUNIDADES2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.GBCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBFactura
            // 
            this.GBFactura.Controls.Add(this.DtgCursos);
            this.GBFactura.Controls.Add(this.LabelTotal);
            this.GBFactura.Controls.Add(this.label13);
            this.GBFactura.Controls.Add(this.LabelCodigoProducto);
            this.GBFactura.Controls.Add(this.DtgFactura);
            this.GBFactura.Location = new System.Drawing.Point(39, 181);
            this.GBFactura.Name = "GBFactura";
            this.GBFactura.Size = new System.Drawing.Size(722, 293);
            this.GBFactura.TabIndex = 56;
            this.GBFactura.TabStop = false;
            this.GBFactura.Text = "Detalle";
            // 
            // DtgCursos
            // 
            this.DtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CValor,
            this.CUNIDADES2});
            this.DtgCursos.Location = new System.Drawing.Point(410, 64);
            this.DtgCursos.Name = "DtgCursos";
            this.DtgCursos.Size = new System.Drawing.Size(306, 182);
            this.DtgCursos.TabIndex = 94;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CValor
            // 
            this.CValor.HeaderText = "Valor";
            this.CValor.Name = "CValor";
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.White;
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTotal.Location = new System.Drawing.Point(367, 258);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(111, 22);
            this.LabelTotal.TabIndex = 93;
            this.LabelTotal.Text = "0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(244, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Total a Pagar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCodigoProducto
            // 
            this.LabelCodigoProducto.BackColor = System.Drawing.Color.White;
            this.LabelCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoProducto.Location = new System.Drawing.Point(42, 30);
            this.LabelCodigoProducto.Name = "LabelCodigoProducto";
            this.LabelCodigoProducto.Size = new System.Drawing.Size(177, 20);
            this.LabelCodigoProducto.TabIndex = 89;
            this.LabelCodigoProducto.Text = "Seleccione el producto";
            this.LabelCodigoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCodigoProducto.Click += new System.EventHandler(this.LabelCodigoProducto_Click);
            // 
            // DtgFactura
            // 
            this.DtgFactura.AllowUserToDeleteRows = false;
            this.DtgFactura.BackgroundColor = System.Drawing.Color.Cyan;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoProducto,
            this.CProducto,
            this.CPrecio,
            this.CUNIDADES,
            this.CMarca});
            this.DtgFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgFactura.Location = new System.Drawing.Point(6, 64);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.ReadOnly = true;
            this.DtgFactura.Size = new System.Drawing.Size(363, 182);
            this.DtgFactura.TabIndex = 88;
            // 
            // CCodigoProducto
            // 
            this.CCodigoProducto.HeaderText = "Codigo Producto";
            this.CCodigoProducto.Name = "CCodigoProducto";
            this.CCodigoProducto.ReadOnly = true;
            this.CCodigoProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.ReadOnly = true;
            this.CProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            this.CPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CUNIDADES
            // 
            this.CUNIDADES.HeaderText = "Unidades";
            this.CUNIDADES.Name = "CUNIDADES";
            this.CUNIDADES.ReadOnly = true;
            this.CUNIDADES.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CMarca
            // 
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            this.CMarca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Labelinstrumento
            // 
            this.Labelinstrumento.BackColor = System.Drawing.Color.White;
            this.Labelinstrumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Labelinstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Labelinstrumento.ForeColor = System.Drawing.Color.Black;
            this.Labelinstrumento.Location = new System.Drawing.Point(237, 538);
            this.Labelinstrumento.Name = "Labelinstrumento";
            this.Labelinstrumento.Size = new System.Drawing.Size(212, 21);
            this.Labelinstrumento.TabIndex = 91;
            this.Labelinstrumento.Text = "Elija el Instrumento para el curso";
            this.Labelinstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(81, 491);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 97);
            this.BtnEliminar.TabIndex = 89;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desea tomar el curso?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBCurso
            // 
            this.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurso.FormattingEnabled = true;
            this.CBCurso.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CBCurso.Location = new System.Drawing.Point(455, 491);
            this.CBCurso.Name = "CBCurso";
            this.CBCurso.Size = new System.Drawing.Size(50, 21);
            this.CBCurso.TabIndex = 59;
            this.CBCurso.SelectedIndexChanged += new System.EventHandler(this.CBCurso_SelectedIndexChanged);
            // 
            // LabelFechaFactura
            // 
            this.LabelFechaFactura.BackColor = System.Drawing.Color.White;
            this.LabelFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelFechaFactura.Location = new System.Drawing.Point(148, 13);
            this.LabelFechaFactura.Name = "LabelFechaFactura";
            this.LabelFechaFactura.Size = new System.Drawing.Size(94, 23);
            this.LabelFechaFactura.TabIndex = 58;
            this.LabelFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(39, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fecha Factura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturar.Image")));
            this.BtnFacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFacturar.Location = new System.Drawing.Point(652, 491);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(109, 97);
            this.BtnFacturar.TabIndex = 54;
            this.BtnFacturar.Text = "Guardar";
            this.BtnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.BtnClienteActual);
            this.GBCliente.Controls.Add(this.BtnRegistrarCliente);
            this.GBCliente.Location = new System.Drawing.Point(39, 51);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(722, 124);
            this.GBCliente.TabIndex = 55;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "Datos del Cliente";
            // 
            // BtnClienteActual
            // 
            this.BtnClienteActual.BackColor = System.Drawing.Color.Transparent;
            this.BtnClienteActual.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnClienteActual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClienteActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClienteActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienteActual.Location = new System.Drawing.Point(581, 40);
            this.BtnClienteActual.Name = "BtnClienteActual";
            this.BtnClienteActual.Size = new System.Drawing.Size(100, 55);
            this.BtnClienteActual.TabIndex = 1;
            this.BtnClienteActual.Text = "Info Cliente";
            this.BtnClienteActual.UseVisualStyleBackColor = false;
            this.BtnClienteActual.Click += new System.EventHandler(this.BtnClienteActual_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(184, 28);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(354, 73);
            this.BtnRegistrarCliente.TabIndex = 0;
            this.BtnRegistrarCliente.Text = "Registrar Cliente";
            this.BtnRegistrarCliente.UseVisualStyleBackColor = true;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(268, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Venta de Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelFondo.Controls.Add(this.LabelCurso);
            this.PanelFondo.Controls.Add(this.Labelinstrumento);
            this.PanelFondo.Controls.Add(this.BtnEliminar);
            this.PanelFondo.Controls.Add(this.label3);
            this.PanelFondo.Controls.Add(this.CBCurso);
            this.PanelFondo.Controls.Add(this.LabelFechaFactura);
            this.PanelFondo.Controls.Add(this.label4);
            this.PanelFondo.Controls.Add(this.BtnFacturar);
            this.PanelFondo.Controls.Add(this.GBCliente);
            this.PanelFondo.Controls.Add(this.GBFactura);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.Location = new System.Drawing.Point(0, 0);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(800, 600);
            this.PanelFondo.TabIndex = 11;
            // 
            // LabelCurso
            // 
            this.LabelCurso.BackColor = System.Drawing.Color.White;
            this.LabelCurso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelCurso.ForeColor = System.Drawing.Color.Black;
            this.LabelCurso.Location = new System.Drawing.Point(455, 539);
            this.LabelCurso.Name = "LabelCurso";
            this.LabelCurso.Size = new System.Drawing.Size(177, 20);
            this.LabelCurso.TabIndex = 92;
            this.LabelCurso.Text = "Seleccione el curso";
            this.LabelCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCurso.Click += new System.EventHandler(this.LabelCurso_Click_1);
            // 
            // CUNIDADES2
            // 
            this.CUNIDADES2.HeaderText = "UNIDADES";
            this.CUNIDADES2.Name = "CUNIDADES2";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.GBFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.GBCliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnRegistrarCliente;
        public System.Windows.Forms.GroupBox GBFactura;
        public System.Windows.Forms.Label Labelinstrumento;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CBCurso;
        public System.Windows.Forms.Label LabelFechaFactura;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BtnFacturar;
        public System.Windows.Forms.GroupBox GBCliente;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Button BtnClienteActual;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Label LabelCodigoProducto;
        private System.Windows.Forms.Label LabelCurso;
        private System.Windows.Forms.DataGridView DtgCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUNIDADES2;
    }
}