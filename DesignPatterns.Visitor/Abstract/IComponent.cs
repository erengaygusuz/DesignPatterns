﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Abstract
{
    internal interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
