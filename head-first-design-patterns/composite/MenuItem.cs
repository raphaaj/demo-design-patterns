using System;
using System.Collections.Generic;
using System.Text;

namespace composite
{
    public class MenuItem : MenuComponent
    {
        private string Name;
        private string Description;
        private bool Vegetarian;
        private double Price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsVegetarian()
        {
            return Vegetarian;
        }

        public override void Print()
        {
            Console.Write($"  {GetName()}");
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"  -- {GetDescription()}");
        }
    }
}
