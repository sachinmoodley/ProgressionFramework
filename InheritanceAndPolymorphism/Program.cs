using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace InheritanceAndPolymorphism
{
    public class Program
    {
        //Add another function to demo polymorphism and why you would use it
        static void Main(string[] args)
        {
            //basic inheritance example
            var horseRacingBet = new HorseRacingBet { BetType = "Pick 6", MinimumBet = 4, RaceNo = "Race 1" };
            Console.WriteLine("Horse Racing");
            Console.WriteLine("_____________");
            Console.WriteLine(horseRacingBet.RaceNo);
            Console.WriteLine(horseRacingBet.GetBet());

            //polymorphism example
            var lottoBet = new LottoBet { BetType = "Powerball", MinimumBet = 6, Pool = 1100000 };
            Console.WriteLine("");
            Console.WriteLine("Lotto");
            Console.WriteLine("_____________");
            Console.WriteLine(lottoBet.GetBet());

            //testing a stack
            var faultyCarwash = new Stack<string>();
            faultyCarwash.Push("Car 1");
            faultyCarwash.Push("Car 2");
            faultyCarwash.Push("Car 3");
            faultyCarwash.Push("Car 4");

            while (faultyCarwash.Count > 0)
            {
                Console.WriteLine(faultyCarwash.Pop());
            }

            var normalCarwash = new Queue<string>();
            normalCarwash.Enqueue("Car 1");
            normalCarwash.Enqueue("Car 2");
            normalCarwash.Enqueue("Car 3");
            normalCarwash.Enqueue("Car 4");

            while (normalCarwash.Count > 0)
            {
                Console.WriteLine(normalCarwash.Dequeue());
            }
        }
    }
}
