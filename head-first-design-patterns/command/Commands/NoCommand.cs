using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}
