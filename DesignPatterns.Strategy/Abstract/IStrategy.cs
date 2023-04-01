using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Abstract
{
    internal interface IStrategy
    {
        void Execute(string data);
    }
}
