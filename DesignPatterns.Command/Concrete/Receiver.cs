﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Concrete
{
    internal class Receiver
    {
        public void Operation(string param)
        {
            Console.WriteLine(param);
        }
    }
}
