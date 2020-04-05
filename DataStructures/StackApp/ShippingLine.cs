using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.StackApp
{
    /* Brendons comments
    stack add a method to remove a specific container.. 
    add example to move out middle and log it, and show the rest coming back on 
    */
    public class ShippingLine
    {
        public static void Start()
        {
            //Default values for demo
            var containers = new Stack();
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

        private static void DisplayAllContainers(Stack containers)
        {
            Console.WriteLine("Total list of containers");
            foreach (string container in containers)
            {
                Console.WriteLine(container);
            }
        }

        private static void RemoveShippingContainer(Stack containers)
        {
            Console.WriteLine("Please enter Container Number to delete?");
            var containerToDelete = Console.ReadLine();
            //was not able to add to an array of strings
            //https://stackoverflow.com/questions/1440265/how-to-add-a-string-to-a-string-array-theres-no-add-function
            //var tempList = new string[] { };
            var tempList = new List<string>();
            while (containers.Contains(containerToDelete))
            {
                var container = containers.Peek().ToString();
                if (container != containerToDelete)
                {
                    tempList.Insert(0, container);
                }

                Console.WriteLine($"Container removed {container}");
                containers.Pop();
            }

            if (tempList.Count == 0) return;
            foreach (var item in tempList)
            {
                Console.WriteLine($"Containers added: {item}");
                containers.Push(item);
            }
        }

        private static void AddShippingContainers(Stack containers)
        {
            Console.WriteLine("Please enter Container Number?");
            var containerNumber = Console.ReadLine();
            containers.Push(containerNumber);
        }
    }
}
