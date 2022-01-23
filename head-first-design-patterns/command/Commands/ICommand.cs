using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
