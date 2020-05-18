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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(deger);
            }
            catch (Exception)
            {
                listBox2.Items.Add(textBox1.Text);
            }
        }
    }
}
