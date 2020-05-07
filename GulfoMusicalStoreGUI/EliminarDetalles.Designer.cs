namespace GulfoMusicalStoreGUI
{
    partial class EliminarDetalles
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
            this.CmbEliminar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAcustica = new System.Windows.Forms.ComboBox();
            this.labelAcustica = new System.Windows.Forms.Label();
            this.labelElectrica = new System.Windows.Forms.Label();
            this.labelPiano = new System.Windows.Forms.Label();
            this.labelBajo = new System.Windows.Forms.Label();
            this.CmbElectrica = new System.Windows.Forms.ComboBox();
            this.CmbPiano = new System.Windows.Forms.ComboBox();
            this.CmbBajo = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.TxtTotalCursosAcusticas = new System.Windows.Forms.TextBox();
            this.TxtElectrica = new System.Windows.Forms.TextBox();
            this.TxtPiano = new System.Windows.Forms.TextBox();
            this.TxtBajo = new System.Windows.Forms.TextBox();
            this.CmbCursos = new System.Windows.Forms.ComboBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelTotalEliminar = new System.Windows.Forms.Label();
            this.CmbEliminarCursos = new System.Windows.Forms.ComboBox();
            this.labelProductos = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbEliminar
            // 
            this.CmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEliminar.FormattingEnabled = true;
            this.CmbEliminar.Items.AddRange(new object[] {
            "Productos",
            "Cursos"});
            this.CmbEliminar.Location = new System.Drawing.Point(159, 76);
            this.CmbEliminar.Name = "CmbEliminar";
            this.CmbEliminar.Size = new System.Drawing.Size(121, 21);
            this.CmbEliminar.TabIndex = 0;
            this.CmbEliminar.SelectedIndexChanged += new System.EventHandler(this.CmbEliminar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliminar";
            // 
            // CmbAcustica
            // 
            this.CmbAcustica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAcustica.FormattingEnabled = true;
            this.CmbAcustica.Location = new System.Drawing.Point(103, 141);
            this.CmbAcustica.Name = "CmbAcustica";
            this.CmbAcustica.Size = new System.Drawing.Size(121, 21);
            this.CmbAcustica.TabIndex = 2;
            // 
            // labelAcustica
            // 
            this.labelAcustica.AutoSize = true;
            this.labelAcustica.Location = new System.Drawing.Point(12, 144);
            this.labelAcustica.Name = "labelAcustica";
            this.labelAcustica.Size = new System.Drawing.Size(85, 13);
            this.labelAcustica.TabIndex = 3;
            this.labelAcustica.Text = "GuitarraAcustica";
            // 
            // labelElectrica
            // 
            this.labelElectrica.AutoSize = true;
            this.labelElectrica.Location = new System.Drawing.Point(12, 203);
            this.labelElectrica.Name = "labelElectrica";
            this.labelElectrica.Size = new System.Drawing.Size(85, 13);
            this.labelElectrica.TabIndex = 4;
            this.labelElectrica.Text = "GuitarraElectrica";
            // 
            // labelPiano
            // 
            this.labelPiano.AutoSize = true;
            this.labelPiano.Location = new System.Drawing.Point(12, 245);
            this.labelPiano.Name = "labelPiano";
            this.labelPiano.Size = new System.Drawing.Size(34, 13);
            this.labelPiano.TabIndex = 5;
            this.labelPiano.Text = "Piano";
            // 
            // labelBajo
            // 
            this.labelBajo.AutoSize = true;
            this.labelBajo.Location = new System.Drawing.Point(13, 290);
            this.labelBajo.Name = "labelBajo";
            this.labelBajo.Size = new System.Drawing.Size(28, 13);
            this.labelBajo.TabIndex = 6;
            this.labelBajo.Text = "Bajo";
            // 
            // CmbElectrica
            // 
            this.CmbElectrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbElectrica.FormattingEnabled = true;
            this.CmbElectrica.Location = new System.Drawing.Point(103, 200);
            this.CmbElectrica.Name = "CmbElectrica";
            this.CmbElectrica.Size = new System.Drawing.Size(121, 21);
            this.CmbElectrica.TabIndex = 7;
            // 
            // CmbPiano
            // 
            this.CmbPiano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPiano.FormattingEnabled = true;
            this.CmbPiano.Location = new System.Drawing.Point(103, 245);
            this.CmbPiano.Name = "CmbPiano";
            this.CmbPiano.Size = new System.Drawing.Size(121, 21);
            this.CmbPiano.TabIndex = 8;
            // 
            // CmbBajo
            // 
            this.CmbBajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBajo.FormattingEnabled = true;
            this.CmbBajo.Location = new System.Drawing.Point(103, 290);
            this.CmbBajo.Name = "CmbBajo";
            this.CmbBajo.Size = new System.Drawing.Size(121, 21);
            this.CmbBajo.TabIndex = 9;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(249, 122);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total";
            // 
            // TxtTotalCursosAcusticas
            // 
            this.TxtTotalCursosAcusticas.Enabled = false;
            this.TxtTotalCursosAcusticas.Location = new System.Drawing.Point(252, 141);
            this.TxtTotalCursosAcusticas.Name = "TxtTotalCursosAcusticas";
            this.TxtTotalCursosAcusticas.Size = new System.Drawing.Size(50, 20);
            this.TxtTotalCursosAcusticas.TabIndex = 11;
            // 
            // TxtElectrica
            // 
            this.TxtElectrica.Enabled = false;
            this.TxtElectrica.Location = new System.Drawing.Point(252, 200);
            this.TxtElectrica.Name = "TxtElectrica";
            this.TxtElectrica.Size = new System.Drawing.Size(50, 20);
            this.TxtElectrica.TabIndex = 12;
            // 
            // TxtPiano
            // 
            this.TxtPiano.Enabled = false;
            this.TxtPiano.Location = new System.Drawing.Point(252, 246);
            this.TxtPiano.Name = "TxtPiano";
            this.TxtPiano.Size = new System.Drawing.Size(50, 20);
            this.TxtPiano.TabIndex = 13;
            // 
            // TxtBajo
            // 
            this.TxtBajo.Enabled = false;
            this.TxtBajo.Location = new System.Drawing.Point(252, 291);
            this.TxtBajo.Name = "TxtBajo";
            this.TxtBajo.Size = new System.Drawing.Size(50, 20);
            this.TxtBajo.TabIndex = 14;
            // 
            // CmbCursos
            // 
            this.CmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCursos.FormattingEnabled = true;
            this.CmbCursos.Location = new System.Drawing.Point(338, 140);
            this.CmbCursos.Name = "CmbCursos";
            this.CmbCursos.Size = new System.Drawing.Size(121, 21);
            this.CmbCursos.TabIndex = 15;
            this.CmbCursos.SelectedIndexChanged += new System.EventHandler(this.CmbCursos_SelectedIndexChanged);
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(338, 121);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(39, 13);
            this.labelCurso.TabIndex = 16;
            this.labelCurso.Text = "Cursos";
            // 
            // labelTotalEliminar
            // 
            this.labelTotalEliminar.AutoSize = true;
            this.labelTotalEliminar.Location = new System.Drawing.Point(341, 189);
            this.labelTotalEliminar.Name = "labelTotalEliminar";
            this.labelTotalEliminar.Size = new System.Drawing.Size(70, 13);
            this.labelTotalEliminar.TabIndex = 17;
            this.labelTotalEliminar.Text = "Total Eliminar";
            // 
            // CmbEliminarCursos
            // 
            this.CmbEliminarCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEliminarCursos.FormattingEnabled = true;
            this.CmbEliminarCursos.Location = new System.Drawing.Point(344, 223);
            this.CmbEliminarCursos.Name = "CmbEliminarCursos";
            this.CmbEliminarCursos.Size = new System.Drawing.Size(121, 21);
            this.CmbEliminarCursos.TabIndex = 18;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(44, 108);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(55, 13);
            this.labelProductos.TabIndex = 19;
            this.labelProductos.Text = "Productos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(159, 357);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // EliminarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.CmbEliminarCursos);
            this.Controls.Add(this.labelTotalEliminar);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.CmbCursos);
            this.Controls.Add(this.TxtBajo);
            this.Controls.Add(this.TxtPiano);
            this.Controls.Add(this.TxtElectrica);
            this.Controls.Add(this.TxtTotalCursosAcusticas);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.CmbBajo);
            this.Controls.Add(this.CmbPiano);
            this.Controls.Add(this.CmbElectrica);
            this.Controls.Add(this.labelBajo);
            this.Controls.Add(this.labelPiano);
            this.Controls.Add(this.labelElectrica);
            this.Controls.Add(this.labelAcustica);
            this.Controls.Add(this.CmbAcustica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbEliminar);
            this.Name = "EliminarDetalles";
            this.Text = "EliminarDetalles";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAcustica;
        private System.Windows.Forms.Label labelAcustica;
        private System.Windows.Forms.Label labelElectrica;
        private System.Windows.Forms.Label labelPiano;
        private System.Windows.Forms.Label labelBajo;
        private System.Windows.Forms.ComboBox CmbElectrica;
        private System.Windows.Forms.ComboBox CmbPiano;
        private System.Windows.Forms.ComboBox CmbBajo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox TxtTotalCursosAcusticas;
        private System.Windows.Forms.TextBox TxtElectrica;
        private System.Windows.Forms.TextBox TxtPiano;
        private System.Windows.Forms.TextBox TxtBajo;
        private System.Windows.Forms.ComboBox CmbCursos;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelTotalEliminar;
        private System.Windows.Forms.ComboBox CmbEliminarCursos;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Button BtnEliminar;
    }
}