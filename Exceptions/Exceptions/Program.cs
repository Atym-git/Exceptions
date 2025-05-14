namespace InternetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Test", -1, -1);
            Cart cart = new Cart();

            cart.Checkout();
            cart.AddProduct(product, -3);
            cart.AddProduct(product, -3);
        }
    }
}
