using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class Order
    {

        public Product Product { get; set; } //= new Product();
        List<ExtraProduct> selectedExtraProducts = new List<ExtraProduct>();
        public double ExtraProductPrice { get; set; }  
        public double TotalPrice { get; set; }
        public int OrderCount { get; set; }
        public double CalculateOrder()
        {
            TotalPrice = 0;            
            TotalPrice =TotalPrice+Product.Price;
            switch (Product.Size)
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
                item.ExtraProductPrice=item.Price+item.ExtraProductPrice;
                TotalPrice = TotalPrice + item.Price;
            }
            return TotalPrice = TotalPrice * OrderCount;
        }
        public override string ToString()
        {            

                if (Product.extraProducts.Count < 1)
                {
                
                return string.Format("{0}x{1} adet\n {2} boy\n {3} ekstraları {4} Toplam ", Product.Name, OrderCount, Product.Size,ExtraProduct.extraProducts, TotalPrice);
                }
                else
                {
                    
                    string lineString = string.Join(",", Product.extraProducts);
                    return string.Format("{0} x {1} Adet\n ,Boy: {2} \n , Ekstra Ürün:{3}\n {4}", Product.Name, OrderCount, Product.Size,lineString, TotalPrice);
                }
                      
            
        }

    }
}
