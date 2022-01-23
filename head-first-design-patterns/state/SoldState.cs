using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class SoldState : IGumballMachineState
    {
        private GumballMachine GumballMachine { get; }

        public SoldState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count > 0)
            {
                GumballMachine.SetState(GumballMachine.NoQuarterState);
            } else
            {
                Console.WriteLine("Oops, out of gumballs!");
                GumballMachine.SetState(GumballMachine.SoldOutState);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public override string ToString()
        {
            return "Gumball dispensed";
        }
    }
}
