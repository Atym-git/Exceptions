using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class EmptyCartException : Exception
    {
        public EmptyCartException() : base("An error occurred during a database operation")
        {

        }
        public EmptyCartException(Dictionary<Product, int> cartValue) : base()
        {
            if (cartValue.Count == 0)
            {
                Console.WriteLine("The cart is empty");
            }
        }
    }
}
