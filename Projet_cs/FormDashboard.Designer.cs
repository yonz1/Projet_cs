﻿namespace Projet_cs
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_scanned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox_lastimported = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_scanned)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_scanned
            // 
            this.chart_scanned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_scanned.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chart_scanned.BorderlineColor = System.Drawing.SystemColors.WindowText;
            this.chart_scanned.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart_scanned.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_scanned.Legends.Add(legend1);
            this.chart_scanned.Location = new System.Drawing.Point(46, 133);
            this.chart_scanned.Name = "chart_scanned";
            this.chart_scanned.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_scanned.Series.Add(series1);
            this.chart_scanned.Size = new System.Drawing.Size(385, 277);
            this.chart_scanned.TabIndex = 0;
            this.chart_scanned.Text = "chart1";
            this.chart_scanned.Click += new System.EventHandler(this.chart1_Click);
            // 
            // listBox_lastimported
            // 
            this.listBox_lastimported.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_lastimported.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_lastimported.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_lastimported.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_lastimported.FormattingEnabled = true;
            this.listBox_lastimported.ItemHeight = 20;
            this.listBox_lastimported.Location = new System.Drawing.Point(454, 133);
            this.listBox_lastimported.Name = "listBox_lastimported";
            this.listBox_lastimported.Size = new System.Drawing.Size(305, 264);
            this.listBox_lastimported.TabIndex = 1;
            this.listBox_lastimported.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.listBox_lastimported);
            this.Controls.Add(this.chart_scanned);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart_scanned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_scanned;
        private System.Windows.Forms.ListBox listBox_lastimported;
    }
}