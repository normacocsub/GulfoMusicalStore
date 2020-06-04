namespace GulfoMusicalStoreGUI
{
    partial class FrmEliminarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarMarca));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.BtnEliminarMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(219, 171);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.AutoSize = true;
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrecioUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.White;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(94, 216);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(71, 20);
            this.LabelPrecioUnidad.TabIndex = 46;
            this.LabelPrecioUnidad.Text = "Nombre";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(218, 216);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 22);
            this.TxtNombre.TabIndex = 45;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.AutoSize = true;
            this.LabelInstrumento.BackColor = System.Drawing.Color.Transparent;
            this.LabelInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.White;
            this.LabelInstrumento.Location = new System.Drawing.Point(94, 124);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(58, 20);
            this.LabelInstrumento.TabIndex = 44;
            this.LabelInstrumento.Text = "Marca";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbMarca
            // 
            this.CmbMarca.BackColor = System.Drawing.Color.White;
            this.CmbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMarca.ForeColor = System.Drawing.Color.Black;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Items.AddRange(new object[] {
            "Seleccionar",
            "Guitarra Acustica",
            "Guitarra Electrica",
            "Bajo",
            "Piano"});
            this.CmbMarca.Location = new System.Drawing.Point(219, 124);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(120, 24);
            this.CmbMarca.TabIndex = 43;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbMarca_SelectedIndexChanged);
            // 
            // BtnEliminarMarca
            // 
            this.BtnEliminarMarca.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnEliminarMarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEliminarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarMarca.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarMarca.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMarca.Image")));
            this.BtnEliminarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarMarca.Location = new System.Drawing.Point(219, 323);
            this.BtnEliminarMarca.Name = "BtnEliminarMarca";
            this.BtnEliminarMarca.Size = new System.Drawing.Size(120, 91);
            this.BtnEliminarMarca.TabIndex = 50;
            this.BtnEliminarMarca.Text = "Eliminar Marca";
            this.BtnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarMarca.UseVisualStyleBackColor = false;
            this.BtnEliminarMarca.Click += new System.EventHandler(this.BtnEliminarMarca_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 47);
            this.label2.TabIndex = 51;
            this.label2.Text = "Eliminar Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(382, 7);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 34);
            this.BtnSalir.TabIndex = 52;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEliminarMarca);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelInstrumento);
            this.Controls.Add(this.CmbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarMarca";
            this.Text = "FrmEliminarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPrecioUnidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Button BtnEliminarMarca;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BtnSalir;
    }
}