using DesignPatterns.Visitor.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Abstract
{
    internal interface IVisitor
    {
        void VisitComponentA(ComponentA component);
        void VisitComponentB(ComponentB component);
    }
}
