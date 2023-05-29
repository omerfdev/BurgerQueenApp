using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerQueenApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAddExtraProduct_Click(object sender, EventArgs e)
        {

            ExtraProduct.extraProducts.Add(new ExtraProduct { Name = txtbxExtraProduct.Text, Price = (double)numericUpDown1.Value });


        }
    }
}
