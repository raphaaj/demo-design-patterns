using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class MacroCommand : ICommand
    {
        List<ICommand> Commands;

        public MacroCommand(List<ICommand> commands)
        {
            Commands = commands;
        }

        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in Commands)
            {
                command.Undo();
            }
        }
    }
}
