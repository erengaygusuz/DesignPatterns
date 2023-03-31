using DesignPatterns.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Observer.Concrete
{
    internal class SubscriberB : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Publisher).State < 3)
            {
                Console.WriteLine("SubscriberB: Reacted to the event.");
            }
        }
    }
}
