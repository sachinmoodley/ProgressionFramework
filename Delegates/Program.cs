using System;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basicCalculate = new BasicCalculate();

            //Delegate for logging
            basicCalculate.Add(20, 10, message => Console.WriteLine(message));
            basicCalculate.Subtract(20, 10, message => Console.WriteLine(message));
        }
    }
}
