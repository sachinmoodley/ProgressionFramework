using System;

namespace Delegates
{
    public class BasicCalculate
    {
        public delegate void calculate(int firstNumber, int secondNumber);

        public void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Addition Method : {firstNumber + secondNumber}");
        }

        public void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Subtraction Method: {firstNumber - secondNumber}");
        }

        //public delegate void InterestCalculationDelegate(int[] num);

        //public void CalculateInterest(int[] deposits, InterestCalculationDelegate calculateInterestCallback)
        //{
        //    // Get interest rate
        //    // Get term
        //    // Get state of the country
        //    // Get favorite color

        //    calculateInterestCallback.Invoke(deposits);
        //}

        //public void CalculateAllInterestsForUser()
        //{
        //    // Get user
        //    // Validate user
        //    // Get history
        //    // Validate history
        //    // Get employment records

        //    var deposits = new[] {1, 2, 123, 45, 566, 2345, 677};

        //    var calculateLongTerm = new InterestCalculationDelegate(CalculateLongTermInterest);
        //    var calculateShortTerm = new InterestCalculationDelegate(CalculateShortTermInterest);

        //    CalculateInterest(deposits, calculateLongTerm);
        //    CalculateInterest(deposits, calculateShortTerm);
        //}

        //public void CalculateLongTermInterest(int[] num)
        //{
        //    // Calculate very complicated stuff 
        //}        
        
        //public void CalculateShortTermInterest(int[] num)
        //{
        //    // Calculate other complicated stuff 
        //}
    }
}
