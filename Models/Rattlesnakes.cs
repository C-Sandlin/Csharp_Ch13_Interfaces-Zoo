using System;

namespace Zoo
{
    public class Rattlesnake : IGroundDwelling, IUndergroundDwelling
    {

        public int MaximumDepth { get; } = 10;
        public int MaximumSpeed { get; } = 34;
        public string TypeEnvironment { get; set; } = "Desert";

        public void Move()
        {
            Console.WriteLine("Animal is now moving across the ground");
        }

        public void MoveUnder()
        {
            Console.WriteLine("the animal is moving under the ground");
        }

    }
}