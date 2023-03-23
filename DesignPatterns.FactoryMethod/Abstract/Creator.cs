using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Abstract
{
    internal abstract class Creator
    {
        public void SomeOperation()
        {
            Console.WriteLine("Some operation function is executed.");
        }

        public abstract IProduct CreateProduct();
    }
}
