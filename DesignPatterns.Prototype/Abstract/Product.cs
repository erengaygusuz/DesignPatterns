using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Abstract
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
