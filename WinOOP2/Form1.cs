using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace WinOOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Corsa corsa = new Corsa();
            Hubele test = new Hubele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AhmetButton btn = new AhmetButton();
            btn.Text = "Hebele";
            btn.Height = btn.Width = 100;
            this.Controls.Add(btn);
        }
    }
}
