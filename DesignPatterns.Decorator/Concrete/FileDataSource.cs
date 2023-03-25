using DesignPatterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Concrete
{
    internal class FileDataSource : IDataSource
    {
        public void ReadData()
        {
            Console.WriteLine("File Data is reading...");
        }

        public void WriteData()
        {
            Console.WriteLine("File Data is writing...");
        }
    }
}
