using DesignPatterns.Strategy.Concrete;

namespace DesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context("data");
            context.SetStrategy(new StrategyA());
            context.DoSomething();
        }
    }
}