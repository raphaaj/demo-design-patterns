using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class SoldOutState : IGumballMachineState
    {
        private GumballMachine GumballMachine { get; }

        public SoldOutState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("The machine is sold out.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("The machine is sold out.");
        }

        public override string ToString()
        {
            return "Machine is sold out";
        }
    }
}
