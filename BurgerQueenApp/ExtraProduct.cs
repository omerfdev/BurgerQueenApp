using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQueenApp
{
    public class ExtraProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static List<ExtraProduct> extraProducts = new List<ExtraProduct>()
        {
            new ExtraProduct{Name="Ketchup", Price=0.25},
            new ExtraProduct{Name="Mayonnaise", Price=0.25},
            new ExtraProduct{Name="BBQ", Price=0.25},
            new ExtraProduct{Name="Mustard", Price=0.25},
            new ExtraProduct{Name="Ranch Sauce", Price=0.25},
            new ExtraProduct{Name="Buffalo", Price=0.25},

        };
        public ExtraProduct()
        {
            
        }
        
    }
}
