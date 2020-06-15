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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        List<Product> productList = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = txtName.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            p.Stock = int.Parse(txtStock.Text);
            productList.Add(p);
            Listele();
        }

        private void Listele()
        {
            lstProducts.Items.Clear();
            foreach (Product product in productList)
            {
                string format = String.Format("Adı : {0} Fiyat :  {1} KDV Dahil :  {2} Stok : {3}",
                    product.Name, product.Price, product.Ext, product.Stock);
                lstProducts.Items.Add(format);
            }
        }
    }
}
