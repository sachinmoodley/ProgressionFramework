using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Program
    {
        //Brendons comments
        //todo make a funtion to limit what t is and show 2 T params

        //My comments
        //created a funtion to limit what t is and show 2 T params
        public static void Main(string[] args)
        {
            //basic list
            var basicList = new List<string>();
            basicList.Add("I am a basic list");
            Console.WriteLine($"basic list {basicList.FirstOrDefault()}");

            //dictionary
            var simpleDictionary = new Dictionary<int, string>();
            simpleDictionary.Add(1, "Bobby");
            simpleDictionary.Add(2, "Bob");
            simpleDictionary.Add(3, "Bobs");
            foreach (var field in simpleDictionary)
            {
                Console.WriteLine(field);
            }

            //generic class and method
            var genericInt = new GenericClass<int>();
            genericInt.GenericMethod(12345);
            var genericString = new GenericClass<string>();
            genericString.GenericMethod("test");

            //Generic method
            GenericMethod(40);
            GenericMethod("Fourty");
            GenericMethod(true);
            var person = new Person { Name = "Bobby", Surname = "Brown" };
            GenericMethod($"{person.Name} {person.Surname}");

            //Generics with type constraints 
            var animal = new Animal { AnimalType = "Lion" };
            ShowGenericsWithTypeConstraints(person, animal);
        }

        private static void GenericMethod<T>(T input)
        {
            Console.WriteLine(input);
        }

        private static void ShowGenericsWithTypeConstraints<T, U>(T person, U animal) where T : Person where U : Animal
        {
            Console.WriteLine($"This persons name is {person.Name}");
            Console.WriteLine($"This animal is a {animal.AnimalType}");
        }
    }
}
