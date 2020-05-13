using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSayiArttirma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rastgele sayı uretmeye yarar
            Random rnd = new Random();
            //Negatif olmayan int rakamlar üretir.
            rnd.Next();
            //0-100 arası rastgele deger
            rnd.Next(100);
            //3 ile 10 arasında bir deger üretir 3 dahildir 10 dahil değil. 
            int uretilen = rnd.Next(3, 10);

            MessageBox.Show(uretilen.ToString());
        }
    }
}
