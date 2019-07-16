using System;

namespace Zoo
{
    public class PaintedDog : IWalking
    {
        public int MaximumSpeed { get; } = 20;
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

    }
}