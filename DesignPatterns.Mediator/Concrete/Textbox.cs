using DesignPatterns.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Concrete
{
    internal class Textbox : Component
    {
        public Textbox(IDialog dialog, string name) : base(dialog, name)
        {
        }

        public void KeyPress()
        {
            dialog.Notify(this, "KeyPress");
        }
    }
}
