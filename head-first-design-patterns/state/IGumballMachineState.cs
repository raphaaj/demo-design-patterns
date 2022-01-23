using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public interface IGumballMachineState
    {
        public void InsertQuarter();
        public void EjectQuarter();
        public void TurnCrank();
        public void Dispense();
    }
}
