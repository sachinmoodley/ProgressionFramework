namespace InheritanceAndPolymorphism
{
    public class LottoBet : Bet
    {
        public int Pool { get; set; }
        public override string GetBet() => $"Minimum bet for {BetType} is R{MinimumBet} and the pool is R{Pool}";
    }
}