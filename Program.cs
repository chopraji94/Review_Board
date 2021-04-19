using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractionDemo a1 = new AbstractionDemo();
            a1.CarName = "BMW";
            a1.CarColor = "Metailc grey";
            a1.Steering();
            a1.Brakes();
            a1.Gear();
        }
    }
}
