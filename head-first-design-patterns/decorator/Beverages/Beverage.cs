using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
