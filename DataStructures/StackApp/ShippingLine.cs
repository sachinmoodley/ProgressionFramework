using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackApp
{
    public class ShippingLine
    {
        public Stack EnterShippingContainersToStore()
        {
            var containers = new Stack();
            string containerNumber;
            var stackLimit = 5;
            for (int x = 0; x < stackLimit; x++)
            {
                Console.WriteLine("Please enter container number?");
                containerNumber = Console.ReadLine();
                containers.Push(containerNumber);
            }

            Console.WriteLine("Oops you cannot stack any more containers, container count: " + containers.Count);

            foreach (string container in containers)
            {
                Console.WriteLine(container);
            }

            return containers;
        }

        public void PullOutShippingContainers(Stack containers)
        {
            foreach (string container in containers)
            {
                Console.WriteLine("container removed: " + container);
            }
        }
    }
}
