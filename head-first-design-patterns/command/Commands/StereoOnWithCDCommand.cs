﻿using command.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace command.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        readonly Stereo Stereo;
        
        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}
