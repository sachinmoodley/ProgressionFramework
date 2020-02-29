using System;
using System.Collections;

namespace DataStructures.QueueApp
{
    public class LicensingOffice
    {
        public Queue EnterCustomersInQueue()
        {
            var customerQueue = new Queue();
            string customerName;
            var queueLimit = 5;
            for (int x = 0; x < queueLimit; x++)
            {
                Console.WriteLine("Please enter customer name?");
                customerName = Console.ReadLine();
                customerQueue.Enqueue(customerName);
            }

            Console.WriteLine("You have reached the maximum people in the Queue: " + customerQueue.Count);

            foreach (string customer in customerQueue)
            {
                Console.WriteLine(customer);
            }

            return customerQueue;
        }

        public void CustomersExitingTheQueue(Queue customersInQueue)
        {
            foreach (string customer in customersInQueue)
            {
                Console.WriteLine("Customer exited: " + customer);
            }
        }
    }
}
