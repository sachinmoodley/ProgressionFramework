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
        */
        static void Main(string[] args)
        {
            //Betting App
            //basic inheritance example
            var horseRacingBet = new HorseRacingBet { BetType = "Pick 6", MinimumBet = 4, RaceNo = "Race 1", BetDescription = "Horse Racing" };
            horseRacingBet.GetBetInformation();

            //polymorphism example
            //Overriding the GetBet Info 
            var lottoBet = new LottoBet { BetType = "Powerball", MinimumBet = 6, Pool = 1100000, BetDescription = "Lotto" };
            lottoBet.GetBetInformation();

            //Animal App to show polymorphism
            var dog = new Dog { Name = "Dog" };
            MakeSound(dog);
            var cat = new Cat { Name = "Cat" };
            MakeSound(cat);
        }

        static void MakeSound(Animal animal)
        {
            animal.AnimalSound();
        }
    }
}
