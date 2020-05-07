namespace GulfoMusicalStoreGUI
{
    partial class FrmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarContraseña));
            this.LabelCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.BtnConfrimar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCedula
            // 
            this.LabelCedula.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelCedula.Location = new System.Drawing.Point(87, 29);
            this.LabelCedula.Name = "LabelCedula";
            this.LabelCedula.Size = new System.Drawing.Size(232, 40);
            this.LabelCedula.TabIndex = 1;
            this.LabelCedula.Text = "Digite su cedula";
            this.LabelCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.TxtCedula.Location = new System.Drawing.Point(87, 81);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(232, 32);
            this.TxtCedula.TabIndex = 2;
            // 
            // BtnConfrimar
            // 
            this.BtnConfrimar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConfrimar.BackColor = System.Drawing.Color.White;
            this.BtnConfrimar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfrimar.FlatAppearance.BorderSize = 0;
            this.BtnConfrimar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnConfrimar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnConfrimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfrimar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfrimar.ForeColor = System.Drawing.Color.Black;
            this.BtnConfrimar.Location = new System.Drawing.Point(87, 151);
            this.BtnConfrimar.Name = "BtnConfrimar";
            this.BtnConfrimar.Size = new System.Drawing.Size(232, 39);
            this.BtnConfrimar.TabIndex = 22;
            this.BtnConfrimar.Text = "Confirmar";
            this.BtnConfrimar.UseVisualStyleBackColor = false;
            this.BtnConfrimar.Click += new System.EventHandler(this.BtnConfrimar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(331, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 34);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(389, 219);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConfrimar);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LabelCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Button BtnConfrimar;
        private System.Windows.Forms.Button BtnSalir;
    }
}