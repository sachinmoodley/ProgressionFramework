using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedListApp
{
    public class PoolCompetition
    {
        public void AddPersonToCompetition()
        {
            var list = new LinkedList<Person>();
            list.AddLast(new Person { Name = "Brent", Score = 70 });
            list.AddLast(new Person { Name = "Ben", Score = 60 });
            list.AddLast(new Person { Name = "Tom", Score = 50 });

            Console.WriteLine("Pool Tournament:");

            foreach (Person str in list)
            {
                Console.Write(str.Name + " ");

                Console.Write(str.Score);
                Console.WriteLine();
            }

            Console.WriteLine("Please enter new apponents score");
            Console.WriteLine("Enter Name: ");
            var newApponant = new Person();
            newApponant.Name = Console.ReadLine();
            Console.WriteLine("Please enter score: ");
            newApponant.Score = Convert.ToInt32(Console.ReadLine());

            //var newLinkedList = list.Find(x => x.Score == newApponant.Score);

        }
    }
}
