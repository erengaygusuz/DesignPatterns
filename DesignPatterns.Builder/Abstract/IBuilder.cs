using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Abstract
{
    internal interface IBuilder
    {
        void SetPartA(string color);
        void SetPartB(string name);
        void SetPartC(int stock);
        void SetPartD(float price);
    }
}
