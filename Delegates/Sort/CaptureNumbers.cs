using System;
using System.Collections.Generic;

namespace Delegates.Sort
{
    public class CaptureNumbers
    {
        private readonly Sort _sort;
        public delegate void Sort(List<int> numbers);

        public CaptureNumbers(Sort sort)
        {
            _sort = sort;
        }

        public List<int> getNumbers()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                numbers.Add(userInput);
            }

            _sort(numbers);
            return numbers;
        }

    }
}