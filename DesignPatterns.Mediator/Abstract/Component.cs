using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Abstract
{
    internal abstract class Component
    {
        protected IDialog dialog;

        public string name;

        public Component(IDialog dialog, string name)
        {
            this.dialog = dialog;
            this.name = name;
        }
    }
}
