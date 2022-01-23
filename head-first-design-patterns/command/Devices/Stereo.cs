using System;
using System.Collections.Generic;
using System.Text;

namespace command.Devices
{
    public class Stereo
    {
        public int Volume { get; set; }

        public Stereo()
        {
            Volume = 10;
        }

        public void On()
        {
            Console.WriteLine("Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is Off");
        }

        public void SetCd()
        {
            Console.WriteLine("CD is Selected");
        }

        public void SetDvd()
        {
            Console.WriteLine("DVD is Selected");
        }

        public void SetRadio()
        {
            Console.WriteLine("Radio is Selected");
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine($"Volume set to {Volume}");
        }


    }
}
