namespace InheritanceAndPolymorphism.BettingApp
{
    public class Bet
    {
        public string BetDescription;
        public string BetType { get; set; }
        public int MinimumBet { get; set; }

        public virtual string GetBet() => $"Minimum bet for {BetType} is R{MinimumBet}";
    }
}
