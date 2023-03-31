using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Concrete
{
    internal class CareTaker
    {
        private Originator originator;
        private Stack<Snapshot> snapshots;

        public CareTaker(Originator originator)
        {
            this.originator = originator;
            snapshots = new Stack<Snapshot>();
        }

        public void Backup()
        {
            var snap = originator.Save();
            snapshots.Push(snap);   
        }

        public void Undo() 
        { 
            var snap = snapshots.Pop();
            originator.Restore(snap);
        }
    }
}
