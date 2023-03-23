using DesignPatterns.AbstractFactory.Abstract;
using DesignPatterns.AbstractFactory.Concrete;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        private static IFactory factory;

        private static IProduct1 product1;
        private static IProduct2 product2;
        private static IProduct3 product3;

        static void Main(string[] args)
        {
            Initialize();
            GetProducts();
            PrintProductsNames();
        }

        static void Initialize()
        {
            factory = new FactoryB();
        }

        static void GetProducts()
        {
            product1 = factory.GetProduct1();
            product2 = factory.GetProduct2();
            product3 = factory.GetProduct3();
        }

        static void PrintProductsNames()
        {
            product1.PrintName();
            product2.PrintName();
            product3.PrintName();
        }
    }
}