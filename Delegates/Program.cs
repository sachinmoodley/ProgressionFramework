using System;
using static Delegates.BasicCalculate;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basicCalculate = new BasicCalculate();

            var addition = new calculate(basicCalculate.Add);
            var subtraction = new calculate(basicCalculate.Subtract);

            addition(100, 40);
            subtraction(100, 40);


            basicCalculate.doSomeWork((message => Console.WriteLine(message)));
        }
    }
}
