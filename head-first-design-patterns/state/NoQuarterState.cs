using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class NoQuarterState : IGumballMachineState
    {
        private GumballMachine GumballMachine { get; }

        public NoQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            GumballMachine.SetState(GumballMachine.HasQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override string ToString()
        {
            return "Machine is waiting for quarter";
        }
    }
}
