using DesignPatterns.State.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Concrete
{
    internal class Context
    {
        private StateClass state = null;

        public Context(StateClass state)
        {
            this.state = state;
        }

        public void TransitionTo(StateClass state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this.state = state;
            state.SetContext(this);
        }

        public void Request1()
        {
            state.Handle1();
        }

        public void Request2()
        {
            state.Handle2();
        }
    }
}
