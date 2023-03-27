using DesignPatterns.Flyweight.Concrete;

namespace DesignPatterns.Flyweight
{
    internal class Program
    {
        private static Context context;
        static void Main(string[] args)
        {
            context = new Context("Red", "Animal", 20);
            context.Move();
        }
    }
}