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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        int deger = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            deger = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = int.Parse(label1.Text);
            counter = counter + deger;
            label1.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
            deger = -1;

        }
    }
}
