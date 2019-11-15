using System;

namespace InheritanceAndPolymorphism
{
    public class Program
    {
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

        }
    }
}
