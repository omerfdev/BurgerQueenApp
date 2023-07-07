using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BurgerQueenApp
{
	public partial class Form2 : Form
	{
		List<Order> FinishedOrders = new List<Order>();
		public Form2()
		{
			InitializeComponent();
		}
		private void Form2_Load(object sender, EventArgs e)
		{

			foreach (ExtraProduct item in ExtraProduct.extraProducts)
			{
				flowLayoutPanelExtraProduct.Controls.Add(new CheckBox() { Text = item.Name, Tag = item, BackColor = Color.OliveDrab });

			}

			cmBoxMenu.Items.AddRange(Product.Products.ToArray());
			cmBoxMenu.DisplayMember = "Name";
			radioButtonLargeSize.Tag = ProductSize.Large;
			radioButtonSmallSize.Tag = ProductSize.Small;
			radioButtonMediumSize.Tag = ProductSize.Medium;

		}
		Order order = new Order();
		private void buttonOrderAdd_Click(object sender, EventArgs e)
		{

			order.OrderCount = Convert.ToInt32(numericUpDown1.Value);
			order.Product = (Product)cmBoxMenu.SelectedItem;

			foreach (Control control in grpbxSize.Controls)
			{
				if (control is RadioButton radioButton && radioButton.Checked)
				{
					order.Product.Size = (ProductSize)radioButton.Tag;

				}
			}
			List<ExtraProduct> extraProducts = new List<ExtraProduct>();
			foreach (Control control in flowLayoutPanelExtraProduct.Controls)
			{
				if (control is CheckBox checkBox && checkBox.Checked)
				{
					ExtraProduct extraProduct = (ExtraProduct)checkBox.Tag;
					order.ExtraProductPrice += extraProduct.AllExtraProductPrice + extraProduct.Price;
					extraProducts.Add(extraProduct);
					order.Product.extraProducts = extraProducts;

				}
			}

			lsBoxOrder.Items.Add(order.ToString());
			lblTotalCoastPrice.Text = Convert.ToString(order.CalculateOrder());


		}

		public void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			lblTotalCoastPrice.Text = ((Product)cmBoxMenu.SelectedItem).Price.ToString();
		}

		public void btnFinishOrder_Click(object sender, EventArgs e)
		{
			DialogResult answer = MessageBox.Show($"Toplam SiparişTutarı: {lblTotalCoastPrice.Text}\nSatın Almayı Tamamlamak İster Misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (answer == DialogResult.Yes)
			{
				MessageBox.Show("Siparişiniz Onaylanmıştır.Afiyet Olsun");

			}
			FinishedOrders.Add(order);
			Form1.finishedOrders = FinishedOrders;

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			pcBoxMenuImage.Image = Image.FromFile(((Product)cmBoxMenu.SelectedItem).Image);

		}



	}
}
