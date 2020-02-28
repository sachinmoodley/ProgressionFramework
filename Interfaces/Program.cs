using System;
using Interfaces.CarApp;
using Interfaces.DogApp;

namespace Interfaces
{
    class Program
    {
        //Brendons comments
        //make a diff car an another function to print both cars that uses ICar
        //write eg of explicitly implementing an interface
        //https://www.geeksforgeeks.org/c-sharp-explicit-interface-implementation/

        //My comments
        //Created another car and added function to print 
        //Created a dog app to show explicit interfaces
        static void Main(string[] args)
        {
            Console.WriteLine("Car App");
            var ferrari = new Ferrari();
            ferrari.PrintCar();
            Console.WriteLine("    ");
            var porsche = new Porsche();
            porsche.PrintCar();

            Console.WriteLine("_____________________");
            Console.WriteLine("Life App");
            var life = new Life();
            ((IHuman)life).Eat();
            ((IAnimal)life).Eat();
        }
    }
}
