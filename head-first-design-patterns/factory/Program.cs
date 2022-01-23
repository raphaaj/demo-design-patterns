﻿using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

        }
    }
}
