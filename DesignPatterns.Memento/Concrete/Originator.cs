using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Concrete
{
    internal class Originator
    {
        public int value1;
        private string value2;

        public Originator(int value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public void PrintStates()
        {
            Console.WriteLine(value1 + " " + value2);   
        }

        public void SetStates(int value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public Snapshot Save()
        {
            return new Snapshot(value1, value2);
        }

        public void Restore(Snapshot snapshot)
        {
            value1 = snapshot.Value1();
            value2 = snapshot.Value2();
        }
    }
}
