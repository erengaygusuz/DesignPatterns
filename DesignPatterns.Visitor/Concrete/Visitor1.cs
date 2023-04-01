using DesignPatterns.Visitor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Visitor.Concrete
{
    internal class Visitor1 : IVisitor
    {
        public void VisitComponentA(ComponentA component)
        {
            Console.WriteLine(component.ExclusiveMethodOfComponentA() + " + Visitor1");
        }

        public void VisitComponentB(ComponentB component)
        {
            Console.WriteLine(component.SpecialMethodOfComponentB() + " + Visitor1");
        }
    }
}
