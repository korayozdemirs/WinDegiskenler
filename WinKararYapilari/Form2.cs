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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            //sayının 2 ile bölümünden kalan 0 ise
            if (sayi < 0)
            {
                MessageBox.Show("Pozitif Sayı Giriniz");
            }
            else if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Sayı tektir");
            }
        }
    }
}
