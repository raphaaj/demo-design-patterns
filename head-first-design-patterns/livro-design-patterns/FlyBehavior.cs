using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public interface FlyBehavior
    {
        public void Fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
