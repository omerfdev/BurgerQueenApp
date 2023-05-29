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
       
        public double TotalPrice { get; set; }
        public int OrderCount { get; set; }
        public void CalculateOrder()
        {
            TotalPrice = 0;
            
            TotalPrice =TotalPrice+Product.Price;
            switch (Product.Sizes)
            {
                case ProductSize.Small:
                    TotalPrice = TotalPrice + 1;
                    break;
                case ProductSize.Medium:
                    TotalPrice = TotalPrice + 2;
                    break;
                case ProductSize.Large:
                    TotalPrice = TotalPrice + 3;
                    break;
                                
            }
            foreach (ExtraProduct item in Product.extraProducts)
            {
                TotalPrice = TotalPrice + item.Price;
            }
            TotalPrice = TotalPrice * OrderCount;

        }
        public override string ToString()
        {            

                if (Product.extraProducts.Count < 1)
                {
                    return string.Format("{0}x{1} adet ,{2} boy, Toplam {3}", Product.Name, OrderCount, Product.Sizes, TotalPrice);
                }
                else
                {
                    return string.Format("{0}x{1} adet ,{2} boy, Toplam {3}", Product.Name, OrderCount, Product.Sizes, TotalPrice);
                }
                      
            
        }

    }
}
