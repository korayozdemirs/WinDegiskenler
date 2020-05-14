using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Deger tipinin referans tipine dönüşmesi BOXING
            //referans tipinin deger tipine dönüşmesi UNBOXING
            int sayi = 12;
            object deger = sayi;

            //Unboxing
            object sayi2 = 22;
            //Casting
            int deger2 = (int)sayi2;

            object asc;
            int x;
        }
    }
}
