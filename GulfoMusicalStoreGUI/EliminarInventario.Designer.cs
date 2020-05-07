namespace GulfoMusicalStoreGUI
{
    partial class EliminarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarInventario));
            this.LabelInstrumento = new System.Windows.Forms.Label();
            this.CmbInstrumento = new System.Windows.Forms.ComboBox();
            this.LabelUnidades = new System.Windows.Forms.Label();
            this.TxtUnidades = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtTotalUnidades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInstrumento
            // 
            this.LabelInstrumento.BackColor = System.Drawing.Color.White;
            this.LabelInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstrumento.ForeColor = System.Drawing.Color.Black;
            this.LabelInstrumento.Location = new System.Drawing.Point(52, 136);
            this.LabelInstrumento.Name = "LabelInstrumento";
            this.LabelInstrumento.Size = new System.Drawing.Size(100, 23);
            this.LabelInstrumento.TabIndex = 25;
            this.LabelInstrumento.Text = "Instrumento";
            this.LabelInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            "Seleccionar",
            "Guitarra Acustica",
            "Guitarra Electrica",
            "Bajo",
            "Piano"});
            this.CmbInstrumento.Location = new System.Drawing.Point(158, 135);
            this.CmbInstrumento.Name = "CmbInstrumento";
            this.CmbInstrumento.Size = new System.Drawing.Size(120, 24);
            this.CmbInstrumento.TabIndex = 24;
            this.CmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.CmbInstrumento_SelectedIndexChanged);
            // 
            // LabelUnidades
            // 
            this.LabelUnidades.BackColor = System.Drawing.Color.White;
            this.LabelUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnidades.ForeColor = System.Drawing.Color.Black;
            this.LabelUnidades.Location = new System.Drawing.Point(52, 216);
            this.LabelUnidades.Name = "LabelUnidades";
            this.LabelUnidades.Size = new System.Drawing.Size(100, 23);
            this.LabelUnidades.TabIndex = 26;
            this.LabelUnidades.Text = "Unidades";
            this.LabelUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.BackColor = System.Drawing.Color.White;
            this.TxtUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidades.ForeColor = System.Drawing.Color.Black;
            this.TxtUnidades.Location = new System.Drawing.Point(158, 217);
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(120, 22);
            this.TxtUnidades.TabIndex = 27;
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
            this.BtnEliminar.Location = new System.Drawing.Point(200, 307);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 78);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtTotalUnidades
            // 
            this.TxtTotalUnidades.BackColor = System.Drawing.Color.White;
            this.TxtTotalUnidades.Enabled = false;
            this.TxtTotalUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalUnidades.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalUnidades.Location = new System.Drawing.Point(342, 137);
            this.TxtTotalUnidades.Name = "TxtTotalUnidades";
            this.TxtTotalUnidades.Size = new System.Drawing.Size(59, 22);
            this.TxtTotalUnidades.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(322, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total unidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotalUnidades);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtUnidades);
            this.Controls.Add(this.LabelUnidades);
            this.Controls.Add(this.LabelInstrumento);
            this.Controls.Add(this.CmbInstrumento);
            this.Name = "EliminarInventario";
            this.Text = "EliminarInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInstrumento;
        private System.Windows.Forms.ComboBox CmbInstrumento;
        private System.Windows.Forms.Label LabelUnidades;
        private System.Windows.Forms.TextBox TxtUnidades;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtTotalUnidades;
        private System.Windows.Forms.Label label1;
    }
}