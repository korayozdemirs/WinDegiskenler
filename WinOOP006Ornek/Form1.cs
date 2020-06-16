using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP006Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Category> categoryList;
        List<Product> productList = new List<Product>();
        int counterId = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            categoryList = new List<Category>()
            {
                new Category{Id = 1,Name="Elektronik"},
                new Category{Id = 2,Name="Giyim"},
                new Category{Id = 3,Name="Temizlik"},
                new Category{Id = 4,Name="İçecek"}
            };

            cmbCategory.DataSource = categoryList;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Id = counterId;
            p.Name = txtName.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            //p.CategoryId = ((Category)cmbCategory.SelectedItem).Id;
            p.Category = (Category)cmbCategory.SelectedItem;
            counterId++;
            productList.Add(p);
            DataFill();
        }

        private void DataFill()
        {
            foreach (Product product in productList)
            {
                ListViewItem li = new ListViewItem(product.Name);
                li.SubItems.Add(product.Price.ToString());
                li.SubItems.Add(product.Category.Name);
                listView1.Items.Add(li);
            }
        }
    }
}
