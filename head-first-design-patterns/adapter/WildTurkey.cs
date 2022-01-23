using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
