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
            new ExtraProduct{Name="Mayonnaise", Price=0.26},
            new ExtraProduct{Name="BBQ", Price=0.27},
            new ExtraProduct{Name="Mustard", Price=0.28},
            new ExtraProduct{Name="Ranch Sauce", Price=0.29},
            new ExtraProduct{Name="Buffalo", Price=0.30},

        };

        public override string ToString()
        {
            
            return $"{Name}  ";
        }
    }
}
