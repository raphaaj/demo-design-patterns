using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class GumballMachine
    {
        public IGumballMachineState SoldOutState { get; }
        public IGumballMachineState NoQuarterState { get; }
        public IGumballMachineState HasQuarterState { get; }
        public IGumballMachineState SoldState { get; }
        public IGumballMachineState WinnerState { get; }

        private IGumballMachineState State;
        public int Count { get; private set; }

        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            if (numberOfGumballs > 0)
            {
                State = NoQuarterState;
            } else
            {
                State = SoldOutState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void SetState(IGumballMachineState state)
        {
            State = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public void Refill(int numberOfGumballs)
        {
            Count += numberOfGumballs;
            if (Count > 0)
            {
                SetState(NoQuarterState);
            }
            Console.WriteLine($"Gumball machine refilled. Inventory: {Count}\n");
        }

        public override string ToString()
        {
            string str = "\nMighty Gumball, Inc.";
            str += "\nC#-enabled Standing Gumball Model #2004";
            str += $"\nInventory: {Count} gumballs\n";
            str += $"{State}\n";

            return str;
        }
    }
}
