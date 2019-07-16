using System;

namespace Zoo
{
    public class PaintedDog : IGroundDwelling
    {

        public int MaximumSpeed { get; } = 47;
        public string TypeEnvironment { get; set; } = "Savannah";
        public void Move()
        {
            Console.WriteLine("Animal is now moving across the ground");
        }

    }
}