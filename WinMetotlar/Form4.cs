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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Trim metodu string ifadede bulunan belli karakterleri baştan ve sondan silen metotdur. 
            string deger = textBox1.Text.Trim();
            //Sadece sondaki
            string deger2 = textBox1.Text.TrimEnd();
            //sadece baştajkı bolukler
            string deger3 = textBox1.Text.TrimStart();
            textBox2.Text = deger;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Eşitlik sorgulaması yapar verilen iki string ifadenin birbirine eşit olup 
            //olmadığını kontrol eder. Eşitlik durumu sonucunda boolean değer döner
            string deger1 = textBox1.Text;
            string deger2 = textBox2.Text;
            if (deger1.Equals(deger2, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Eşitler");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //String ifadede bulunan karakterlerden belirtilen index numarasından başlayarak 
            //string ifadenin sonuna kadar keser.
            //0-5 aralıgı
            string deger = textBox1.Text.Substring(0, 5);
            //2 den başla sonuna kadar
            string deger2 = textBox1.Text.Substring(2);
            MessageBox.Show(deger2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //String ifadede ki karakter topluluğunu ters çevirmek için kullanılan string metotudur. 
            IEnumerable<Char> karakterler = textBox1.Text.Reverse();
            foreach (var item in karakterler)
            {
                textBox2.Text += item;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Yazılan kelime içerisinde belirttiğim karakteri arar. 
            //Bulmazsa -1 döndürür
            string deger = textBox1.Text.IndexOf('a').ToString();
            MessageBox.Show(deger.ToString());

            //b nin indexini döndürür
            string deger2 = textBox1.Text.IndexOf("bilge adam").ToString();
            MessageBox.Show(deger2.ToString());


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Contains metodu, metot içerisinde verilen ifadenin, 
            //string ifade içerisinde olup olmadığını kontrol eden string metotdur. 
            //Boolean sonuç döndürür.Eğer string ifade verdiğimiz değeri içeriyorsa ‘true’ ,
            //içermiyorsa ‘false’ değeri döndürür. 
            bool deger = textBox1.Text.Contains('a');

            if (deger)
            {
                MessageBox.Show("a harfi var");
            }
            else
            {
                MessageBox.Show("Yok");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //String ifade içeriside belirttiğimiz alanı kesebilir ve kestiğimiz alan dışında kalan kısmı elde edebiliriz. 
            //2.index’den başla ve 4 karakter sil

            string deger = textBox1.Text.Remove(2, 4);
            MessageBox.Show(deger);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //String ifade içerisinde bulunan değerleri değiştirmek için kullanılır. 
            string deger = textBox1.Text.Replace('a', 'b');
            MessageBox.Show(deger);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //String ifade içerisine verdiğimiz ayıraca göre string ifadeyi böler.Böldüğü ifadeyi bir diziye aktarır.
            string[] degerler = textBox1.Text.Split(' ');

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text.ToLower());
            MessageBox.Show(textBox1.Text.ToUpper());
        }
    }
}
