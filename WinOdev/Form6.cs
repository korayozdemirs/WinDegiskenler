using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOdev
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //sender uzerıne gelinen nesneyı temsil eder
            //Tip belli olmadığı için Button nesnesi oluşturup Buttona cast ettik.
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }
    }
}
