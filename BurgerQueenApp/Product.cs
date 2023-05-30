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
            new Product{Name="BurgerQueen", Price=5.28 },
            new Product{Name="BigMac", Price=4.25},
            new Product{Name="Mac", Price=3.25},
            new Product{Name="CheeseBurger", Price=4.25},

        };
    }


}
