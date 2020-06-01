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
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(219, 146);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.White;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.Black;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(94, 209);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(100, 23);
            this.LabelPrecioUnidad.TabIndex = 46;
            this.LabelPrecioUnidad.Text = "Nombre";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(218, 210);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 22);
            this.TxtNombre.TabIndex = 45;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(94, 98);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
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
            this.CmbMarca.Location = new System.Drawing.Point(219, 98);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(120, 24);
            this.CmbMarca.TabIndex = 43;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbMarca_SelectedIndexChanged);
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
            this.BtnEliminarMarca.Location = new System.Drawing.Point(201, 287);
            this.BtnEliminarMarca.Name = "BtnEliminarMarca";
            this.BtnEliminarMarca.Size = new System.Drawing.Size(138, 78);
            this.BtnEliminarMarca.TabIndex = 50;
            this.BtnEliminarMarca.Text = "Eliminar Marca";
            this.BtnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarMarca.UseVisualStyleBackColor = false;
            this.BtnEliminarMarca.Click += new System.EventHandler(this.BtnEliminarMarca_Click);
            // 
            // FrmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.BtnEliminarMarca);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelInstrumento);
            this.Controls.Add(this.CmbMarca);
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
    }
}