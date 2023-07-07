namespace BurgerQueenApp
{

	public partial class Form1 : Form
	{
		public static List<Order> finishedOrders = new List<Order>();
		public Form1()
		{
			InitializeComponent();
			flwSideBar.Width = flwSideBar.MinimumSize.Width;
			pnlProduct.Height = pnlProduct.MinimumSize.Height;
			pnlOrderManagement.Height = pnlOrderManagement.MinimumSize.Height;
		}
		public Form1(List<Order> finishedOrders)
		{
			InitializeComponent();
		}
		public void OpenForm(Form childForm)
		{
			this.Width = childForm.Width + 100;
			this.Width = childForm.Height + 150;
			bool situation = false;
			foreach (Form form in this.MdiChildren)
			{

				if (form.Text == childForm.Text)
				{
					situation = true;
					form.Activate();
				}
				else
				{
					form.Close();
				}
			}
			if (situation == false)
			{
				childForm.MdiParent = this;
				childForm.Dock = DockStyle.Fill;
				childForm.Show();
			}

		}

		bool sideBarExpand;
		private void sideBarTimer_Tick(object sender, EventArgs e)
		{
			if (sideBarExpand)
			{
				flwSideBar.Width -= 10;
				if (flwSideBar.Width == flwSideBar.MinimumSize.Width)
				{
					sideBarExpand = false;
					sideBarTimer.Stop();
				}

			}
			else
			{
				flwSideBar.Width += 10;
				if (flwSideBar.Width == flwSideBar.MaximumSize.Width)
				{
					sideBarExpand = true;
					sideBarTimer.Stop();
				}

			}
		}

		bool ProductManagement;

		private void btnProductManagement_Click(object sender, EventArgs e)
		{
			productManagementTimer.Start();
		}

		private void productManagementTimer_Tick(object sender, EventArgs e)
		{
			if (ProductManagement)
			{
				pnlProduct.Height -= 10;
				if (pnlProduct.Height == pnlProduct.MinimumSize.Height)
				{
					ProductManagement = false;
					productManagementTimer.Stop();
				}

			}
			else
			{
				pnlProduct.Height += 10;
				if (pnlProduct.Height == pnlProduct.MaximumSize.Height)
				{
					ProductManagement = true;
					productManagementTimer.Stop();
				}

			}
		}


		private void pcBoxMenu_Click(object sender, EventArgs e)
		{
			sideBarTimer.Start();
		}

		private void btnOrderManagement_Click(object sender, EventArgs e)
		{
			orderManagementTimer.Start();
		}
		bool orderManagement;
		private void orderManagementTimer_Tick(object sender, EventArgs e)
		{
			if (orderManagement)
			{
				pnlOrderManagement.Height -= 10;
				if (pnlOrderManagement.Height == pnlOrderManagement.MinimumSize.Height)
				{
					orderManagement = false;
					orderManagementTimer.Stop();
				}

			}
			else
			{
				pnlOrderManagement.Height += 10;
				if (pnlOrderManagement.Height == pnlOrderManagement.MaximumSize.Height)
				{
					orderManagement = true;
					orderManagementTimer.Stop();
				}

			}
		}

		private void btnAddOrder_Click(object sender, EventArgs e)
		{
			OpenForm(new Form2());
		}

		private void btnListOrder_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			OpenForm(form);
		}

		private void btnAddMenu_Click(object sender, EventArgs e)
		{
			OpenForm(new Form4());
		}

		private void btnAddExtraMenu_Click(object sender, EventArgs e)
		{
			OpenForm(new Form5());
		}

		private void btnContact_Click(object sender, EventArgs e)
		{
			OpenForm(new Form6());
		}
	}
}