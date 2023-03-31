using DesignPatterns.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Observer.Concrete
{
    internal class SubscriberA : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Publisher).State == 0 || (publisher as Publisher).State >= 2)
            {
                Console.WriteLine("SubscriberA: Reacted to the event.");
            }
        }
    }
}
