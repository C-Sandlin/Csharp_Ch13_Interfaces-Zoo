using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE (1)
            SeaTurtle Larry = new SeaTurtle();
            SeaTurtle Frank = new SeaTurtle();
            SeaTurtle Gus = new SeaTurtle();

            PaintedDog Steve = new PaintedDog();
            Chicken Billiam = new Chicken();

            List<IGroundDwelling> AnimalsThatCanWalk = new List<IGroundDwelling>()
            {
                Larry, Frank, Gus, Steve, Billiam
            };

            foreach (IGroundDwelling animal in AnimalsThatCanWalk)
            {
                Console.WriteLine($"The animal {animal.GetType()} is walking at {animal.MaximumSpeed} miles per hour");
            }

            // PART TWO (2)
            BettaFish Colin = new BettaFish();

            var myAquarium = new Aquarium();
            myAquarium.FishTank.Add(Colin);
            myAquarium.FishTank.Add(Larry);

            foreach (IWaterDwelling creature in myAquarium.FishTank)
            {
                Console.WriteLine($"The animal's Max depth is {creature.MaximumDepth}");
            }


        }
    }
}
