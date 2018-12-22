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
    public partial class Form1 : Form{
        String dosyaYolu;
        public Form1(){
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e){

        }

        private void button2_Click(object sender, EventArgs e){ 
            if (dosyaYolu == null){
                MessageBox.Show("Önce resim seçiniz.", "Hata");
            }
            else{ 
            Islem i1 = new Islem(dosyaYolu);
            i1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e){
            openFileDialog1.Filter = "jpg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp |jpeg dosyası(*.jpeg)|*.jpeg|GIF dosyası(*.gif)|*.gif|PNG dosyası(*.png)|*.png"; 
            if (DialogResult.OK==openFileDialog1.ShowDialog()){
                dosyaYolu= openFileDialog1.FileName;  
                Bitmap b1 = new Bitmap(dosyaYolu);
                if (b1.Width <= 1000 && b1.Height <= 1000){
                    pictureBox1.Image = b1;
                }
                else{
                    MessageBox.Show("Seçilen Resmin Boyutu Çok Büyüktür","Hata");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
