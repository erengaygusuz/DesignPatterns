using DesignPatterns.Memento.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Concrete
{
    internal class Snapshot : ISnapshot
    {
        public int value1;
        private string value2;

        public Snapshot(int value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int Value1()
        {
            return value1;
        }

        public string Value2()
        {
            return value2;
        }
    }
}
