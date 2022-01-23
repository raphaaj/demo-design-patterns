using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class Whip : CondimentDecorator
    {
        public Beverage Beverage { get; }

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }
    }
}
