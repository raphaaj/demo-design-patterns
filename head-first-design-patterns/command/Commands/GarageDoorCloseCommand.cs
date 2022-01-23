using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        readonly GarageDoor GarageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute()
        {
            GarageDoor.Down();
        }

        public void Undo()
        {
            GarageDoor.Up();
        }
    }
}
