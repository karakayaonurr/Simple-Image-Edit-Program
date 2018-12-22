using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace YazLab1_1{
    public partial class Islem : Form{

        public string DosyaYolu;
        Bitmap enSonHali;
        Bitmap b1;
        int[] GriPixel;
        int[] KirmiziPiksel;
        int[] YesilPiksel;
        int[] MaviPiksel;

        

        public void GriHistogram(Bitmap resmim){
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height;j++ ){
                    Color c1 = resmim.GetPixel(i, j);
                    int ortDeger = (c1.R + c1.G + c1.B)/3;
                    GriPixel[ortDeger] += 1;
                }
            }
        }

        public void KirmiziHistogram(Bitmap resmim){
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){

                    Color c1 = resmim.GetPixel(i, j);
                    int kirmiziDeger=c1.R;
                    KirmiziPiksel[kirmiziDeger] += 1;
                }
            }
        }

        public void YesilHistogram(Bitmap resmim){
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){   
                    Color c1 = resmim.GetPixel(i, j);
                    int yesilDeger = c1.G;
                    YesilPiksel[yesilDeger] += 1;
                }
            }
        }

        public void MaviHistogram(Bitmap resmim){
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    int maviDeger = c1.B;
                    MaviPiksel[maviDeger] += 1;
                }
            }
        }

        private static Bitmap YenidenBoyutlandir(Bitmap mg, Size newSize){

            double ratio = 0d;
            double myThumbWidth = 0d;
            double myThumbHeight = 0d;
            int x = 0;
            int y = 0;
            Bitmap bp;

            if((mg.Width / Convert.ToDouble(newSize.Width)) > (mg.Height /
            Convert.ToDouble(newSize.Height)))
            ratio = Convert.ToDouble(mg.Width) / Convert.ToDouble(newSize.Width);
            else
            ratio = Convert.ToDouble(mg.Height) / Convert.ToDouble(newSize.Height);
            myThumbHeight = Math.Ceiling(mg.Height / ratio);
            myThumbWidth = Math.Ceiling(mg.Width / ratio);

            Size thumbSize = new Size((int)myThumbWidth, (int)myThumbHeight);
            bp = new Bitmap(newSize.Width, newSize.Height);
            x = (newSize.Width - thumbSize.Width) / 2;
            y = (newSize.Height - thumbSize.Height);

            System.Drawing.Graphics g = Graphics.FromImage(bp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            Rectangle rect = new Rectangle(x, y, thumbSize.Width, thumbSize.Height);
            g.DrawImage(mg, rect, 0, 0, mg.Width, mg.Height, GraphicsUnit.Pixel);

            return bp;
        }

        public Bitmap Olceklendirme(Bitmap resmim,double genislikOrani,double yukseklikOrani){
            Bitmap olceklendirilmis =  YenidenBoyutlandir(resmim, new Size((int)(genislikOrani* resmim.Width), (int)(yukseklikOrani *resmim.Height)));
            olceklendirilmis.SetResolution(resmim.HorizontalResolution,resmim.VerticalResolution);
            return olceklendirilmis;
        }
      
        public Bitmap SolaAynalama(Bitmap resmim){
            Bitmap SolaAynalanmis = new Bitmap(resmim.Width * 2, resmim.Height);
            for(int i = 0; i < resmim.Width; i++){
                for(int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    SolaAynalanmis.SetPixel(resmim.Width - 1 +i, j, c1);
                }
            }
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    SolaAynalanmis.SetPixel(resmim.Width - 1 - i, j, c1);
                }
            }
            return SolaAynalanmis;
        }

        public Bitmap SagaAynalama(Bitmap resmim) {
            Bitmap SagaAynalanmis = new Bitmap(resmim.Width*2 , resmim.Height);
            for (int i = 0; i < resmim.Width; i++){
                for(int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    SagaAynalanmis.SetPixel(i, j, c1);
                }
            }
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    SagaAynalanmis.SetPixel(resmim.Width * 2 - 1 - i, j, c1);
                }
            }
            return SagaAynalanmis;
        }

        public Bitmap KirmiziKanal(Bitmap resmim){
            Bitmap KirmiziKanalHali = new Bitmap(resmim.Width, resmim.Height);
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    int reddegeri = c1.R;
                    Color c2;
                    c2 = Color.FromArgb(reddegeri, 0, 0);
                    KirmiziKanalHali.SetPixel(i, j, c2);
                }
            }
            return KirmiziKanalHali;
        }

        public Bitmap YesilKanal(Bitmap resmim){
            Bitmap YesilKanalHali = new Bitmap(resmim.Width, resmim.Height);
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    int greendegeri = c1.G;
                    Color c2;
                    c2 = Color.FromArgb(0, greendegeri, 0);
                    YesilKanalHali.SetPixel(i, j, c2);
                }
            }
            return YesilKanalHali;
        }

        public Bitmap MaviKanal(Bitmap resmim){
            Bitmap MaviKanalHali = new Bitmap(resmim.Width, resmim.Height);
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1 = resmim.GetPixel(i, j);
                    int bluedegeri = c1.B;
                    Color c2;
                    c2 = Color.FromArgb(0, 0, bluedegeri);
                    MaviKanalHali.SetPixel(i, j, c2);
                }
            }
            return MaviKanalHali;
        }

        public Bitmap YenidenAcma(){
            Bitmap YenidenAcilan = new Bitmap(b1.Width, b1.Height);
            for (int i = 0; i < b1.Width; i++){
                for (int j = 0; j < b1.Height; j++){
                    Color c1 = b1.GetPixel(i, j);
                    YenidenAcilan.SetPixel(i, j, c1);
                }
            }
            return YenidenAcilan;
        }

        public Bitmap Tersleme(Bitmap resmim){
            Bitmap Terslenmis = new Bitmap(resmim.Width, resmim.Height);
            for (int i = 0; i < resmim.Width; i++){
                for (int j = 0; j < resmim.Height; j++){
                    Color c1;
                    c1 = resmim.GetPixel(i, j);
                    Color c2;
                    c2 = Color.FromArgb(255 - c1.R, 255 - c1.G, 255 - c1.B);
                    Terslenmis.SetPixel(i, j, c2);            
                }
            }      
            return Terslenmis;
        }

        public Bitmap DoksanDereceSaga(Bitmap resmim){
            Bitmap SagaDondurulmus = new Bitmap(resmim.Height, resmim.Width);
            for (int y = 0;y < resmim.Height; y++){
                for(int x= 0; x < resmim.Width; x++){
                    Color c1;
                    c1 = resmim.GetPixel(x, y);
                    int YeniY = x;
                    int YeniX = resmim.Height - 1 - y;
                    SagaDondurulmus.SetPixel(YeniX, YeniY, c1);
                }
            }
            return SagaDondurulmus;
        }

        public Bitmap DoksanDereceSola(Bitmap resmim){
            Bitmap SolaDondurulmus = new Bitmap(resmim.Height, resmim.Width);
            for (int x = 0; x < resmim.Width; x++){
                for (int y = 0; y < resmim.Height;y++){
                    Color c1;
                    c1 = resmim.GetPixel(x, y);
                    int YeniX = y;
                    int YeniY = resmim.Width - 1 - x;
                    SolaDondurulmus.SetPixel(YeniX, YeniY, c1);
                }
            }
            return SolaDondurulmus;
        }

        public Bitmap GriTonlama(Bitmap resmim){

            Bitmap GriTonlanmis = new Bitmap(resmim.Width, resmim.Height);
            for(int i = 0; i < resmim.Width; i++){
                for(int j = 0; j < resmim.Height; j++){
                    Color c1;
                    c1 = resmim.GetPixel(i, j);
                    Color c2;
                    int griton = (c1.R + c1.G + c1.B)/3;
                    c2 = Color.FromArgb(griton, griton, griton);
                    GriTonlanmis.SetPixel(i, j, c2);
                }
            }
            return GriTonlanmis;
        }
        
        //aktarma
        public Islem(String dosyaYolu){
            this.DosyaYolu = dosyaYolu;
            b1 = new Bitmap(DosyaYolu);
            enSonHali =b1;
            InitializeComponent();
        }

        //Tersleme
        private void button2_Click(object sender, EventArgs e){
            enSonHali =Tersleme(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Gri tonlama
        private void button9_Click(object sender, EventArgs e){
            enSonHali = GriTonlama(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Doksan derece sağa döndürme
        private void button14_Click(object sender, EventArgs e){
            enSonHali = DoksanDereceSaga(enSonHali);
            int genislik, yukseklik;
            genislik = enSonHali.Width;
            yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;      
            pictureBox1.Image = enSonHali;
        }

        //Doksan derece sola döndürme
        private void button6_Click(object sender, EventArgs e){
            enSonHali = DoksanDereceSola(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Tekrar açma
        private void TekrarAcma_Click(object sender, EventArgs e){
            enSonHali = YenidenAcma();
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
            //pictureBox1.Image = b1;
        }

        //Kırmızı kanal
        private void button10_Click(object sender, EventArgs e){
            enSonHali = KirmiziKanal(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Yeşil kanal
        private void button11_Click(object sender, EventArgs e){
            enSonHali = YesilKanal(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Mavi kanal
        private void button12_Click(object sender, EventArgs e){
            enSonHali = MaviKanal(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Sağa Aynalama
        private void button4_Click(object sender, EventArgs e){
            enSonHali = SagaAynalama(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Sola Aynalama
        private void button3_Click(object sender, EventArgs e){
            enSonHali = SolaAynalama(enSonHali);
            int genislik = enSonHali.Width;
            int yukseklik = enSonHali.Height;
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
            pictureBox1.Image = enSonHali;
        }

        //Ölçeklendirme
        private void button7_Click(object sender, EventArgs e){
            MessageBox.Show("Bu buton internetten hazır alınmıştır. Görmek için yorum satırlarını aktif ediniz.","Uyarı!");
            /*float x, y;
            double oran;
           bool Dogruluk= Double.TryParse(textBox1.Text, out oran);
            if (Dogruluk == true)
            {

                enSonHali = Olceklendirme(enSonHali, oran, oran);
                int genislik = enSonHali.Width;
                int yukseklik = enSonHali.Height;
                pictureBox1.Width = genislik;
                pictureBox1.Height = yukseklik;
                pictureBox1.Image = enSonHali;
            }
            else
            {

                MessageBox.Show("Lütfen Sayı Giriniz!!!", "Hata");

            }*/
        }

        //Histogram
        private void button1_Click(object sender, EventArgs e){
            GriPixel = new int[256];
            GriHistogram(enSonHali);
            KirmiziPiksel = new int[256];
            KirmiziHistogram(enSonHali);
            YesilPiksel = new int[256];
            YesilHistogram(enSonHali);
            MaviPiksel = new int[256];
            MaviHistogram(enSonHali);
            Histogram h1 = new Histogram(GriPixel,KirmiziPiksel,YesilPiksel,MaviPiksel);
            h1.ShowDialog();
        }

        //Kaydetme
        private void button13_Click(object sender, EventArgs e){
            //pictureBox1.Image.Save("D:\\temp.png", ImageFormat.Png);
            SaveFileDialog kaydedilen = new SaveFileDialog();
            kaydedilen.Filter = "jpg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp |jpeg dosyası(*.jpeg)|*.jpeg|GIF dosyası(*.gif)|*.gif|PNG dosyası(*.png)|*.png ";
            kaydedilen.Title = "Kaydetme";
            kaydedilen.FileName = "";
            DialogResult sonuc = kaydedilen.ShowDialog();
            if (sonuc == DialogResult.OK){
                pictureBox1.Image.Save(kaydedilen.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
        }

        //RGB Histogram
        private void button8_Click(object sender, EventArgs e)
        {
            KirmiziPiksel = new int[256];
            KirmiziHistogram(enSonHali);
            YesilPiksel = new int[256];
            YesilHistogram(enSonHali);
            MaviPiksel = new int[256];
            MaviHistogram(enSonHali);
            RGBHistogram h1 = new RGBHistogram(KirmiziPiksel, YesilPiksel, MaviPiksel);
            h1.ShowDialog();
        }
    }
}
