using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Concrete
{
    internal class Product1
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public void PrintDescription()
        {
            Console.WriteLine(Stock + " " + Color + " " + Name + " are " + (Stock * Price) + " TL");
        }
    }
}
