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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LabelCodigoFact = new System.Windows.Forms.Label();
            this.GBB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.LabelInfor = new System.Windows.Forms.Label();
            this.GBTime = new System.Windows.Forms.GroupBox();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.CNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudadFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNumeroFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GBB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.GB2.SuspendLayout();
            this.GBTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(476, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(268, 52);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LabelCodigoFact
            // 
            this.LabelCodigoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelCodigoFact.ForeColor = System.Drawing.Color.Black;
            this.LabelCodigoFact.Location = new System.Drawing.Point(24, 32);
            this.LabelCodigoFact.Name = "LabelCodigoFact";
            this.LabelCodigoFact.Size = new System.Drawing.Size(233, 27);
            this.LabelCodigoFact.TabIndex = 68;
            this.LabelCodigoFact.Text = "Ingresar el codigo de la factura";
            this.LabelCodigoFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBB
            // 
            this.GBB.Controls.Add(this.TxtNumeroFactura);
            this.GBB.Controls.Add(this.BtnBuscar);
            this.GBB.Controls.Add(this.LabelCodigoFact);
            this.GBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GBB.ForeColor = System.Drawing.Color.Black;
            this.GBB.Location = new System.Drawing.Point(12, 507);
            this.GBB.Name = "GBB";
            this.GBB.Size = new System.Drawing.Size(776, 81);
            this.GBB.TabIndex = 71;
            this.GBB.TabStop = false;
            this.GBB.Text = "Consulta Individual";
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
            this.panel1.TabIndex = 67;
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
            this.label2.TabIndex = 158;
            this.label2.Text = "Facturas";
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
            this.pictureBox1.TabIndex = 157;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContenedor.Controls.Add(this.DtgFactura);
            this.PanelContenedor.Controls.Add(this.GBB);
            this.PanelContenedor.Controls.Add(this.GB2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 68;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.TxtTotal);
            this.GB2.Controls.Add(this.TxtCedula);
            this.GB2.Controls.Add(this.label5);
            this.GB2.Controls.Add(this.label1);
            this.GB2.Controls.Add(this.CBBusqueda);
            this.GB2.Controls.Add(this.LabelInfor);
            this.GB2.Controls.Add(this.GBTime);
            this.GB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GB2.ForeColor = System.Drawing.Color.Black;
            this.GB2.Location = new System.Drawing.Point(12, 60);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(776, 190);
            this.GB2.TabIndex = 72;
            this.GB2.TabStop = false;
            this.GB2.Text = "ConsultaTotal";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Depth = 0;
            this.TxtTotal.Hint = "Total";
            this.TxtTotal.Location = new System.Drawing.Point(554, 131);
            this.TxtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.Size = new System.Drawing.Size(172, 23);
            this.TxtTotal.TabIndex = 81;
            this.TxtTotal.UseSystemPasswordChar = false;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Depth = 0;
            this.TxtCedula.Hint = "Cédula";
            this.TxtCedula.Location = new System.Drawing.Point(554, 88);
            this.TxtCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.PasswordChar = '\0';
            this.TxtCedula.SelectedText = "";
            this.TxtCedula.SelectionLength = 0;
            this.TxtCedula.SelectionStart = 0;
            this.TxtCedula.Size = new System.Drawing.Size(172, 23);
            this.TxtCedula.TabIndex = 80;
            this.TxtCedula.UseSystemPasswordChar = false;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(409, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Busqueda por Cedula";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(409, 131);
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
            this.CBBusqueda.Location = new System.Drawing.Point(554, 44);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(172, 24);
            this.CBBusqueda.TabIndex = 71;
            this.CBBusqueda.SelectedIndexChanged += new System.EventHandler(this.CBBusqueda_SelectedIndexChanged);
            // 
            // LabelInfor
            // 
            this.LabelInfor.AutoSize = true;
            this.LabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.ForeColor = System.Drawing.Color.Black;
            this.LabelInfor.Location = new System.Drawing.Point(409, 47);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(105, 16);
            this.LabelInfor.TabIndex = 70;
            this.LabelInfor.Text = "Busqueda tipica";
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
            this.GBTime.Location = new System.Drawing.Point(49, 27);
            this.GBTime.Name = "GBTime";
            this.GBTime.Size = new System.Drawing.Size(320, 149);
            this.GBTime.TabIndex = 76;
            this.GBTime.TabStop = false;
            this.GBTime.Text = "Por intérvalo de fecha";
            // 
            // DtpHasta
            // 
            this.DtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHasta.Location = new System.Drawing.Point(111, 68);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(161, 22);
            this.DtpHasta.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 76;
            this.label4.Text = "Hasta";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesde.Location = new System.Drawing.Point(111, 28);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(161, 22);
            this.DtpDesde.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFiltrar.FlatAppearance.BorderSize = 0;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.ForeColor = System.Drawing.Color.White;
            this.BtnFiltrar.Location = new System.Drawing.Point(42, 99);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(230, 38);
            this.BtnFiltrar.TabIndex = 75;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNumero,
            this.CNombre,
            this.CTelefono,
            this.CFecha,
            this.CEstado,
            this.CCiudadFactura,
            this.CCantidad,
            this.CIVA,
            this.CSubTotal,
            this.CTotal,
            this.CCedula});
            this.DtgFactura.EnableHeadersVisualStyles = false;
            this.DtgFactura.Location = new System.Drawing.Point(12, 261);
            this.DtgFactura.Name = "DtgFactura";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DtgFactura.Size = new System.Drawing.Size(776, 240);
            this.DtgFactura.TabIndex = 159;
            // 
            // CNumero
            // 
            this.CNumero.HeaderText = "Numero";
            this.CNumero.Name = "CNumero";
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
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Depth = 0;
            this.TxtNumeroFactura.Hint = "";
            this.TxtNumeroFactura.Location = new System.Drawing.Point(275, 32);
            this.TxtNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.PasswordChar = '\0';
            this.TxtNumeroFactura.SelectedText = "";
            this.TxtNumeroFactura.SelectionLength = 0;
            this.TxtNumeroFactura.SelectionStart = 0;
            this.TxtNumeroFactura.Size = new System.Drawing.Size(169, 23);
            this.TxtNumeroFactura.TabIndex = 71;
            this.TxtNumeroFactura.UseSystemPasswordChar = false;
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
            this.ShowIcon = false;
            this.Text = "FrmFacturas";
            this.GBB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.GBTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LabelCodigoFact;
        private System.Windows.Forms.GroupBox GBB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.GroupBox GBTime;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCedula;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNumeroFactura;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudadFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
    }
}