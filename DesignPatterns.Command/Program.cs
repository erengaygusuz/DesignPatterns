using DesignPatterns.Command.Concrete;

namespace DesignPatterns.Command
{
    internal class Program
    {
        private static Invoker invoker;

        static void Main(string[] args)
        {
            invoker = new Invoker();

            invoker.SetCommand(new Command1(new Receiver(), "Copy Text"));

            invoker.ExecuteCommand();

            invoker.SetCommand(new Command1(new Receiver(), "Paste Text"));

            invoker.ExecuteCommand();
        }
    }
}