namespace YazLab1_1
{
    partial class RGBHistogram
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRGB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRGB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRGB.Legends.Add(legend1);
            this.chartRGB.Location = new System.Drawing.Point(12, 12);
            this.chartRGB.Name = "chartRGB";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Kırmızı";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Yesil";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Mavi";
            this.chartRGB.Series.Add(series1);
            this.chartRGB.Series.Add(series2);
            this.chartRGB.Series.Add(series3);
            this.chartRGB.Size = new System.Drawing.Size(1021, 550);
            this.chartRGB.TabIndex = 0;
            this.chartRGB.Text = "chart1";
            // 
            // RGBHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 574);
            this.Controls.Add(this.chartRGB);
            this.Name = "RGBHistogram";
            this.Text = "RGBHistogram";
            this.Load += new System.EventHandler(this.RGBHistogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRGB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRGB;
    }
}