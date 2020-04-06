using System;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basicCalculate = new BasicCalculate();
            //basicCalculate.doSomeWork(message => Console.WriteLine(message));

            basicCalculate.Add(20, 10, message => Console.WriteLine(message));
            basicCalculate.Subtract(20, 10, message => Console.WriteLine(message));
        }
    }
}
