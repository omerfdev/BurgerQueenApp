namespace BurgerQueenApp
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			pcBoxGitHub = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pcBoxGitHub).BeginInit();
			SuspendLayout();
			// 
			// pcBoxGitHub
			// 
			pcBoxGitHub.Image = (Image)resources.GetObject("pcBoxGitHub.Image");
			pcBoxGitHub.Location = new Point(249, 164);
			pcBoxGitHub.Name = "pcBoxGitHub";
			pcBoxGitHub.Size = new Size(117, 62);
			pcBoxGitHub.SizeMode = PictureBoxSizeMode.StretchImage;
			pcBoxGitHub.TabIndex = 0;
			pcBoxGitHub.TabStop = false;
			pcBoxGitHub.Click += pcBoxGitHub_Click;
			// 
			// Form6
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pcBoxGitHub);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form6";
			Text = "Form6";
			((System.ComponentModel.ISupportInitialize)pcBoxGitHub).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pcBoxGitHub;
	}
}