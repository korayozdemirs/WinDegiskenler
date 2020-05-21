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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alt = int.Parse(txtAlt.Text);
            int ust = int.Parse(txtUst.Text);
            int sonuc = 1;

            for (int i = 0; i < ust; i++)
            {
                //sonuc = sonuc * alt;
                sonuc *= alt;
            }
            MessageBox.Show(sonuc.ToString());
        }
    }
}
