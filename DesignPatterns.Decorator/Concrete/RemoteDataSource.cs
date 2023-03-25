using DesignPatterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Concrete
{
    internal class RemoteDataSource : IDataSource
    {
        public void ReadData()
        {
            Console.WriteLine("Remote Data is reading...");
        }

        public void WriteData()
        {
            Console.WriteLine("Remote Data is writing...");
        }
    }
}
