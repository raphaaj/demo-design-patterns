using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    // Abstract Factory: Interface para uma família de produtos, definidos a partir de um contexto
    public interface IPizzaIngredientFactory
    {
        // Factory Method
        public Dough CreateDough();

        // Factory Method
        public Sauce CreateSauce();

        // Factory Method
        public Cheese CreateCheese();

        // Factory Method
        public List<Veggie> CreateVeggies();

        // Factory Method
        public Pepperoni CreatePepperoni();

        // Factory Method
        public Clam CreateClam();
    }
}
