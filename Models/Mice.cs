using System;

namespace Zoo
{
    public class Mouse : IGroundDwelling, IUndergroundDwelling
    {

        public int MaximumDepth { get; } = 11;
        public int MaximumSpeed { get; } = 38;
        public string TypeEnvironment { get; set; } = "Urban";

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