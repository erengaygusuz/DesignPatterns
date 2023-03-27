using DesignPatterns.Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Concrete
{
    internal class ProxyClass : IService
    {
        private Service service;

        public ProxyClass(Service service)
        {
            this.service = service;
        }

        public void Operation()
        {
            Console.WriteLine("Service before executed");
            service.Operation();
            Console.WriteLine("Service after executed");
        }
    }
}
