using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class LightOnCommand : ICommand
    {
        readonly Light Light;

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
