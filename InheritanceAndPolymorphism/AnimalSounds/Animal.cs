using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.AnimalSounds
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void AnimalSound()
        {
            Console.WriteLine($"A {Name} Noise");
        }
    }
}
