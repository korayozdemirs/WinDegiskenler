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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i >= 36 && i <= 40)
                {
                    continue;
                }
                else if (i >= 60 && i <= 65)
                {
                    continue;
                }
                else if (i > 90)
                {
                    break;
                }
                else
                {
                    listBox1.Items.Add(i);
                }

            }
        }
    }
}
