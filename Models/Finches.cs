using System;

namespace Zoo
{
    public class Finch : IAirDwelling, IGroundDwelling
    {
        public string TypeEnvironment { get; set; } = "Forest";

        public int MaximumSpeed { get; set; } = 30;
        public int MaximumCeiling { get; } = 40;
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