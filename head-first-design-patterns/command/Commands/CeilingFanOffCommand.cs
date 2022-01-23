using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        readonly CeilingFan CeilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            CeilingFan.Off();
        }

        public void Undo()
        {
            CeilingFan.High();
        }
    }
}
