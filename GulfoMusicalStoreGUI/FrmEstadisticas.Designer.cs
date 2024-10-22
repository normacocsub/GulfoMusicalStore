﻿namespace GulfoMusicalStoreGUI
{
    partial class FrmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabelFacturasTotal = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GBTime = new System.Windows.Forms.GroupBox();
            this.LabelHasta = new System.Windows.Forms.Label();
            this.LabelDesde = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.GBTime.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.Controls.Add(this.LabelFacturasTotal);
            this.Panel2.Controls.Add(this.chart3);
            this.Panel2.Controls.Add(this.LabelTotal);
            this.Panel2.Controls.Add(this.LabelCantidad);
            this.Panel2.Controls.Add(this.Chart2);
            this.Panel2.Controls.Add(this.Chart1);
            this.Panel2.Controls.Add(this.GBTime);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 60);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(800, 540);
            this.Panel2.TabIndex = 10;
            // 
            // LabelFacturasTotal
            // 
            this.LabelFacturasTotal.BackColor = System.Drawing.Color.White;
            this.LabelFacturasTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelFacturasTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelFacturasTotal.Location = new System.Drawing.Point(688, 195);
            this.LabelFacturasTotal.Name = "LabelFacturasTotal";
            this.LabelFacturasTotal.Size = new System.Drawing.Size(100, 23);
            this.LabelFacturasTotal.TabIndex = 101;
            this.LabelFacturasTotal.Text = "0";
            this.LabelFacturasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart3
            // 
            this.chart3.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(530, 139);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(258, 389);
            this.chart3.TabIndex = 100;
            this.chart3.Text = "chart1";
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.White;
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTotal.Location = new System.Drawing.Point(397, 195);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(120, 23);
            this.LabelTotal.TabIndex = 94;
            this.LabelTotal.Text = "0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCantidad
            // 
            this.LabelCantidad.BackColor = System.Drawing.Color.White;
            this.LabelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCantidad.Location = new System.Drawing.Point(158, 195);
            this.LabelCantidad.Name = "LabelCantidad";
            this.LabelCantidad.Size = new System.Drawing.Size(86, 23);
            this.LabelCantidad.TabIndex = 93;
            this.LabelCantidad.Text = "0";
            this.LabelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chart2
            // 
            this.Chart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Chart2.BorderlineWidth = 0;
            this.Chart2.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.Chart2.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart2.BorderSkin.BorderWidth = 0;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.Name = "ChartArea1";
            this.Chart2.ChartAreas.Add(chartArea2);
            this.Chart2.IsSoftShadows = false;
            legend2.Name = "Legend1";
            this.Chart2.Legends.Add(legend2);
            this.Chart2.Location = new System.Drawing.Point(9, 139);
            this.Chart2.Margin = new System.Windows.Forms.Padding(0);
            this.Chart2.Name = "Chart2";
            this.Chart2.Size = new System.Drawing.Size(235, 389);
            this.Chart2.TabIndex = 8;
            this.Chart2.Text = "chart1";
            // 
            // Chart1
            // 
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea3.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart1.Legends.Add(legend3);
            this.Chart1.Location = new System.Drawing.Point(260, 139);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(257, 389);
            this.Chart1.TabIndex = 7;
            this.Chart1.Text = "chart1";
            // 
            // GBTime
            // 
            this.GBTime.Controls.Add(this.LabelHasta);
            this.GBTime.Controls.Add(this.LabelDesde);
            this.GBTime.Controls.Add(this.BtnFiltrar);
            this.GBTime.Controls.Add(this.DtpDesde);
            this.GBTime.Controls.Add(this.DtpHasta);
            this.GBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTime.Location = new System.Drawing.Point(12, 3);
            this.GBTime.Name = "GBTime";
            this.GBTime.Size = new System.Drawing.Size(776, 130);
            this.GBTime.TabIndex = 98;
            this.GBTime.TabStop = false;
            this.GBTime.Text = "Time";
            // 
            // LabelHasta
            // 
            this.LabelHasta.AutoSize = true;
            this.LabelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHasta.Location = new System.Drawing.Point(146, 75);
            this.LabelHasta.Name = "LabelHasta";
            this.LabelHasta.Size = new System.Drawing.Size(49, 16);
            this.LabelHasta.TabIndex = 99;
            this.LabelHasta.Text = "Hasta";
            // 
            // LabelDesde
            // 
            this.LabelDesde.AutoSize = true;
            this.LabelDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesde.Location = new System.Drawing.Point(146, 18);
            this.LabelDesde.Name = "LabelDesde";
            this.LabelDesde.Size = new System.Drawing.Size(54, 16);
            this.LabelDesde.TabIndex = 98;
            this.LabelDesde.Text = "Desde";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiltrar.Image")));
            this.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFiltrar.Location = new System.Drawing.Point(524, 24);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(107, 91);
            this.BtnFiltrar.TabIndex = 97;
            this.BtnFiltrar.Text = "Filtrar Fecha";
            this.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // DtpDesde
            // 
            this.DtpDesde.Location = new System.Drawing.Point(146, 37);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(292, 22);
            this.DtpDesde.TabIndex = 95;
            // 
            // DtpHasta
            // 
            this.DtpHasta.Location = new System.Drawing.Point(146, 94);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(294, 22);
            this.DtpHasta.TabIndex = 96;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.LabelTitulo);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 60);
            this.Panel1.TabIndex = 9;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.BackColor = System.Drawing.Color.White;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelTitulo.Location = new System.Drawing.Point(268, 11);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(260, 34);
            this.LabelTitulo.TabIndex = 23;
            this.LabelTitulo.Text = "Estadistica";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticas";
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.GBTime.ResumeLayout(false);
            this.GBTime.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelCantidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.GroupBox GBTime;
        private System.Windows.Forms.Label LabelHasta;
        private System.Windows.Forms.Label LabelDesde;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label LabelFacturasTotal;
    }
}