using DesignPatterns.Visitor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Concrete
{
    internal class ComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentB(this);
        }

        public string SpecialMethodOfComponentB()
        {
            return "B";
        }
    }
}
