using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            SeaTurtle Larry = new SeaTurtle();
            SeaTurtle Frank = new SeaTurtle();
            SeaTurtle Gus = new SeaTurtle();

            PaintedDog Steve = new PaintedDog();
            Chicken Billiam = new Chicken();

            List<IWalking> AnimalsThatCanWalk = new List<IWalking>()
            {
                Larry, Frank, Gus, Steve, Billiam
            };

            foreach (IWalking animal in AnimalsThatCanWalk)
            {
                Console.WriteLine($"The animal {animal.GetType()} is walking at {animal.MaximumSpeed} miles per hour");
            }
        }
    }
}
