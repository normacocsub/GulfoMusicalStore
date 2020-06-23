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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LabelRecuperarContraseña = new System.Windows.Forms.Label();
            this.PBVerContraseña = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelLogin.Controls.Add(this.pictureBox1);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelLogin.Size = new System.Drawing.Size(200, 400);
            this.PanelLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(32, 93);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(135, 73);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Iniciar Sesión";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(271, 287);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(209, 39);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
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
            this.LabelRecuperarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecuperarContraseña.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelRecuperarContraseña.Location = new System.Drawing.Point(271, 329);
            this.LabelRecuperarContraseña.Name = "LabelRecuperarContraseña";
            this.LabelRecuperarContraseña.Size = new System.Drawing.Size(209, 47);
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
            this.PBVerContraseña.Location = new System.Drawing.Point(497, 159);
            this.PBVerContraseña.Name = "PBVerContraseña";
            this.PBVerContraseña.Size = new System.Drawing.Size(32, 29);
            this.PBVerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBVerContraseña.TabIndex = 30;
            this.PBVerContraseña.TabStop = false;
            this.PBVerContraseña.Click += new System.EventHandler(this.PBVerContraseña_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.Location = new System.Drawing.Point(225, 97);
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(304, 23);
            this.TxtUsuario.TabIndex = 31;
            this.TxtUsuario.UseSystemPasswordChar = false;
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Depth = 0;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TxtContraseña.Hint = "Contraseña";
            this.TxtContraseña.Location = new System.Drawing.Point(225, 165);
            this.TxtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '\0';
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.SelectionLength = 0;
            this.TxtContraseña.SelectionStart = 0;
            this.TxtContraseña.Size = new System.Drawing.Size(266, 23);
            this.TxtContraseña.TabIndex = 32;
            this.TxtContraseña.UseSystemPasswordChar = false;
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PBVerContraseña);
            this.Controls.Add(this.LabelRecuperarContraseña);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.PanelLogin);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LabelRecuperarContraseña;
        private System.Windows.Forms.PictureBox PBVerContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtContraseña;
    }
}

