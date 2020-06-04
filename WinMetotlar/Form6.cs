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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = (txtSayi1.Text == string.Empty) ? 0 : int.Parse(txtSayi1.Text);
            string islem = txtIslem.Text;
            int sayi2 = (txtSayi2.Text == string.Empty) ? 0 : int.Parse(txtSayi2.Text);

            if (sayi1 != 0 && islem != string.Empty && sayi2 != 0)
            {
                //hepsi dolu ise
            }
            else if (sayi1 != 0 && islem != string.Empty)
            {
                //ilk 2 si dolu ise
                Hesapla(sayi1, islem);
            }
            else if (sayi1 != 0)
            {
                //ilki dolu ise
                int sonuc = Hesapla(5);
            }
        }

        /// <summary>
        /// Bir değer alır değere 30 ekler
        /// </summary>
        /// <param name="sayi">Parametre 1</param>
        /// <returns>Geriye verilen degere 30 ekler</returns>
        int Hesapla(int sayi)
        {
            return sayi + 30;
        }

        /// <summary>
        /// Verilen deger ile işlemi yapar
        /// </summary>
        /// <param name="sayi">Sayı girişi</param>
        /// <param name="islem">Yapıalcak işlem</param>
        /// <returns>İşlem türüne göre 30 ile işlme yapar</returns>
        int Hesapla(int sayi, string islem)
        {
            int sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi + 30;
                    break;
                case "*":
                    sonuc = sayi * 30;
                    break;
                case "/":
                    sonuc = sayi / 30;
                    break;
                case "-":
                    sonuc = sayi - 30;
                    break;
            }
            return sonuc;
        }


        int Hesapla(int sayi, string islem, int sayi2)
        {
            int sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi + sayi2;
                    break;
                case "*":
                    sonuc = sayi * sayi2;
                    break;
                case "/":
                    sonuc = sayi / sayi2;
                    break;
                case "-":
                    sonuc = sayi - sayi2;
                    break;
            }
            return sonuc;
        }

    }
}
