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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public void Form3_Load(object sender, EventArgs e)
        {
            //TODO:BURASI YAPILACAK.SİPARİŞ SAYISI,CİRO ,EXTRA MALZEME GELİRİ,TOPLAM GELİR VERİLERİNİ ALMAN LAZIM.
            if (Form1.finishedOrders != null)
            {
                listBox1.DataSource = Form1.finishedOrders;
            }
            foreach (var item in Form1.finishedOrders)
            {
                lblCiro.Text = Convert.ToString(item.CalculateOrder());
                lblExtraMalzemeGeliri.Text = Convert.ToString(item.Product.extraProducts.ToArray());
                lblSatilanUrun.Text = Convert.ToString(item.OrderCount);
                lblTSiparisSayisi.Text = Convert.ToString(item.OrderCount);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
