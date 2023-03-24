using DesignPatterns.Adapter.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Abstract
{
    internal interface IDataProvider
    {
        Xml GetData();
    }
}
