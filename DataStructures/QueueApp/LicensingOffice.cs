using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.QueueApp
{
    /*Bredons feedback
    Instead of peek should use dequeue and store in variable to log
    */
    public class LicensingOffice
    {
        public static void Start()
        {
            var customerQueue = new Queue<string>();
            StartQueue(customerQueue);

            while (customerQueue.Count != 0)
            {
                Console.WriteLine("Please enter 'J' to join the Queue or 'E' to exit");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "J":
                    {
                        Console.WriteLine("Please enter user name?");
                        var customerName = Console.ReadLine();
                        customerQueue.Enqueue(customerName);
                        break;
                    }
                    case "E":
                        var customerExiting = customerQueue.Dequeue();
                        Console.WriteLine($"{customerExiting} is leaving the queue");
                        break;
                    default:
                        Console.WriteLine("Oops you have not entered a valid input");
                        break;
                }

                if (userInput != "J" && userInput != "E") continue;
                foreach (string customer in customerQueue)
                {
                    Console.WriteLine(customer);
                }
            }
            Console.WriteLine("Congratulations !!! Your queue is now empty");
        }

        private static void StartQueue(Queue<string> customerQueue)
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("Whoohoo!! You are the first person in line, Please enter your name");
                var userInput = Console.ReadLine();
                customerQueue.Enqueue(userInput);
            }
        }
    }
}
