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

        Order order = new Order();
        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (ExtraProduct item in ExtraProduct.extraProducts)
            {
                flowLayoutPanelExtraProduct.Controls.Add(new CheckBox() { Text = item.Name, Tag = item });

            }

            comboBox1.Items.AddRange(Product.Products.ToArray());
            comboBox1.DisplayMember = "Name";
            radioButtonLargeSize.Tag = ProductSize.Large;
            radioButtonSmallSize.Tag = ProductSize.Small;
            radioButtonMediumSize.Tag = ProductSize.Medium;

        }
        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {

            foreach (Control control in grpbxSize.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {

                    listBox1.Items.Add(comboBox1.Text + order.OrderCount + radioButton.Tag + radioButtonLargeSize.Tag);
                    if (radioButton.Tag == "Large") { MessageBox.Show(radioButtonLargeSize.ToString()); };
                }


            }

            foreach (Control control in flowLayoutPanelExtraProduct.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {

                    listBox1.Items.Add(comboBox1.Text +order.OrderCount + ((ExtraProduct)checkBox.Tag).Price.ToString());
                    order.OrderCount = Convert.ToInt32(numericUpDown1.Value);
                }

            }
            if (comboBox1.SelectedItem is Product selectedProduct)
            {
                order.Product.Name = (comboBox1.SelectedItem);
                order.Product.Price= ((Product)comboBox1.SelectedItem).Price;
            }
        
            order.OrderCount = Convert.ToInt32(numericUpDown1.Value);
            
            order.ToString(); 
            
            

           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lblTotalCoastPrice.Text = ((Product)comboBox1.SelectedItem).Price.ToString();
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {

        }


    }
}
