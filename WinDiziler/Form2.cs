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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //form açılışında bir dizi tanımlayıp içine 
            //33,12,55,65,13,46,78,32,1,4,72 değerlerini atayın.
            int[] sayilar = { 33, 12, 55, 65, 13, 46, 78, 32, 1, 4, 72 };
            sayilar[3] = 9999;
        }
    }
}
