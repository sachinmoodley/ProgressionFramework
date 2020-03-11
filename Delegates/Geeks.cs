using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Geeks
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum" 
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract" 
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        public delegate void InterestCalculationDelegate(int[] num);

        public void CalculateInterest(int[] deposits, InterestCalculationDelegate calculateInterestCallback)
        {
            // Get interest rate
            // Get term
            // Get state of the country
            // Get favorite color

            calculateInterestCallback.Invoke(deposits);
        }

        public void CalculateAllInterestsForUser()
        {
            // Get user
            // Validate user
            // Get history
            // Validate history
            // Get employment records

            var deposits = new[] {1, 2, 123, 45, 566, 2345, 677};

            var calculateLongTerm = new InterestCalculationDelegate(CalculateLongTermInterest);
            var calculateShortTerm = new InterestCalculationDelegate(CalculateShortTermInterest);

            CalculateInterest(deposits, calculateLongTerm);
            CalculateInterest(deposits, calculateShortTerm);
        }

        public void CalculateLongTermInterest(int[] num)
        {
            // Calculate very complicated stuff 
        }        
        
        public void CalculateShortTermInterest(int[] num)
        {
            // Calculate other complicated stuff 
        }
    }
}
