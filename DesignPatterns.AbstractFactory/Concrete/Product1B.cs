using DesignPatterns.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Concrete
{
    internal class Product1B : IProduct1
    {
        public void PrintName()
        {
            Console.WriteLine("This is Product1B");
        }
    }
}
