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
			btnAddExtraProduct = new Button();
			pictureBox1 = new PictureBox();
			numericUpDown1 = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// txtbxExtraProduct
			// 
			txtbxExtraProduct.Location = new Point(159, 109);
			txtbxExtraProduct.MaxLength = 30;
			txtbxExtraProduct.Name = "txtbxExtraProduct";
			txtbxExtraProduct.PlaceholderText = "Extra Product";
			txtbxExtraProduct.Size = new Size(149, 27);
			txtbxExtraProduct.TabIndex = 0;
			// 
			// btnAddExtraProduct
			// 
			btnAddExtraProduct.BackColor = Color.OliveDrab;
			btnAddExtraProduct.Location = new Point(159, 183);
			btnAddExtraProduct.Name = "btnAddExtraProduct";
			btnAddExtraProduct.Size = new Size(149, 56);
			btnAddExtraProduct.TabIndex = 2;
			btnAddExtraProduct.Text = "Add Extra Product";
			btnAddExtraProduct.UseVisualStyleBackColor = false;
			btnAddExtraProduct.Click += btnAddExtraProduct_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._1497554315_burger_84849;
			pictureBox1.Location = new Point(389, 109);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(127, 130);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(161, 149);
			numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(147, 27);
			numericUpDown1.TabIndex = 4;
			numericUpDown1.ThousandsSeparator = true;
			// 
			// Form5
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(numericUpDown1);
			Controls.Add(pictureBox1);
			Controls.Add(btnAddExtraProduct);
			Controls.Add(txtbxExtraProduct);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form5";
			Text = "Form5";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtbxExtraProduct;
		private Button btnAddExtraProduct;
		private PictureBox pictureBox1;
		private NumericUpDown numericUpDown1;
	}
}