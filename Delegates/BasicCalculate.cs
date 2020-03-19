using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class BasicCalculate
    {
        public delegate void calculate(int firstNumber, int secondNumber);
        public delegate void log(string message);

        public void Add(calculate calculate)
        {
            calculate(100, 30);
        }

        public void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Subtraction Method: {firstNumber - secondNumber}");
        }

        public void doSomeWork(log log)
        {
            log("Success");
        }

        //public calculate Cake()
        //{
        //    var x = new List<int>();
        //    x.Select(Moo);
        //    return Add;
        //}

        //public string Moo(int x)
        //{
        //    return x.ToString();
        //}

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
