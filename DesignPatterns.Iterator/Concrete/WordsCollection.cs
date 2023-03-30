using DesignPatterns.Iterator.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Concrete
{
    internal class WordsCollection : IterableCollection
    {
        List<string> collection = new List<string>();

        bool direction = false;

        public void ReverseDirection()
        {
            direction = !direction;
        }

        public List<string> GetItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, direction);
        }
    }
}
