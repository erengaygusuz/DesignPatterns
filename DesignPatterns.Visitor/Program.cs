using DesignPatterns.Visitor.Abstract;
using DesignPatterns.Visitor.Concrete;

namespace DesignPatterns.Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ComponentA(),
                new ComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new Visitor1();

            foreach (var component in components)
            {
                component.Accept(visitor1);
            }

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new Visitor2();

            foreach (var component in components)
            {
                component.Accept(visitor2);
            }
        }
    }
}