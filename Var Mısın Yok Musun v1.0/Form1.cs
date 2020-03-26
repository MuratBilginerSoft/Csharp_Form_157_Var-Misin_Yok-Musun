using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Var_Mısın_Yok_Musun_v1._0
{
    public partial class Form1 : Form
    {

        #region Değişkenler

        int x1; // yarışmacı yerleştir bay bayan değeri için rastgele değer
        int y1; // bayan resimlerinden hangisinin seçileceğini tutan rastgele değer
        int y2; // Bayan isimlerini getirmek için rastgele değer tutan değişken
        int y3; // Erkek resimlerinden hangisinin seçileceğini tutan rastgele değer
        int y4; // Erkek isimlerini getirmek için rastgele değer tutan değişken
        #endregion


        #region Tanımlamalar

        Label etiket = new Label();
        Label[] etiket1 = new Label[20];
        PictureBox pic = new PictureBox();
        PictureBox[] pic1 = new PictureBox[20];

        Random r = new Random();

        int[] bayanyarışmacı = new int[20];
        int[] erkekyarışmacı = new int[20];

        int[] yarışmacılartümüisim=new int[20];
        int[] yarışmacılartümüresim = new int[20];

        int[] para = { 1,2,5,25,50,100,500,1000,2500,5000,10000,15000,25000,50000,75000,100000,125000,250000,500000,1000000 };

        int[] paradağılımı = new int[20];

        int[] parax=new int[20];

        string[] tümyarışmacılar = { "Ayşe", "Kübra", "Gül", "Gülser", "Gülsüm", "Ece", "Dilara", "Esen", "Zeynep", "Pınar", "Selnur", "Merve", "Derya", "Monica", "Şeyma", "Ceren", "Gülçin", "Gizem", "Dilek", "Özlem", "Murat", "Yaşar", "Kobi", "Ersin", "Selim", "Sadık", "Bekir", "İbrahim", "Koray", "Tuncer", "Ferhat", "Süleyman", "Metin", "Ali", "Sabri", "Yunus", "Mehmet", "Sait", "Yiğit", "Jack" };

        string[] bayanyarışmacıismi = { "Ayşe", "Kübra", "Gül", "Gülser", "Gülsüm", "Ece", "Dilara", "Esen", "Zeynep", "Pınar", "Selnur", "Merve", "Derya", "Monica", "Şeyma", "Ceren", "Gülçin", "Gizem", "Dilek", "Özlem" };
        string[] erkekyarışmacıismi = { "Murat", "Yaşar", "Kobi", "Ersin", "Selim", "Sadık", "Bekir", "İbrahim", "Koray", "Tuncer", "Ferhat", "Süleyman", "Metin", "Ali", "Sabri", "Yunus", "Mehmet", "Sait", "Yiğit", "Jack" };

        string[] yarışmacıresimyol = { "\\1.png", "\\2.png", "\\3.png", "\\4.png", "\\5.png", "\\6.png", "\\7.png", "\\tel.png", };
        #endregion
        #region Metodlar

        public void yarışmacıyerleştir()
        {
           

            for (int i = 0; i < 20; i++)
            {
                x1 = r.Next(0, 7);

                if (x1 == 0 || x1 == 1)
                {
                    y1 = r.Next(0, 2);
                    pic1[i].Image = Image.FromFile(Application.StartupPath + yarışmacıresimyol[y1]);
                    y2 = r.Next(0, 20);
                    etiket1[i].Text = tümyarışmacılar[y2];
                    yarışmacılartümüisim[i] = y2;
                    yarışmacılartümüresim[i] = y1;

                }

                else
                {
                    y3 = r.Next(3, 7);
                    pic1[i].Image = Image.FromFile(Application.StartupPath + yarışmacıresimyol[y3]);
                    y4 = r.Next(20, 39);
                    etiket1[i].Text =tümyarışmacılar[y4];
                    yarışmacılartümüisim[i] = y4;
                    yarışmacılartümüresim[i] = y3;
                }



            }

        }

        public void resimalanı()
        {
            int x1 = 39, y1=73;
            int x2 = 144, y2 = 170;
            int x3 = 39, y3 = 270;
            int x4 = 355, y4 = 373;
            for (int i = 0; i < 20; i++)
            {
                if (i<6)
                {

                    pic1[i] = new PictureBox();
                    pic1[i].Location = new Point(x1, y1);
                    pic1[i].Size = new Size(100, 94);
                    pic1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Controls.Add(pic1[i]);
                    x1 = x1 + 211;
                }


                else if (i>5 && i<11)
                {
                    pic1[i] = new PictureBox();
                    pic1[i].Location = new Point(x2, y2);
                    pic1[i].Size = new Size(100, 94);
                    pic1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Controls.Add(pic1[i]);
                    x2 = x2 + 211;
                }

                else if (i>10 && i<17)
                {
                    pic1[i] = new PictureBox();
                    pic1[i].Location = new Point(x3, y3);
                    pic1[i].Size = new Size(100, 94);
                    pic1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Controls.Add(pic1[i]);
                    x3 = x3 + 211;
                }

                else
                {
                    pic1[i] = new PictureBox();
                    pic1[i].Location = new Point(x4, y4);
                    pic1[i].Size = new Size(100, 94);
                    pic1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    groupBox1.Controls.Add(pic1[i]);
                    x4 = x4 + 211;
                }
            }
           
        
        
        
        }

        public void parabutonsil(int q)
        {
            switch (parax[q])
            {
                case 0: button1.Enabled = false; break;
                case 1: button2.Enabled = false; break;
                case 2: button3.Enabled = false; break;
                case 3: button4.Enabled = false; break;
                case 4: button5.Enabled = false; break;
                case 5: button6.Enabled = false; break;
                case 6: button7.Enabled = false; break;
                case 7: button8.Enabled = false; break;
                case 8: button9.Enabled = false; break;
                case 9: button10.Enabled = false; break;
                case 10: button20.Enabled = false; break;
                case 11: button19.Enabled = false; break;
                case 12: button18.Enabled = false; break;
                case 13: button17.Enabled = false; break;
                case 14: button16.Enabled = false; break;
                case 15: button15.Enabled = false; break;
                case 16: button14.Enabled = false; break;
                case 17: button13.Enabled = false; break;
                case 18: button12.Enabled = false; break;
                case 19: button11.Enabled = false; break;
                
            }
        
        
        }

        public void labeloluştur()
        {

            int x1 = 60, y1 = 51;
            int x2 = 164, y2 = 146;
            int x3 = 60, y3 = 243;
            int x4 = 384, y4 = 350;

            for (int i = 0; i < 20; i++)
            {
                if (i < 6)
                {

                    etiket1[i] = new Label();
                    etiket1[i].Location = new Point(x1, y1);
                    groupBox1.Controls.Add(etiket1[i]);
                    x1 = x1 + 214;
                }


                else if (i > 5 && i < 11)
                {
                    etiket1[i] = new Label();
                    etiket1[i].Location = new Point(x2, y2);
                    groupBox1.Controls.Add(etiket1[i]);
                    x2 = x2 + 214;
                }

                else if (i > 10 && i < 17)
                {
                    etiket1[i] = new Label();
                    etiket1[i].Location = new Point(x3, y3);
                    groupBox1.Controls.Add(etiket1[i]);
                    x3 = x3 + 214;
                }

                else
                {
                    etiket1[i] = new Label();
                    etiket1[i].Location = new Point(x4, y4);
                    groupBox1.Controls.Add(etiket1[i]);
                    x4 = x4 + 214;
                }
            }
        
        
        }

        #endregion



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\acun.png");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\masa.png");
            pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\tel.png");
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            resimalanı();
            labeloluştur();
            yarışmacıyerleştir();
            button42.Enabled = false;
            groupBox7.Visible = false;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        int y5; // Yarışmacı seçerken rastgele yarışmacı seçici

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac<10)
            {
                y5 = r.Next(20);
                pictureBox6.Image = Image.FromFile(Application.StartupPath + yarışmacıresimyol[yarışmacılartümüresim[y5]]);
                label22.Text = tümyarışmacılar[yarışmacılartümüisim[y5]].ToString();
                sayac++;
            }

            else
            {
                timer1.Stop();
                button42.Enabled = true;
            }
        }

        int y7;

        private void button42_Click(object sender, EventArgs e)
        {
            pic1[y5].Image =null;
            etiket1[y5].Text = " ";

            pictureBox2.Image = Image.FromFile(Application.StartupPath + yarışmacıresimyol[yarışmacılartümüresim[y5]]);
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\acun.png");

            label23.Text = label22.Text;

            groupBox6.Enabled = true;
            groupBox4.Enabled = false;

            groupBox4.Visible = false;
            groupBox7.Visible = true;
            groupBox7.Enabled = true;
            groupBox5.Enabled = true;

            pictureBox11.Image = Image.FromFile(Application.StartupPath + "\\masa.png");
            pictureBox10.Image = Image.FromFile(Application.StartupPath + "\\tel.png");

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    y7 = r.Next(20);
                    
                } while (Array.IndexOf(paradağılımı,para[y7])!=-1);

                paradağılımı[i] = para[y7];
                parax[i] = y7;

            }

            foreach (int a in paradağılımı)
            {
                listBox1.Items.Add(a);
            }

            switch (y5)
            {
                case 0: button21.Enabled = false; break;
                case 1: button22.Enabled = false; break;
                case 2: button23.Enabled = false; break;
                case 3: button24.Enabled = false; break;
                case 4: button25.Enabled = false; break;
                case 5: button26.Enabled = false; break;
                case 6: button27.Enabled = false; break;
                case 7: button28.Enabled = false; break;
                case 8: button29.Enabled = false; break;
                case 9: button30.Enabled = false; break;
                case 10: button31.Enabled = false; break;
                case 11: button32.Enabled = false; break;
                case 12: button33.Enabled = false; break;
                case 13: button34.Enabled = false; break;
                case 14: button35.Enabled = false; break;
                case 15: button36.Enabled = false; break;
                case 16: button37.Enabled = false; break;
                case 17: button38.Enabled = false; break;
                case 18: button39.Enabled = false; break;
                case 19: button41.Enabled = false; break;



            }

        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label26.Text = paradağılımı[0].ToString();
            parabutonsil(0);
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label27.Text = paradağılımı[1].ToString();
            parabutonsil(1);
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label28.Text = paradağılımı[2].ToString();
            parabutonsil(2);
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label29.Text = paradağılımı[3].ToString();
            parabutonsil(3);
            button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label30.Text = paradağılımı[4].ToString();
            parabutonsil(4);
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label31.Text = paradağılımı[5].ToString();
            parabutonsil(5);
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label32.Text = paradağılımı[6].ToString();
            parabutonsil(6);
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label33.Text = paradağılımı[7].ToString();
            parabutonsil(7);
            button28.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label34.Text = paradağılımı[8].ToString();
            parabutonsil(8);
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label35.Text = paradağılımı[9].ToString();
            parabutonsil(9);
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label36.Text = paradağılımı[10].ToString();
            parabutonsil(10);
            button31.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label37.Text = paradağılımı[11].ToString();
            parabutonsil(11);
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label38.Text = paradağılımı[12].ToString();
            parabutonsil(12);
            button33.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label39.Text = paradağılımı[13].ToString();
            parabutonsil(13);
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            label40.Text = paradağılımı[14].ToString();
            parabutonsil(14);
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            label41.Text = paradağılımı[15].ToString();
            parabutonsil(15);
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            label42.Text = paradağılımı[16].ToString();
            parabutonsil(16);
            button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            label43.Text = paradağılımı[17].ToString();
            parabutonsil(17);
            button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            label44.Text = paradağılımı[18].ToString();
            parabutonsil(18);
            button39.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            label45.Text = paradağılımı[19].ToString();
            parabutonsil(19);
            button41.Enabled = false;
        }

       
    }
}
