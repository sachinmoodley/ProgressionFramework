using System;

namespace Interfaces.CarApp
{
    public class Ferrari : ICar
    {
        public int MaxKilowatts()
        {
            return 400;
        }

        public double Motor()
        {
            return 5.5;
        }

        public string CarName()
        {
            return "Ferrari";
        }

        public void PrintCar()
        {
            Console.WriteLine($"{CarName()} Specs is: ");
            Console.WriteLine($"Max Kilowatts is {MaxKilowatts()}");
            Console.WriteLine($"Engine Size is {Motor()} Litre");
        }
    }
}
