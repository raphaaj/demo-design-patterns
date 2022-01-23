using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class Mocha : CondimentDecorator
    {
        public Beverage Beverage { get; }

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }
    }
}
