using DesignPatterns.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Concrete
{
    internal class FactoryA : IFactory
    {
        public IProduct1 GetProduct1()
        {
            return new Product1A();
        }

        public IProduct2 GetProduct2()
        {
            return new Product2A();
        }

        public IProduct3 GetProduct3()
        {
            return new Product3A();
        }
    }
}
