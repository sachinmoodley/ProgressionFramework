using System;
using System.Collections;

namespace DataStructures.QueueApp
{
    /*Bredons feedback
    Use a while loop
    For each time ask if joining or leave and then do action
    */
    public class LicensingOffice
    {
        public static void Start()
        {
            var customerQueue = new Queue();
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
                        Console.WriteLine(customerQueue.Peek() + "is leaving the queue");
                        customerQueue.Dequeue();
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

        private static void StartQueue(Queue customerQueue)
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
