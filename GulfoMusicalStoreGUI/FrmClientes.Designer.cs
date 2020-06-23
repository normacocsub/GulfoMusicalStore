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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.LabelInfor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrimerNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelInfor
            // 
            this.LabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfor.ForeColor = System.Drawing.Color.Black;
            this.LabelInfor.Location = new System.Drawing.Point(279, 32);
            this.LabelInfor.Name = "LabelInfor";
            this.LabelInfor.Size = new System.Drawing.Size(168, 21);
            this.LabelInfor.TabIndex = 72;
            this.LabelInfor.Text = "Busqueda Por Cedula";
            this.LabelInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(279, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
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
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.TxtPrimerNombre);
            this.groupBox1.Controls.Add(this.BtnTodos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelInfor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 163);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Depth = 0;
            this.TxtTotal.Hint = "         Total";
            this.TxtTotal.Location = new System.Drawing.Point(339, 109);
            this.TxtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.Size = new System.Drawing.Size(108, 23);
            this.TxtTotal.TabIndex = 82;
            this.TxtTotal.UseSystemPasswordChar = false;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Depth = 0;
            this.TxtCedula.Hint = "              Cedula";
            this.TxtCedula.Location = new System.Drawing.Point(283, 67);
            this.TxtCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.PasswordChar = '\0';
            this.TxtCedula.SelectedText = "";
            this.TxtCedula.SelectionLength = 0;
            this.TxtCedula.SelectionStart = 0;
            this.TxtCedula.Size = new System.Drawing.Size(161, 23);
            this.TxtCedula.TabIndex = 81;
            this.TxtCedula.UseSystemPasswordChar = false;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Depth = 0;
            this.TxtPrimerNombre.Hint = "           Primer Nombre";
            this.TxtPrimerNombre.Location = new System.Drawing.Point(42, 93);
            this.TxtPrimerNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.PasswordChar = '\0';
            this.TxtPrimerNombre.SelectedText = "";
            this.TxtPrimerNombre.SelectionLength = 0;
            this.TxtPrimerNombre.SelectionStart = 0;
            this.TxtPrimerNombre.Size = new System.Drawing.Size(189, 23);
            this.TxtPrimerNombre.TabIndex = 80;
            this.TxtPrimerNombre.UseSystemPasswordChar = false;
            this.TxtPrimerNombre.TextChanged += new System.EventHandler(this.TxtPrimerNombre_TextChanged);
            // 
            // BtnTodos
            // 
            this.BtnTodos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTodos.FlatAppearance.BorderSize = 0;
            this.BtnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTodos.ForeColor = System.Drawing.Color.White;
            this.BtnTodos.Location = new System.Drawing.Point(525, 32);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(203, 100);
            this.BtnTodos.TabIndex = 79;
            this.BtnTodos.Text = "Consultar";
            this.BtnTodos.UseVisualStyleBackColor = false;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 78;
            this.label3.Text = "Busqueda Por Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgClientes
            // 
            this.DtgClientes.AllowUserToAddRows = false;
            this.DtgClientes.AllowUserToDeleteRows = false;
            this.DtgClientes.AllowUserToResizeColumns = false;
            this.DtgClientes.AllowUserToResizeRows = false;
            this.DtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgClientes.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.DtgClientes.EnableHeadersVisualStyles = false;
            this.DtgClientes.Location = new System.Drawing.Point(21, 223);
            this.DtgClientes.Name = "DtgClientes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DtgClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgClientes.Size = new System.Drawing.Size(756, 286);
            this.DtgClientes.TabIndex = 67;
            // 
            // CCedula
            // 
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.Name = "CCedula";
            // 
            // CPrimerNombre
            // 
            this.CPrimerNombre.HeaderText = "Primer Nombre";
            this.CPrimerNombre.Name = "CPrimerNombre";
            // 
            // CSegundoNombre
            // 
            this.CSegundoNombre.HeaderText = "Segundo Nombre";
            this.CSegundoNombre.Name = "CSegundoNombre";
            // 
            // CPrimerApellido
            // 
            this.CPrimerApellido.HeaderText = "Primer Apellido";
            this.CPrimerApellido.Name = "CPrimerApellido";
            // 
            // CSegundoApellido
            // 
            this.CSegundoApellido.HeaderText = "Segundo Apellido";
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
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.White;
            this.PanelTitulo.Controls.Add(this.label2);
            this.PanelTitulo.Controls.Add(this.pictureBox1);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(800, 60);
            this.PanelTitulo.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(90, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 60);
            this.label2.TabIndex = 152;
            this.label2.Text = "Clientes";
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
            this.pictureBox1.TabIndex = 151;
            this.pictureBox1.TabStop = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.ShowIcon = false;
            this.Text = "FrmCursos";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTodos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
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
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCedula;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrimerNombre;
    }
}