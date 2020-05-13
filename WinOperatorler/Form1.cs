using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOperatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(txtDeger1.Text);
            int deger2 = Convert.ToInt32(txtDeger2.Text);
            //+ iki sayının toplanması
            int toplam = deger1 + deger1;
            //- iki sayının farkını alır
            int fark = deger1 - deger2;
            // / bölme işlemi
            int bolum = deger1 / deger2;
            // * çarpma işlemi
            int carpim = deger1 * deger2;
            // % mod alma
            int mod = 5 % 2;
            //++ -- += -=
            int deger = 1;
            deger++;
            //deger = deger + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             >  büyüktür işareti
             >= büyük ve eşittir
             <  küçüktür işareti 
             <= küçük eşittir
             =  Atama işlemi
             == Eşit mi kontrol eder.
             */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* 
                == Eşit mi ? x == y
                != Eşit değil
                &  ve
                && ve
                |  veya
                || veya
             */
        }
    }
}
