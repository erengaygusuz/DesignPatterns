using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Abstract
{
    internal interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void NotifySubscribers();
    }
}
