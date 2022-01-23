using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>()
            {
                new Eggplant(),
                new Spinach(),
                new BlackOlive()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }
    }
}
