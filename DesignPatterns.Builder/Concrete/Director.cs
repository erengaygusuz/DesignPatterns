using DesignPatterns.Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Concrete
{
    internal class Director
    {
        public void BuildProduct1(IBuilder builder)
        {
            builder.SetPartA("Red");
            builder.SetPartB("Product1");
            builder.SetPartC(10);
            builder.SetPartD(2);
        }
    }
}
