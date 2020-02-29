using DataStructures.QueueApp;
using System;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var licensingOffice = new LicensingOffice();
            var customersEntered = licensingOffice.EnterCustomersInQueue();

            licensingOffice.CustomersExitingTheQueue(customersEntered);
        }
    }
}
