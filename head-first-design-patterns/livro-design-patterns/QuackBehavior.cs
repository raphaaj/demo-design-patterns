using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public interface QuackBehavior
    {
        public void Quack();
    }

    public class QuackSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
