namespace GulfoMusicalStoreGUI
{
    partial class FrmModificarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarMarca));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(210, 153);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(85, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.White;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.Black;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(85, 216);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(100, 23);
            this.LabelPrecioUnidad.TabIndex = 39;
            this.LabelPrecioUnidad.Text = "Nombre";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(209, 217);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 22);
            this.TxtNombre.TabIndex = 38;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(85, 105);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
            this.LabelInstrumento.TabIndex = 37;
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
            this.CmbMarca.Location = new System.Drawing.Point(210, 105);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(120, 24);
            this.CmbMarca.TabIndex = 36;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbInstrumento_SelectedIndexChanged);
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
            this.BtnModificar.Location = new System.Drawing.Point(191, 305);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(138, 78);
            this.BtnModificar.TabIndex = 43;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // FrmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelInstrumento);
            this.Controls.Add(this.CmbMarca);
            this.Name = "FrmModificarMarca";
            this.Text = "FrmModificarMarca";
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
        private System.Windows.Forms.Button BtnModificar;
    }
}