using DesignPatterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Concrete
{
    internal class CompressDataDecorator : DataDecorator, IDataSource
    {
        public CompressDataDecorator(IDataSource source) : base(source)
        {
        }

        private void Compress()
        {
            Console.WriteLine("Data is compressed");
        }

        private void Decompress()
        {
            Console.WriteLine("Data is decompressed");
        }

        public override void WriteData()
        {
            Compress();
        }

        public override void ReadData()
        {
            Decompress();
        }
    }
}
