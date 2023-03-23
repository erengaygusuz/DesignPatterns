using DesignPatterns.Builder.Abstract;
using DesignPatterns.Builder.Concrete;

namespace DesignPatterns.Builder
{
    internal class Program
    {
        private static Director director;

        private static Product1 product1;
        private static Product1Builder builder;

        static void Main(string[] args)
        {
            director = new Director();

            builder = new Product1Builder();

            director.BuildProduct1(builder);

            product1 = builder.GetProduct();

            product1.PrintDescription();
        }
    }
}