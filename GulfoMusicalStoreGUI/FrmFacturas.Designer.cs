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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LabelCodigoFact = new System.Windows.Forms.Label();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.GBB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudadFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.LabelInfor = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.GBTime = new System.Windows.Forms.GroupBox();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.GBB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.GB2.SuspendLayout();
            this.GBTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.Location = new System.Drawing.Point(411, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 27);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LabelCodigoFact
            // 
            this.LabelCodigoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCodigoFact.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoFact.Location = new System.Drawing.Point(112, 35);
            this.LabelCodigoFact.Name = "LabelCodigoFact";
            this.LabelCodigoFact.Size = new System.Drawing.Size(142, 27);
            this.LabelCodigoFact.TabIndex = 68;
            this.LabelCodigoFact.Text = "Ingresar el codigo de factura";
            this.LabelCodigoFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(260, 35);
            this.TxtNumeroFactura.Multiline = true;
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(104, 27);
            this.TxtNumeroFactura.TabIndex = 69;
            this.TxtNumeroFactura.TextChanged += new System.EventHandler(this.TxtNumeroFactura_TextChanged_1);
            // 
            // GBB
            // 
            this.GBB.Controls.Add(this.BtnBuscar);
            this.GBB.Controls.Add(this.LabelCodigoFact);
            this.GBB.Controls.Add(this.TxtNumeroFactura);
            this.GBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GBB.ForeColor = System.Drawing.Color.Black;
            this.GBB.Location = new System.Drawing.Point(58, 507);
            this.GBB.Name = "GBB";
            this.GBB.Size = new System.Drawing.Size(674, 81);
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
            this.PanelContenedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelContenedor.Controls.Add(this.GBB);
            this.PanelContenedor.Controls.Add(this.DtgFactura);
            this.PanelContenedor.Controls.Add(this.GB2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 68;
            // 
            // DtgFactura
            // 
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNumero,
            this.CCiudadFactura,
            this.CCantidad,
            this.CIVA,
            this.CSubTotal,
            this.CTotal,
            this.CCedula,
            this.CNombre,
            this.CTelefono,
            this.CFecha,
            this.CEstado});
            this.DtgFactura.Location = new System.Drawing.Point(58, 256);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.Size = new System.Drawing.Size(674, 240);
            this.DtgFactura.TabIndex = 77;
            // 
            // CNumero
            // 
            this.CNumero.HeaderText = "Numero";
            this.CNumero.Name = "CNumero";
            // 
            // CCiudadFactura
            // 
            this.CCiudadFactura.HeaderText = "Ciudad Factura";
            this.CCiudadFactura.Name = "CCiudadFactura";
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            // 
            // CIVA
            // 
            this.CIVA.HeaderText = "IVA";
            this.CIVA.Name = "CIVA";
            // 
            // CSubTotal
            // 
            this.CSubTotal.HeaderText = "Sub Total";
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
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
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
            // GB2
            // 
            this.GB2.Controls.Add(this.label5);
            this.GB2.Controls.Add(this.TxtCedula);
            this.GB2.Controls.Add(this.label1);
            this.GB2.Controls.Add(this.CBBusqueda);
            this.GB2.Controls.Add(this.LabelInfor);
            this.GB2.Controls.Add(this.TxtTotal);
            this.GB2.Controls.Add(this.GBTime);
            this.GB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GB2.ForeColor = System.Drawing.Color.Black;
            this.GB2.Location = new System.Drawing.Point(58, 60);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(674, 190);
            this.GB2.TabIndex = 72;
            this.GB2.TabStop = false;
            this.GB2.Text = "ConsultaTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(513, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Busqueda Cedula";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(516, 112);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(128, 22);
            this.TxtCedula.TabIndex = 78;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged_1);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(487, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
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
            "Facturas Inactivas",
            "Total Ascendente ",
            "Total Descendente"});
            this.CBBusqueda.Location = new System.Drawing.Point(500, 54);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(144, 24);
            this.CBBusqueda.TabIndex = 71;
            this.CBBusqueda.SelectedIndexChanged += new System.EventHandler(this.CBBusqueda_SelectedIndexChanged);
            // 
            // LabelInfor
            // 
            this.LabelInfor.AutoSize = true;
            this.LabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.ForeColor = System.Drawing.Color.Black;
            this.LabelInfor.Location = new System.Drawing.Point(524, 35);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(120, 16);
            this.LabelInfor.TabIndex = 70;
            this.LabelInfor.Text = "Busqueda tipica";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(559, 146);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(85, 24);
            this.TxtTotal.TabIndex = 69;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GBTime
            // 
            this.GBTime.Controls.Add(this.DtpHasta);
            this.GBTime.Controls.Add(this.label4);
            this.GBTime.Controls.Add(this.DtpDesde);
            this.GBTime.Controls.Add(this.label3);
            this.GBTime.Controls.Add(this.BtnFiltrar);
            this.GBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GBTime.ForeColor = System.Drawing.Color.Black;
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
            this.label4.ForeColor = System.Drawing.Color.Black;
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
            this.label3.ForeColor = System.Drawing.Color.Black;
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
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.GBTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LabelCodigoFact;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.GroupBox GBB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.GroupBox GBTime;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudadFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        public System.Windows.Forms.ComboBox CBBusqueda;
    }
}