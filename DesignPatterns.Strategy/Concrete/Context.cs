using DesignPatterns.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignPatterns.Strategy.Concrete
{ 
    internal class Context
    {
        private string data;
        private IStrategy strategy;

        public Context(string data) 
        {
            this.data = data;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoSomething()
        {
            strategy.Execute(data);
        }
    }
}
