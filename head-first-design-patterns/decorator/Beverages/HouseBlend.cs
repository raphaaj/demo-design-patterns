using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
