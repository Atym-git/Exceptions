using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Stock { get; private set; }

        public Product(string name, int price, int stock)
        {
            Name = name;
            if (price <= 0)
            {
                throw new ArgumentException(nameof(price), "Price can not be less than zero");
            }
            if (stock <= 0)
            {
                throw new ArgumentException(nameof(stock), "Stock can not be less than zero");
            }
            Price = price;
            Stock = stock;
        }
    }
}
