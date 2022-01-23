using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }
    }
}
