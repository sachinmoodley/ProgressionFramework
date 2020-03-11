using DataStructures.LinkedListApp;
using DataStructures.QueueApp;
using DataStructures.StackApp;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Queue
            var licensingOffice = new LicensingOffice();
            var customersEntered = licensingOffice.EnterCustomersInQueue();

            licensingOffice.CustomersExitingTheQueue(customersEntered);

            //Stack
            var shippingLine = new ShippingLine();
            var containersStored = shippingLine.EnterShippingContainersToStore();

            shippingLine.PullOutShippingContainers(containersStored);

            //Linked List
            var people = new CompetitionList();
            people.AddPersonToCompetition();

        }
    }
}
