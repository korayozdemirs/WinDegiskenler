using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDiziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] sayilar = { 33, 12, 55, 65, 13, 46, 78, 32, 1, 4, 72 };
        private void Form2_Load(object sender, EventArgs e)
        {
            //form açılışında bir dizi tanımlayıp içine 
            //33,12,55,65,13,46,78,32,1,4,72 değerlerini atayın.
            //sayilar[3] = 9999;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > max)
            //    {
            //        max = sayilar[i];
            //    }
            //}
            foreach (int sayi in sayilar)
            {
                if (sayi > max)
                {
                    max = sayi;
                }
            }
            MessageBox.Show(max.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listele
            //for (int i = 0; i < 11; i++)
            //{
            //    listBox1.Items.Add(sayilar[i]);
            //}

            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < min)
            //    {
            //        min = sayilar[i];
            //    }
            //}

            foreach (int sayi in sayilar)
            {
                if (sayi < min)
                {
                    min = sayi;
                }
            }
            MessageBox.Show(min.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
                //toplam = toplam + sayi;
            }
            decimal ortalama = (toplam / sayilar.Length);
            MessageBox.Show(ortalama.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
                //toplam = toplam + sayi;
            }
            decimal ortalama = (toplam / sayilar.Length);

            foreach (int sayi in sayilar)
            {
                if (sayi > ortalama)
                {
                    listBox1.Items.Add(sayi);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //"Ahmet","Mehmet","Dursun","Fatma","Cevriye"
            string[] isimler = { "Ahmet", "Mehmet", "Dursun", "Fatma", "Cevriye" };
            foreach (string isim in isimler)
            {
                listBox1.Items.Add(isim);
            }
        }
        int[] liste = new int[0];
        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            Array.Resize(ref liste, liste.Length + 1);
            liste[liste.Length - 1] = sayi;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var sayi in liste)
            {
                listBox1.Items.Add(sayi);
            }
        }

        int[] cikanSayiler = new int[6];
        int sayac = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while (sayac < 6)
            {
                int uretilen = rnd.Next(1, 11);
                //uretilen deger cikanlar listesinde yoksa
                if (Array.IndexOf(cikanSayiler, uretilen) == -1)
                {
                    cikanSayiler[sayac] = uretilen;
                    sayac++;
                }
            }

            for (int i = 0; i < cikanSayiler.Length; i++)
            {
                listBox1.Items.Add(cikanSayiler[i]);
            }
        }
    }
}
