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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.BtnEliminarMarca = new System.Windows.Forms.Button();
            this.BtnModificarMarca = new System.Windows.Forms.Button();
            this.DtgMarcas = new System.Windows.Forms.DataGridView();
            this.SK_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.CCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.BtnRegistrarMarca = new System.Windows.Forms.Button();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelVenta = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PanelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnEliminar.Location = new System.Drawing.Point(40, 475);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(138, 78);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.BtnModificar.Location = new System.Drawing.Point(40, 379);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(138, 78);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.White;
            this.PanelFondo.Controls.Add(this.BtnEliminarMarca);
            this.PanelFondo.Controls.Add(this.BtnModificarMarca);
            this.PanelFondo.Controls.Add(this.DtgMarcas);
            this.PanelFondo.Controls.Add(this.DtgProductos);
            this.PanelFondo.Controls.Add(this.PanelLateral);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.Location = new System.Drawing.Point(0, 45);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(957, 558);
            this.PanelFondo.TabIndex = 11;
            // 
            // BtnEliminarMarca
            // 
            this.BtnEliminarMarca.BackColor = System.Drawing.Color.White;
            this.BtnEliminarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMarca.BackgroundImage")));
            this.BtnEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEliminarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarMarca.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarMarca.Location = new System.Drawing.Point(645, 413);
            this.BtnEliminarMarca.Name = "BtnEliminarMarca";
            this.BtnEliminarMarca.Size = new System.Drawing.Size(138, 78);
            this.BtnEliminarMarca.TabIndex = 40;
            this.BtnEliminarMarca.Text = "Eliminar Marca";
            this.BtnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarMarca.UseVisualStyleBackColor = false;
            this.BtnEliminarMarca.Click += new System.EventHandler(this.BtnEliminarMarca_Click);
            // 
            // BtnModificarMarca
            // 
            this.BtnModificarMarca.BackColor = System.Drawing.Color.White;
            this.BtnModificarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificarMarca.BackgroundImage")));
            this.BtnModificarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnModificarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnModificarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModificarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarMarca.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarMarca.Location = new System.Drawing.Point(645, 281);
            this.BtnModificarMarca.Name = "BtnModificarMarca";
            this.BtnModificarMarca.Size = new System.Drawing.Size(148, 85);
            this.BtnModificarMarca.TabIndex = 40;
            this.BtnModificarMarca.Text = "Modificar Marca";
            this.BtnModificarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarMarca.UseVisualStyleBackColor = false;
            this.BtnModificarMarca.Click += new System.EventHandler(this.BtnModificarMarca_Click);
            // 
            // DtgMarcas
            // 
            this.DtgMarcas.BackgroundColor = System.Drawing.Color.White;
            this.DtgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SK_MARCA,
            this.CNOMBRE});
            this.DtgMarcas.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DtgMarcas.Location = new System.Drawing.Point(293, 265);
            this.DtgMarcas.MultiSelect = false;
            this.DtgMarcas.Name = "DtgMarcas";
            this.DtgMarcas.ReadOnly = true;
            this.DtgMarcas.Size = new System.Drawing.Size(262, 185);
            this.DtgMarcas.TabIndex = 41;
            this.DtgMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SK_MARCA
            // 
            this.SK_MARCA.HeaderText = "SK_MARCA";
            this.SK_MARCA.Name = "SK_MARCA";
            this.SK_MARCA.ReadOnly = true;
            // 
            // CNOMBRE
            // 
            this.CNOMBRE.HeaderText = "MARCA";
            this.CNOMBRE.Name = "CNOMBRE";
            this.CNOMBRE.ReadOnly = true;
            // 
            // DtgProductos
            // 
            this.DtgProductos.BackgroundColor = System.Drawing.Color.White;
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigoProducto,
            this.CInstrumento,
            this.CPrecio,
            this.CMarca});
            this.DtgProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DtgProductos.Location = new System.Drawing.Point(293, 62);
            this.DtgProductos.MultiSelect = false;
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.ReadOnly = true;
            this.DtgProductos.Size = new System.Drawing.Size(440, 185);
            this.DtgProductos.TabIndex = 40;
            this.DtgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCurso_CellContentClick);
            // 
            // CCodigoProducto
            // 
            this.CCodigoProducto.HeaderText = "Codigo Producto";
            this.CCodigoProducto.Name = "CCodigoProducto";
            this.CCodigoProducto.ReadOnly = true;
            // 
            // CInstrumento
            // 
            this.CInstrumento.HeaderText = "Instrumento";
            this.CInstrumento.Name = "CInstrumento";
            this.CInstrumento.ReadOnly = true;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // CMarca
            // 
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelLateral.Controls.Add(this.BtnRegistrarMarca);
            this.PanelLateral.Controls.Add(this.BtnRegistrarProducto);
            this.PanelLateral.Controls.Add(this.BtnEliminar);
            this.PanelLateral.Controls.Add(this.PB1);
            this.PanelLateral.Controls.Add(this.BtnModificar);
            this.PanelLateral.Controls.Add(this.label2);
            this.PanelLateral.Location = new System.Drawing.Point(0, -7);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(266, 562);
            this.PanelLateral.TabIndex = 21;
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
            this.BtnRegistrarMarca.Location = new System.Drawing.Point(40, 299);
            this.BtnRegistrarMarca.Name = "BtnRegistrarMarca";
            this.BtnRegistrarMarca.Size = new System.Drawing.Size(138, 74);
            this.BtnRegistrarMarca.TabIndex = 25;
            this.BtnRegistrarMarca.Text = "Registrar Marca";
            this.BtnRegistrarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarMarca.UseVisualStyleBackColor = false;
            this.BtnRegistrarMarca.Click += new System.EventHandler(this.BtnRegistrarMarca_Click);
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
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(40, 197);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(138, 85);
            this.BtnRegistrarProducto.TabIndex = 39;
            this.BtnRegistrarProducto.Text = "Registrar Producto";
            this.BtnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
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
            this.PanelFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelVenta;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button BtnRegistrarMarca;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridView DtgMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SK_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNOMBRE;
        private System.Windows.Forms.Button BtnEliminarMarca;
        private System.Windows.Forms.Button BtnModificarMarca;
    }
}