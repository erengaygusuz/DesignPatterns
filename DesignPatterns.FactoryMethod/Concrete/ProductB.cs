using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Concrete
{
    internal class ProductB : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Product B do stuff function is executed.");
        }
    }
}
