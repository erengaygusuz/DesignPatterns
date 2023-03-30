using DesignPatterns.Command.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Concrete
{
    internal class Command1 : ICommand
    {
        private Receiver receiver;
        private string param;

        public Command1(Receiver receiver, string param) 
        { 
            this.receiver = receiver;
            this.param = param;
        }

        public void Execute()
        {
            receiver.Operation(param);
        }
    }
}
