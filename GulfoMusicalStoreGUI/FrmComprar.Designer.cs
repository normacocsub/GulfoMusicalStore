namespace GulfoMusicalStoreGUI
{
    partial class FrmComprar
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
            this.CmbInstrumento = new System.Windows.Forms.ComboBox();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbInstrumento
            // 
            this.CmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInstrumento.FormattingEnabled = true;
            this.CmbInstrumento.Location = new System.Drawing.Point(141, 98);
            this.CmbInstrumento.Name = "CmbInstrumento";
            this.CmbInstrumento.Size = new System.Drawing.Size(121, 21);
            this.CmbInstrumento.TabIndex = 0;
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(141, 299);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(113, 23);
            this.BtnFacturar.TabIndex = 10;
            this.BtnFacturar.Text = "Añadir Factura";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(141, 180);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(121, 20);
            this.TxtTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Instrumento";
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.CmbInstrumento);
            this.Name = "FrmComprar";
            this.Text = "FrmComprar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbInstrumento;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}