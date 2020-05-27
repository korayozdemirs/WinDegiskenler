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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Button btn = new Button();
        private void Form8_Load(object sender, EventArgs e)
        {
            btn.Text = "AHmet Taş";
            btn.ForeColor = Color.Yellow;
            btn.BackColor = Color.Blue;
            btn.Height = 50;
            btn.Width = 100;
            btn.Location = new Point(50, 50);
            btn.Tag = "hübele";

            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona TIklandı");
        }
    }
}
