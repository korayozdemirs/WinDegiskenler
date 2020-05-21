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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int sayi;
        int counter = 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(textBox1.Text);
            timer1.Enabled = true;
            //int n = sayi / 2;
            //toplam = n * (n + 1);
            //MessageBox.Show(toplam.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter % 2 == 0)
            {
                //toplam = toplam + counter;
                toplam += counter;
            }
            if (counter == sayi)
            {
                timer1.Enabled = false;
                MessageBox.Show(toplam.ToString());
            }
            counter++;
        }
    }
}
