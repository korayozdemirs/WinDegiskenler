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

        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button btn = new Button();
                btn.Height = btn.Width = 33;
                btn.Margin = new Padding(2);
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
