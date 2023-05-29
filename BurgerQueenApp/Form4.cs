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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAddExtraProduct_Click_1(object sender, EventArgs e)
        {

            Product.Products.Add(new Product { Name = txtbxMenu.Text, Price = ((double)numericUpDownMenuPrice.Value) });

        }
    }
}
