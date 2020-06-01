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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    //txt.Text = "";
                    //txt.Text = string.Empty;
                }
                else if (item is Button)
                {
                    Button btn = item as Button;
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.Yellow;
                }
            }
            MessageBox.Show("Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncellendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    //txt.Text = "";
                    //txt.Text = string.Empty;
                }
                else if (item is Button)
                {
                    Button btn = item as Button;
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.Yellow;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temizlendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                    //txt.Text = "";
                    //txt.Text = string.Empty;
                }
                else if (item is Button)
                {
                    Button btn = item as Button;
                    btn.BackColor = Color.Blue;
                    btn.ForeColor = Color.Yellow;
                }
            }
        }


    }
}
