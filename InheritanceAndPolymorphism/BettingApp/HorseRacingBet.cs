using System;

namespace InheritanceAndPolymorphism.BettingApp
{
    public class HorseRacingBet : Bet
    {
        public string RaceNo { get; set; }
        public override void GetBetInformation()
        {
            Console.WriteLine("Bet Description: " + BetDescription);
            Console.WriteLine("RaceNo: " + RaceNo);
            Console.WriteLine(GetBet());
            Console.WriteLine("   ");
        }
    }
}