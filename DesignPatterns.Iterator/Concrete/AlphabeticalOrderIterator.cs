using DesignPatterns.Iterator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Concrete
{
    internal class AlphabeticalOrderIterator : IteratorClass
    {
        private WordsCollection collection;
        private int position = -1;
        private bool reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this.collection = collection;
            this.reverse = reverse;

            if (reverse)
            {
                position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return collection.GetItems()[position];
        }

        public override int Key()
        {
            return position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = position + (reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < collection.GetItems().Count)
            {
                position = updatedPosition;

                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            position = reverse ? collection.GetItems().Count - 1 : 0;
        }
    }
}
