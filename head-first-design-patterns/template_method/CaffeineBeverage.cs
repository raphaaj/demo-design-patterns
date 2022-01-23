using System;
using System.Collections.Generic;
using System.Text;

namespace template_method
{
    public abstract class CaffeineBeverage
    {
        /*
         * Template Method
         * Método que funciona como base para execução de uma sequência de instruções.
         * Cada instrução é representada por um método
         * Alguns métodos são manuseados por essa classe e alguns, específicos, pelas subclasses
         */
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments()) AddCondiments();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        /*
         * Gancho que permite que as subclasses tenham algum controle sobre o algoritmo
         * Nesse exemplo, esse método pode ser sobreescrito nas subclasses para não adicionar
         * condimentos, caso não seja necessário.
         */
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }   
}
