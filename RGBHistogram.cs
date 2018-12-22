using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_1
{
    public partial class RGBHistogram : Form
    {
        int[] KirmiziHistogramDegerler = new int[256];
        int[] YesilHistogramDegerler = new int[256];
        int[] MaviHistogramDegerler = new int[256];

        public RGBHistogram(int[] Kirmizi, int[] Yesil, int[] Mavi)
        {
            KirmiziHistogramDegerler = Kirmizi;
            YesilHistogramDegerler = Yesil;
            MaviHistogramDegerler = Mavi;
            InitializeComponent();
        }

        private void RGBHistogram_Load(object sender, EventArgs e)
        {
            chartRGB.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartRGB.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            int deger = KirmiziHistogramDegerler.Length;

            for (int i = 0; i < deger; i++)
            {
                
                chartRGB.Series["Kırmızı"].Points.Add(KirmiziHistogramDegerler[i]);
                chartRGB.Series["Yesil"].Points.Add(YesilHistogramDegerler[i]);
                chartRGB.Series["Mavi"].Points.Add(MaviHistogramDegerler[i]);
            }

        }
    }
}
