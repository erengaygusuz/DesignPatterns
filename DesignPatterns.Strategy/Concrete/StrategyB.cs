using DesignPatterns.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Concrete
{
    internal class StrategyB : IStrategy
    {
        public void Execute(string data)
        {
            Console.WriteLine(data + " is used by strategy b");
        }
    }
}
