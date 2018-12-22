namespace YazLab1_1
{
    partial class Histogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartgri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartyesil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartmavi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartkirmizi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartgri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartyesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartkirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartgri
            // 
            chartArea1.Name = "ChartArea1";
            this.chartgri.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartgri.Legends.Add(legend1);
            this.chartgri.Location = new System.Drawing.Point(0, 0);
            this.chartgri.Name = "chartgri";
            this.chartgri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.Name = "Gri";
            this.chartgri.Series.Add(series1);
            this.chartgri.Size = new System.Drawing.Size(645, 360);
            this.chartgri.TabIndex = 0;
            this.chartgri.Text = "chart1";
            this.chartgri.Click += new System.EventHandler(this.chartgri_Click);
            // 
            // chartyesil
            // 
            chartArea2.Name = "ChartArea1";
            this.chartyesil.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartyesil.Legends.Add(legend2);
            this.chartyesil.Location = new System.Drawing.Point(0, 365);
            this.chartyesil.Name = "chartyesil";
            this.chartyesil.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Yesil";
            this.chartyesil.Series.Add(series2);
            this.chartyesil.Size = new System.Drawing.Size(645, 360);
            this.chartyesil.TabIndex = 2;
            this.chartyesil.Text = "chart2";
            // 
            // chartmavi
            // 
            chartArea3.Name = "ChartArea1";
            this.chartmavi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartmavi.Legends.Add(legend3);
            this.chartmavi.Location = new System.Drawing.Point(686, 365);
            this.chartmavi.Name = "chartmavi";
            this.chartmavi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Mavi";
            this.chartmavi.Series.Add(series3);
            this.chartmavi.Size = new System.Drawing.Size(645, 360);
            this.chartmavi.TabIndex = 3;
            this.chartmavi.Text = "chart3";
            // 
            // chartkirmizi
            // 
            chartArea4.Name = "ChartArea1";
            this.chartkirmizi.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartkirmizi.Legends.Add(legend4);
            this.chartkirmizi.Location = new System.Drawing.Point(686, 0);
            this.chartkirmizi.Name = "chartkirmizi";
            this.chartkirmizi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Kırmızı";
            this.chartkirmizi.Series.Add(series4);
            this.chartkirmizi.Size = new System.Drawing.Size(645, 360);
            this.chartkirmizi.TabIndex = 4;
            this.chartkirmizi.Text = "chart4";
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 736);
            this.Controls.Add(this.chartkirmizi);
            this.Controls.Add(this.chartmavi);
            this.Controls.Add(this.chartyesil);
            this.Controls.Add(this.chartgri);
            this.Name = "Histogram";
            this.Text = "Histogramlar";
            this.Load += new System.EventHandler(this.Histogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartgri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartyesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartkirmizi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartgri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartyesil;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmavi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartkirmizi;
    }
}