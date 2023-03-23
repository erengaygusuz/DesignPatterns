using DesignPatterns.Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Concrete
{
    internal class ProductB : Product, IClonable
    {
        private int Stock = 10;

        public Product Clone()
        {
            return new ProductB
            {
                Name = Name,
                Price = Price,
                Stock = Stock
            };
        }
    }
}
