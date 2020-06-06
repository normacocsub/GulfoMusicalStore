namespace GulfoMusicalStoreGUI
{
    partial class FrmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturas));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LabelCodigoFact = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.GBB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.LabelInfor = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBTime = new System.Windows.Forms.GroupBox();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.GBB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.GB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.GBTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.Location = new System.Drawing.Point(172, 52);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 27);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LabelCodigoFact
            // 
            this.LabelCodigoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCodigoFact.ForeColor = System.Drawing.Color.White;
            this.LabelCodigoFact.Location = new System.Drawing.Point(6, 19);
            this.LabelCodigoFact.Name = "LabelCodigoFact";
            this.LabelCodigoFact.Size = new System.Drawing.Size(142, 27);
            this.LabelCodigoFact.TabIndex = 68;
            this.LabelCodigoFact.Text = "Ingresar el codigo de factura";
            this.LabelCodigoFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(181, 19);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 27);
            this.txtCodigo.TabIndex = 69;
            // 
            // GBB
            // 
            this.GBB.Controls.Add(this.BtnBuscar);
            this.GBB.Controls.Add(this.LabelCodigoFact);
            this.GBB.Controls.Add(this.txtCodigo);
            this.GBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GBB.ForeColor = System.Drawing.Color.White;
            this.GBB.Location = new System.Drawing.Point(58, 512);
            this.GBB.Name = "GBB";
            this.GBB.Size = new System.Drawing.Size(328, 85);
            this.GBB.TabIndex = 71;
            this.GBB.TabStop = false;
            this.GBB.Text = "Consulta Individual";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Facturas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelContenedor.Controls.Add(this.button3);
            this.PanelContenedor.Controls.Add(this.GBB);
            this.PanelContenedor.Controls.Add(this.GB2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 68;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(538, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 50);
            this.button3.TabIndex = 80;
            this.button3.Text = "Generar Informe";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.label1);
            this.GB2.Controls.Add(this.CBBusqueda);
            this.GB2.Controls.Add(this.LabelInfor);
            this.GB2.Controls.Add(this.TxtResultado);
            this.GB2.Controls.Add(this.DtgFactura);
            this.GB2.Controls.Add(this.GBTime);
            this.GB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GB2.ForeColor = System.Drawing.Color.White;
            this.GB2.Location = new System.Drawing.Point(58, 60);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(674, 446);
            this.GB2.TabIndex = 72;
            this.GB2.TabStop = false;
            this.GB2.Text = "ConsultaTotal";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Items.AddRange(new object[] {
            "Total Facturas",
            "Facturas Activas",
            "Facturas Inactivas"});
            this.CBBusqueda.Location = new System.Drawing.Point(500, 76);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(144, 24);
            this.CBBusqueda.TabIndex = 71;
            // 
            // LabelInfor
            // 
            this.LabelInfor.AutoSize = true;
            this.LabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.ForeColor = System.Drawing.Color.White;
            this.LabelInfor.Location = new System.Drawing.Point(519, 51);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(120, 16);
            this.LabelInfor.TabIndex = 70;
            this.LabelInfor.Text = "Busqueda tipica";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Location = new System.Drawing.Point(559, 115);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(85, 24);
            this.TxtResultado.TabIndex = 69;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtgFactura
            // 
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CCantidad,
            this.CIVA,
            this.CSubTotal,
            this.CTotal,
            this.CCedula,
            this.CNombre,
            this.CSexo,
            this.CFecha,
            this.CEstado});
            this.DtgFactura.Location = new System.Drawing.Point(31, 182);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.Size = new System.Drawing.Size(613, 258);
            this.DtgFactura.TabIndex = 67;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "CantidadProductos";
            this.CCantidad.Name = "CCantidad";
            // 
            // CIVA
            // 
            this.CIVA.HeaderText = "IVA";
            this.CIVA.Name = "CIVA";
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "SubTotal";
            this.CSubTotal.Name = "CSubTotal";
            // 
            // CTotal
            // 
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            // 
            // CCedula
            // 
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.Name = "CCedula";
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CSexo
            // 
            this.CSexo.HeaderText = "Sexo";
            this.CSexo.Name = "CSexo";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            // 
            // GBTime
            // 
            this.GBTime.Controls.Add(this.DtpHasta);
            this.GBTime.Controls.Add(this.label4);
            this.GBTime.Controls.Add(this.DtpDesde);
            this.GBTime.Controls.Add(this.label3);
            this.GBTime.Controls.Add(this.BtnFiltrar);
            this.GBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GBTime.ForeColor = System.Drawing.Color.White;
            this.GBTime.Location = new System.Drawing.Point(31, 35);
            this.GBTime.Name = "GBTime";
            this.GBTime.Size = new System.Drawing.Size(312, 135);
            this.GBTime.TabIndex = 76;
            this.GBTime.TabStop = false;
            this.GBTime.Text = "Time";
            // 
            // DtpHasta
            // 
            this.DtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DtpHasta.Location = new System.Drawing.Point(16, 77);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(286, 22);
            this.DtpHasta.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Hasta";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DtpDesde.Location = new System.Drawing.Point(16, 35);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(286, 22);
            this.DtpDesde.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "De";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.Location = new System.Drawing.Point(115, 106);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 75;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.GBB.ResumeLayout(false);
            this.GBB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.GBTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LabelCodigoFact;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox GBB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.GroupBox GBTime;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}