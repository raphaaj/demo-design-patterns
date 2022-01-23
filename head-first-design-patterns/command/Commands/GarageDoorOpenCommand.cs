using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        readonly GarageDoor GarageDoor;
        
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute()
        {
            GarageDoor.Up();
        }

        public void Undo()
        {
            GarageDoor.Down();
        }
    }
}
