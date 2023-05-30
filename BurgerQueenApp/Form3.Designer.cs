namespace BurgerQueenApp
{
    partial class Form3
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
            listBox1 = new ListBox();
            btnList = new Button();
            groupBoxCiro = new GroupBox();
            lblCiro = new Label();
            groupBoxTSiparisSayisi = new GroupBox();
            lblTSiparişSayisi = new Label();
            groupBoxExtraMalzemeGeliri = new GroupBox();
            lblExtraMalzemeGeliri = new Label();
            groupBoxSatilanUrun = new GroupBox();
            lblSatilanUrun = new Label();
            groupBoxCiro.SuspendLayout();
            groupBoxTSiparisSayisi.SuspendLayout();
            groupBoxExtraMalzemeGeliri.SuspendLayout();
            groupBoxSatilanUrun.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(553, 344);
            listBox1.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(196, 380);
            btnList.Name = "btnList";
            btnList.Size = new Size(135, 29);
            btnList.TabIndex = 1;
            btnList.Text = "List Order";
            btnList.UseVisualStyleBackColor = true;
            // 
            // groupBoxCiro
            // 
            groupBoxCiro.Controls.Add(lblCiro);
            groupBoxCiro.Location = new Point(600, 33);
            groupBoxCiro.Name = "groupBoxCiro";
            groupBoxCiro.Size = new Size(250, 98);
            groupBoxCiro.TabIndex = 2;
            groupBoxCiro.TabStop = false;
            groupBoxCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(29, 46);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(0, 20);
            lblCiro.TabIndex = 0;
            // 
            // groupBoxTSiparisSayisi
            // 
            groupBoxTSiparisSayisi.Controls.Add(lblTSiparişSayisi);
            groupBoxTSiparisSayisi.Location = new Point(600, 137);
            groupBoxTSiparisSayisi.Name = "groupBoxTSiparisSayisi";
            groupBoxTSiparisSayisi.Size = new Size(250, 98);
            groupBoxTSiparisSayisi.TabIndex = 3;
            groupBoxTSiparisSayisi.TabStop = false;
            groupBoxTSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblTSiparişSayisi
            // 
            lblTSiparişSayisi.AutoSize = true;
            lblTSiparişSayisi.ForeColor = Color.Red;
            lblTSiparişSayisi.Location = new Point(29, 46);
            lblTSiparişSayisi.Name = "lblTSiparişSayisi";
            lblTSiparişSayisi.Size = new Size(0, 20);
            lblTSiparişSayisi.TabIndex = 0;
            // 
            // groupBoxExtraMalzemeGeliri
            // 
            groupBoxExtraMalzemeGeliri.Controls.Add(lblExtraMalzemeGeliri);
            groupBoxExtraMalzemeGeliri.Location = new Point(600, 241);
            groupBoxExtraMalzemeGeliri.Name = "groupBoxExtraMalzemeGeliri";
            groupBoxExtraMalzemeGeliri.Size = new Size(250, 98);
            groupBoxExtraMalzemeGeliri.TabIndex = 4;
            groupBoxExtraMalzemeGeliri.TabStop = false;
            groupBoxExtraMalzemeGeliri.Text = "Extra Malzeme Geliri";
            // 
            // lblExtraMalzemeGeliri
            // 
            lblExtraMalzemeGeliri.AutoSize = true;
            lblExtraMalzemeGeliri.ForeColor = Color.Red;
            lblExtraMalzemeGeliri.Location = new Point(29, 46);
            lblExtraMalzemeGeliri.Name = "lblExtraMalzemeGeliri";
            lblExtraMalzemeGeliri.Size = new Size(0, 20);
            lblExtraMalzemeGeliri.TabIndex = 0;
            // 
            // groupBoxSatilanUrun
            // 
            groupBoxSatilanUrun.Controls.Add(lblSatilanUrun);
            groupBoxSatilanUrun.Location = new Point(600, 345);
            groupBoxSatilanUrun.Name = "groupBoxSatilanUrun";
            groupBoxSatilanUrun.Size = new Size(250, 93);
            groupBoxSatilanUrun.TabIndex = 5;
            groupBoxSatilanUrun.TabStop = false;
            groupBoxSatilanUrun.Text = "Satılan Ürün";
            // 
            // lblSatilanUrun
            // 
            lblSatilanUrun.AutoSize = true;
            lblSatilanUrun.ForeColor = Color.Red;
            lblSatilanUrun.Location = new Point(29, 46);
            lblSatilanUrun.Name = "lblSatilanUrun";
            lblSatilanUrun.Size = new Size(0, 20);
            lblSatilanUrun.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(groupBoxSatilanUrun);
            Controls.Add(groupBoxExtraMalzemeGeliri);
            Controls.Add(groupBoxTSiparisSayisi);
            Controls.Add(groupBoxCiro);
            Controls.Add(btnList);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Load += Form3_Load;
            groupBoxCiro.ResumeLayout(false);
            groupBoxCiro.PerformLayout();
            groupBoxTSiparisSayisi.ResumeLayout(false);
            groupBoxTSiparisSayisi.PerformLayout();
            groupBoxExtraMalzemeGeliri.ResumeLayout(false);
            groupBoxExtraMalzemeGeliri.PerformLayout();
            groupBoxSatilanUrun.ResumeLayout(false);
            groupBoxSatilanUrun.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnList;
        private GroupBox groupBoxCiro;
        private Label lblCiro;
        private GroupBox groupBoxTSiparisSayisi;
        private Label lblTSiparişSayisi;
        private GroupBox groupBoxExtraMalzemeGeliri;
        private Label lblExtraMalzemeGeliri;
        private GroupBox groupBoxSatilanUrun;
        private Label lblSatilanUrun;
    }
}