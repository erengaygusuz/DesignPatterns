using DesignPatterns.Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Concrete
{
    internal class Service : IService
    {
        public void Operation()
        {
            Console.WriteLine("Service Function is Executed");
        }
    }
}
