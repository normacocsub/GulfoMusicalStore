namespace GulfoMusicalStoreGUI
{
    partial class FrmFacturaIndividual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaIndividual));
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.LabelFechaFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelCodigoFactura = new System.Windows.Forms.Label();
            this.LabelCodigoFacturatitulo = new System.Windows.Forms.Label();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.BtnClienteActual = new System.Windows.Forms.Button();
            this.GBFactura = new System.Windows.Forms.GroupBox();
            this.DtgCursos = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUNIDADES2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.CBCambiarEstado = new System.Windows.Forms.ComboBox();
            this.LabelIVA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsede = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFondo.SuspendLayout();
            this.GBCliente.SuspendLayout();
            this.GBFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelFondo.Controls.Add(this.LabelFechaFactura);
            this.PanelFondo.Controls.Add(this.label4);
            this.PanelFondo.Controls.Add(this.LabelCodigoFactura);
            this.PanelFondo.Controls.Add(this.LabelCodigoFacturatitulo);
            this.PanelFondo.Controls.Add(this.GBCliente);
            this.PanelFondo.Controls.Add(this.GBFactura);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.Location = new System.Drawing.Point(0, 60);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(800, 540);
            this.PanelFondo.TabIndex = 13;
            // 
            // LabelFechaFactura
            // 
            this.LabelFechaFactura.BackColor = System.Drawing.Color.White;
            this.LabelFechaFactura.Enabled = false;
            this.LabelFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaFactura.ForeColor = System.Drawing.Color.Black;
            this.LabelFechaFactura.Location = new System.Drawing.Point(148, 13);
            this.LabelFechaFactura.Name = "LabelFechaFactura";
            this.LabelFechaFactura.Size = new System.Drawing.Size(94, 23);
            this.LabelFechaFactura.TabIndex = 58;
            this.LabelFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fecha Factura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCodigoFactura
            // 
            this.LabelCodigoFactura.BackColor = System.Drawing.Color.White;
            this.LabelCodigoFactura.Enabled = false;
            this.LabelCodigoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigoFactura.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoFactura.Location = new System.Drawing.Point(702, 13);
            this.LabelCodigoFactura.Name = "LabelCodigoFactura";
            this.LabelCodigoFactura.Size = new System.Drawing.Size(74, 23);
            this.LabelCodigoFactura.TabIndex = 53;
            this.LabelCodigoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCodigoFacturatitulo
            // 
            this.LabelCodigoFacturatitulo.BackColor = System.Drawing.Color.White;
            this.LabelCodigoFacturatitulo.Enabled = false;
            this.LabelCodigoFacturatitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigoFacturatitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoFacturatitulo.Location = new System.Drawing.Point(593, 13);
            this.LabelCodigoFacturatitulo.Name = "LabelCodigoFacturatitulo";
            this.LabelCodigoFacturatitulo.Size = new System.Drawing.Size(103, 23);
            this.LabelCodigoFacturatitulo.TabIndex = 52;
            this.LabelCodigoFacturatitulo.Text = "Codigo Factura";
            this.LabelCodigoFacturatitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.BtnClienteActual);
            this.GBCliente.Location = new System.Drawing.Point(39, 59);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(722, 95);
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
            this.BtnClienteActual.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienteActual.Location = new System.Drawing.Point(15, 19);
            this.BtnClienteActual.Name = "BtnClienteActual";
            this.BtnClienteActual.Size = new System.Drawing.Size(693, 58);
            this.BtnClienteActual.TabIndex = 98;
            this.BtnClienteActual.Text = "Info Cliente";
            this.BtnClienteActual.UseVisualStyleBackColor = false;
            this.BtnClienteActual.Click += new System.EventHandler(this.BtnClienteActual_Click);
            // 
            // GBFactura
            // 
            this.GBFactura.Controls.Add(this.DtgCursos);
            this.GBFactura.Controls.Add(this.label5);
            this.GBFactura.Controls.Add(this.label3);
            this.GBFactura.Controls.Add(this.LabelCantidad);
            this.GBFactura.Controls.Add(this.BtnModificar);
            this.GBFactura.Controls.Add(this.CBCambiarEstado);
            this.GBFactura.Controls.Add(this.LabelIVA);
            this.GBFactura.Controls.Add(this.label11);
            this.GBFactura.Controls.Add(this.label10);
            this.GBFactura.Controls.Add(this.LabelSubTotal);
            this.GBFactura.Controls.Add(this.label9);
            this.GBFactura.Controls.Add(this.label6);
            this.GBFactura.Controls.Add(this.LabelTotal);
            this.GBFactura.Controls.Add(this.label13);
            this.GBFactura.Controls.Add(this.DtgFactura);
            this.GBFactura.Location = new System.Drawing.Point(39, 160);
            this.GBFactura.Name = "GBFactura";
            this.GBFactura.Size = new System.Drawing.Size(722, 358);
            this.GBFactura.TabIndex = 56;
            this.GBFactura.TabStop = false;
            this.GBFactura.Text = "Datos Factura";
            // 
            // DtgCursos
            // 
            this.DtgCursos.AllowUserToAddRows = false;
            this.DtgCursos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgCursos.ColumnHeadersHeight = 34;
            this.DtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CValor,
            this.CUNIDADES2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCursos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtgCursos.Location = new System.Drawing.Point(376, 101);
            this.DtgCursos.Name = "DtgCursos";
            this.DtgCursos.Size = new System.Drawing.Size(299, 189);
            this.DtgCursos.TabIndex = 97;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo Curso";
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
            // CUNIDADES2
            // 
            this.CUNIDADES2.HeaderText = "UNIDADES";
            this.CUNIDADES2.Name = "CUNIDADES2";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 30);
            this.label5.TabIndex = 96;
            this.label5.Text = "Modificar Estado De La Factura";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(368, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 95;
            this.label3.Text = "Cantidad Elementos Comprados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCantidad
            // 
            this.LabelCantidad.BackColor = System.Drawing.Color.White;
            this.LabelCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCantidad.Location = new System.Drawing.Point(595, 28);
            this.LabelCantidad.Name = "LabelCantidad";
            this.LabelCantidad.Size = new System.Drawing.Size(86, 30);
            this.LabelCantidad.TabIndex = 92;
            this.LabelCantidad.Text = "0";
            this.LabelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(257, 55);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(84, 29);
            this.BtnModificar.TabIndex = 89;
            this.BtnModificar.Text = "Aceptar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // CBCambiarEstado
            // 
            this.CBCambiarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCambiarEstado.FormattingEnabled = true;
            this.CBCambiarEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBCambiarEstado.Location = new System.Drawing.Point(257, 28);
            this.CBCambiarEstado.Name = "CBCambiarEstado";
            this.CBCambiarEstado.Size = new System.Drawing.Size(84, 21);
            this.CBCambiarEstado.TabIndex = 0;
            this.CBCambiarEstado.TabStop = false;
            this.CBCambiarEstado.Tag = "0";
            this.CBCambiarEstado.UseWaitCursor = true;
            // 
            // LabelIVA
            // 
            this.LabelIVA.BackColor = System.Drawing.Color.White;
            this.LabelIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelIVA.Location = new System.Drawing.Point(142, 319);
            this.LabelIVA.Name = "LabelIVA";
            this.LabelIVA.Size = new System.Drawing.Size(86, 23);
            this.LabelIVA.TabIndex = 87;
            this.LabelIVA.Text = "0";
            this.LabelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(42, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 86;
            this.label11.Text = "Iva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(334, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "$";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSubTotal
            // 
            this.LabelSubTotal.BackColor = System.Drawing.Color.White;
            this.LabelSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSubTotal.Location = new System.Drawing.Point(334, 319);
            this.LabelSubTotal.Name = "LabelSubTotal";
            this.LabelSubTotal.Size = new System.Drawing.Size(117, 23);
            this.LabelSubTotal.TabIndex = 84;
            this.LabelSubTotal.Text = "0";
            this.LabelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(234, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 83;
            this.label9.Text = "SubTotal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.White;
            this.LabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTotal.Location = new System.Drawing.Point(570, 319);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(111, 20);
            this.LabelTotal.TabIndex = 81;
            this.LabelTotal.Text = "0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(470, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 80;
            this.label13.Text = "Total a Pagar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgFactura
            // 
            this.DtgFactura.AllowUserToAddRows = false;
            this.DtgFactura.BackgroundColor = System.Drawing.Color.White;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoProducto,
            this.CProducto,
            this.Modelo,
            this.CMarca,
            this.CPrecio});
            this.DtgFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgFactura.Location = new System.Drawing.Point(47, 101);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.Size = new System.Drawing.Size(299, 189);
            this.DtgFactura.TabIndex = 64;
            // 
            // CCodigoProducto
            // 
            this.CCodigoProducto.HeaderText = "Codigo Producto";
            this.CCodigoProducto.Name = "CCodigoProducto";
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // CMarca
            // 
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelsede);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 140;
            this.label1.Text = "Sede Factura: ";
            // 
            // labelsede
            // 
            this.labelsede.AutoSize = true;
            this.labelsede.BackColor = System.Drawing.Color.White;
            this.labelsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsede.Location = new System.Drawing.Point(619, 22);
            this.labelsede.Name = "labelsede";
            this.labelsede.Size = new System.Drawing.Size(108, 20);
            this.labelsede.TabIndex = 60;
            this.labelsede.Text = "nombresede";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(742, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 34);
            this.BtnSalir.TabIndex = 139;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFacturaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelFondo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturaIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturaIndividual";
            this.PanelFondo.ResumeLayout(false);
            this.GBCliente.ResumeLayout(false);
            this.GBFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Label LabelFechaFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelCodigoFactura;
        private System.Windows.Forms.Label LabelCodigoFacturatitulo;
        private System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.GroupBox GBFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCantidad;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox CBCambiarEstado;
        private System.Windows.Forms.Label LabelIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label labelsede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgCursos;
        private System.Windows.Forms.Button BtnClienteActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUNIDADES2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
    }
}