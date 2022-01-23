using command.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    public class RemoteControl
    {
        public static readonly int NUMBER_OF_SLOTS = 7;

        private readonly ICommand[] OnCommands;
        private readonly ICommand[] OffCommands;

        private ICommand LastCommand;

        public RemoteControl()
        {
            OnCommands = new ICommand[RemoteControl.NUMBER_OF_SLOTS];
            OffCommands = new ICommand[RemoteControl.NUMBER_OF_SLOTS];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < RemoteControl.NUMBER_OF_SLOTS; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }

            LastCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
            LastCommand = OnCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
            LastCommand = OffCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            LastCommand.Undo();
        }

        public override string ToString()
        {
            string str = "\n----- Remote Control -----\n";
            for (int i = 0; i < OnCommands.Length; i++)
            {
                str += $"[slot {i}] {OnCommands[i].GetType().Name}    {OffCommands[i].GetType().Name}\n";
            }

            str += $"[undo] {LastCommand.GetType().Name}";

            return str;
        }
    }
}
