using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Abstract
{
    internal abstract class IterableCollection : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
