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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            string konroledilecekDeger = textBox2.Text;

            if (Contains(deger, konroledilecekDeger))
            {
                MessageBox.Show("Var");
            }
            else
            {
                MessageBox.Show("yok");
            }

        }

        public bool Contains(string deger, string kontrolEdilecekDeger)
        {
            Char[] karakterler = deger.ToCharArray();
            bool varmi = false;

            foreach (var karakter in karakterler)
            {
                if (karakter.ToString() == kontrolEdilecekDeger)
                {
                    varmi = true;
                    break;
                }
            }
            return varmi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] karakterler = textBox1.Text.ToCharArray();

            for (int i = karakterler.Length - 1; i >= 0; i--)
            {
                textBox2.Text += karakterler[i];
            }

        }
    }
}
