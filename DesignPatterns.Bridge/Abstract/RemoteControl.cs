using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Abstract
{
    internal abstract class RemoteControl
    {
        public abstract void OpenDevice();
        public abstract void CloseDevice();
    }
}
