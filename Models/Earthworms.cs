using System;

namespace Zoo
{
    public class EarthWorm : IUndergroundDwelling
    {

        public int MaximumDepth { get; } = 12;
        public string TypeEnvironment { get; set; } = "Savannah";
        public void MoveUnder()
        {
            Console.WriteLine("Animal is now moving under the ground");
        }

    }
}