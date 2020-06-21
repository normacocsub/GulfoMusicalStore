namespace GulfoMusicalStoreGUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LabelRecuperarContraseña = new System.Windows.Forms.Label();
            this.PBVerContraseña = new System.Windows.Forms.PictureBox();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelLogin.Size = new System.Drawing.Size(200, 400);
            this.PanelLogin.TabIndex = 0;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.Location = new System.Drawing.Point(3, 122);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(194, 156);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Iniciar Sesión";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(225, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 3);
            this.label3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(225, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 3);
            this.label2.TabIndex = 22;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(225, 287);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(304, 39);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtContraseña.BackColor = System.Drawing.Color.White;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContraseña.Location = new System.Drawing.Point(225, 156);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(304, 25);
            this.TxtContraseña.TabIndex = 30;
            this.TxtContraseña.Text = "Contraseña";
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(225, 88);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(304, 25);
            this.TxtUsuario.TabIndex = 20;
            this.TxtUsuario.Text = "Administrador";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(492, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 34);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LabelRecuperarContraseña
            // 
            this.LabelRecuperarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRecuperarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelRecuperarContraseña.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecuperarContraseña.Location = new System.Drawing.Point(221, 329);
            this.LabelRecuperarContraseña.Name = "LabelRecuperarContraseña";
            this.LabelRecuperarContraseña.Size = new System.Drawing.Size(308, 47);
            this.LabelRecuperarContraseña.TabIndex = 0;
            this.LabelRecuperarContraseña.Text = "< Recuperar contraseña >";
            this.LabelRecuperarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRecuperarContraseña.Click += new System.EventHandler(this.LabelRecuperarContraseña_Click);
            // 
            // PBVerContraseña
            // 
            this.PBVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBVerContraseña.Image = ((System.Drawing.Image)(resources.GetObject("PBVerContraseña.Image")));
            this.PBVerContraseña.InitialImage = null;
            this.PBVerContraseña.Location = new System.Drawing.Point(497, 153);
            this.PBVerContraseña.Name = "PBVerContraseña";
            this.PBVerContraseña.Size = new System.Drawing.Size(32, 29);
            this.PBVerContraseña.TabIndex = 30;
            this.PBVerContraseña.TabStop = false;
            this.PBVerContraseña.Click += new System.EventHandler(this.PBVerContraseña_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.PBVerContraseña);
            this.Controls.Add(this.LabelRecuperarContraseña);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LabelRecuperarContraseña;
        private System.Windows.Forms.PictureBox PBVerContraseña;
    }
}

