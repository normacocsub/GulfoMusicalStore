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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.TxtTotalMarcas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbFiltradoMarca = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.PanelLateral.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnModificar.Location = new System.Drawing.Point(3, 437);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(256, 78);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar Producto";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.White;
            this.PanelFondo.Controls.Add(this.BtnTodos);
            this.PanelFondo.Controls.Add(this.TxtTotalMarcas);
            this.PanelFondo.Controls.Add(this.label4);
            this.PanelFondo.Controls.Add(this.CmbFiltradoMarca);
            this.PanelFondo.Controls.Add(this.TxtTotal);
            this.PanelFondo.Controls.Add(this.label3);
            this.PanelFondo.Controls.Add(this.label1);
            this.PanelFondo.Controls.Add(this.BtnModificarMarca);
            this.PanelFondo.Controls.Add(this.DtgMarcas);
            this.PanelFondo.Controls.Add(this.DtgProductos);
            this.PanelFondo.Controls.Add(this.PanelLateral);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.Location = new System.Drawing.Point(0, 60);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(800, 540);
            this.PanelFondo.TabIndex = 11;
            // 
            // BtnTodos
            // 
            this.BtnTodos.Location = new System.Drawing.Point(293, 53);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(75, 23);
            this.BtnTodos.TabIndex = 48;
            this.BtnTodos.Text = "Todos";
            this.BtnTodos.UseVisualStyleBackColor = true;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // TxtTotalMarcas
            // 
            this.TxtTotalMarcas.Enabled = false;
            this.TxtTotalMarcas.Location = new System.Drawing.Point(652, 323);
            this.TxtTotalMarcas.Name = "TxtTotalMarcas";
            this.TxtTotalMarcas.Size = new System.Drawing.Size(81, 20);
            this.TxtTotalMarcas.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total";
            // 
            // CmbFiltradoMarca
            // 
            this.CmbFiltradoMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltradoMarca.FormattingEnabled = true;
            this.CmbFiltradoMarca.Location = new System.Drawing.Point(652, 29);
            this.CmbFiltradoMarca.Name = "CmbFiltradoMarca";
            this.CmbFiltradoMarca.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltradoMarca.TabIndex = 45;
            this.CmbFiltradoMarca.SelectedIndexChanged += new System.EventHandler(this.CmbFiltradoMarca_SelectedIndexChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(652, 67);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(81, 20);
            this.TxtTotal.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filtrado Marca";
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
            this.BtnModificarMarca.Location = new System.Drawing.Point(585, 375);
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
            this.DtgMarcas.Location = new System.Drawing.Point(293, 323);
            this.DtgMarcas.MultiSelect = false;
            this.DtgMarcas.Name = "DtgMarcas";
            this.DtgMarcas.ReadOnly = true;
            this.DtgMarcas.Size = new System.Drawing.Size(262, 185);
            this.DtgMarcas.TabIndex = 41;
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
            this.DtgProductos.Location = new System.Drawing.Point(293, 98);
            this.DtgProductos.MultiSelect = false;
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.ReadOnly = true;
            this.DtgProductos.Size = new System.Drawing.Size(440, 185);
            this.DtgProductos.TabIndex = 40;
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
            this.PanelLateral.Controls.Add(this.BtnModificar);
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
            this.BtnRegistrarMarca.Location = new System.Drawing.Point(3, 253);
            this.BtnRegistrarMarca.Name = "BtnRegistrarMarca";
            this.BtnRegistrarMarca.Size = new System.Drawing.Size(256, 74);
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
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(5, 44);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(256, 85);
            this.BtnRegistrarProducto.TabIndex = 39;
            this.BtnRegistrarProducto.Text = "Registrar Producto";
            this.BtnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 60);
            this.Panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(268, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Registro de Instrumento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelFondo);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.PanelFondo.ResumeLayout(false);
            this.PanelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PanelFondo;
        private System.Windows.Forms.Panel PanelLateral;
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
        private System.Windows.Forms.Button BtnModificarMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbFiltradoMarca;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalMarcas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnTodos;
    }
}