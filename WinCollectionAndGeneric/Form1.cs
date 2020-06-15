using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCollectionAndGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> isimler = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string isim in isimler)
            {
                listBox1.Items.Add(isim);
            }
        }
    }
}
