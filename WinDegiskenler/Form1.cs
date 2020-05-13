using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Comment Line
            //txtValue da yazan değeri name değişkenine atadık
            string name = txtValue.Text;
            //txtValue2 da yazan değeri surname değişkenine atadık
            string surname = txtValue2.Text;
            string fullName = name + surname;

            MessageBox.Show(fullName);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //txtvalue.text string i al. Conver.toInt32 Metodunu kullanarak integer tipine çevir
            int number1 = Convert.ToInt32(txtValue.Text);
            //bu sadece string tipini değiştirir
            int number2 = Int32.Parse(txtValue2.Text);
            int sum = number1 + number2;
            //Sayısal ifadeyi string tipine çeviriyoruz.
            MessageBox.Show(sum.ToString());
        }
    }
}
