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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<Customer> customerList = new List<Customer>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Name = txtAdi.Text;
            c.Surname = txtSoyadi.Text;
            c.Capital = Convert.ToDecimal(txtAnapara.Text);
            decimal kdv = Convert.ToDecimal(txtKdvli.Text);
            decimal kdvliHali = c.Capital * (1 + (kdv / 100));
            c.Ext = kdvliHali;
            customerList.Add(c);
            Listele();
        }

        private void Listele()
        {
            lstKrediler.Items.Clear();
            foreach (Customer customer in customerList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = customer.Name;
                li.SubItems.Add(customer.Surname);
                li.SubItems.Add(customer.Capital.ToString());
                li.SubItems.Add(customer.Ext.ToString());
                li.SubItems.Add((customer.Capital + customer.Ext).ToString());
                lstKrediler.Items.Add(li);
            }
        }
    }
}
