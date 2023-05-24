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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            addOrderToolStripMenuItem = new ToolStripMenuItem();
            listOrderToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            addMenuToolStripMenuItem = new ToolStripMenuItem();
            addExtraProductToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderManagementToolStripMenuItem, productManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(172, 653);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1100, 700);
            MinimumSize = new Size(1100, 700);
            Name = "Form1";
            Text = "Burger Queen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}