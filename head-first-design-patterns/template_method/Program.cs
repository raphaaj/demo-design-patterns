using System;

namespace template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage coffee = new CoffeeWithOptionalCondiments();
            coffee.PrepareRecipe();
        }
    }
}
