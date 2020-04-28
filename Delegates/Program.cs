using System;
using System.Collections.Generic;
using System.Linq;
using Delegates.Calculator;
using Delegates.Sort;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basicCalculate = new BasicCalculate();

            //Delegate for logging
            //basicCalculate.Add(20, 10, message => Console.WriteLine(message));
            //basicCalculate.Subtract(20, 10, message => Console.WriteLine(message));

            //Delegates for sorting
            var captureNumbersInAscending = new CaptureNumbers(PrintAscendingNumbers);
            captureNumbersInAscending.getNumbers();

            var captureNumbersInDescending = new CaptureNumbers(OrderNumbersInDescending);
            captureNumbersInDescending.getNumbers();
        }

        private static void PrintAscendingNumbers(List<int> numbers)
        {
            numbers.Sort();
            Console.WriteLine("Sort numbers in ascending");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void OrderNumbersInDescending(List<int> numbers)
        {
            var orderByDescending = numbers.OrderByDescending(i => i);
            Console.WriteLine("Sort numbers in descending");
            foreach (var number in orderByDescending)
            {
                Console.WriteLine(number);
            }
        }
    }
}
