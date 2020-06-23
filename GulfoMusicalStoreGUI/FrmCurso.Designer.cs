namespace GulfoMusicalStoreGUI
{
    partial class FrmCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVaciar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgCurso = new System.Windows.Forms.DataGridView();
            this.TxtTodos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtInstrumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CCodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCurso)).BeginInit();
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
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.TxtCodigo);
            this.panel3.Controls.Add(this.TxtPrecio);
            this.panel3.Controls.Add(this.TxtInstrumento);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.CmbEstado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BtnVaciar);
            this.panel3.Controls.Add(this.BtnRegistrar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LabelPrecioUnidad);
            this.panel3.Controls.Add(this.LabelInstrumento);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 600);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Codigo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.White;
            this.CmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.ForeColor = System.Drawing.Color.Black;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Seleccionar",
            "ACTIVO",
            "DESHABILITADO"});
            this.CmbEstado.Location = new System.Drawing.Point(139, 353);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(120, 27);
            this.CmbEstado.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Estado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnVaciar
            // 
            this.BtnVaciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVaciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVaciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVaciar.FlatAppearance.BorderSize = 0;
            this.BtnVaciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVaciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciar.ForeColor = System.Drawing.Color.White;
            this.BtnVaciar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVaciar.Image")));
            this.BtnVaciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVaciar.Location = new System.Drawing.Point(11, 517);
            this.BtnVaciar.Name = "BtnVaciar";
            this.BtnVaciar.Size = new System.Drawing.Size(249, 69);
            this.BtnVaciar.TabIndex = 22;
            this.BtnVaciar.Text = "Vaciar";
            this.BtnVaciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVaciar.UseVisualStyleBackColor = false;
            this.BtnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.Location = new System.Drawing.Point(12, 430);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(248, 69);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registro de curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.Black;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(7, 286);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(121, 18);
            this.LabelPrecioUnidad.TabIndex = 4;
            this.LabelPrecioUnidad.Text = "Precio";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.Transparent;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(7, 219);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(121, 22);
            this.LabelInstrumento.TabIndex = 2;
            this.LabelInstrumento.Text = "Nombre del curso";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.TxtTodos);
            this.Panel2.Controls.Add(this.DtgCurso);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.CmbFiltroEstado);
            this.Panel2.Controls.Add(this.BtnActualizar);
            this.Panel2.Controls.Add(this.BtnModificar);
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(800, 600);
            this.Panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Filtrado Estado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbFiltroEstado
            // 
            this.CmbFiltroEstado.BackColor = System.Drawing.Color.White;
            this.CmbFiltroEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltroEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroEstado.ForeColor = System.Drawing.Color.Black;
            this.CmbFiltroEstado.FormattingEnabled = true;
            this.CmbFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "ACTIVO",
            "DESHABILITADO"});
            this.CmbFiltroEstado.Location = new System.Drawing.Point(485, 77);
            this.CmbFiltroEstado.Name = "CmbFiltroEstado";
            this.CmbFiltroEstado.Size = new System.Drawing.Size(220, 27);
            this.CmbFiltroEstado.TabIndex = 26;
            this.CmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.CmbFiltroEstado_SelectedIndexChanged);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.Location = new System.Drawing.Point(288, 454);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(490, 58);
            this.BtnActualizar.TabIndex = 24;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.Location = new System.Drawing.Point(288, 520);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(490, 58);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.label2.TabIndex = 156;
            this.label2.Text = "Crear Curso";
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
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            // 
            // DtgCurso
            // 
            this.DtgCurso.AllowUserToAddRows = false;
            this.DtgCurso.AllowUserToDeleteRows = false;
            this.DtgCurso.AllowUserToResizeColumns = false;
            this.DtgCurso.AllowUserToResizeRows = false;
            this.DtgCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCurso.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtgCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoCurso,
            this.CInstrumento,
            this.CPrecio,
            this.CEstado,
            this.CFecha});
            this.DtgCurso.EnableHeadersVisualStyles = false;
            this.DtgCurso.Location = new System.Drawing.Point(288, 161);
            this.DtgCurso.Name = "DtgCurso";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DtgCurso.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgCurso.Size = new System.Drawing.Size(490, 274);
            this.DtgCurso.TabIndex = 68;
            // 
            // TxtTodos
            // 
            this.TxtTodos.Depth = 0;
            this.TxtTodos.Hint = "Todos";
            this.TxtTodos.Location = new System.Drawing.Point(485, 119);
            this.TxtTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTodos.Name = "TxtTodos";
            this.TxtTodos.PasswordChar = '\0';
            this.TxtTodos.SelectedText = "";
            this.TxtTodos.SelectionLength = 0;
            this.TxtTodos.SelectionStart = 0;
            this.TxtTodos.Size = new System.Drawing.Size(220, 23);
            this.TxtTodos.TabIndex = 69;
            this.TxtTodos.UseSystemPasswordChar = false;
            // 
            // TxtInstrumento
            // 
            this.TxtInstrumento.Depth = 0;
            this.TxtInstrumento.Hint = "Todos";
            this.TxtInstrumento.Location = new System.Drawing.Point(139, 219);
            this.TxtInstrumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtInstrumento.Name = "TxtInstrumento";
            this.TxtInstrumento.PasswordChar = '\0';
            this.TxtInstrumento.SelectedText = "";
            this.TxtInstrumento.SelectionLength = 0;
            this.TxtInstrumento.SelectionStart = 0;
            this.TxtInstrumento.Size = new System.Drawing.Size(120, 23);
            this.TxtInstrumento.TabIndex = 70;
            this.TxtInstrumento.UseSystemPasswordChar = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Depth = 0;
            this.TxtPrecio.Hint = "Todos";
            this.TxtPrecio.Location = new System.Drawing.Point(139, 286);
            this.TxtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.PasswordChar = '\0';
            this.TxtPrecio.SelectedText = "";
            this.TxtPrecio.SelectionLength = 0;
            this.TxtPrecio.SelectionStart = 0;
            this.TxtPrecio.Size = new System.Drawing.Size(120, 23);
            this.TxtPrecio.TabIndex = 71;
            this.TxtPrecio.UseSystemPasswordChar = false;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Depth = 0;
            this.TxtCodigo.Hint = "Código";
            this.TxtCodigo.Location = new System.Drawing.Point(139, 152);
            this.TxtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PasswordChar = '\0';
            this.TxtCodigo.SelectedText = "";
            this.TxtCodigo.SelectionLength = 0;
            this.TxtCodigo.SelectionStart = 0;
            this.TxtCodigo.Size = new System.Drawing.Size(121, 23);
            this.TxtCodigo.TabIndex = 72;
            this.TxtCodigo.UseSystemPasswordChar = false;
            // 
            // CCodigoCurso
            // 
            this.CCodigoCurso.HeaderText = "Código Curso";
            this.CCodigoCurso.Name = "CCodigoCurso";
            // 
            // CInstrumento
            // 
            this.CInstrumento.HeaderText = "Instrumento";
            this.CInstrumento.Name = "CInstrumento";
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCurso";
            this.ShowIcon = false;
            this.Text = "FrmCurso";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVaciar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPrecioUnidad;
        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFiltroEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtInstrumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTodos;
        private System.Windows.Forms.DataGridView DtgCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
    }
}