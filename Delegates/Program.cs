using System;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basicCalculate = new BasicCalculate();
            //basicCalculate.doSomeWork(message => Console.WriteLine(message));

            basicCalculate.Add((number1, number2) => Console.WriteLine(number1 + number2));
            basicCalculate.Subtract((number1, number2) => Console.WriteLine(number1 - number2));
        }
    }
}
