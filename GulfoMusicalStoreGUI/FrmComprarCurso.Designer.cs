namespace GulfoMusicalStoreGUI
{
    partial class FrmComprarCurso
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
            this.CmbNombreCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUnidades = new System.Windows.Forms.ComboBox();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbNombreCurso
            // 
            this.CmbNombreCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNombreCurso.FormattingEnabled = true;
            this.CmbNombreCurso.Location = new System.Drawing.Point(185, 104);
            this.CmbNombreCurso.Name = "CmbNombreCurso";
            this.CmbNombreCurso.Size = new System.Drawing.Size(121, 21);
            this.CmbNombreCurso.TabIndex = 0;
            this.CmbNombreCurso.SelectedIndexChanged += new System.EventHandler(this.CmbNombreCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NombreCurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidades";
            // 
            // CmbUnidades
            // 
            this.CmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidades.FormattingEnabled = true;
            this.CmbUnidades.Location = new System.Drawing.Point(185, 151);
            this.CmbUnidades.Name = "CmbUnidades";
            this.CmbUnidades.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidades.TabIndex = 3;
            this.CmbUnidades.SelectedIndexChanged += new System.EventHandler(this.CmbUnidades_SelectedIndexChanged);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(139, 270);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(122, 33);
            this.BtnFacturar.TabIndex = 4;
            this.BtnFacturar.Text = "Añadir Factura";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // FrmComprarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 399);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.CmbUnidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbNombreCurso);
            this.Name = "FrmComprarCurso";
            this.Text = "FrmComprarCurso";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbNombreCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUnidades;
        private System.Windows.Forms.Button BtnFacturar;
    }
}