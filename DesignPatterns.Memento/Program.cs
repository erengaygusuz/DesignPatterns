using DesignPatterns.Memento.Concrete;

namespace DesignPatterns.Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator(5, "bes");
            CareTaker careTaker = new CareTaker(originator);

            careTaker.Backup();
            originator.PrintStates();

            originator.SetStates(6, "alti");
            originator.PrintStates();

            careTaker.Undo();
            originator.PrintStates();
        }
    }
}