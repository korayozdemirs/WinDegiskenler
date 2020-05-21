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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //5 * 4* 3 * 2* 1
            int sayi = int.Parse(textBox1.Text);
            int sonuc = 1;
            //for (int i = sayi; i >= 1; i--)
            //{
            //    //sonuc = sonuc * i;
            //    sonuc *= i;
            //}
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            MessageBox.Show(sonuc.ToString());
        }
    }
}
