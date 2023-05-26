using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class Order
    {
        public Product Product { get; set; }

        public Size Size { get; set; }  
        public ExtraProduct ExtraProduct { get; set; }
        public double CalculateOrder(ExtraProduct extraProduct,Product product) { return (extraProduct.Price+product.Price); }
     
    }
}
