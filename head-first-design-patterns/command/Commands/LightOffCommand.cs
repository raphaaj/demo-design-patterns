using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class LightOffCommand : ICommand
    {
        readonly Light Light;

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}
