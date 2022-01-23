using System;
using System.Collections.Generic;
using System.Text;

namespace template_method
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Stteping the Tea");
        }
    }
}
