using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Abstract
{
    internal interface IDialog
    {
        void Notify(Component sender, string eventName);
    }
}
