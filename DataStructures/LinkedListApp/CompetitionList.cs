using System;
using System.Collections.Generic;

namespace DataStructures.LinkedListApp
{
    public class CompetitionList
    {
        public void AddPersonToCompetition()
        {
            var personList = new LinkedList<string>();
            personList.AddLast("Tom");
            personList.AddLast("Banks");
            DisplayPersonList(personList);

            string userAnswer = null;
            while (userAnswer != "Exit")
            {
                Console.WriteLine("Please enter 'add' to add a new person to list or 'remove' to delete a person or 'Exit to stop program'");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "add")
                {
                    Console.WriteLine("Please eneter persons name");
                    var newPerson = Console.ReadLine();
                    personList.AddLast(newPerson);
                    Console.WriteLine("Person successfully added");
                    DisplayPersonList(personList);
                }

                if (userAnswer.ToLower() == "delete")
                {
                    Console.WriteLine("Eneter persons name to delete");
                    var personToDelete = Console.ReadLine();
                    personList.Remove(personToDelete);
                    Console.WriteLine("Person successfully deleted");
                    DisplayPersonList(personList);
                }
            }
        }

        private static void DisplayPersonList(LinkedList<string> personList)
        {
            Console.WriteLine("People in list: " + personList.Count);
            foreach (string person in personList)
            {
                Console.WriteLine("Person Name: " + person);
            }
        }
    }
}
