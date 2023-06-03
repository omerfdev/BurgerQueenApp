using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public  List<ExtraProduct> extraProducts = new List<ExtraProduct>(){};
        public ProductSize Size { get; set; }
        public string Image { get; set; }    
        public static List<Product> Products = new List<Product>()
        {
            new Product{Name="Burger Queen", Price=5.28,Image=@"C:\Users\omerf\source\repos\BurgerQueenApp\BurgerQueenApp\Image\Burger Queen.png" },
            new Product{Name="Big Mac", Price=4.25,Image=@"C:\Users\omerf\source\repos\BurgerQueenApp\BurgerQueenApp\Image\Big Mac.png"},
            new Product{Name="Mac", Price=3.25,Image=@"C:\Users\omerf\source\repos\BurgerQueenApp\BurgerQueenApp\Image\Mac.png"},
            new Product{Name="CheeseBurger", Price=4.25,Image = @"C:\Users\omerf\source\repos\BurgerQueenApp\BurgerQueenApp\Image\Cheese Burger.png"},

        };
    }


}
