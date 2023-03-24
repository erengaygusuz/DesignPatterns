using DesignPatterns.Bridge.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Concrete
{
    internal class DeviceA : IDevice
    {
        public void Close()
        {
            Console.WriteLine("DeviceA is Closed");
        }

        public void Open()
        {
            Console.WriteLine("DeviceA is Opened");
        }
    }
}
