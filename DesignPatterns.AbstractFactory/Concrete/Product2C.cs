using DesignPatterns.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Concrete
{
    internal class Product2C : IProduct2
    {
        public void PrintName()
        {
            Console.WriteLine("This is Product2C");
        }
    }
}
