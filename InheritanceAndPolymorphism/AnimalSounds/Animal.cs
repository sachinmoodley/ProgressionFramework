using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.AnimalSounds
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void AnimalSound();
    }
}
