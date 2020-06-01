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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        bool gizlendimi = false;
        private void Form8_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button btn = new Button();
                btn.Height = btn.Width = 33;
                btn.Margin = new Padding(0);
                btn.Click += Btn_Click;
                btn.BackColor = Color.AliceBlue;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //gilendi butonuna tıklanmış ise
            if (gizlendimi)
            {
                if (btn.Tag == "G")
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Blue;
                }
            }
            else
            {
                if (btn.Tag == "G")
                {
                    btn.Tag = null;
                    btn.BackColor = Color.AliceBlue;
                }
                else
                {
                    btn.BackColor = Color.Blue;
                    btn.Tag = "G";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gizlendimi = true;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                Button btn = (Button)item;
                btn.BackColor = Color.AliceBlue;
            }
            button1.Enabled = false;
        }
    }
}
