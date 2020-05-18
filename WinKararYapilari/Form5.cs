using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKararYapilari
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int sayi;
        int sayici = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            //Sayımızı aldık
            sayi = int.Parse(textBox1.Text);
            //Timerımızı başlattık
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sayıcı adında değişken tanımladık.
            //girilen değer 100 ise 1 den 100 e kadar gitmesini sağlamak için
            //eğer sayicinin 3 ile bölümünden kalan 0 ise
            if (sayici % 3 == 0)
            {
                listBox1.Items.Add(sayici);
            }
            //eğer sayicinin 5 ile bölümünden kalan 0 ise
            if (sayici % 5 == 0)
            {
                listBox2.Items.Add(sayici);
            }
            //eğer sayicinin 7 ile bölümünden kalan 0 ise
            if (sayici % 7 == 0)
            {
                listBox3.Items.Add(sayici);
            }
            //eğer sayici ve sayi eşit ise artık saymayı durdurması için timer enabled = false dedik
            if (sayici == sayi)
            {
                timer1.Enabled = false;
            }
            //her işlemden sonra sayiya gidene kadar değeri 1 arttırdık
            sayici++;
           
        }
    }
}
