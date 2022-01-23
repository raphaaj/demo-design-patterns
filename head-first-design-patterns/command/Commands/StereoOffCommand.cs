using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class StereoOffCommand : ICommand
    {
        readonly Stereo Stereo;

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.Off();
        }

        public void Undo()
        {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }
    }
}
