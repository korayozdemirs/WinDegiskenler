using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBatanBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;
            decimal anaPara = Convert.ToDecimal(txtAnapara.Text);
            decimal kdv = Convert.ToDecimal(txtKdvli.Text);
            decimal kdvliHali = anaPara * (1 + (kdv / 100));

            ListViewItem li = new ListViewItem();
            li.Text = adi;
            li.SubItems.Add(soyadi);
            li.SubItems.Add(anaPara.ToString());
            li.SubItems.Add(kdv.ToString());
            li.SubItems.Add(kdvliHali.ToString());
            lstKrediler.Items.Add(li);
        }
    }
}
