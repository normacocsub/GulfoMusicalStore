namespace GulfoMusicalStoreGUI
{
    partial class FrmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.LabelInfor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.GBTime = new System.Windows.Forms.GroupBox();
            this.BtnGenerarInforme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtgCurso = new System.Windows.Forms.DataGridView();
            this.CCodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBTime.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCurso)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelInfor
            // 
            this.LabelInfor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.Location = new System.Drawing.Point(482, 34);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(151, 21);
            this.LabelInfor.TabIndex = 72;
            this.LabelInfor.Text = "Busqueda Total Personalizada";
            this.LabelInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(578, 110);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(85, 24);
            this.TxtResultado.TabIndex = 74;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtpHasta
            // 
            this.DtpHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpHasta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHasta.Location = new System.Drawing.Point(29, 91);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(286, 26);
            this.DtpHasta.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 76;
            this.label4.Text = "Hasta";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpDesde.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDesde.Location = new System.Drawing.Point(29, 35);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(286, 26);
            this.DtpDesde.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "De";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFiltrar.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.Location = new System.Drawing.Point(127, 129);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 75;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // GBTime
            // 
            this.GBTime.Controls.Add(this.DtpHasta);
            this.GBTime.Controls.Add(this.label4);
            this.GBTime.Controls.Add(this.DtpDesde);
            this.GBTime.Controls.Add(this.label3);
            this.GBTime.Controls.Add(this.BtnFiltrar);
            this.GBTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTime.Location = new System.Drawing.Point(51, 19);
            this.GBTime.Name = "GBTime";
            this.GBTime.Size = new System.Drawing.Size(323, 158);
            this.GBTime.TabIndex = 80;
            this.GBTime.TabStop = false;
            this.GBTime.Text = "Time";
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarInforme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarInforme.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerarInforme.Image")));
            this.BtnGenerarInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(583, 493);
            this.BtnGenerarInforme.Name = "BtnGenerarInforme";
            this.BtnGenerarInforme.Size = new System.Drawing.Size(205, 50);
            this.BtnGenerarInforme.TabIndex = 81;
            this.BtnGenerarInforme.Text = "Generar Informe";
            this.BtnGenerarInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.BtnGenerarInforme);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 555);
            this.panel2.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GBTime);
            this.groupBox1.Controls.Add(this.DtgCurso);
            this.groupBox1.Controls.Add(this.LabelInfor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBBusqueda);
            this.groupBox1.Controls.Add(this.TxtResultado);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 467);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Total";
            // 
            // DtgCurso
            // 
            this.DtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoCurso,
            this.CInstrumento,
            this.CCedula,
            this.CNombre,
            this.CSexo,
            this.CFecha,
            this.CEstado,
            this.CPrecio});
            this.DtgCurso.Location = new System.Drawing.Point(51, 192);
            this.DtgCurso.Name = "DtgCurso";
            this.DtgCurso.Size = new System.Drawing.Size(613, 258);
            this.DtgCurso.TabIndex = 67;
            // 
            // CCodigoCurso
            // 
            this.CCodigoCurso.HeaderText = "CodigoCurso";
            this.CCodigoCurso.Name = "CCodigoCurso";
            // 
            // CInstrumento
            // 
            this.CInstrumento.HeaderText = "Instrumento";
            this.CInstrumento.Name = "CInstrumento";
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
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Items.AddRange(new object[] {
            "Todos",
            "Guitarra Electrica",
            "Bajo",
            "Piano",
            "Guitarra Acustica",
            "Hombres",
            "Mujeres",
            "A -> Z Nombres",
            "Z -> A Nombres",
            "Precio Mayor a Menor",
            "Precio Mayor a Menor"});
            this.CBBusqueda.Location = new System.Drawing.Point(451, 68);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(213, 27);
            this.CBBusqueda.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(268, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cursos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 70;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.GBTime.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCurso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.GroupBox GBTime;
        private System.Windows.Forms.Button BtnGenerarInforme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}