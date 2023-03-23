using DesignPatterns.AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Abstract
{
    internal interface IFactory
    {
        IProduct1 GetProduct1();
        IProduct2 GetProduct2();
        IProduct3 GetProduct3();
    }
}
