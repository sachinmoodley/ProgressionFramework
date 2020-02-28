using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.AnimalSounds
{
    //Idea came from https://www.ict.social/csharp/oop/inheritance-and-polymorphism-in-csharp-net
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void AnimalSound();
    }
}
