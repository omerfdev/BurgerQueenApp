using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerQueenApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public List<Product> Products = new List<Product>()
        {
            new Product{Name="Burger Queen", Price=5.25},
            new Product{Name="Big Mac", Price=4.25},
            new Product{Name="Mac", Price=3.25},
            new Product{Name="Lahmacun", Price=4.25},
            
        };
        public List<Order> Orders = new List<Order>() { };
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (ExtraProduct item in extraProducts)
            {
                flowLayoutPanelExtraProduct.Controls.Add(new CheckBox() { Text = item.Name, Tag = item });

            }
            foreach (Product item in Products)
            {
                comboBox1.Items.Add(item.Name);

            }
          
        }

        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in Orders)
            {
                //listBox1.DataSource=item.Name+item.Price+grpbxSize.Text+numericUpDown1.Value;

            }
            listBox1.Items.Add(comboBox1.Text +grpbxSize.Size);
            
        }
    }
}
