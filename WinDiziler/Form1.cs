using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tip[] adi = new tip[boyut];
            string[] isimler = new string[3];
            //diziye değer atama
            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Dursun";
            //isimler[3] = "Dursun";
            string isim = isimler[1];
            //dizideki değerleri okuma
            MessageBox.Show(isim);

        }
    }
}
