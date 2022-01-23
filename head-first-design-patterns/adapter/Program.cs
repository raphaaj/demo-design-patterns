using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();
            ITurkey turkey = new WildTurkey();

            TestDuck(duck);
            TestDuck(new Turkey2DuckAdapter(turkey));
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
