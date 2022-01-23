using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duckModel = new ModelDuck();
            duckModel.PerformFly();
            duckModel.flyBehavior = new FlyRocketPowered();
            duckModel.PerformFly();
        }
    }
}
