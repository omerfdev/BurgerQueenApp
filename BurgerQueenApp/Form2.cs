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


        public List<Order> Orders = new List<Order>() { };
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (ExtraProduct item in ExtraProduct.extraProducts)
            {
                flowLayoutPanelExtraProduct.Controls.Add(new CheckBox() { Text = item.Name, Tag = item });

            }
            //foreach (Product item in Product.Products)
            //{
            //    comboBox1.Items.Add(item.Name);

            //}
            comboBox1.Items.AddRange(Product.Products.ToArray());
            comboBox1.DisplayMember = "Name";

        }

        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(comboBox1.Text + grpbxSize.Size);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            double totalOrderPrice = 0;

           lblTotalCoastPrice.Text = ((Product)comboBox1.SelectedItem).Price.ToString();


        }
    }
}
