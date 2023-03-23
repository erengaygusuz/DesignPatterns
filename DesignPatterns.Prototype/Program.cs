using DesignPatterns.Prototype.Concrete;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Prototype
{
    internal class Program
    {
        private static ProductManager productManager;

        static void Main(string[] args)
        {
            productManager = new ProductManager();
            var products = productManager.GetProducts();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name);
            }
        }
    }
}