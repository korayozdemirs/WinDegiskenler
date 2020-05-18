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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int ilktahmin;
        int max = 100;
        int min = 1;
        int counter = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            ilktahmin = rnd.Next(1, 100);
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yeniTahmin = rnd.Next(min, max);
            label1.Text += yeniTahmin + ",";
            counter++;
            if (yeniTahmin > ilktahmin)
            {
                max = yeniTahmin;
            }
            else if (yeniTahmin < ilktahmin)
            {
                min = yeniTahmin;
            }
            else
            {
                MessageBox.Show("Furdum oni " + counter + " tahminde");
            }
        }
    }
}
