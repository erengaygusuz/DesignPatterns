using DesignPatterns.Visitor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Concrete
{
    internal class ComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentA(this);
        }

        public string ExclusiveMethodOfComponentA()
        {
            return "A";
        }
    }
}
