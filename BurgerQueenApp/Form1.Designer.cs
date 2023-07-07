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
			menuStrip1 = new MenuStrip();
			orderManagementToolStripMenuItem = new ToolStripMenuItem();
			addOrderToolStripMenuItem = new ToolStripMenuItem();
			listOrderToolStripMenuItem = new ToolStripMenuItem();
			productManagementToolStripMenuItem = new ToolStripMenuItem();
			addMenuToolStripMenuItem = new ToolStripMenuItem();
			addExtraProductToolStripMenuItem = new ToolStripMenuItem();
			flwSideBar = new FlowLayoutPanel();
			pnlMenu = new Panel();
			lblMenuBar = new Label();
			pcBoxMenu = new PictureBox();
			pnlOrderManagement = new Panel();
			button6 = new Button();
			button5 = new Button();
			btnOrderManagement = new Button();
			pnlProduct = new Panel();
			button8 = new Button();
			button7 = new Button();
			btnProductManagement = new Button();
			panel5 = new Panel();
			button4 = new Button();
			button1 = new Button();
			sideBarTimer = new System.Windows.Forms.Timer(components);
			productManagementTimer = new System.Windows.Forms.Timer(components);
			orderManagementTimer = new System.Windows.Forms.Timer(components);
			menuStrip1.SuspendLayout();
			flwSideBar.SuspendLayout();
			pnlMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).BeginInit();
			pnlOrderManagement.SuspendLayout();
			pnlProduct.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Dock = DockStyle.Right;
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { orderManagementToolStripMenuItem, productManagementToolStripMenuItem });
			menuStrip1.Location = new Point(910, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(172, 853);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// orderManagementToolStripMenuItem
			// 
			orderManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addOrderToolStripMenuItem, listOrderToolStripMenuItem });
			orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
			orderManagementToolStripMenuItem.Size = new Size(159, 24);
			orderManagementToolStripMenuItem.Text = "Order Management";
			// 
			// addOrderToolStripMenuItem
			// 
			addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
			addOrderToolStripMenuItem.Size = new Size(162, 26);
			addOrderToolStripMenuItem.Text = "Add Order";
			addOrderToolStripMenuItem.Click += addOrderToolStripMenuItem_Click;
			// 
			// listOrderToolStripMenuItem
			// 
			listOrderToolStripMenuItem.Name = "listOrderToolStripMenuItem";
			listOrderToolStripMenuItem.Size = new Size(162, 26);
			listOrderToolStripMenuItem.Text = "List Order";
			listOrderToolStripMenuItem.Click += listOrderToolStripMenuItem_Click;
			// 
			// productManagementToolStripMenuItem
			// 
			productManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addMenuToolStripMenuItem, addExtraProductToolStripMenuItem });
			productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
			productManagementToolStripMenuItem.Size = new Size(159, 24);
			productManagementToolStripMenuItem.Text = "Product Management";
			// 
			// addMenuToolStripMenuItem
			// 
			addMenuToolStripMenuItem.Name = "addMenuToolStripMenuItem";
			addMenuToolStripMenuItem.Size = new Size(212, 26);
			addMenuToolStripMenuItem.Text = "Add Menu";
			addMenuToolStripMenuItem.Click += addMenuToolStripMenuItem_Click;
			// 
			// addExtraProductToolStripMenuItem
			// 
			addExtraProductToolStripMenuItem.Name = "addExtraProductToolStripMenuItem";
			addExtraProductToolStripMenuItem.Size = new Size(212, 26);
			addExtraProductToolStripMenuItem.Text = "Add Extra Product";
			addExtraProductToolStripMenuItem.Click += addExtraProductToolStripMenuItem_Click;
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
			pnlOrderManagement.Controls.Add(button6);
			pnlOrderManagement.Controls.Add(button5);
			pnlOrderManagement.Controls.Add(btnOrderManagement);
			pnlOrderManagement.Location = new Point(3, 71);
			pnlOrderManagement.MaximumSize = new Size(263, 258);
			pnlOrderManagement.MinimumSize = new Size(263, 93);
			pnlOrderManagement.Name = "pnlOrderManagement";
			pnlOrderManagement.Size = new Size(263, 258);
			pnlOrderManagement.TabIndex = 5;
			// 
			// button6
			// 
			button6.BackColor = SystemColors.ControlDark;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button6.Image = (Image)resources.GetObject("button6.Image");
			button6.ImageAlign = ContentAlignment.MiddleLeft;
			button6.Location = new Point(3, 181);
			button6.Name = "button6";
			button6.Padding = new Padding(5, 0, 0, 0);
			button6.Size = new Size(247, 74);
			button6.TabIndex = 6;
			button6.Text = "                 List Order";
			button6.TextAlign = ContentAlignment.MiddleRight;
			button6.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			button5.BackColor = SystemColors.ControlDark;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(3, 101);
			button5.Name = "button5";
			button5.Padding = new Padding(5, 0, 0, 0);
			button5.Size = new Size(247, 74);
			button5.TabIndex = 5;
			button5.Text = "                 Add Order";
			button5.TextAlign = ContentAlignment.MiddleRight;
			button5.UseVisualStyleBackColor = false;
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
			pnlProduct.Controls.Add(button8);
			pnlProduct.Controls.Add(button7);
			pnlProduct.Controls.Add(btnProductManagement);
			pnlProduct.Location = new Point(3, 335);
			pnlProduct.MaximumSize = new Size(263, 281);
			pnlProduct.MinimumSize = new Size(263, 101);
			pnlProduct.Name = "pnlProduct";
			pnlProduct.Size = new Size(263, 281);
			pnlProduct.TabIndex = 5;
			// 
			// button8
			// 
			button8.BackColor = SystemColors.ControlDark;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button8.Image = (Image)resources.GetObject("button8.Image");
			button8.ImageAlign = ContentAlignment.MiddleLeft;
			button8.Location = new Point(3, 200);
			button8.Name = "button8";
			button8.Padding = new Padding(5, 0, 0, 0);
			button8.Size = new Size(247, 78);
			button8.TabIndex = 6;
			button8.Text = "              Add Extra Menu";
			button8.TextAlign = ContentAlignment.MiddleRight;
			button8.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			button7.BackColor = SystemColors.ControlDark;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button7.Image = (Image)resources.GetObject("button7.Image");
			button7.ImageAlign = ContentAlignment.MiddleLeft;
			button7.Location = new Point(3, 116);
			button7.Name = "button7";
			button7.Padding = new Padding(5, 0, 0, 0);
			button7.Size = new Size(247, 78);
			button7.TabIndex = 5;
			button7.Text = "              Add Menu";
			button7.TextAlign = ContentAlignment.MiddleRight;
			button7.UseVisualStyleBackColor = false;
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
			Controls.Add(menuStrip1);
			ForeColor = Color.Transparent;
			Icon = (Icon)resources.GetObject("$this.Icon");
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			MaximumSize = new Size(1100, 900);
			MinimumSize = new Size(1100, 900);
			Name = "Form1";
			Text = "Burger Queen";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			flwSideBar.ResumeLayout(false);
			pnlMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).EndInit();
			pnlOrderManagement.ResumeLayout(false);
			pnlProduct.ResumeLayout(false);
			panel5.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem orderManagementToolStripMenuItem;
		private ToolStripMenuItem addOrderToolStripMenuItem;
		private ToolStripMenuItem listOrderToolStripMenuItem;
		private ToolStripMenuItem productManagementToolStripMenuItem;
		private ToolStripMenuItem addMenuToolStripMenuItem;
		private ToolStripMenuItem addExtraProductToolStripMenuItem;
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
		private Button button6;
		private Button button5;
		private Button button8;
		private Button button7;
		private System.Windows.Forms.Timer productManagementTimer;
		private System.Windows.Forms.Timer orderManagementTimer;
	}
}