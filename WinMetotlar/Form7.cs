using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMetotlar
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int toplamAdet = 10;
        int[] sayilar;
        string[] resimler;
        int sayac = 0;
        int tiklamaSayisi = 1;
        Button acikButon = null;
        Random rnd = new Random();
        private void Form7_Load(object sender, EventArgs e)
        {
            sayilar = new int[toplamAdet];
            resimler = new string[toplamAdet];
            while (sayac < toplamAdet)
            {
                int uretilen = rnd.Next(1, toplamAdet + 1);
                if (Array.IndexOf(sayilar, uretilen) == -1)
                {
                    int ortalama = toplamAdet / 2;

                    sayilar[sayac] = uretilen;
                    string path = "";
                    if (uretilen > ortalama)
                    {
                        path = Application.StartupPath + @"\images\" + (uretilen - ortalama) + ".png";
                    }
                    else
                    {
                        path = Application.StartupPath + @"\images\" + uretilen + ".png";
                    }

                    resimler[sayac] = path;
                    Button btn = new Button();
                    btn.Width = 80;
                    btn.Height = 150;
                    btn.Tag = sayilar[sayac];
                    btn.Click += Btn_Click;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    flowLayoutPanel1.Controls.Add(btn);
                    sayac++;
                }
            }
        }

        private async void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;

            if (tiklanan.Tag != "A")
            {
                int ilkTiklanan = (int)tiklanan.Tag;
                int tiklananIndex = TiklananIndexiGetir(ilkTiklanan);
                tiklanan.BackgroundImage = Image.FromFile(resimler[tiklananIndex]);
                if (tiklamaSayisi == 1)
                {
                    tiklamaSayisi++;
                    acikButon = tiklanan;
                }
                else
                {
                    int ortalama = toplamAdet / 2;
                    int acikbutonTagdegeri = (int)acikButon.Tag;
                    if (ilkTiklanan <= ortalama)
                    {
                        ilkTiklanan *= -1;
                    }
                    if (Math.Abs((ilkTiklanan - ortalama)) == acikbutonTagdegeri)
                    {
                        tiklanan.Tag = "A";
                        acikButon.Tag = "A";
                        tiklamaSayisi = 1;
                        acikButon = null;
                        if (KontrolEt())
                        {
                            MessageBox.Show("Tebrikler");
                        }
                    }
                    else
                    {
                        Task.Delay(1000).Wait();
                        await ButonlariKapat();
                    }
                }
            }
            else
            {
                MessageBox.Show("Daha ne tıklıyorsun açtık ya :D");
            }
        }

        private int TiklananIndexiGetir(int ilkTiklanan)
        {
            int sonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == ilkTiklanan)
                {
                    sonuc = i;
                }
            }
            return sonuc;
        }

        async Task ButonlariKapat()
        {
            tiklamaSayisi = 1;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    if (btn.Tag != "A")
                    {
                        btn.BackgroundImage = null;
                    }
                }
            }
        }

        private bool KontrolEt()
        {
            bool result = true;

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    if (btn.Tag != "A")
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }


    }
}
