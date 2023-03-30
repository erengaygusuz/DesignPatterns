﻿using DesignPatterns.Command.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Concrete
{
    internal class Invoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
