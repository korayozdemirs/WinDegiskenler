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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    listBox1.Items.Add(i);
            //    i++;
            //}

            int i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i > 10 && i < 20);

            //listBox1.Items.Add(1);
            //listBox1.Items.Add(2);
            //listBox1.Items.Add(3);
            //listBox1.Items.Add(4);
            //listBox1.Items.Add(5);
            //listBox1.Items.Add(6);
            //listBox1.Items.Add(7);
            //listBox1.Items.Add(8);
            //listBox1.Items.Add(9);
            //listBox1.Items.Add(10);
        }
    }
}
