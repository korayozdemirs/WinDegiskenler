using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinOOP01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Categories> categoryList = new List<Categories>();
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtCatName.Text;
            string Desc = txtDesc.Text;

            Categories c = new Categories();
            c.CategoryName = Name;
            c.Description = Desc;
            categoryList.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Categories category in categoryList)
            {
                listBox1.Items.Add(category.CategoryName + " " + category.Description);
            }

            dataGridView1.DataSource = categoryList;
        }
    }
}
