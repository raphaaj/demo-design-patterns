using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class Soy : CondimentDecorator
    {
        public Beverage Beverage { get; }

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .15 + Beverage.Cost();
        }
    }
}
