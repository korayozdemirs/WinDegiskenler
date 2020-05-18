using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tahmin;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tahmin = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int benimTahminim = Convert.ToInt32(textBox1.Text);
            if (benimTahminim > tahmin)
            {
                MessageBox.Show("Daha Küçük Sayı tahmin et");
            }
            else if (benimTahminim < tahmin)
            {
                MessageBox.Show("Daha büyük tahmin et");
            }
            else
            {
                MessageBox.Show("Tabrikler");
            }
        }
    }
}
