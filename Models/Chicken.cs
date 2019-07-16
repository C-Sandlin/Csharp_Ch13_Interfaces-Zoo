using System;

namespace Zoo
{
    public class Chicken : IGroundDwelling, IAirDwelling
    {

        public int MaximumSpeed { get; } = 20;
        public string TypeEnvironment { get; set; } = "Prairie";
        public void Move()
        {
            Console.WriteLine("Animal is now moving across the ground");
        }

        public int MaximumCeiling { get; } = 5;
        public void Fly()
        {
            Console.WriteLine("Animal is now Flying through the air");
        }

    }
}