using DesignPatterns.Bridge.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Concrete
{
    internal class RemoteControlA : RemoteControl
    {
        private IDevice device;


        public RemoteControlA()
        {
            device = new DeviceA();
        }

        public override void CloseDevice()
        {
            device.Close();
        }

        public override void OpenDevice()
        {
            device.Open();
        }
    }
}
