using command.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    public class SimpleRemoteControl
    {
        private ICommand Slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
        
    }
}
