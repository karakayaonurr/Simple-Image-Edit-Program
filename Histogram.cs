using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_1{
    public partial class Histogram : Form{

        int[] GriHistogramDegerler = new int[256];
        int[] KirmiziHistogramDegerler = new int[256];
        int[] YesilHistogramDegerler = new int[256];
        int[] MaviHistogramDegerler = new int[256];

        public Histogram(int [] Gri, int []Kirmizi, int []Yesil, int[] Mavi){

            GriHistogramDegerler = Gri;
            KirmiziHistogramDegerler = Kirmizi;
            YesilHistogramDegerler = Yesil;
            MaviHistogramDegerler = Mavi;
            InitializeComponent();
        }

        private void Histogram_Load(object sender, EventArgs e){

            chartgri.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartgri.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            chartkirmizi.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartkirmizi.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            chartyesil.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartyesil.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            chartmavi.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartmavi.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            int deger = GriHistogramDegerler.Length;

            for (int i = 0; i < deger; i++){
               
                chartgri.Series["Gri"].Points.Add(GriHistogramDegerler[i]);
                chartkirmizi.Series["Kırmızı"].Points.Add(KirmiziHistogramDegerler[i]);
                chartyesil.Series["Yesil"].Points.Add(YesilHistogramDegerler[i]);
                chartmavi.Series["Mavi"].Points.Add(MaviHistogramDegerler[i]);
            }
        }

        private void chartgri_Click(object sender, EventArgs e)
        {

        }
    }
}
