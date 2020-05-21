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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi = int.Parse(textBox1.Text);

            //for (int i = 1; i <= sayi; i++)
            //{
            //    //toplam = toplam + i;
            //    toplam += i;
            //}

            int i = 1;
            while (i <= sayi)
            {
                toplam += i;
                i++;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
