namespace Zoo
{
    public interface IWalking
    {
        int MaximumSpeed { get; }
        void Run();
        void Walk();
    }
}