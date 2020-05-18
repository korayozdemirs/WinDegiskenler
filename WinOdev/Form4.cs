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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            Random rnd = new Random();
            pictureBox1.Image = Image.FromFile(path + @"\zar" + rnd.Next(1, 7) + ".png");
            pictureBox2.Image = Image.FromFile(path + @"\zar" + rnd.Next(1, 7) + ".png");
        }
    }
}
