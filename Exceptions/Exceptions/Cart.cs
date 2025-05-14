using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Cart
    {
        Dictionary<Product, int> products = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product) && products.TryGetValue(product, out quantity))
            {
                products.Add(product, quantity);
            }
            else
            {
                throw new InsufficientExecutionStackException();
            }
        }
        public void Checkout()
        {
            if (products.Count != 0)
            {
                Console.WriteLine("The order is done");
            }
            else
            {
                throw new EmptyCartException();
            }
        }
    }
}
