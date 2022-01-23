using System;
using System.Collections.Generic;
using System.Text;

namespace command.Devices
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;

        private int Speed;

        public CeilingFan()
        {
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
            Console.WriteLine("Ceiling Fan is on High Speed");
        }

        public void Medium()
        {
            Speed = MEDIUM;
            Console.WriteLine("Ceiling Fan is on Medium Speed");
        }

        public void Low()
        {
            Speed = LOW;
            Console.WriteLine("Ceiling Fan is on Low Speed");
        }

        public void Off()
        {
            Speed = OFF;
            Console.WriteLine("Ceiling Fan is Off");
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
}
