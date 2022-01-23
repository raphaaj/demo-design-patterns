using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory IngredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
        }
    }
}
