using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kazak m = new Kazak();
            m.Id = 1;
            m.Fiyat = 100;
            m.Renk = "Morcvert";
            MessageBox.Show(m.KdvHesapla().ToString());
        }
    }
}
