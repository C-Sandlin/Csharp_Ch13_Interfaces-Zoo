using System;

namespace Zoo
{
    public class BettaFish : IWaterDwelling
    {

        public int MaximumDepth { get; } = 34;
        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
}