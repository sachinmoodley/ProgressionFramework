using System;

namespace InheritanceAndPolymorphism.BettingApp
{
    public class LottoBet : Bet
    {
        public int Pool { get; set; }
        public override string GetBet() => $"Minimum bet for {BetType} is R{MinimumBet} for a massive pool of R{Pool}";
        public void GetBetInformation()
        {
            Console.WriteLine("Bet Description: " + BetDescription);
            Console.WriteLine("Pool: " + Pool);
            Console.WriteLine(GetBet());
        }
    }
}