using System;
using Interfaces.CarApp;
using Interfaces.LifeApp;

namespace Interfaces
{
    /*
     * Brendons comments
     * make a function on this class that will take a car and log the print car details
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car App");
            var ferrari = new Ferrari();
            PrintCar(ferrari);

            Console.WriteLine("    ");
            var porsche = new Porsche();
            PrintCar(porsche);

            Console.WriteLine("_____________________");
            Console.WriteLine("Life App");
            var life = new Life();
            ((IHuman)life).Eat();
            ((IAnimal)life).Eat();
        }

        private static void PrintCar(ICar car)
        {
            car.PrintCar();
        }
    }
}
