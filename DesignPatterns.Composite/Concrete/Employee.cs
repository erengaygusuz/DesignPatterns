using DesignPatterns.Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Concrete
{
    internal class Employee : IJob
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is working...");
        }
    }
}
