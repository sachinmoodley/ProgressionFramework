using System;

namespace Interfaces.DogApp
{
    public class Life : IAnimal, IHuman
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("Animal eats");
        }

        void IHuman.Eat()
        {
            Console.WriteLine("Human eats");
        }
    }
}