using InheritanceAndPolymorphism.AnimalSounds;
using InheritanceAndPolymorphism.BettingApp;

namespace InheritanceAndPolymorphism
{
    public class Program
    {
        //Brendons comments
        //Add another function to demo polymorphism and why you would use it

        /*My comments
         -Created a class to log data
         -Created a new app Animal sounds to demo why i would use polymorphism 
         -changed betting app to rather call Parent class and pass it a child class to demo polymorphism
        */
        static void Main(string[] args)
        {
            //Betting App
            var horseRacingBet = new HorseRacingBet { BetType = "Pick 6", MinimumBet = 4, RaceNo = "Race 1", BetDescription = "Horse Racing" };
            BetDetails(horseRacingBet);

            var lottoBet = new LottoBet { BetType = "Powerball", MinimumBet = 6, Pool = 1100000, BetDescription = "Lotto" };
            BetDetails(lottoBet);

            //Animal App to show polymorphism
            var dog = new Dog { Name = "Dog" };
            MakeSound(dog);
            var cat = new Cat { Name = "Cat" };
            MakeSound(cat);
        }

        private static void MakeSound(Animal animal)
        {
            animal.AnimalSound();
        }

        private static void BetDetails(Bet bet)
        {
            bet.GetBetInformation();
        }
    }
}
