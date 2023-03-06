using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping_Mall
{
    class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Order(Customer customer, List<Product> products, DateTime orderDate, decimal totalPrice)
        {
            this.Customer = customer;
            this.Products = products;
            this.OrderDate = orderDate;
            this.TotalPrice = totalPrice;
        }

        // Method to calculate the total price of the order
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0m;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }


}
