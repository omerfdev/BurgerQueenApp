namespace BurgerQueenApp
{
    partial class Form2
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
            lblTotalCoastPrice = new Label();
            lblTotalCoast = new Label();
            label2 = new Label();
            buttonOrderAdd = new Button();
            lblMQQOFORDER = new Label();
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanelExtraProduct = new FlowLayoutPanel();
            grpbxSize = new GroupBox();
            radioButtonLargeSize = new RadioButton();
            radioButtonMediumSize = new RadioButton();
            radioButtonSmallSize = new RadioButton();
            comboBox1 = new ComboBox();
            btnFinishOrder = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            grpbxSize.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Burger;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTotalCoastPrice
            // 
            lblTotalCoastPrice.AutoSize = true;
            lblTotalCoastPrice.ForeColor = Color.Red;
            lblTotalCoastPrice.Location = new Point(391, 462);
            lblTotalCoastPrice.Name = "lblTotalCoastPrice";
            lblTotalCoastPrice.Size = new Size(0, 20);
            lblTotalCoastPrice.TabIndex = 26;
            // 
            // lblTotalCoast
            // 
            lblTotalCoast.AutoSize = true;
            lblTotalCoast.BackColor = SystemColors.ControlLightLight;
            lblTotalCoast.Location = new Point(283, 462);
            lblTotalCoast.Name = "lblTotalCoast";
            lblTotalCoast.Size = new Size(86, 20);
            lblTotalCoast.TabIndex = 25;
            lblTotalCoast.Text = "Total Coast:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OliveDrab;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 287);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 24;
            label2.Text = "CHOOSE EXTRA PRODUCT";
            // 
            // buttonOrderAdd
            // 
            buttonOrderAdd.Location = new Point(208, 458);
            buttonOrderAdd.Name = "buttonOrderAdd";
            buttonOrderAdd.Size = new Size(63, 29);
            buttonOrderAdd.TabIndex = 23;
            buttonOrderAdd.Text = "Add";
            buttonOrderAdd.UseVisualStyleBackColor = true;
            buttonOrderAdd.Click += buttonOrderAdd_Click;
            // 
            // lblMQQOFORDER
            // 
            lblMQQOFORDER.AutoSize = true;
            lblMQQOFORDER.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMQQOFORDER.Location = new Point(12, 460);
            lblMQQOFORDER.Name = "lblMQQOFORDER";
            lblMQQOFORDER.Size = new Size(119, 20);
            lblMQQOFORDER.TabIndex = 22;
            lblMQQOFORDER.Text = "MOQ OF ORDER";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 458);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 27);
            numericUpDown1.TabIndex = 21;
            // 
            // flowLayoutPanelExtraProduct
            // 
            flowLayoutPanelExtraProduct.AccessibleName = "";
            flowLayoutPanelExtraProduct.Location = new Point(12, 310);
            flowLayoutPanelExtraProduct.Name = "flowLayoutPanelExtraProduct";
            flowLayoutPanelExtraProduct.Size = new Size(259, 142);
            flowLayoutPanelExtraProduct.TabIndex = 20;
            // 
            // grpbxSize
            // 
            grpbxSize.Controls.Add(radioButtonLargeSize);
            grpbxSize.Controls.Add(radioButtonMediumSize);
            grpbxSize.Controls.Add(radioButtonSmallSize);
            grpbxSize.Location = new Point(12, 222);
            grpbxSize.Name = "grpbxSize";
            grpbxSize.Size = new Size(259, 62);
            grpbxSize.TabIndex = 19;
            grpbxSize.TabStop = false;
            grpbxSize.Text = "Size";
            // 
            // radioButtonLargeSize
            // 
            radioButtonLargeSize.AutoSize = true;
            radioButtonLargeSize.Location = new Point(170, 30);
            radioButtonLargeSize.Name = "radioButtonLargeSize";
            radioButtonLargeSize.Size = new Size(67, 24);
            radioButtonLargeSize.TabIndex = 2;
            radioButtonLargeSize.TabStop = true;
            radioButtonLargeSize.Text = "Large";
            radioButtonLargeSize.UseVisualStyleBackColor = true;
            // 
            // radioButtonMediumSize
            // 
            radioButtonMediumSize.AutoSize = true;
            radioButtonMediumSize.Location = new Point(79, 30);
            radioButtonMediumSize.Name = "radioButtonMediumSize";
            radioButtonMediumSize.Size = new Size(85, 24);
            radioButtonMediumSize.TabIndex = 1;
            radioButtonMediumSize.TabStop = true;
            radioButtonMediumSize.Text = "Medium";
            radioButtonMediumSize.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmallSize
            // 
            radioButtonSmallSize.AutoSize = true;
            radioButtonSmallSize.Location = new Point(6, 30);
            radioButtonSmallSize.Name = "radioButtonSmallSize";
            radioButtonSmallSize.Size = new Size(67, 24);
            radioButtonSmallSize.TabIndex = 0;
            radioButtonSmallSize.TabStop = true;
            radioButtonSmallSize.Text = "Small";
            radioButtonSmallSize.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // btnFinishOrder
            // 
            btnFinishOrder.BackColor = Color.Yellow;
            btnFinishOrder.Location = new Point(511, 428);
            btnFinishOrder.Name = "btnFinishOrder";
            btnFinishOrder.Size = new Size(122, 52);
            btnFinishOrder.TabIndex = 28;
            btnFinishOrder.Text = "FINISH THE ORDER";
            btnFinishOrder.UseVisualStyleBackColor = false;
            btnFinishOrder.Click += btnFinishOrder_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(283, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(566, 384);
            listBox1.TabIndex = 27;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 517);
            Controls.Add(btnFinishOrder);
            Controls.Add(listBox1);
            Controls.Add(lblTotalCoastPrice);
            Controls.Add(lblTotalCoast);
            Controls.Add(label2);
            Controls.Add(buttonOrderAdd);
            Controls.Add(lblMQQOFORDER);
            Controls.Add(numericUpDown1);
            Controls.Add(flowLayoutPanelExtraProduct);
            Controls.Add(grpbxSize);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Add Burger Order Page";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            grpbxSize.ResumeLayout(false);
            grpbxSize.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTotalCoastPrice;
        private Label lblTotalCoast;
        private Label label2;
        private Button buttonOrderAdd;
        private Label lblMQQOFORDER;
        private NumericUpDown numericUpDown1;
        public FlowLayoutPanel flowLayoutPanelExtraProduct;
        private GroupBox grpbxSize;
        private ComboBox comboBox1;
        private Button btnFinishOrder;
        private ListBox listBox1;
        private RadioButton radioButtonLargeSize;
        private RadioButton radioButtonMediumSize;
        private RadioButton radioButtonSmallSize;
    }
}