using System;
using System.Collections.Generic;

namespace DataStructures.StackApp
{
    /* Brendons comments
        remove peek just use pop
    */
    public class ShippingLine
    {
        public static void Start()
        {
            var containers = new Stack<string>();
            containers.Push("Container 1");
            containers.Push("Container 2");
            containers.Push("Container 3");

            while (containers.Count != 0)
            {
                Console.WriteLine("Please enter 'Y' to add a container or 'N' to remove a container");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Y":
                    {
                        AddShippingContainers(containers);
                        break;
                    }
                    case "N":
                    {
                        RemoveShippingContainer(containers);
                        break;
                    }
                    default:
                        Console.WriteLine("Oops you have not entered a valid input");
                        break;
                }

                DisplayAllContainers(containers);
            }
            Console.WriteLine("You have pulled out all the containers!!");
        }

        private static void DisplayAllContainers(Stack<string> containers)
        {
            Console.WriteLine("Total list of containers");
            foreach (string container in containers)
            {
                Console.WriteLine(container);
            }
        }

        private static void RemoveShippingContainer(Stack<string> containers)
        {
            Console.WriteLine("Please enter Container Number to delete?");
            var containerToDelete = Console.ReadLine();
            var tempList = new List<string>();

            while (containers.Contains(containerToDelete))
            {
                var container = containers.Pop();
                if (container != containerToDelete)
                {
                    tempList.Insert(0, container);
                }
                Console.WriteLine($"Container removed {container}");
            }

            foreach (var item in tempList)
            {
                Console.WriteLine($"Containers added: {item}");
                containers.Push(item);
            }
        }

        private static void AddShippingContainers(Stack<string> containers)
        {
            Console.WriteLine("Please enter Container Number?");
            var containerNumber = Console.ReadLine();
            containers.Push(containerNumber);
        }
    }
}
