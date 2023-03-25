﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Abstract
{
    internal interface IDataSource
    {
        void WriteData();
        void ReadData();
    }
}
