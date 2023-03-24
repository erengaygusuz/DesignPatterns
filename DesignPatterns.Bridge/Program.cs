using DesignPatterns.Bridge.Abstract;
using DesignPatterns.Bridge.Concrete;

namespace DesignPatterns.Bridge
{
    internal class Program
    {
        private static RemoteControl remoteControl;

        static void Main(string[] args)
        {
            remoteControl = new RemoteControlA();

            remoteControl.OpenDevice();
        }
    }
}