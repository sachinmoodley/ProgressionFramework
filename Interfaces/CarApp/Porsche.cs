using System;

namespace Interfaces.CarApp
{
    public class Porsche : ICar
    {
        public int MaxKilowatts()
        {
            return 350;
        }

        public double Motor()
        {
            return 4;
        }

        public string CarName()
        {
            return "Porsche";
        }

        public void PrintCar()
        {
            Console.WriteLine($"{CarName()} Specs is: ");
            Console.WriteLine($"Max Kilowatts is {MaxKilowatts()}");
            Console.WriteLine($"Engine Size is {Motor()} Litre");
        }
    }
}
