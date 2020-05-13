using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSayiArttirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValue.Text = "0";
        }

        int number = 0;
        private void btnInc_Click(object sender, EventArgs e)
        {
            number = number + 1;
            lblValue.Text = number.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            number = number - 1;
            lblValue.Text = number.ToString();
        }
    }
}
