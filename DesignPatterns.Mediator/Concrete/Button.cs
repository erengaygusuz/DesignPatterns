using DesignPatterns.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Concrete
{
    internal class Button : Component
    {
        public Button(IDialog dialog, string name) : base(dialog, name)
        {
        }

        public void Click()
        {
            dialog.Notify(this, "Click");
        }
    }
}
