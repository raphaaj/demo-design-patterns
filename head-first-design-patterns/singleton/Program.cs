using System;
using System.Collections.Generic;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var boilers = new List<ChocolateBoilerSafe1>()
            {
                ChocolateBoilerSafe1.GetBoiler(),
                ChocolateBoilerSafe1.GetBoiler()
            };


            foreach (var boiler in boilers)
            {
                boiler.Fill();
                boiler.Boil();
                boiler.Drain();
            }
        }
    }
}
