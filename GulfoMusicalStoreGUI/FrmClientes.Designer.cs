namespace GulfoMusicalStoreGUI
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.LabelInfor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnGenerarInforme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelsede = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelInfor
            // 
            this.LabelInfor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.ForeColor = System.Drawing.Color.Black;
            this.LabelInfor.Location = new System.Drawing.Point(424, 32);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(151, 21);
            this.LabelInfor.TabIndex = 72;
            this.LabelInfor.Text = "Busqueda Cedula";
            this.LabelInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(424, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtTotal.Location = new System.Drawing.Point(493, 110);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(79, 24);
            this.TxtTotal.TabIndex = 74;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarInforme.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarInforme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarInforme.ForeColor = System.Drawing.Color.Black;
            this.BtnGenerarInforme.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerarInforme.Image")));
            this.BtnGenerarInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(553, 478);
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
            this.panel2.Controls.Add(this.DtgClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 540);
            this.panel2.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnTodos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPrimerNombre);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.LabelInfor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(43, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 163);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Total";
            // 
            // BtnTodos
            // 
            this.BtnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTodos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTodos.ForeColor = System.Drawing.Color.Black;
            this.BtnTodos.Location = new System.Drawing.Point(28, 102);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(92, 40);
            this.BtnTodos.TabIndex = 79;
            this.BtnTodos.Text = "Todos";
            this.BtnTodos.UseVisualStyleBackColor = true;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(110, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 21);
            this.label3.TabIndex = 78;
            this.label3.Text = "Busqueda PrimerNombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtPrimerNombre.Location = new System.Drawing.Point(136, 66);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(164, 26);
            this.TxtPrimerNombre.TabIndex = 77;
            this.TxtPrimerNombre.TextChanged += new System.EventHandler(this.TxtPrimerNombre_TextChanged);
            // 
            // TxtCedula
            // 
            this.TxtCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtCedula.Location = new System.Drawing.Point(428, 66);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(144, 26);
            this.TxtCedula.TabIndex = 76;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            // 
            // DtgClientes
            // 
            this.DtgClientes.BackgroundColor = System.Drawing.Color.White;
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCedula,
            this.CPrimerNombre,
            this.CSegundoNombre,
            this.CPrimerApellido,
            this.CSegundoApellido,
            this.CCorreo,
            this.CTelefono,
            this.CDireccion,
            this.CCiudad,
            this.CBarrio});
            this.DtgClientes.Location = new System.Drawing.Point(82, 197);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(613, 261);
            this.DtgClientes.TabIndex = 67;
            // 
            // CCedula
            // 
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.Name = "CCedula";
            // 
            // CPrimerNombre
            // 
            this.CPrimerNombre.HeaderText = "PrimerNombre";
            this.CPrimerNombre.Name = "CPrimerNombre";
            // 
            // CSegundoNombre
            // 
            this.CSegundoNombre.HeaderText = "SegundoNombre";
            this.CSegundoNombre.Name = "CSegundoNombre";
            // 
            // CPrimerApellido
            // 
            this.CPrimerApellido.HeaderText = "PrimerApellido";
            this.CPrimerApellido.Name = "CPrimerApellido";
            // 
            // CSegundoApellido
            // 
            this.CSegundoApellido.HeaderText = "SegundoApellido";
            this.CSegundoApellido.Name = "CSegundoApellido";
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            // 
            // CDireccion
            // 
            this.CDireccion.HeaderText = "Direccion";
            this.CDireccion.Name = "CDireccion";
            // 
            // CCiudad
            // 
            this.CCiudad.HeaderText = "Ciudad";
            this.CCiudad.Name = "CCiudad";
            // 
            // CBarrio
            // 
            this.CBarrio.HeaderText = "Barrio";
            this.CBarrio.Name = "CBarrio";
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
            this.label2.Text = "Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelsede);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 70;
            // 
            // labelsede
            // 
            this.labelsede.AutoSize = true;
            this.labelsede.BackColor = System.Drawing.Color.White;
            this.labelsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsede.Location = new System.Drawing.Point(624, 23);
            this.labelsede.Name = "labelsede";
            this.labelsede.Size = new System.Drawing.Size(108, 20);
            this.labelsede.TabIndex = 83;
            this.labelsede.Text = "nombresede";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Sede: ";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmCursos";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnGenerarInforme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarrio;
        private System.Windows.Forms.Button BtnTodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsede;
    }
}