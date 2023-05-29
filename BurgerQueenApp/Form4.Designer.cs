namespace BurgerQueenApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnAddExtraProduct = new Button();
            txtbxMenu = new TextBox();
            numericUpDownMenuPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenuPrice).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1497554315_burger_84849;
            pictureBox1.Location = new Point(526, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 154);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnAddExtraProduct
            // 
            btnAddExtraProduct.Location = new Point(258, 185);
            btnAddExtraProduct.Name = "btnAddExtraProduct";
            btnAddExtraProduct.Size = new Size(144, 42);
            btnAddExtraProduct.TabIndex = 6;
            btnAddExtraProduct.Text = "Add Menu";
            btnAddExtraProduct.UseVisualStyleBackColor = true;
            btnAddExtraProduct.Click += btnAddExtraProduct_Click_1;
            // 
            // txtbxMenu
            // 
            txtbxMenu.Location = new Point(258, 93);
            txtbxMenu.MaxLength = 30;
            txtbxMenu.Name = "txtbxMenu";
            txtbxMenu.PlaceholderText = "Menu Name";
            txtbxMenu.Size = new Size(148, 27);
            txtbxMenu.TabIndex = 4;
            // 
            // numericUpDownMenuPrice
            // 
            numericUpDownMenuPrice.Location = new Point(258, 141);
            numericUpDownMenuPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMenuPrice.Name = "numericUpDownMenuPrice";
            numericUpDownMenuPrice.Size = new Size(144, 27);
            numericUpDownMenuPrice.TabIndex = 8;
            numericUpDownMenuPrice.ThousandsSeparator = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownMenuPrice);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddExtraProduct);
            Controls.Add(txtbxMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenuPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddExtraProduct;
        private TextBox txtbxMenu;
        private NumericUpDown numericUpDownMenuPrice;
    }
}