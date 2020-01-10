using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class GenericClass<T>
    {
        public void GenericMethod<T>(T input)
        {
            Console.WriteLine(input);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Program
    {
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

            //Generic method
            GenericMethod(40);
            GenericMethod("Fourty");
            GenericMethod(true);
            var person = new Person { Name = "Bobby", Surname = "Brown" };
            GenericMethod($"{person.Name} {person.Surname}");
        }

        private static void GenericMethod<T>(T input)
        {
            Console.WriteLine(input);
        }
    }
}
