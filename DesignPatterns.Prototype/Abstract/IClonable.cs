using DesignPatterns.Prototype.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Abstract
{
    internal interface IClonable
    {
        Product Clone();
    }
}
