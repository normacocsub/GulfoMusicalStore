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
            this.CmbUnidadesAcustica = new System.Windows.Forms.ComboBox();
            this.CmbUnidadesElectricas = new System.Windows.Forms.ComboBox();
            this.CmbUnidadesPiano = new System.Windows.Forms.ComboBox();
            this.CmbUnidadesBajo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.TxtAcustica = new System.Windows.Forms.TextBox();
            this.TxtElectrica = new System.Windows.Forms.TextBox();
            this.TxtPiano = new System.Windows.Forms.TextBox();
            this.TxtBajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbUnidadesAcustica
            // 
            this.CmbUnidadesAcustica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidadesAcustica.FormattingEnabled = true;
            this.CmbUnidadesAcustica.Location = new System.Drawing.Point(163, 73);
            this.CmbUnidadesAcustica.Name = "CmbUnidadesAcustica";
            this.CmbUnidadesAcustica.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidadesAcustica.TabIndex = 0;
            // 
            // CmbUnidadesElectricas
            // 
            this.CmbUnidadesElectricas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidadesElectricas.FormattingEnabled = true;
            this.CmbUnidadesElectricas.Location = new System.Drawing.Point(163, 130);
            this.CmbUnidadesElectricas.Name = "CmbUnidadesElectricas";
            this.CmbUnidadesElectricas.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidadesElectricas.TabIndex = 1;
            // 
            // CmbUnidadesPiano
            // 
            this.CmbUnidadesPiano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidadesPiano.FormattingEnabled = true;
            this.CmbUnidadesPiano.Location = new System.Drawing.Point(163, 182);
            this.CmbUnidadesPiano.Name = "CmbUnidadesPiano";
            this.CmbUnidadesPiano.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidadesPiano.TabIndex = 2;
            // 
            // CmbUnidadesBajo
            // 
            this.CmbUnidadesBajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidadesBajo.FormattingEnabled = true;
            this.CmbUnidadesBajo.Location = new System.Drawing.Point(163, 235);
            this.CmbUnidadesBajo.Name = "CmbUnidadesBajo";
            this.CmbUnidadesBajo.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidadesBajo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guitarra Acustica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Guitarra Electrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Piano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bajo";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(163, 334);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(113, 23);
            this.BtnFacturar.TabIndex = 10;
            this.BtnFacturar.Text = "Añadir Factura";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // TxtAcustica
            // 
            this.TxtAcustica.Enabled = false;
            this.TxtAcustica.Location = new System.Drawing.Point(334, 73);
            this.TxtAcustica.Name = "TxtAcustica";
            this.TxtAcustica.Size = new System.Drawing.Size(63, 20);
            this.TxtAcustica.TabIndex = 11;
            // 
            // TxtElectrica
            // 
            this.TxtElectrica.Enabled = false;
            this.TxtElectrica.Location = new System.Drawing.Point(334, 133);
            this.TxtElectrica.Name = "TxtElectrica";
            this.TxtElectrica.Size = new System.Drawing.Size(63, 20);
            this.TxtElectrica.TabIndex = 12;
            // 
            // TxtPiano
            // 
            this.TxtPiano.Enabled = false;
            this.TxtPiano.Location = new System.Drawing.Point(334, 183);
            this.TxtPiano.Name = "TxtPiano";
            this.TxtPiano.Size = new System.Drawing.Size(63, 20);
            this.TxtPiano.TabIndex = 13;
            // 
            // TxtBajo
            // 
            this.TxtBajo.Enabled = false;
            this.TxtBajo.Location = new System.Drawing.Point(334, 235);
            this.TxtBajo.Name = "TxtBajo";
            this.TxtBajo.Size = new System.Drawing.Size(63, 20);
            this.TxtBajo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBajo);
            this.Controls.Add(this.TxtPiano);
            this.Controls.Add(this.TxtElectrica);
            this.Controls.Add(this.TxtAcustica);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbUnidadesBajo);
            this.Controls.Add(this.CmbUnidadesPiano);
            this.Controls.Add(this.CmbUnidadesElectricas);
            this.Controls.Add(this.CmbUnidadesAcustica);
            this.Name = "FrmComprar";
            this.Text = "FrmComprar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbUnidadesAcustica;
        private System.Windows.Forms.ComboBox CmbUnidadesElectricas;
        private System.Windows.Forms.ComboBox CmbUnidadesPiano;
        private System.Windows.Forms.ComboBox CmbUnidadesBajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.TextBox TxtAcustica;
        private System.Windows.Forms.TextBox TxtElectrica;
        private System.Windows.Forms.TextBox TxtPiano;
        private System.Windows.Forms.TextBox TxtBajo;
        private System.Windows.Forms.Label label5;
    }
}