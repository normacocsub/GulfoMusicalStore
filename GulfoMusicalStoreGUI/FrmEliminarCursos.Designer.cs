namespace GulfoMusicalStoreGUI
{
    partial class FrmEliminarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarCursos));
            this.BtmEliminar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.CmbCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtmEliminar
            // 
            this.BtmEliminar.BackColor = System.Drawing.Color.White;
            this.BtmEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmEliminar.BackgroundImage")));
            this.BtmEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtmEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtmEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtmEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtmEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtmEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtmEliminar.Location = new System.Drawing.Point(181, 272);
            this.BtmEliminar.Name = "BtmEliminar";
            this.BtmEliminar.Size = new System.Drawing.Size(138, 78);
            this.BtmEliminar.TabIndex = 57;
            this.BtmEliminar.Text = "Eliminar";
            this.BtmEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtmEliminar.UseVisualStyleBackColor = false;
            this.BtmEliminar.Click += new System.EventHandler(this.BtmEliminar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.Location = new System.Drawing.Point(199, 131);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(120, 22);
            this.TxtCodigo.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.BackColor = System.Drawing.Color.White;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioUnidad.ForeColor = System.Drawing.Color.Black;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(74, 194);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(100, 23);
            this.LabelPrecioUnidad.TabIndex = 54;
            this.LabelPrecioUnidad.Text = "Nombre";
            this.LabelPrecioUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(198, 195);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 22);
            this.TxtNombre.TabIndex = 53;
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(74, 83);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
            this.LabelInstrumento.TabIndex = 52;
            this.LabelInstrumento.Text = "Curso";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbCurso
            // 
            this.CmbCurso.BackColor = System.Drawing.Color.White;
            this.CmbCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCurso.ForeColor = System.Drawing.Color.Black;
            this.CmbCurso.FormattingEnabled = true;
            this.CmbCurso.Items.AddRange(new object[] {
            "Seleccionar",
            "Guitarra Acustica",
            "Guitarra Electrica",
            "Bajo",
            "Piano"});
            this.CmbCurso.Location = new System.Drawing.Point(199, 83);
            this.CmbCurso.Name = "CmbCurso";
            this.CmbCurso.Size = new System.Drawing.Size(120, 24);
            this.CmbCurso.TabIndex = 51;
            this.CmbCurso.SelectedIndexChanged += new System.EventHandler(this.CmbCurso_SelectedIndexChanged);
            // 
            // FrmEliminarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.BtmEliminar);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelInstrumento);
            this.Controls.Add(this.CmbCurso);
            this.Name = "FrmEliminarCursos";
            this.Text = "FrmEliminarCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtmEliminar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPrecioUnidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.ComboBox CmbCurso;
    }
}