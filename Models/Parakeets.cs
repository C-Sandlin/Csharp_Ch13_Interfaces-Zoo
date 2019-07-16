using System;

namespace Zoo
{
    public class Parakeet : IAirDwelling, IGroundDwelling
    {
        public string TypeEnvironment { get; set; } = "Rainforest";
        public int MaximumSpeed { get; set; } = 4;
        public int MaximumCeiling { get; } = 20;
        public void Fly()
        {
            Console.WriteLine("Animal is now Flying through the air");
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving across the ground");
        }
    }
}