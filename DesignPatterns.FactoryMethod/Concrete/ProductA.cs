using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Concrete
{
    internal class ProductA : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Product A do stuff function is executed.");
        }
    }
}
