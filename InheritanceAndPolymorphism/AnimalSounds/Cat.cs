using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.AnimalSounds
{
    public class Cat: Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine($"A {Name} Meaows");
        }
    }
}
