using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.malzeme = "Keten";

            ayakkabi.MarkaYaz("Abibas");
            MessageBox.Show(ayakkabi.MarkaOku());

            //ayakkabi.marka = "Abibas";
            ayakkabi.numara = 41;
            ayakkabi.renk = "Morcivert";

            ayakkabi.Tip = "Converse";
            MessageBox.Show(ayakkabi.Tip);

            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi2.malzeme = "Bez";
            //ayakkabi2.marka = "Nixe";
            ayakkabi2.numara = 41;
            ayakkabi2.renk = "Yavru ağzı";
            ayakkabi2.Tip = "Nubuk";

        }
    }
}
