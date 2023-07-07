namespace BurgerQueenApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			flwSideBar = new FlowLayoutPanel();
			pnlMenu = new Panel();
			lblMenuBar = new Label();
			pcBoxMenu = new PictureBox();
			pnlOrderManagement = new Panel();
			btnListOrder = new Button();
			btnAddOrder = new Button();
			btnOrderManagement = new Button();
			pnlProduct = new Panel();
			btnAddExtraMenu = new Button();
			btnAddMenu = new Button();
			btnProductManagement = new Button();
			panel5 = new Panel();
			button4 = new Button();
			button1 = new Button();
			sideBarTimer = new System.Windows.Forms.Timer(components);
			productManagementTimer = new System.Windows.Forms.Timer(components);
			orderManagementTimer = new System.Windows.Forms.Timer(components);
			flwSideBar.SuspendLayout();
			pnlMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).BeginInit();
			pnlOrderManagement.SuspendLayout();
			pnlProduct.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// flwSideBar
			// 
			flwSideBar.BackColor = SystemColors.ControlDarkDark;
			flwSideBar.Controls.Add(pnlMenu);
			flwSideBar.Controls.Add(pnlOrderManagement);
			flwSideBar.Controls.Add(pnlProduct);
			flwSideBar.Controls.Add(panel5);
			flwSideBar.Dock = DockStyle.Left;
			flwSideBar.Location = new Point(0, 0);
			flwSideBar.MaximumSize = new Size(280, 900);
			flwSideBar.MinimumSize = new Size(81, 900);
			flwSideBar.Name = "flwSideBar";
			flwSideBar.Size = new Size(280, 900);
			flwSideBar.TabIndex = 3;
			// 
			// pnlMenu
			// 
			pnlMenu.Controls.Add(lblMenuBar);
			pnlMenu.Controls.Add(pcBoxMenu);
			pnlMenu.Location = new Point(3, 3);
			pnlMenu.Name = "pnlMenu";
			pnlMenu.Size = new Size(250, 62);
			pnlMenu.TabIndex = 1;
			// 
			// lblMenuBar
			// 
			lblMenuBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblMenuBar.Location = new Point(89, 24);
			lblMenuBar.Name = "lblMenuBar";
			lblMenuBar.Size = new Size(80, 31);
			lblMenuBar.TabIndex = 5;
			lblMenuBar.Text = "Menu";
			// 
			// pcBoxMenu
			// 
			pcBoxMenu.Cursor = Cursors.Hand;
			pcBoxMenu.Image = (Image)resources.GetObject("pcBoxMenu.Image");
			pcBoxMenu.Location = new Point(9, 9);
			pcBoxMenu.Name = "pcBoxMenu";
			pcBoxMenu.Size = new Size(57, 56);
			pcBoxMenu.SizeMode = PictureBoxSizeMode.StretchImage;
			pcBoxMenu.TabIndex = 0;
			pcBoxMenu.TabStop = false;
			pcBoxMenu.Click += pcBoxMenu_Click;
			// 
			// pnlOrderManagement
			// 
			pnlOrderManagement.Controls.Add(btnListOrder);
			pnlOrderManagement.Controls.Add(btnAddOrder);
			pnlOrderManagement.Controls.Add(btnOrderManagement);
			pnlOrderManagement.Location = new Point(3, 71);
			pnlOrderManagement.MaximumSize = new Size(263, 258);
			pnlOrderManagement.MinimumSize = new Size(263, 93);
			pnlOrderManagement.Name = "pnlOrderManagement";
			pnlOrderManagement.Size = new Size(263, 258);
			pnlOrderManagement.TabIndex = 5;
			// 
			// btnListOrder
			// 
			btnListOrder.BackColor = SystemColors.ControlDark;
			btnListOrder.FlatStyle = FlatStyle.Flat;
			btnListOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnListOrder.Image = (Image)resources.GetObject("btnListOrder.Image");
			btnListOrder.ImageAlign = ContentAlignment.MiddleLeft;
			btnListOrder.Location = new Point(3, 181);
			btnListOrder.Name = "btnListOrder";
			btnListOrder.Padding = new Padding(5, 0, 0, 0);
			btnListOrder.Size = new Size(247, 74);
			btnListOrder.TabIndex = 6;
			btnListOrder.Text = "                 List Order";
			btnListOrder.TextAlign = ContentAlignment.MiddleRight;
			btnListOrder.UseVisualStyleBackColor = false;
			btnListOrder.Click += btnListOrder_Click;
			// 
			// btnAddOrder
			// 
			btnAddOrder.BackColor = SystemColors.ControlDark;
			btnAddOrder.FlatStyle = FlatStyle.Flat;
			btnAddOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAddOrder.Image = (Image)resources.GetObject("btnAddOrder.Image");
			btnAddOrder.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddOrder.Location = new Point(3, 101);
			btnAddOrder.Name = "btnAddOrder";
			btnAddOrder.Padding = new Padding(5, 0, 0, 0);
			btnAddOrder.Size = new Size(247, 74);
			btnAddOrder.TabIndex = 5;
			btnAddOrder.Text = "                 Add Order";
			btnAddOrder.TextAlign = ContentAlignment.MiddleRight;
			btnAddOrder.UseVisualStyleBackColor = false;
			btnAddOrder.Click += btnAddOrder_Click;
			// 
			// btnOrderManagement
			// 
			btnOrderManagement.FlatStyle = FlatStyle.Flat;
			btnOrderManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnOrderManagement.Image = (Image)resources.GetObject("btnOrderManagement.Image");
			btnOrderManagement.ImageAlign = ContentAlignment.MiddleLeft;
			btnOrderManagement.Location = new Point(3, 12);
			btnOrderManagement.Name = "btnOrderManagement";
			btnOrderManagement.Padding = new Padding(5, 0, 0, 0);
			btnOrderManagement.Size = new Size(247, 74);
			btnOrderManagement.TabIndex = 4;
			btnOrderManagement.Text = "                 Order Management";
			btnOrderManagement.TextAlign = ContentAlignment.MiddleRight;
			btnOrderManagement.UseVisualStyleBackColor = true;
			btnOrderManagement.Click += btnOrderManagement_Click;
			// 
			// pnlProduct
			// 
			pnlProduct.Controls.Add(btnAddExtraMenu);
			pnlProduct.Controls.Add(btnAddMenu);
			pnlProduct.Controls.Add(btnProductManagement);
			pnlProduct.Location = new Point(3, 335);
			pnlProduct.MaximumSize = new Size(263, 281);
			pnlProduct.MinimumSize = new Size(263, 101);
			pnlProduct.Name = "pnlProduct";
			pnlProduct.Size = new Size(263, 281);
			pnlProduct.TabIndex = 5;
			// 
			// btnAddExtraMenu
			// 
			btnAddExtraMenu.BackColor = SystemColors.ControlDark;
			btnAddExtraMenu.FlatStyle = FlatStyle.Flat;
			btnAddExtraMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAddExtraMenu.Image = (Image)resources.GetObject("btnAddExtraMenu.Image");
			btnAddExtraMenu.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddExtraMenu.Location = new Point(3, 200);
			btnAddExtraMenu.Name = "btnAddExtraMenu";
			btnAddExtraMenu.Padding = new Padding(5, 0, 0, 0);
			btnAddExtraMenu.Size = new Size(247, 78);
			btnAddExtraMenu.TabIndex = 6;
			btnAddExtraMenu.Text = "              Add Extra Menu";
			btnAddExtraMenu.TextAlign = ContentAlignment.MiddleRight;
			btnAddExtraMenu.UseVisualStyleBackColor = false;
			btnAddExtraMenu.Click += btnAddExtraMenu_Click;
			// 
			// btnAddMenu
			// 
			btnAddMenu.BackColor = SystemColors.ControlDark;
			btnAddMenu.FlatStyle = FlatStyle.Flat;
			btnAddMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAddMenu.Image = (Image)resources.GetObject("btnAddMenu.Image");
			btnAddMenu.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddMenu.Location = new Point(3, 116);
			btnAddMenu.Name = "btnAddMenu";
			btnAddMenu.Padding = new Padding(5, 0, 0, 0);
			btnAddMenu.Size = new Size(247, 78);
			btnAddMenu.TabIndex = 5;
			btnAddMenu.Text = "              Add Menu";
			btnAddMenu.TextAlign = ContentAlignment.MiddleRight;
			btnAddMenu.UseVisualStyleBackColor = false;
			btnAddMenu.Click += btnAddMenu_Click;
			// 
			// btnProductManagement
			// 
			btnProductManagement.FlatStyle = FlatStyle.Flat;
			btnProductManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnProductManagement.Image = (Image)resources.GetObject("btnProductManagement.Image");
			btnProductManagement.ImageAlign = ContentAlignment.MiddleLeft;
			btnProductManagement.Location = new Point(3, 13);
			btnProductManagement.Name = "btnProductManagement";
			btnProductManagement.Padding = new Padding(5, 0, 0, 0);
			btnProductManagement.Size = new Size(247, 81);
			btnProductManagement.TabIndex = 4;
			btnProductManagement.Text = "              Product Management";
			btnProductManagement.TextAlign = ContentAlignment.MiddleRight;
			btnProductManagement.UseVisualStyleBackColor = true;
			btnProductManagement.Click += btnProductManagement_Click;
			// 
			// panel5
			// 
			panel5.Controls.Add(button4);
			panel5.Location = new Point(3, 622);
			panel5.Name = "panel5";
			panel5.Size = new Size(263, 80);
			panel5.TabIndex = 5;
			// 
			// button4
			// 
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(3, 3);
			button4.Name = "button4";
			button4.Size = new Size(247, 63);
			button4.TabIndex = 4;
			button4.Text = "Contact";
			button4.TextAlign = ContentAlignment.MiddleRight;
			button4.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(3, 12);
			button1.Name = "button1";
			button1.Padding = new Padding(5, 0, 0, 0);
			button1.Size = new Size(247, 50);
			button1.TabIndex = 4;
			button1.Text = "                Home";
			button1.TextAlign = ContentAlignment.MiddleRight;
			button1.UseVisualStyleBackColor = true;
			// 
			// sideBarTimer
			// 
			sideBarTimer.Interval = 1;
			sideBarTimer.Tick += sideBarTimer_Tick;
			// 
			// productManagementTimer
			// 
			productManagementTimer.Interval = 1;
			productManagementTimer.Tick += productManagementTimer_Tick;
			// 
			// orderManagementTimer
			// 
			orderManagementTimer.Interval = 1;
			orderManagementTimer.Tick += orderManagementTimer_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1082, 853);
			Controls.Add(flwSideBar);
			ForeColor = Color.Transparent;
			Icon = (Icon)resources.GetObject("$this.Icon");
			IsMdiContainer = true;
			MaximumSize = new Size(1100, 900);
			MinimumSize = new Size(1100, 900);
			Name = "Form1";
			Text = "Burger Queen";
			flwSideBar.ResumeLayout(false);
			pnlMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).EndInit();
			pnlOrderManagement.ResumeLayout(false);
			pnlProduct.ResumeLayout(false);
			panel5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private FlowLayoutPanel flwSideBar;
		private Panel pnlMenu;
		//private Panel panel1;
		private Button button1;
		private Panel pnlOrderManagement;
		private Button btnOrderManagement;
		private Panel pnlProduct;
		private Button btnProductManagement;
		private Panel panel5;
		private Button button4;
		private Label lblMenuBar;
		private PictureBox pcBoxMenu;
		private System.Windows.Forms.Timer sideBarTimer;
		private Button btnListOrder;
		private Button btnAddOrder;
		private Button btnAddExtraMenu;
		private Button btnAddMenu;
		private System.Windows.Forms.Timer productManagementTimer;
		private System.Windows.Forms.Timer orderManagementTimer;
	}
}