using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck() { }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swin()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackSound();
            flyBehavior = new FlyWithWings();
        }

        override public void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackSound();
        }

        override public void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
