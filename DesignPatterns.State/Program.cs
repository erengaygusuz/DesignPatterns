using DesignPatterns.State.Concrete;

namespace DesignPatterns.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var state = new StateA();

            var context = new Context(state);
            state.SetContext(context);

            context.Request1();
            context.Request2();
        }
    }
}