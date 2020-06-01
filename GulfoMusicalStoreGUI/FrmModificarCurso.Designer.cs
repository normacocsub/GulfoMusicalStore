namespace GulfoMusicalStoreGUI
{
    partial class FrmModificarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // CmbCurso
            // 
            this.CmbCurso.FormattingEnabled = true;
            this.CmbCurso.Location = new System.Drawing.Point(151, 124);
            this.CmbCurso.Name = "CmbCurso";
            this.CmbCurso.Size = new System.Drawing.Size(121, 21);
            this.CmbCurso.TabIndex = 1;
            this.CmbCurso.SelectedIndexChanged += new System.EventHandler(this.CmbCurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(151, 220);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(121, 20);
            this.TxtPrecio.TabIndex = 3;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.White;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BtnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(141, 295);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 78);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(151, 177);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(121, 20);
            this.TxtCodigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo";
            // 
            // FrmModificarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCurso);
            this.Controls.Add(this.label1);
            this.Name = "FrmModificarCurso";
            this.Text = "FrmModificarCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
    }
}