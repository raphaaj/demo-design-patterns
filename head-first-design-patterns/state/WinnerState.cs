using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class WinnerState : IGumballMachineState
    {
        private GumballMachine GumballMachine { get; }

        public WinnerState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You're a winner! You get two gumballs for your quarter");

            GumballMachine.ReleaseBall();
            if (GumballMachine.Count == 0)
            {
                GumballMachine.SetState(GumballMachine.SoldOutState);
            }
            else
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
            return "Gumball dispensed (Winner)";
        }
    }
}
