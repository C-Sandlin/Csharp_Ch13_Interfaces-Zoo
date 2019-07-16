using System;

namespace Zoo
{
    public class SeaTurtle : IWaterDwelling, IGroundDwelling
    {

        public int MaximumDepth { get; } = 14;
        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }

        public int MaximumSpeed { get; } = 20;
        public string TypeEnvironment { get; set; } = "Tropical";
        public void Move()
        {
            Console.WriteLine($"The animal is moving across the ground at {MaximumSpeed} miles per hour");
        }
    }
}