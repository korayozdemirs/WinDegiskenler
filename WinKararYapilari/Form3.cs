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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string takim = textBox1.Text.ToLower();

            #region if ile yapılmış hali
            if (takim == "fb")
            {
                MessageBox.Show("FenerBahçe");
            }
            else if (takim == "bjk")
            {
                MessageBox.Show("Beşiktaş");
            }
            else if (takim == "gs")
            {
                MessageBox.Show("Galatasaray");
            }
            else if (takim == "ts")
            {
                MessageBox.Show("Trabzon");
            }
            else
            {
                MessageBox.Show("Tanımsız takım");
            }
            #endregion

            #region Switch Case Hali
            switch (takim)
            {
                case "fb":
                    MessageBox.Show("Fenerbahçe");
                    break;
                case "gs":
                    MessageBox.Show("Galata");
                    break;
                case "bjk":
                    MessageBox.Show("Beşiktaş");
                    break;
                case "ts":
                    MessageBox.Show("Trabzon");
                    break;
                default:
                    MessageBox.Show("Tanımsız Trakım");
                    break;
            }
            #endregion

        }
    }
}
