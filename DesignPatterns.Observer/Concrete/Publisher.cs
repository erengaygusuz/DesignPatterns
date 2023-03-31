using DesignPatterns.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Concrete
{
    internal class Publisher : IPublisher
    {
        public int State { get; set; }

        private List<ISubscriber> subscribers;

        public Publisher() 
        {
            subscribers = new List<ISubscriber>();
        }

        public void NotifySubscribers()
        {
            subscribers.ForEach(s => s.Update(this));
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void DoSomething()
        {
            State = new Random().Next(0, 10);
            NotifySubscribers();
        }
    }
}
