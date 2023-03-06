using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping_Mall
{
     class Store
    {
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string Address { get; set; }
        public List<Product> ProductList { get; set; }

        public Store(string storeName, string storeDescription, string address)
        {
            StoreName = storeName;
            StoreDescription = storeDescription;
            Address = address;
            ProductList = new List<Product>();
        }

       

        List<Store> stores = new List<Store>
            {
            new Store("Store 1", "123 Main St", new List<Product>
            {
                new Product("Product A", "This is product A", 10.99),
                new Product("Product B", "This is product B", 5.99m),
                new Product("Product C", "This is product C", 7.99m)
            }),
            new Store("Store 2", "456 Oak St", new List<Product>
            {
                new Product("Product D", "This is product D", 12.99m),
                new Product("Product E", "This is product E", 9.99m),
                new Product("Product F", "This is product F", 4.99m)
            }),
            new Store("Store 3", "789 Maple St", new List<Product>
            {
                new Product("Product G", "This is product G", 8.99m),
                new Product("Product H", "This is product H", 6.99m),
                new Product("Product I", "This is product I", 3.99m)
            })
             };


    }
}
