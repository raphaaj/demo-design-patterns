using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
