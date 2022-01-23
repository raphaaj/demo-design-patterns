using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class HasQuarterState : IGumballMachineState
    {
        private Random RandomWinner = new Random();
        private GumballMachine GumballMachine { get; }

        public HasQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.SetState(GumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            GumballMachine.SetState(IsWinner() ? GumballMachine.WinnerState : GumballMachine.SoldState);
        }

        private bool IsWinner()
        {
            return RandomWinner.Next(10) == 0 && GumballMachine.Count > 1;
        }

        public override string ToString()
        {
            return "Machine has quarter";
        }
    }
}
