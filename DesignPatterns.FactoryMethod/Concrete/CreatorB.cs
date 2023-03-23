using DesignPatterns.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Concrete
{
    internal class CreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
