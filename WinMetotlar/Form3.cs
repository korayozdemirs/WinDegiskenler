using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMetotlar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1 = decimal.Parse(txtSayi1.Text);
            decimal sayi2 = decimal.Parse(txtSayi2.Text);
            string islem = txtIslem.Text;
            Hesapla(sayi1, sayi2, islem);
        }

        void Hesapla(decimal sayi1, decimal sayi2, string islem)
        {
            decimal sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
            }

            MessageBox.Show("İşlem Socunu = " + sonuc);
        }
    }
}
