using DesignPatterns.FactoryMethod.Abstract;
using DesignPatterns.FactoryMethod.Concrete;

namespace DesignPatterns.FactoryMethod
{
    internal class Program
    {
        private static Creator creator;
        private static IProduct product;

        static void Main(string[] args)
        {
            Initialize();

            product = creator.CreateProduct();

            product.DoStuff();
        }

        static void Initialize()
        {
            creator = new CreatorA();
        }
    }
}