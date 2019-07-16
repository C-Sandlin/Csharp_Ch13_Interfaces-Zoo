using System;

namespace Zoo
{
    public class Chicken : IWalking, IFlying
    {
        public int MaximumCeiling { get; } = 10;
        public int MaximumSpeed { get; } = 34;
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
}