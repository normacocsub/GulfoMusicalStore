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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBFactura = new System.Windows.Forms.GroupBox();
            this.DtgCursos = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCurso = new System.Windows.Forms.Label();
            this.LabelIVA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabelCodigoProducto = new System.Windows.Forms.Label();
            this.GBCliente = new System.Windows.Forms.GroupBox();
            this.BtnClienteActual = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelFechaFactura = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.GBCliente.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(90, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 60);
            this.label2.TabIndex = 160;
            this.label2.Text = "Venta de Productos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 60);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // GBFactura
            // 
            this.GBFactura.Controls.Add(this.DtgCursos);
            this.GBFactura.Controls.Add(this.DtgFactura);
            this.GBFactura.Controls.Add(this.CBCurso);
            this.GBFactura.Controls.Add(this.label3);
            this.GBFactura.Controls.Add(this.LabelCurso);
            this.GBFactura.Controls.Add(this.LabelIVA);
            this.GBFactura.Controls.Add(this.label11);
            this.GBFactura.Controls.Add(this.label10);
            this.GBFactura.Controls.Add(this.LabelSubTotal);
            this.GBFactura.Controls.Add(this.label9);
            this.GBFactura.Controls.Add(this.label6);
            this.GBFactura.Controls.Add(this.labelTotal);
            this.GBFactura.Controls.Add(this.Label15);
            this.GBFactura.Controls.Add(this.LabelCodigoProducto);
            this.GBFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFactura.Location = new System.Drawing.Point(39, 188);
            this.GBFactura.Name = "GBFactura";
            this.GBFactura.Size = new System.Drawing.Size(722, 306);
            this.GBFactura.TabIndex = 56;
            this.GBFactura.TabStop = false;
            this.GBFactura.Text = "Detalle";
            // 
            // DtgCursos
            // 
            this.DtgCursos.AllowUserToAddRows = false;
            this.DtgCursos.AllowUserToDeleteRows = false;
            this.DtgCursos.AllowUserToResizeColumns = false;
            this.DtgCursos.AllowUserToResizeRows = false;
            this.DtgCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCursos.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtgCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CValor,
            this.Unidades});
            this.DtgCursos.EnableHeadersVisualStyles = false;
            this.DtgCursos.Location = new System.Drawing.Point(381, 88);
            this.DtgCursos.Name = "DtgCursos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DtgCursos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgCursos.Size = new System.Drawing.Size(321, 154);
            this.DtgCursos.TabIndex = 104;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Código";
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
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            // 
            // DtgFactura
            // 
            this.DtgFactura.AllowUserToAddRows = false;
            this.DtgFactura.AllowUserToDeleteRows = false;
            this.DtgFactura.AllowUserToResizeColumns = false;
            this.DtgFactura.AllowUserToResizeRows = false;
            this.DtgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgFactura.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtgFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoProducto,
            this.CProducto,
            this.CPrecio,
            this.CUnidades,
            this.CMarca});
            this.DtgFactura.EnableHeadersVisualStyles = false;
            this.DtgFactura.Location = new System.Drawing.Point(21, 88);
            this.DtgFactura.Name = "DtgFactura";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DtgFactura.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgFactura.Size = new System.Drawing.Size(354, 154);
            this.DtgFactura.TabIndex = 103;
            // 
            // CCodigoProducto
            // 
            this.CCodigoProducto.HeaderText = "Código Producto";
            this.CCodigoProducto.Name = "CCodigoProducto";
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CUnidades
            // 
            this.CUnidades.HeaderText = "Unidades";
            this.CUnidades.Name = "CUnidades";
            // 
            // CMarca
            // 
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            // 
            // CBCurso
            // 
            this.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurso.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCurso.FormattingEnabled = true;
            this.CBCurso.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CBCurso.Location = new System.Drawing.Point(561, 27);
            this.CBCurso.Name = "CBCurso";
            this.CBCurso.Size = new System.Drawing.Size(126, 26);
            this.CBCurso.TabIndex = 59;
            this.CBCurso.SelectedIndexChanged += new System.EventHandler(this.CBCurso_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(381, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desea tomar el curso?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCurso
            // 
            this.LabelCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurso.ForeColor = System.Drawing.Color.Black;
            this.LabelCurso.Location = new System.Drawing.Point(381, 60);
            this.LabelCurso.Name = "LabelCurso";
            this.LabelCurso.Size = new System.Drawing.Size(306, 20);
            this.LabelCurso.TabIndex = 92;
            this.LabelCurso.Text = "Seleccione el curso";
            this.LabelCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCurso.Click += new System.EventHandler(this.LabelCurso_Click_1);
            // 
            // LabelIVA
            // 
            this.LabelIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelIVA.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIVA.Location = new System.Drawing.Point(106, 260);
            this.LabelIVA.Name = "LabelIVA";
            this.LabelIVA.Size = new System.Drawing.Size(86, 23);
            this.LabelIVA.TabIndex = 102;
            this.LabelIVA.Text = "0";
            this.LabelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(41, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 101;
            this.label11.Text = "Iva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 100;
            this.label10.Text = "$";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSubTotal
            // 
            this.LabelSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSubTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTotal.Location = new System.Drawing.Point(309, 261);
            this.LabelSubTotal.Name = "LabelSubTotal";
            this.LabelSubTotal.Size = new System.Drawing.Size(117, 23);
            this.LabelSubTotal.TabIndex = 99;
            this.LabelSubTotal.Text = "0";
            this.LabelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(209, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 98;
            this.label9.Text = "SubTotal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(576, 264);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(111, 20);
            this.labelTotal.TabIndex = 96;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(447, 263);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(105, 20);
            this.Label15.TabIndex = 95;
            this.Label15.Text = "Total a Pagar";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCodigoProducto
            // 
            this.LabelCodigoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCodigoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoProducto.Location = new System.Drawing.Point(44, 27);
            this.LabelCodigoProducto.Name = "LabelCodigoProducto";
            this.LabelCodigoProducto.Size = new System.Drawing.Size(290, 53);
            this.LabelCodigoProducto.TabIndex = 89;
            this.LabelCodigoProducto.Text = "Seleccione el producto";
            this.LabelCodigoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCodigoProducto.Click += new System.EventHandler(this.LabelCodigoProducto_Click);
            // 
            // GBCliente
            // 
            this.GBCliente.Controls.Add(this.BtnClienteActual);
            this.GBCliente.Controls.Add(this.BtnRegistrarCliente);
            this.GBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCliente.Location = new System.Drawing.Point(39, 71);
            this.GBCliente.Name = "GBCliente";
            this.GBCliente.Size = new System.Drawing.Size(722, 111);
            this.GBCliente.TabIndex = 55;
            this.GBCliente.TabStop = false;
            this.GBCliente.Text = "Datos del Cliente";
            // 
            // BtnClienteActual
            // 
            this.BtnClienteActual.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnClienteActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClienteActual.FlatAppearance.BorderSize = 0;
            this.BtnClienteActual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClienteActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClienteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienteActual.ForeColor = System.Drawing.Color.White;
            this.BtnClienteActual.Location = new System.Drawing.Point(397, 23);
            this.BtnClienteActual.Name = "BtnClienteActual";
            this.BtnClienteActual.Size = new System.Drawing.Size(303, 73);
            this.BtnClienteActual.TabIndex = 1;
            this.BtnClienteActual.Text = "Info Cliente";
            this.BtnClienteActual.UseVisualStyleBackColor = false;
            this.BtnClienteActual.Click += new System.EventHandler(this.BtnClienteActual_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(21, 23);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(354, 73);
            this.BtnRegistrarCliente.TabIndex = 0;
            this.BtnRegistrarCliente.Text = "Registrar Cliente";
            this.BtnRegistrarCliente.UseVisualStyleBackColor = false;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturar.FlatAppearance.BorderSize = 0;
            this.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.ForeColor = System.Drawing.Color.White;
            this.BtnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturar.Image")));
            this.BtnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFacturar.Location = new System.Drawing.Point(39, 509);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(722, 66);
            this.BtnFacturar.TabIndex = 54;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturar.UseVisualStyleBackColor = false;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
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
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContenedor.Controls.Add(this.LabelFechaFactura);
            this.PanelContenedor.Controls.Add(this.label4);
            this.PanelContenedor.Controls.Add(this.BtnFacturar);
            this.PanelContenedor.Controls.Add(this.GBCliente);
            this.PanelContenedor.Controls.Add(this.GBFactura);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 11;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.ShowIcon = false;
            this.Text = "FrmVenta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.GBCliente.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox GBFactura;
        private System.Windows.Forms.Label LabelCurso;
        private System.Windows.Forms.Label LabelIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label LabelCodigoProducto;
        public System.Windows.Forms.GroupBox GBCliente;
        private System.Windows.Forms.Button BtnClienteActual;
        public System.Windows.Forms.Button BtnRegistrarCliente;
        public System.Windows.Forms.Button BtnFacturar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LabelFechaFactura;
        public System.Windows.Forms.ComboBox CBCurso;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.DataGridView DtgCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
    }
}