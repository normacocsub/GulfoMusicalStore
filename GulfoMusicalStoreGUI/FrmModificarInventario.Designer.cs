namespace GulfoMusicalStoreGUI
{
    partial class FrmModificarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarInventario));
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CmbInstrumento = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(40, 122);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
            this.LabelInstrumento.TabIndex = 23;
            this.LabelInstrumento.Text = "Instrumento";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.White;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.ForeColor = System.Drawing.Color.Black;
            this.TxtPrecio.Location = new System.Drawing.Point(164, 234);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(120, 22);
            this.TxtPrecio.TabIndex = 24;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.White;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.Black;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(40, 233);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(100, 23);
            this.LabelPrecioUnidad.TabIndex = 25;
            this.LabelPrecioUnidad.Text = "Precio";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnModificar.Location = new System.Drawing.Point(164, 295);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 78);
            this.BtnModificar.TabIndex = 26;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(165, 170);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 35;
            // 
            // CmbInstrumento
            // 
            this.CmbInstrumento.FormattingEnabled = true;
            this.CmbInstrumento.Location = new System.Drawing.Point(165, 123);
            this.CmbInstrumento.Name = "CmbInstrumento";
            this.CmbInstrumento.Size = new System.Drawing.Size(121, 21);
            this.CmbInstrumento.TabIndex = 36;
            this.CmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.CmbInstrumento_SelectedIndexChanged_1);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(320, 121);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 37;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmModificarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.CmbInstrumento);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LabelInstrumento);
            this.Name = "FrmModificarInventario";
            this.Text = "FrmModificarInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LabelPrecioUnidad;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ComboBox CmbInstrumento;
        private System.Windows.Forms.Button BtnConsultar;
    }
}