using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerQueenApp
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		static void OpenBrowser(string url)
		{

			Process.Start(new ProcessStartInfo
			{
				FileName = url,
				UseShellExecute = true
			});

		}

		private void pcBoxGitHub_Click(object sender, EventArgs e)
		{
			OpenBrowser("https://github.com/omerfdev");
		}
	}
}
