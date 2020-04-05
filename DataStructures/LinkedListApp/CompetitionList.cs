using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Have some default values in the list
 * Have an Add method that checks the linked list score and adds item where node is greater than previous node and less than next node
 * Delete a node given the persons name
 * Display all values in linked list
 */

namespace DataStructures.LinkedListApp
{
    /*
     Brendons Feedback
     * linked list do displaying person
     * do it with a while loop without a index
     * add score class that has name and score.. 
     * while loop will fix issue i had
     */
    public class CompetitionList
    {
        public static void Start()
        {
            var competitionList = new LinkedList<Competition>();
            competitionList.AddLast(new Competition { Name = "Tom", Score = 55 });
            competitionList.AddLast(new Competition { Name = "Banks", Score = 60 });

            string userInput = null;
            while (userInput != "Exit")
            {
                Console.WriteLine("Please enter 'add' to add a person to the competition, 'delete' to remove a person or 'Exit to stop program'");
                userInput = Console.ReadLine();

                if (userInput == "add")
                {
                    AddPersonToCompetition(competitionList);
                }
                else if (userInput == "delete")
                {
                    RemovePersonFromCompetition(competitionList);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }

                DisplayPersonList(competitionList);

            }
        }

        private static void RemovePersonFromCompetition(LinkedList<Competition> competitionList)
        {
            DisplayPersonList(competitionList);
            Console.WriteLine("Enter persons name to delete");
            var personToDelete = Console.ReadLine();
            var currentNode = competitionList.First;
            while (currentNode != null)
            {
                if (currentNode.Value.Name == personToDelete)
                {
                    var toRemove = currentNode;
                    competitionList.Remove(toRemove);
                    Console.WriteLine("Person successfully deleted");
                    break;
                }
            }
        }

        private static void AddPersonToCompetition(LinkedList<Competition> competitionList)
        {
            Console.WriteLine("Please enter person name");
            var personName = Console.ReadLine();
            Console.WriteLine("Please enter person score");
            var personScore = Convert.ToInt32(Console.ReadLine());

            if (personScore <= competitionList.First().Score)
            {
                competitionList.AddFirst(new Competition { Name = personName, Score = personScore });
                Console.WriteLine("Person successfully added");
            }
            else if (personScore >= competitionList.Last.Value.Score)
            {
                competitionList.AddLast(new Competition { Name = personName, Score = personScore });
                Console.WriteLine("Person successfully added");
            }
            else
            {
                var currentNode = competitionList.First;
                while (currentNode != null)
                {

                    if (personScore >= currentNode.Value.Score && personScore <= currentNode.Next.Value.Score)
                    {
                        competitionList.AddAfter(currentNode, new Competition { Name = personName, Score = personScore });
                        Console.WriteLine("Person successfully added");
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

        private static void DisplayPersonList(LinkedList<Competition> personList)
        {
            Console.WriteLine("People in list: " + personList.Count);
            foreach (var person in personList)
            {
                Console.WriteLine($"Person Name: {person.Name}, Person Score: {person.Score}");
            }
        }
    }
}
