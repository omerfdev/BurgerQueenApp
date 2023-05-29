using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public  List<ExtraProduct> extraProducts = new List<ExtraProduct>(){};
        public ProductSize Sizes { get; set; }
        public static List<Product> Products = new List<Product>()
        {
            new Product{Name="Burger Queen", Price=5.25,Sizes=ProductSize.Large},
            new Product{Name="Big Mac", Price=4.25,Sizes=ProductSize.Small},
            new Product{Name="Mac", Price=3.25, Sizes = ProductSize.Large},
            new Product{Name="Lahmacun", Price=4.25, Sizes = ProductSize.Medium},

        };
    }


}
