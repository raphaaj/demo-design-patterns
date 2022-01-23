using System;
using System.Collections.Generic;
using System.Text;

namespace template_method
{
    public class CoffeeWithOptionalCondiments : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            char answer = GetUserInput();
            return answer == 'y';
        }

        private char GetUserInput()
        {
            Console.Write("Would you like milk and sugar with your coffee (y/n)? ");
            char answer = Console.ReadKey().Key == ConsoleKey.Y ? 'y' : 'n';
            Console.WriteLine();

            return answer;
        }
    }
}
