using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Abstract
{
    internal abstract class DataDecorator : IDataSource
    {
        private readonly IDataSource _source;

        public DataDecorator(IDataSource source)
        {
            _source = source;
        }

        public abstract void ReadData();

        public abstract void WriteData();
    }
}
