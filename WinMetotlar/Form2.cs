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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            BirlestirGoster(adi, soyadi);
        }

        void BirlestirGoster(string name, string surname)
        {
            MessageBox.Show(name + " " + surname);
        }
    }
}
