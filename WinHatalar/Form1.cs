using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHatalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                //Çalışacak kodları
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);
                int bolum = sayi1 + sayi2;
                MessageBox.Show(bolum.ToString());
            }
            catch (FormatException)
            {
                //Hata olunca çalışacak kodlar
                MessageBox.Show("Yazım Formatınızda hata mevcut");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Sıfıra bölünebilme hatası");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Sayı çok fazla");
            }
            finally
            {
                //Hata alsın yada almasın çalışacak kodlar
                MessageBox.Show("Finally çalıştı");
            } 
        }
    }
}
