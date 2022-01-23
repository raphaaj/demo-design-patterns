using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        readonly CeilingFan CeilingFan;
        private int PreviousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            PreviousSpeed = CeilingFan.GetSpeed();
            CeilingFan.High();
        }

        public void Undo()
        {
            if (PreviousSpeed == CeilingFan.HIGH) CeilingFan.High();
            else if (PreviousSpeed == CeilingFan.MEDIUM) CeilingFan.Medium();
            else if (PreviousSpeed == CeilingFan.LOW) CeilingFan.Low();
            else if (PreviousSpeed == CeilingFan.OFF) CeilingFan.Off();
        }
    }
}
