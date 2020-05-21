using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDonguler
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            bool sayiAsalmi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    sayiAsalmi = false;
            }

            if (sayiAsalmi)
            {
                MessageBox.Show("Sayı ASal");
            }
            else
            {
                MessageBox.Show("Sayı asal degıl");
            }

        }
    }
}
