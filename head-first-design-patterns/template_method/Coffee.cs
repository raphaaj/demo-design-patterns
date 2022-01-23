using System;
using System.Collections.Generic;
using System.Text;

namespace template_method
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
