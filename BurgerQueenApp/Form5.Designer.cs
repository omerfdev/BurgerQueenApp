namespace BurgerQueenApp
{
    partial class Form5
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
            txtbxExtraProduct = new TextBox();
            txtbxProductPrice = new TextBox();
            btnAddExtraProduct = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbxExtraProduct
            // 
            txtbxExtraProduct.Location = new Point(114, 89);
            txtbxExtraProduct.MaxLength = 30;
            txtbxExtraProduct.Name = "txtbxExtraProduct";
            txtbxExtraProduct.PlaceholderText = "Product";
            txtbxExtraProduct.Size = new Size(293, 27);
            txtbxExtraProduct.TabIndex = 0;
            // 
            // txtbxProductPrice
            // 
            txtbxProductPrice.Location = new Point(114, 137);
            txtbxProductPrice.MaxLength = 30;
            txtbxProductPrice.Name = "txtbxProductPrice";
            txtbxProductPrice.PlaceholderText = "Price";
            txtbxProductPrice.Size = new Size(293, 27);
            txtbxProductPrice.TabIndex = 1;
            // 
            // btnAddExtraProduct
            // 
            btnAddExtraProduct.Location = new Point(182, 184);
            btnAddExtraProduct.Name = "btnAddExtraProduct";
            btnAddExtraProduct.Size = new Size(144, 42);
            btnAddExtraProduct.TabIndex = 2;
            btnAddExtraProduct.Text = "Add Extra Product";
            btnAddExtraProduct.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1497554315_burger_84849;
            pictureBox1.Location = new Point(491, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 146);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddExtraProduct);
            Controls.Add(txtbxProductPrice);
            Controls.Add(txtbxExtraProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxExtraProduct;
        private TextBox txtbxProductPrice;
        private Button btnAddExtraProduct;
        private PictureBox pictureBox1;
    }
}