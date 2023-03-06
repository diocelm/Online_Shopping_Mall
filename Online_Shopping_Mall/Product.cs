using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping_Mall
{
     public class Product
    {
        public string Item { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string item, string description, decimal price)
        {
            this.Item = item;
            this.Description = description;
            this.Price = price;
        }

        Product p1 = new Product("Tshirt", "V-neck, Color: Red, Size: S", 250);
        Product p2 = new Product("Short", "Cargo, Color: Blue, Size: M", 550);
        Product p3 = new Product("Dress", "Floral Color: Yellow, Size: S", 1000);
        Product p4 = new Product("Slipper", "Flipflop, Color: Black, Size: 37", 350);
        Product p5 = new Product("BackBag", "Heartstring, Color: Maroon", 850);
    }
}
