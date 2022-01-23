using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            while (gumballMachine.Count > 0)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                Console.WriteLine(gumballMachine);
            }

            gumballMachine.Refill(2);

            while (gumballMachine.Count > 0)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                Console.WriteLine(gumballMachine);
            }

        }
    }
}
