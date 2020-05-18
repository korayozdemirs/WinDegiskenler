using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKararYapilari
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            string islem = txtIslem.Text;
            int sonuc;

            #region İf hali
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                MessageBox.Show("Tanımsız işlem");
                sonuc = 0;
            }
            #endregion

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    sonuc = 0;
                    MessageBox.Show("Bu nasıl işlemdir.");
                    break;
            }
            MessageBox.Show(sonuc.ToString());
        }
    }
}
