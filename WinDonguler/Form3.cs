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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            int ciftToplam = 0;
            int ucToplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                if (i % 3 == 0)
                {
                    ucToplam += i;
                }
            }
            MessageBox.Show("Çift : " + ciftToplam + " Tek Toplam : " + ucToplam);
        }
    }
}
