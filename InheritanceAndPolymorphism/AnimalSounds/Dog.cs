using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.AnimalSounds
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine($"A {Name} Barks");
        }
    }
}
