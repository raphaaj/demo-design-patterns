using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
