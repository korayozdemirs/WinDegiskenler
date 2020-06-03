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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        string[] resimler = new string[24];
        int selectedIndex = 0;
        Random rnd = new Random();
        private void Form10_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= resimler.Length; i++)
            {
                Button btn = new Button();
                btn.Height = btn.Width = 44;
                btn.Margin = new Padding(0);
                string url = Application.StartupPath + "\\images\\image (" + i + ").jpg";
                btn.BackgroundImage = Image.FromFile(url);
                btn.Tag = i - 1;
                resimler[i - 1] = url;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            selectedIndex = (int)btn.Tag;
            pictureBox1.BackgroundImage = btn.BackgroundImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectedIndex++;
            if (selectedIndex >= resimler.Length)
            {
                selectedIndex = 0;
            }
            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            selectedIndex--;
            if (selectedIndex < 0)
            {
                selectedIndex = resimler.Length - 1;
            }
            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            selectedIndex = resimler.Length - 1;
            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            selectedIndex = 0;
            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            selectedIndex = rnd.Next(0, resimler.Length);
            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSlayt_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            selectedIndex++;
            if (selectedIndex >= resimler.Length)
            {
                selectedIndex = 0;
            }

            pictureBox1.BackgroundImage = Image.FromFile(resimler[selectedIndex]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
