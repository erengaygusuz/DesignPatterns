using DesignPatterns.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Concrete
{
    internal class FactoryC : IFactory
    {
        public IProduct1 GetProduct1()
        {
            return new Product1C();
        }

        public IProduct2 GetProduct2()
        {
            return new Product2C();
        }

        public IProduct3 GetProduct3()
        {
            return new Product3C();
        }
    }
}
