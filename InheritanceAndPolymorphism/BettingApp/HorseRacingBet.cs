using System;

namespace InheritanceAndPolymorphism.BettingApp
{
    public class HorseRacingBet : Bet
    {
        public string RaceNo { get; set; }
        public void GetBetInformation()
        {
            Console.WriteLine("Bet Description: " + BetDescription);
            Console.WriteLine("RaceNo: " + RaceNo);
            Console.WriteLine(GetBet());
        }
    }
}