using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // Factory Method (Subclasses implmenta as fábricas)
        public abstract Pizza CreatePizza(string type);
    }
}
