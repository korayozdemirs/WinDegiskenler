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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            //eğer sayi buyuktur 10 ise mesaj : sayı 10 dan buyuktur
            //değilse mesaj : Sayı 10 dan küçüktür
            //else kontrol edecek başka ihtimal olmam durumunda kullanılır.
            //yada gerşiye kalan üm durumlar için.
            if (sayi > 10)
            {
                MessageBox.Show("Sayı 10 dan büyüktür");
            }
            else if (sayi == 10)
            {
                MessageBox.Show("Sayı 10 a eşittir");
            }
            else 
            {
                MessageBox.Show("Sayı 10 dan küçüktür");
            }

        }
    }
}
