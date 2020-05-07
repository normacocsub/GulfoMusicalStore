namespace GulfoMusicalStoreGUI
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.DtgInventario = new System.Windows.Forms.DataGridView();
            this.CInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotalInstrumentos2 = new System.Windows.Forms.Label();
            this.LabelTotalInstrumentos = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.LabelNGElectrica = new System.Windows.Forms.Label();
            this.PBGuitarraElectrica = new System.Windows.Forms.PictureBox();
            this.LabelNPiano = new System.Windows.Forms.Label();
            this.PBPiano = new System.Windows.Forms.PictureBox();
            this.LabelNBajo = new System.Windows.Forms.Label();
            this.PBBajo = new System.Windows.Forms.PictureBox();
            this.LabelNGAcustica = new System.Windows.Forms.Label();
            this.PBGuitarraAcustica = new System.Windows.Forms.PictureBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.BtnRegistrarMarca = new System.Windows.Forms.Button();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUnidades = new System.Windows.Forms.TextBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.BtnVaciar = new System.Windows.Forms.Button();
            this.CmbInstrumento = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.LabelVenta = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGuitarraElectrica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPiano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGuitarraAcustica)).BeginInit();
            this.PanelFondo.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.White;
            this.BtnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.BackgroundImage")));
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnActualizar.Location = new System.Drawing.Point(789, 465);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(120, 78);
            this.BtnActualizar.TabIndex = 24;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DtgInventario
            // 
            this.DtgInventario.BackgroundColor = System.Drawing.Color.White;
            this.DtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CInstrumento,
            this.CCodigo,
            this.CMarca,
            this.CPrecioUnidad});
            this.DtgInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DtgInventario.Location = new System.Drawing.Point(313, 208);
            this.DtgInventario.MultiSelect = false;
            this.DtgInventario.Name = "DtgInventario";
            this.DtgInventario.ReadOnly = true;
            this.DtgInventario.Size = new System.Drawing.Size(444, 238);
            this.DtgInventario.TabIndex = 20;
            // 
            // CInstrumento
            // 
            this.CInstrumento.HeaderText = "Instrumento";
            this.CInstrumento.Name = "CInstrumento";
            this.CInstrumento.ReadOnly = true;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // CMarca
            // 
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            // 
            // CPrecioUnidad
            // 
            this.CPrecioUnidad.HeaderText = "Precio Unidad";
            this.CPrecioUnidad.Name = "CPrecioUnidad";
            this.CPrecioUnidad.ReadOnly = true;
            // 
            // LabelTotalInstrumentos2
            // 
            this.LabelTotalInstrumentos2.BackColor = System.Drawing.Color.White;
            this.LabelTotalInstrumentos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotalInstrumentos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalInstrumentos2.ForeColor = System.Drawing.Color.Black;
            this.LabelTotalInstrumentos2.Location = new System.Drawing.Point(686, 42);
            this.LabelTotalInstrumentos2.Name = "LabelTotalInstrumentos2";
            this.LabelTotalInstrumentos2.Size = new System.Drawing.Size(106, 24);
            this.LabelTotalInstrumentos2.TabIndex = 12;
            this.LabelTotalInstrumentos2.Text = "0";
            this.LabelTotalInstrumentos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotalInstrumentos
            // 
            this.LabelTotalInstrumentos.BackColor = System.Drawing.Color.White;
            this.LabelTotalInstrumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotalInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalInstrumentos.ForeColor = System.Drawing.Color.Black;
            this.LabelTotalInstrumentos.Location = new System.Drawing.Point(686, 11);
            this.LabelTotalInstrumentos.Name = "LabelTotalInstrumentos";
            this.LabelTotalInstrumentos.Size = new System.Drawing.Size(106, 24);
            this.LabelTotalInstrumentos.TabIndex = 11;
            this.LabelTotalInstrumentos.Text = "Total Instrumentos";
            this.LabelTotalInstrumentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(663, 465);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 78);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PB2
            // 
            this.PB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB2.Location = new System.Drawing.Point(299, 69);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(174, 122);
            this.PB2.TabIndex = 24;
            this.PB2.TabStop = false;
            // 
            // LabelNGElectrica
            // 
            this.LabelNGElectrica.BackColor = System.Drawing.Color.White;
            this.LabelNGElectrica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNGElectrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNGElectrica.ForeColor = System.Drawing.Color.Black;
            this.LabelNGElectrica.Location = new System.Drawing.Point(575, 168);
            this.LabelNGElectrica.Name = "LabelNGElectrica";
            this.LabelNGElectrica.Size = new System.Drawing.Size(61, 23);
            this.LabelNGElectrica.TabIndex = 38;
            this.LabelNGElectrica.Text = "0";
            this.LabelNGElectrica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBGuitarraElectrica
            // 
            this.PBGuitarraElectrica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBGuitarraElectrica.BackgroundImage")));
            this.PBGuitarraElectrica.Location = new System.Drawing.Point(575, 97);
            this.PBGuitarraElectrica.Name = "PBGuitarraElectrica";
            this.PBGuitarraElectrica.Size = new System.Drawing.Size(60, 67);
            this.PBGuitarraElectrica.TabIndex = 37;
            this.PBGuitarraElectrica.TabStop = false;
            // 
            // LabelNPiano
            // 
            this.LabelNPiano.BackColor = System.Drawing.Color.White;
            this.LabelNPiano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNPiano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNPiano.ForeColor = System.Drawing.Color.Black;
            this.LabelNPiano.Location = new System.Drawing.Point(708, 168);
            this.LabelNPiano.Name = "LabelNPiano";
            this.LabelNPiano.Size = new System.Drawing.Size(61, 23);
            this.LabelNPiano.TabIndex = 36;
            this.LabelNPiano.Text = "0";
            this.LabelNPiano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBPiano
            // 
            this.PBPiano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBPiano.BackgroundImage")));
            this.PBPiano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBPiano.Location = new System.Drawing.Point(708, 97);
            this.PBPiano.Name = "PBPiano";
            this.PBPiano.Size = new System.Drawing.Size(60, 67);
            this.PBPiano.TabIndex = 35;
            this.PBPiano.TabStop = false;
            // 
            // LabelNBajo
            // 
            this.LabelNBajo.BackColor = System.Drawing.Color.White;
            this.LabelNBajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNBajo.ForeColor = System.Drawing.Color.Black;
            this.LabelNBajo.Location = new System.Drawing.Point(642, 168);
            this.LabelNBajo.Name = "LabelNBajo";
            this.LabelNBajo.Size = new System.Drawing.Size(61, 23);
            this.LabelNBajo.TabIndex = 34;
            this.LabelNBajo.Text = "0";
            this.LabelNBajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBBajo
            // 
            this.PBBajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBBajo.BackgroundImage")));
            this.PBBajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBBajo.Location = new System.Drawing.Point(641, 97);
            this.PBBajo.Name = "PBBajo";
            this.PBBajo.Size = new System.Drawing.Size(60, 67);
            this.PBBajo.TabIndex = 33;
            this.PBBajo.TabStop = false;
            // 
            // LabelNGAcustica
            // 
            this.LabelNGAcustica.BackColor = System.Drawing.Color.White;
            this.LabelNGAcustica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNGAcustica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNGAcustica.ForeColor = System.Drawing.Color.Black;
            this.LabelNGAcustica.Location = new System.Drawing.Point(508, 168);
            this.LabelNGAcustica.Name = "LabelNGAcustica";
            this.LabelNGAcustica.Size = new System.Drawing.Size(61, 23);
            this.LabelNGAcustica.TabIndex = 32;
            this.LabelNGAcustica.Text = "0";
            this.LabelNGAcustica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBGuitarraAcustica
            // 
            this.PBGuitarraAcustica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBGuitarraAcustica.BackgroundImage")));
            this.PBGuitarraAcustica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBGuitarraAcustica.Location = new System.Drawing.Point(508, 97);
            this.PBGuitarraAcustica.Name = "PBGuitarraAcustica";
            this.PBGuitarraAcustica.Size = new System.Drawing.Size(60, 67);
            this.PBGuitarraAcustica.TabIndex = 31;
            this.PBGuitarraAcustica.TabStop = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.White;
            this.BtnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificar.BackgroundImage")));
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(537, 465);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 78);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.White;
            this.PanelFondo.Controls.Add(this.BtnRegistrarProducto);
            this.PanelFondo.Controls.Add(this.BtnRegistrarMarca);
            this.PanelFondo.Controls.Add(this.BtnActualizar);
            this.PanelFondo.Controls.Add(this.PB2);
            this.PanelFondo.Controls.Add(this.LabelNGElectrica);
            this.PanelFondo.Controls.Add(this.PBGuitarraElectrica);
            this.PanelFondo.Controls.Add(this.LabelNPiano);
            this.PanelFondo.Controls.Add(this.PBPiano);
            this.PanelFondo.Controls.Add(this.LabelNBajo);
            this.PanelFondo.Controls.Add(this.PBBajo);
            this.PanelFondo.Controls.Add(this.LabelNGAcustica);
            this.PanelFondo.Controls.Add(this.PBGuitarraAcustica);
            this.PanelFondo.Controls.Add(this.DtgInventario);
            this.PanelFondo.Controls.Add(this.LabelTotalInstrumentos2);
            this.PanelFondo.Controls.Add(this.LabelTotalInstrumentos);
            this.PanelFondo.Controls.Add(this.BtnEliminar);
            this.PanelFondo.Controls.Add(this.BtnModificar);
            this.PanelFondo.Controls.Add(this.PanelLateral);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.Location = new System.Drawing.Point(0, 45);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(957, 558);
            this.PanelFondo.TabIndex = 11;
            // 
            // BtnRegistrarMarca
            // 
            this.BtnRegistrarMarca.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarMarca.BackgroundImage")));
            this.BtnRegistrarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistrarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRegistrarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarMarca.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrarMarca.Location = new System.Drawing.Point(275, 465);
            this.BtnRegistrarMarca.Name = "BtnRegistrarMarca";
            this.BtnRegistrarMarca.Size = new System.Drawing.Size(120, 78);
            this.BtnRegistrarMarca.TabIndex = 25;
            this.BtnRegistrarMarca.Text = "Registrar Marca";
            this.BtnRegistrarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarMarca.UseVisualStyleBackColor = false;
            this.BtnRegistrarMarca.Click += new System.EventHandler(this.BtnRegistrarMarca_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelLateral.Controls.Add(this.label3);
            this.PanelLateral.Controls.Add(this.TxtCodigo);
            this.PanelLateral.Controls.Add(this.label1);
            this.PanelLateral.Controls.Add(this.TxtUnidades);
            this.PanelLateral.Controls.Add(this.PB1);
            this.PanelLateral.Controls.Add(this.BtnVaciar);
            this.PanelLateral.Controls.Add(this.CmbInstrumento);
            this.PanelLateral.Controls.Add(this.BtnRegistrar);
            this.PanelLateral.Controls.Add(this.label2);
            this.PanelLateral.Controls.Add(this.LabelInstrumento);
            this.PanelLateral.Location = new System.Drawing.Point(0, -7);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(266, 562);
            this.PanelLateral.TabIndex = 21;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Unidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.BackColor = System.Drawing.Color.White;
            this.TxtUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidades.ForeColor = System.Drawing.Color.Black;
            this.TxtUnidades.Location = new System.Drawing.Point(136, 400);
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(120, 22);
            this.TxtUnidades.TabIndex = 25;
            // 
            // PB1
            // 
            this.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB1.Location = new System.Drawing.Point(40, 69);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(174, 122);
            this.PB1.TabIndex = 23;
            this.PB1.TabStop = false;
            // 
            // BtnVaciar
            // 
            this.BtnVaciar.BackColor = System.Drawing.Color.White;
            this.BtnVaciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVaciar.BackgroundImage")));
            this.BtnVaciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVaciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVaciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnVaciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVaciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciar.ForeColor = System.Drawing.Color.Black;
            this.BtnVaciar.Location = new System.Drawing.Point(10, 472);
            this.BtnVaciar.Name = "BtnVaciar";
            this.BtnVaciar.Size = new System.Drawing.Size(120, 78);
            this.BtnVaciar.TabIndex = 22;
            this.BtnVaciar.Text = "Vaciar";
            this.BtnVaciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVaciar.UseVisualStyleBackColor = false;
            this.BtnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // CmbInstrumento
            // 
            this.CmbInstrumento.BackColor = System.Drawing.Color.White;
            this.CmbInstrumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbInstrumento.ForeColor = System.Drawing.Color.Black;
            this.CmbInstrumento.FormattingEnabled = true;
            this.CmbInstrumento.Items.AddRange(new object[] {
            "Seleccionar"});
            this.CmbInstrumento.Location = new System.Drawing.Point(136, 240);
            this.CmbInstrumento.Name = "CmbInstrumento";
            this.CmbInstrumento.Size = new System.Drawing.Size(120, 24);
            this.CmbInstrumento.TabIndex = 21;
            this.CmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.CmbInstrumento_SelectedIndexChanged);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.White;
            this.BtnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.BackgroundImage")));
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRegistrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrar.Location = new System.Drawing.Point(136, 472);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(120, 78);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Registro de Instrumento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(4, 240);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
            this.LabelInstrumento.TabIndex = 2;
            this.LabelInstrumento.Text = "Instrumento";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVenta
            // 
            this.LabelVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelVenta.BackColor = System.Drawing.Color.Transparent;
            this.LabelVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelVenta.Location = new System.Drawing.Point(415, 9);
            this.LabelVenta.Name = "LabelVenta";
            this.LabelVenta.Size = new System.Drawing.Size(123, 23);
            this.LabelVenta.TabIndex = 1;
            this.LabelVenta.Text = "Inventario";
            this.LabelVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.LabelVenta);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(957, 45);
            this.Panel1.TabIndex = 10;
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarProducto.BackgroundImage")));
            this.BtnRegistrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRegistrarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(401, 465);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(120, 81);
            this.BtnRegistrarProducto.TabIndex = 39;
            this.BtnRegistrarProducto.Text = "Registrar Producto";
            this.BtnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(136, 323);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 34;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 603);
            this.Controls.Add(this.PanelFondo);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.DtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGuitarraElectrica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPiano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGuitarraAcustica)).EndInit();
            this.PanelFondo.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DtgInventario;
        private System.Windows.Forms.Label LabelTotalInstrumentos2;
        private System.Windows.Forms.Label LabelTotalInstrumentos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.Label LabelNGElectrica;
        private System.Windows.Forms.PictureBox PBGuitarraElectrica;
        private System.Windows.Forms.Label LabelNPiano;
        private System.Windows.Forms.PictureBox PBPiano;
        private System.Windows.Forms.Label LabelNBajo;
        private System.Windows.Forms.PictureBox PBBajo;
        private System.Windows.Forms.Label LabelNGAcustica;
        private System.Windows.Forms.PictureBox PBGuitarraAcustica;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Button BtnVaciar;
        private System.Windows.Forms.ComboBox CmbInstrumento;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.Label LabelVenta;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button BtnRegistrarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnidad;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
    }
}