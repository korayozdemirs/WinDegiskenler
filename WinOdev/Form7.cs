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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int counter = 0;
        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button btn = new Button();
                btn.Height = btn.Width = 33;
                btn.Margin = new Padding(2);
                int uretilen = rnd.Next(1, 814);
                if (uretilen % 7 == 0)
                {
                    btn.Tag = "M";
                    counter++;
                }
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
            MessageBox.Show(counter.ToString());
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag == "M")
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    if (item.Tag == "M")
                    {
                        item.BackColor = Color.Red;
                    }
                    else
                    {
                        item.BackColor = Color.Blue;
                    }
                }
            }
            else
            {
                btn.BackColor = Color.Blue;
            }
        }
    }
}
