using DesignPatterns.Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Concrete
{
    internal class ProductA : Product, IClonable
    {
        private string Color = "White";

        public Product Clone()
        {
            return new ProductA
            {
                Color = Color,
                Name = Name,
                Price = Price
            };
        }
    }
}
