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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.BtnFiltar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.GBTime.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.Controls.Add(this.BtnFiltar);
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
            // BtnFiltar
            // 
            this.BtnFiltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltar.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFiltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiltar.Image")));
            this.BtnFiltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFiltar.Location = new System.Drawing.Point(605, 483);
            this.BtnFiltar.Name = "BtnFiltar";
            this.BtnFiltar.Size = new System.Drawing.Size(181, 50);
            this.BtnFiltar.TabIndex = 99;
            this.BtnFiltar.Text = "Generar Informe";
            this.BtnFiltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiltar.UseVisualStyleBackColor = true;
            this.BtnFiltar.Click += new System.EventHandler(this.BtnFiltar_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.White;
            this.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTotal.Location = new System.Drawing.Point(408, 152);
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
            this.LabelCantidad.Location = new System.Drawing.Point(10, 152);
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
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.Name = "ChartArea1";
            this.Chart2.ChartAreas.Add(chartArea1);
            this.Chart2.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.Chart2.Legends.Add(legend1);
            this.Chart2.Location = new System.Drawing.Point(9, 86);
            this.Chart2.Margin = new System.Windows.Forms.Padding(0);
            this.Chart2.Name = "Chart2";
            this.Chart2.Size = new System.Drawing.Size(381, 389);
            this.Chart2.TabIndex = 8;
            this.Chart2.Text = "chart1";
            // 
            // Chart1
            // 
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(405, 87);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(381, 389);
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
            this.GBTime.Location = new System.Drawing.Point(108, 3);
            this.GBTime.Name = "GBTime";
            this.GBTime.Size = new System.Drawing.Size(581, 78);
            this.GBTime.TabIndex = 98;
            this.GBTime.TabStop = false;
            this.GBTime.Text = "Time";
            // 
            // LabelHasta
            // 
            this.LabelHasta.AutoSize = true;
            this.LabelHasta.Location = new System.Drawing.Point(246, 25);
            this.LabelHasta.Name = "LabelHasta";
            this.LabelHasta.Size = new System.Drawing.Size(35, 13);
            this.LabelHasta.TabIndex = 99;
            this.LabelHasta.Text = "Hasta";
            // 
            // LabelDesde
            // 
            this.LabelDesde.AutoSize = true;
            this.LabelDesde.Location = new System.Drawing.Point(16, 25);
            this.LabelDesde.Name = "LabelDesde";
            this.LabelDesde.Size = new System.Drawing.Size(38, 13);
            this.LabelDesde.TabIndex = 98;
            this.LabelDesde.Text = "Desde";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(481, 41);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 20);
            this.BtnFiltrar.TabIndex = 97;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // DtpDesde
            // 
            this.DtpDesde.Location = new System.Drawing.Point(16, 41);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(214, 20);
            this.DtpDesde.TabIndex = 95;
            // 
            // DtpHasta
            // 
            this.DtpHasta.Location = new System.Drawing.Point(249, 41);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(214, 20);
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
            this.LabelTitulo.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold);
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
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.GBTime.ResumeLayout(false);
            this.GBTime.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button BtnFiltar;
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
    }
}