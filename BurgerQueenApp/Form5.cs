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
        public List<ExtraProduct> extraProducts = new List<ExtraProduct>()
        {
            new ExtraProduct{Name="Ketchup", Price=0.25},
            new ExtraProduct{Name="Mayonnaise", Price=0.25},
            new ExtraProduct{Name="BBQ", Price=0.25},
            new ExtraProduct{Name="Mustard", Price=0.25},
            new ExtraProduct{Name="Ranch Sauce", Price=0.25},
            new ExtraProduct{Name="Buffalo", Price=0.25},
            
        };
        private void btnAddExtraProduct_Click(object sender, EventArgs e)
        {
            extraProducts.Add(new ExtraProduct { Name = txtbxExtraProduct.Text, Price = double.Parse(txtbxProductPrice.Text) });
           

        }
    }
}
