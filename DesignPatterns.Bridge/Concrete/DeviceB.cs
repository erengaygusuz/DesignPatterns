using DesignPatterns.Bridge.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Concrete
{
    internal class DeviceB : IDevice
    {
        public void Close()
        {
            Console.WriteLine("DeviceB is Closed");
        }

        public void Open()
        {
            Console.WriteLine("DeviceB is Opened");
        }
    }
}
