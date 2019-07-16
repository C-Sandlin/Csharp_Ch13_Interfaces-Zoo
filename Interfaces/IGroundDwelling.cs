namespace Zoo
{
    public interface IGroundDwelling
    {
        int MaximumSpeed { get; }

        string TypeEnvironment { get; set; }

        void Move();
    }
}