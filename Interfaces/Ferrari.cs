namespace Interfaces
{
    public class Ferrari: ICar
    {
        public int MaxKilowatts(int maxSpeed)
        {
            return maxSpeed;
        }

        public double Motor(double engineSize)
        {
            return engineSize;
        }
    }
}
