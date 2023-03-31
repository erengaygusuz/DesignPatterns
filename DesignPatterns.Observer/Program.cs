using DesignPatterns.Observer.Concrete;

namespace DesignPatterns.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            var subscriberA = new SubscriberA();
            publisher.Subscribe(subscriberA);

            var subscriberB = new SubscriberB();    
            publisher.Subscribe(subscriberB);

            publisher.DoSomething();

            publisher.Unsubscribe(subscriberA);

            publisher.DoSomething();
        }
    }
}